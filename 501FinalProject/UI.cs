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

        private void verifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TextKSIS.Text = openFileDialog1.FileName;

                //TextOutput.Text = Controller.Verify(openFileDialog1.FileName);
                //will return and print the compared files
            }
        }
    }
}
