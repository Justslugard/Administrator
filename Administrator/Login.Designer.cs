namespace Winform_Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.logkan = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.cash = new System.Windows.Forms.Button();
            this.adm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "SMK Sales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Winform for managing smk sales";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(144, 86);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(322, 20);
            this.email.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(144, 118);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(322, 20);
            this.password.TabIndex = 5;
            this.password.UseSystemPasswordChar = true;
            // 
            // logkan
            // 
            this.logkan.Location = new System.Drawing.Point(184, 156);
            this.logkan.Name = "logkan";
            this.logkan.Size = new System.Drawing.Size(75, 23);
            this.logkan.TabIndex = 6;
            this.logkan.Text = "Login";
            this.logkan.UseVisualStyleBackColor = true;
            this.logkan.Click += new System.EventHandler(this.logkan_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(265, 156);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 7;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // cash
            // 
            this.cash.Location = new System.Drawing.Point(404, 9);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(75, 23);
            this.cash.TabIndex = 8;
            this.cash.Text = "Cashier";
            this.cash.UseVisualStyleBackColor = true;
            this.cash.Click += new System.EventHandler(this.button1_Click);
            // 
            // adm
            // 
            this.adm.Location = new System.Drawing.Point(404, 38);
            this.adm.Name = "adm";
            this.adm.Size = new System.Drawing.Size(75, 23);
            this.adm.TabIndex = 9;
            this.adm.Text = "Admin";
            this.adm.UseVisualStyleBackColor = true;
            this.adm.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(491, 201);
            this.Controls.Add(this.adm);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.close);
            this.Controls.Add(this.logkan);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button logkan;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button cash;
        private System.Windows.Forms.Button adm;
    }
}