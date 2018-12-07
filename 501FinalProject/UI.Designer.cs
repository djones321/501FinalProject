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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextKSIS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextLocal = new System.Windows.Forms.TextBox();
            this.TextOutput = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(821, 17);
            this.buttonReload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(87, 41);
            this.buttonReload.TabIndex = 0;
            this.buttonReload.Text = "Reload";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(928, 17);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(87, 41);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1029, 26);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.verifyToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.openToolStripMenuItem.Text = "Load";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // verifyToolStripMenuItem
            // 
            this.verifyToolStripMenuItem.Name = "verifyToolStripMenuItem";
            this.verifyToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.verifyToolStripMenuItem.Text = "Verify";
            this.verifyToolStripMenuItem.Click += new System.EventHandler(this.verifyToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(555, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "KSIS";
            // 
            // TextKSIS
            // 
            this.TextKSIS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextKSIS.Enabled = false;
            this.TextKSIS.Location = new System.Drawing.Point(618, 79);
            this.TextKSIS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextKSIS.Multiline = true;
            this.TextKSIS.Name = "TextKSIS";
            this.TextKSIS.Size = new System.Drawing.Size(401, 50);
            this.TextKSIS.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Local";
            // 
            // TextLocal
            // 
            this.TextLocal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextLocal.Enabled = false;
            this.TextLocal.Location = new System.Drawing.Point(97, 79);
            this.TextLocal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextLocal.Multiline = true;
            this.TextLocal.Name = "TextLocal";
            this.TextLocal.Size = new System.Drawing.Size(417, 50);
            this.TextLocal.TabIndex = 8;
            // 
            // TextOutput
            // 
            this.TextOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextOutput.Location = new System.Drawing.Point(15, 133);
            this.TextOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextOutput.Multiline = true;
            this.TextOutput.Name = "TextOutput";
            this.TextOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextOutput.Size = new System.Drawing.Size(1004, 498);
            this.TextOutput.TabIndex = 9;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 644);
            this.Controls.Add(this.TextOutput);
            this.Controls.Add(this.TextLocal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextKSIS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "UI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextKSIS;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextLocal;
        private System.Windows.Forms.TextBox TextOutput;
        private System.Windows.Forms.ToolStripMenuItem verifyToolStripMenuItem;
    }
}

