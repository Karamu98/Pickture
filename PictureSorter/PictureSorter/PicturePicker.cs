using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace PictureSorter
{
    public partial class PicturePicker : Form
    {
        public Dictionary<Button, string> buttons = new Dictionary<Button, string>(); // Hashset? 
        public Button buttonToEdit;
        private ToolStripItem itemToEdit;

        public Dictionary<ToolStripItem, Button> toolButtons = new Dictionary<ToolStripItem, Button>();

        string srcPath; // Location of the source folder
        string curImgPath; // Path to current image

        // Storing the last copy
        string preImagePath; // Path to previos image
        string preImageDir; // Directory of previous image

        Queue<string> imageQueue = new Queue<string>(); // Queue of images to cycle


        public PicturePicker()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Callback for when a destination button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnButtonClicked(object sender, EventArgs e)
        {
            Button btn = sender as Button; // Grab the button

            if(curImgPath != null && curImgPath != "")
            {
                string dest = buttons[btn];
                string fileName = curImgPath.Split(System.IO.Path.DirectorySeparatorChar).Last();

                if (Directory.Exists(dest))
                {
                    File.Copy(curImgPath, dest + fileName, true);

                    preImagePath = curImgPath;
                    preImageDir = dest + fileName;

                    ChangePicture();

                }
                else
                {
                    MessageBox.Show("Destination '" + dest + "' no longer exists");
                }
            }
        }

        private void OnDestinationEdit(object sender, EventArgs e)
        {
            itemToEdit = sender as ToolStripItem;
            buttonToEdit = toolButtons[itemToEdit];

            EditDestination editDestForm = new EditDestination();
            editDestForm.parentForm = this;

            DialogResult result = editDestForm.ShowDialog();

            if (result == DialogResult.OK) // Button edit
            {
                itemToEdit.Text = editDestForm.name;
                buttonToEdit.Text = editDestForm.name;
                buttons[buttonToEdit] = editDestForm.destDir;
            }
            else if(result == DialogResult.No) // Button to be deleted
            {
                // Button removal
                destButtonLayout.Controls.Remove(buttonToEdit);
                buttons.Remove(buttonToEdit);
                buttonToEdit = null;

                // Tool bar removal
                editDestinations.DropDownItems.Remove(itemToEdit);
                toolButtons.Remove(itemToEdit);
                itemToEdit = null;
            }
        }

        private void ChangePicture()
        {
            // Remove image but track, change labels and image
            if (imageQueue.Count > 0)
            {
                preImagePath = imageQueue.Dequeue();
                if(imageQueue.Count > 0)
                {
                    curImgPath = imageQueue.Peek();
                    ImageNameLabel.Text = imageQueue.Peek();
                    pictureSlot.ImageLocation = imageQueue.Peek();
                }
                else
                {
                    curImgPath = "";
                    ImageNameLabel.Text = "";
                    pictureSlot.ImageLocation = "";
                }

            }
            else
            {
                curImgPath = "";
                ImageNameLabel.Text = "";
                pictureSlot.ImageLocation = "";
            }
        }

        private void addFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDestination addDestinationForm = new AddDestination();
            if(addDestinationForm.ShowDialog() == DialogResult.OK)
            {
                // Add new button
                Button newButton = new Button();
                newButton.Width = 70;
                newButton.Height = 45;
                newButton.Text = addDestinationForm.name;
                newButton.Click += new EventHandler(this.OnButtonClicked);

                destButtonLayout.Controls.Add(newButton);

                buttons.Add(newButton, addDestinationForm.destDir + "\\");

                // Add the edit selection
                ToolStripItem newItem = editDestinations.DropDownItems.Add(newButton.Text, null, OnDestinationEdit);

                toolButtons.Add(newItem, newButton);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // On load function
        }

        private void setSourceFolderToolStripMenuItem_Click(object sender, EventArgs e) // Find source folder
        {
            if (sourcePicker.ShowDialog() == DialogResult.OK)
            {
                // Clear
                imageQueue.Clear();
                preImagePath = "";
                preImageDir = "";
                curImgPath = "";

                srcPath = sourcePicker.SelectedPath;
                sourcePathLabel.Text = srcPath;

                // Get all images
                DirectoryInfo folder;
                List<FileInfo> images = new List<FileInfo>();

                folder = new DirectoryInfo(srcPath);

                FileInfo[] pngs = folder.GetFiles("*.png", SearchOption.TopDirectoryOnly);
                FileInfo[] jpgs = folder.GetFiles("*.jpg", SearchOption.TopDirectoryOnly);

                images.InsertRange(0, pngs);
                images.InsertRange(0, jpgs);

                if (images.Count > 0)
                {
                    foreach (FileInfo file in images)
                    {
                        imageQueue.Enqueue(srcPath + "\\" + file.Name);
                    }

                    // Present the first image
                    curImgPath = imageQueue.Peek();
                    ImageNameLabel.Text = imageQueue.Peek();
                    pictureSlot.ImageLocation = imageQueue.Peek();
                }
                else
                {
                    curImgPath = "";
                    ImageNameLabel.Text = "";
                    pictureSlot.ImageLocation = "";
                    MessageBox.Show("No images found at " + srcPath);
                }
            }
        }

        private void skipImageButton_Click(object sender, EventArgs e)
        {
            if(imageQueue.Count <= 0)
            {
                MessageBox.Show("No Images to skip");
                return;
            }

            // Skip
            preImagePath = curImgPath;
            preImageDir = "";

            // If the current image is on top of the queue
            if(curImgPath == imageQueue.Peek())
            {
                // Move it to the back
                imageQueue.Enqueue(imageQueue.Dequeue());
            }
            else
            {
                // Add it to the back of the queue
                imageQueue.Enqueue(preImagePath);
            }

            // Show top of queue
            curImgPath = imageQueue.Peek();
            ImageNameLabel.Text = imageQueue.Peek();
            pictureSlot.ImageLocation = imageQueue.Peek();
        } // Skip clicked

        private void button1_Click(object sender, EventArgs e) // Back
        {
            if(File.Exists(preImageDir))
            {
                File.Delete(preImageDir);

                curImgPath = preImagePath;
                ImageNameLabel.Text = preImagePath;
                pictureSlot.ImageLocation = preImagePath;
            }
            else
            {
                if(preImagePath == "" || preImagePath == null)
                {

                }
                else
                {
                    curImgPath = preImagePath;
                    ImageNameLabel.Text = preImagePath;
                    pictureSlot.ImageLocation = preImagePath;
                }
            }
        }
    }
}
