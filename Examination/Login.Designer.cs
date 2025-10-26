namespace Examination
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ps = new System.Windows.Forms.TextBox();
            this.logkan = new System.Windows.Forms.Button();
            this.adm = new System.Windows.Forms.Button();
            this.exam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Esemka Examination";
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username.Cursor = System.Windows.Forms.Cursors.Hand;
            this.username.Location = new System.Drawing.Point(37, 111);
            this.username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(356, 22);
            this.username.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // ps
            // 
            this.ps.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ps.Location = new System.Drawing.Point(37, 197);
            this.ps.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ps.Name = "ps";
            this.ps.PasswordChar = '*';
            this.ps.Size = new System.Drawing.Size(356, 22);
            this.ps.TabIndex = 3;
            // 
            // logkan
            // 
            this.logkan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logkan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logkan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logkan.Location = new System.Drawing.Point(37, 262);
            this.logkan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logkan.Name = "logkan";
            this.logkan.Size = new System.Drawing.Size(357, 43);
            this.logkan.TabIndex = 5;
            this.logkan.Text = "Login";
            this.logkan.UseVisualStyleBackColor = true;
            this.logkan.Click += new System.EventHandler(this.logkan_Click);
            // 
            // adm
            // 
            this.adm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adm.Location = new System.Drawing.Point(37, 313);
            this.adm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adm.Name = "adm";
            this.adm.Size = new System.Drawing.Size(104, 31);
            this.adm.TabIndex = 6;
            this.adm.Text = "Admin";
            this.adm.UseVisualStyleBackColor = true;
            this.adm.Click += new System.EventHandler(this.button1_Click);
            // 
            // exam
            // 
            this.exam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exam.Location = new System.Drawing.Point(149, 313);
            this.exam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exam.Name = "exam";
            this.exam.Size = new System.Drawing.Size(104, 31);
            this.exam.TabIndex = 7;
            this.exam.Text = "Exam";
            this.exam.UseVisualStyleBackColor = true;
            this.exam.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 341);
            this.Controls.Add(this.exam);
            this.Controls.Add(this.adm);
            this.Controls.Add(this.logkan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ps);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ps;
        private System.Windows.Forms.Button logkan;
        private System.Windows.Forms.Button adm;
        private System.Windows.Forms.Button exam;
    }
}

