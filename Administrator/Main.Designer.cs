namespace Winform_Login
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.wutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(625, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // wutToolStripMenuItem
            // 
            this.wutToolStripMenuItem.Checked = true;
            this.wutToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asToolStripMenuItem,
            this.asToolStripMenuItem1});
            this.wutToolStripMenuItem.Name = "wutToolStripMenuItem";
            this.wutToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.wutToolStripMenuItem.Text = "File";
            // 
            // asToolStripMenuItem
            // 
            this.asToolStripMenuItem.Name = "asToolStripMenuItem";
            this.asToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.asToolStripMenuItem.Text = "Exit";
            // 
            // asToolStripMenuItem1
            // 
            this.asToolStripMenuItem1.Name = "asToolStripMenuItem1";
            this.asToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.asToolStripMenuItem1.Text = "Login";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(625, 333);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "SMK Sales";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asToolStripMenuItem1;
    }
}