using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using StringBuilder = System.Text.StringBuilder;

namespace _501FinalProject
{
    public partial class UI : Form
    {
        
        public UI()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TextLocal.Text = openFileDialog1.FileName;
                TextOutput.Text = Controller.Load(openFileDialog1.FileName);
            }
        }
        public string filename;

        private void verifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TextLocal.Text == "") MessageBox.Show("Load a local file first!");
            else if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                TextKSIS.Text = filename;

                TextOutput.Text = Controller.Verify(filename);
            }
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            if (TextLocal.Text == "") MessageBox.Show("Load a local file first!");
            else if (TextKSIS.Text != "" && TextLocal.Text != "")
            {
                TextOutput.Text = Controller.Reload(filename);
            }
            else MessageBox.Show("Load the 2 files to be compared first!");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

            TextKSIS.Text = "";
            TextLocal.Text = "";
            TextOutput.Text = "";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SVT Version: 1.0.0 \nDate: 12/7/18 \nDamon Jones and Charles Tryban");
        }
    }
}
