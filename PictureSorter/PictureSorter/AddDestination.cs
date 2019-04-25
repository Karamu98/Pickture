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
    public partial class AddDestination : Form
    {
        public string name;
        public string destDir;

        public AddDestination()
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

        private void destName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
