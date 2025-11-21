namespace Score
{
    partial class MDI
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
            this.welcome = new System.Windows.Forms.Label();
            this.gbm = new System.Windows.Forms.GroupBox();
            this.lB = new System.Windows.Forms.Button();
            this.midB = new System.Windows.Forms.Button();
            this.upB = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.gbm.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Location = new System.Drawing.Point(16, 40);
            this.welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(58, 13);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome, ";
            // 
            // gbm
            // 
            this.gbm.Controls.Add(this.lB);
            this.gbm.Controls.Add(this.midB);
            this.gbm.Controls.Add(this.upB);
            this.gbm.Location = new System.Drawing.Point(9, 69);
            this.gbm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbm.Name = "gbm";
            this.gbm.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbm.Size = new System.Drawing.Size(279, 178);
            this.gbm.TabIndex = 1;
            this.gbm.TabStop = false;
            this.gbm.Text = "groupBox1";
            // 
            // lB
            // 
            this.lB.BackColor = System.Drawing.Color.MediumPurple;
            this.lB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lB.Location = new System.Drawing.Point(18, 126);
            this.lB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lB.Name = "lB";
            this.lB.Size = new System.Drawing.Size(242, 39);
            this.lB.TabIndex = 5;
            this.lB.Text = "Log Out";
            this.lB.UseVisualStyleBackColor = false;
            this.lB.Click += new System.EventHandler(this.lB_Click);
            // 
            // midB
            // 
            this.midB.BackColor = System.Drawing.Color.MediumPurple;
            this.midB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.midB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.midB.Location = new System.Drawing.Point(18, 77);
            this.midB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.midB.Name = "midB";
            this.midB.Size = new System.Drawing.Size(242, 39);
            this.midB.TabIndex = 4;
            this.midB.Text = "Log Out";
            this.midB.UseVisualStyleBackColor = false;
            this.midB.Click += new System.EventHandler(this.midB_Click);
            // 
            // upB
            // 
            this.upB.BackColor = System.Drawing.Color.MediumPurple;
            this.upB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upB.Location = new System.Drawing.Point(18, 27);
            this.upB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.upB.Name = "upB";
            this.upB.Size = new System.Drawing.Size(242, 39);
            this.upB.TabIndex = 3;
            this.upB.Text = "Log Out";
            this.upB.UseVisualStyleBackColor = false;
            this.upB.Click += new System.EventHandler(this.upB_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(100, 283);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(66, 40);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(67, 13);
            this.name.TabIndex = 3;
            this.name.Text = "Welcome, ";
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 329);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbm);
            this.Controls.Add(this.welcome);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MDI";
            this.Text = "SMK Score - Navigation";
            this.gbm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.GroupBox gbm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button upB;
        private System.Windows.Forms.Button lB;
        private System.Windows.Forms.Button midB;
        private System.Windows.Forms.Label name;
    }
}