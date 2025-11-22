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
            this.logoutStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.adminStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.modelStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.merchandStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wutToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.transactionToolStripMenuItem});
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
            this.logoutStrip,
            this.exitStrip});
            this.wutToolStripMenuItem.Name = "wutToolStripMenuItem";
            this.wutToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.wutToolStripMenuItem.Text = "File";
            // 
            // logoutStrip
            // 
            this.logoutStrip.Name = "logoutStrip";
            this.logoutStrip.Size = new System.Drawing.Size(112, 22);
            this.logoutStrip.Text = "Logout";
            this.logoutStrip.Click += new System.EventHandler(this.logoutStrip_Click);
            // 
            // exitStrip
            // 
            this.exitStrip.Name = "exitStrip";
            this.exitStrip.Size = new System.Drawing.Size(112, 22);
            this.exitStrip.Text = "Exit";
            this.exitStrip.Click += new System.EventHandler(this.exitStrip_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerStrip,
            this.adminStrip,
            this.modelStrip,
            this.merchandStrip});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // customerStrip
            // 
            this.customerStrip.Name = "customerStrip";
            this.customerStrip.Size = new System.Drawing.Size(147, 22);
            this.customerStrip.Text = "Customer";
            this.customerStrip.Click += new System.EventHandler(this.customerStrip_Click);
            // 
            // adminStrip
            // 
            this.adminStrip.Name = "adminStrip";
            this.adminStrip.Size = new System.Drawing.Size(147, 22);
            this.adminStrip.Text = "Administrator";
            this.adminStrip.Click += new System.EventHandler(this.adminStrip_Click);
            // 
            // modelStrip
            // 
            this.modelStrip.Name = "modelStrip";
            this.modelStrip.Size = new System.Drawing.Size(147, 22);
            this.modelStrip.Text = "Model";
            this.modelStrip.Click += new System.EventHandler(this.modelStrip_Click);
            // 
            // merchandStrip
            // 
            this.merchandStrip.Name = "merchandStrip";
            this.merchandStrip.Size = new System.Drawing.Size(147, 22);
            this.merchandStrip.Text = "Merchandise";
            this.merchandStrip.Click += new System.EventHandler(this.merchandStrip_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Winform_Login.Properties.Resources._1388342;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(625, 333);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "SMK Sales";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutStrip;
        private System.Windows.Forms.ToolStripMenuItem exitStrip;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerStrip;
        private System.Windows.Forms.ToolStripMenuItem adminStrip;
        private System.Windows.Forms.ToolStripMenuItem modelStrip;
        private System.Windows.Forms.ToolStripMenuItem merchandStrip;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
    }
}