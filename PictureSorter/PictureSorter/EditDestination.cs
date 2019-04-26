using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureSorter
{
    public partial class EditDestination : Form
    {
        public string name;
        public string destDir;

        public PicturePicker parentForm;

        public EditDestination()
        {
            InitializeComponent();
        }

        private void pickSource_Click(object sender, EventArgs e)
        {
            if (findDestination.ShowDialog() == DialogResult.OK)
            {
                destDir = findDestination.SelectedPath;

                if (destName.Text == null || destName.Text == "")
                {
                    name = destDir.Split(System.IO.Path.DirectorySeparatorChar).Last();
                }
                else
                {
                    name = destName.Text;
                }

                this.DialogResult = DialogResult.OK;
            }
        }

        private void OnLoadForm(object sender, EventArgs e)
        {
            destName.Text = parentForm.buttonToEdit.Text;
        }

        private void destName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            destDir = parentForm.buttons[parentForm.buttonToEdit];
            name = destName.Text;

            this.DialogResult = DialogResult.OK;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
