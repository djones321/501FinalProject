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

                //TextOutput.Text = sb.ToString();
            }
        }
        public string filename;

        private void verifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                TextKSIS.Text = filename;

                TextOutput.Text = Controller.Verify(filename);
                //will return and print the compared files
            }
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            TextOutput.Text = Controller.Reload(filename);
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
