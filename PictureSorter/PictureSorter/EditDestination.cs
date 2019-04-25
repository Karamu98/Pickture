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
        public PicturePicker parentForm;

        public EditDestination()
        {
            InitializeComponent();
        }

        private void pickSource_Click(object sender, EventArgs e)
        {

        }

        private void OnLoadForm(object sender, EventArgs e)
        {
            destName.Text = parentForm.buttons[parentForm.buttonToEdit];
        }

        private void destName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
