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
        Dictionary<Button, string> buttons = new Dictionary<Button, string>();

        string sourcePath;
        string currentImagePath;

        Queue<string> sourceImages = new Queue<string>();


        public PicturePicker()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if(currentImagePath != null && currentImagePath != "")
            {
                string destination = buttons[btn];
                string fileName = currentImagePath.Split(System.IO.Path.DirectorySeparatorChar).Last();

                if (Directory.Exists(destination))
                {
                    File.Copy(currentImagePath, destination + fileName, true);

                    ChangePicture();

                }
                else
                {
                    MessageBox.Show("Failed to copy");
                }
            }
        }

        private void ChangePicture()
        {
            // Push image to back, change labels and image
            sourceImages.Enqueue(sourceImages.Dequeue());
            currentImagePath = sourceImages.Peek();
            ImageNameLabel.Text = sourceImages.Peek();
            pictureSlot.ImageLocation = sourceImages.Peek();
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
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // On load function
        }

        private void setSourceFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(sourcePicker.ShowDialog() == DialogResult.OK)
            {
                sourcePath = sourcePicker.SelectedPath;
                sourcePathLabel.Text = sourcePath;

                // Get all images
                DirectoryInfo folder;
                FileInfo[] images;

                folder = new DirectoryInfo(sourcePath);
                images = folder.GetFiles("*.png", SearchOption.AllDirectories);

                if (images.Length > 0)
                {
                    foreach (FileInfo file in images)
                    {
                        
                        sourceImages.Enqueue(sourcePath + "\\" + file.Name);
                    }

                    ChangePicture();
                }
                else
                {
                    MessageBox.Show("No images found at " + sourcePath);
                }
            }
        }

        private void skipImageButton_Click(object sender, EventArgs e)
        {
            if(sourceImages.Count <= 0)
            {
                MessageBox.Show("No Images to skip");
                return;
            }

            ChangePicture();

        }
    }
}
