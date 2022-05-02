using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class1_WF3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string folder = $@"c:\{txtCreate.Text}";
            if (!System.IO.Directory.Exists(folder))
            {
                System.IO.Directory.CreateDirectory(folder);
                txtCreate.Clear();
            }
                  
            else 
                MessageBox.Show("Folder Exists Already", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCreate.Clear();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string folder = $@"c:\{txtDelete.Text}";
            if (System.IO.Directory.Exists(folder))
            {
                System.IO.Directory.Delete(folder);
                txtDelete.Clear();
            }                
            else
                MessageBox.Show("Folder Not Found", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDelete.Clear();
        }
        private void btnMove_Click(object sender, EventArgs e)
        {
            string fileName = txtName.Text;
            string originFolder = $@"c:\{txtOrigin.Text}";
            string destinationFolder = $@"c:\{txtDestination.Text}";

            string originFile = System.IO.Path.Combine(originFolder, fileName);
            string destinationFile = System.IO.Path.Combine(destinationFolder, fileName);

            System.IO.File.Move(originFile, destinationFile);
        }
    }
}
