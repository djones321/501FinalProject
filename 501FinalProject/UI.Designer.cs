namespace _501FinalProject
{
    partial class UI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonReload = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.load = new System.Windows.Forms.ToolStripMenuItem();
            this.verify = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextKSIS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextLocal = new System.Windows.Forms.TextBox();
            this.TextOutput = new System.Windows.Forms.TextBox();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(1232, 27);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(130, 64);
            this.buttonReload.TabIndex = 0;
            this.buttonReload.Text = "Reload";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(1392, 27);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(130, 64);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.about});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1544, 42);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip1";
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.load,
            this.verify});
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(64, 38);
            this.file.Text = "File";
            // 
            // load
            // 
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(324, 38);
            this.load.Text = "Load";
            this.load.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // verify
            // 
            this.verify.Name = "verify";
            this.verify.Size = new System.Drawing.Size(324, 38);
            this.verify.Text = "Verify";
            this.verify.Click += new System.EventHandler(this.verifyToolStripMenuItem_Click);
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(92, 38);
            this.about.Text = "About";
            this.about.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(832, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "KSIS";
            // 
            // TextKSIS
            // 
            this.TextKSIS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextKSIS.Enabled = false;
            this.TextKSIS.Location = new System.Drawing.Point(927, 123);
            this.TextKSIS.Multiline = true;
            this.TextKSIS.Name = "TextKSIS";
            this.TextKSIS.Size = new System.Drawing.Size(600, 76);
            this.TextKSIS.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Local";
            // 
            // TextLocal
            // 
            this.TextLocal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextLocal.Enabled = false;
            this.TextLocal.Location = new System.Drawing.Point(146, 123);
            this.TextLocal.Multiline = true;
            this.TextLocal.Name = "TextLocal";
            this.TextLocal.Size = new System.Drawing.Size(624, 76);
            this.TextLocal.TabIndex = 8;
            // 
            // TextOutput
            // 
            this.TextOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextOutput.Location = new System.Drawing.Point(22, 208);
            this.TextOutput.Multiline = true;
            this.TextOutput.Name = "TextOutput";
            this.TextOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextOutput.Size = new System.Drawing.Size(1504, 776);
            this.TextOutput.TabIndex = 9;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 1006);
            this.Controls.Add(this.TextOutput);
            this.Controls.Add(this.TextLocal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextKSIS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextKSIS;
        private System.Windows.Forms.ToolStripMenuItem load;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextLocal;
        private System.Windows.Forms.TextBox TextOutput;
        private System.Windows.Forms.ToolStripMenuItem verify;
    }
}

