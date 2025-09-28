namespace Winform_Login
{
    partial class Strator
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insert = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.rmv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cpass = new System.Windows.Forms.TextBox();
            this.birth = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.spass = new System.Windows.Forms.Button();
            this.debug = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column5});
            this.dgv.Location = new System.Drawing.Point(44, 81);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.Size = new System.Drawing.Size(951, 405);
            this.dgv.TabIndex = 2;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Id";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "RoleID";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Email";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Password";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "PhoneNumber";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "BirthDate";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // insert
            // 
            this.insert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.insert.Location = new System.Drawing.Point(644, 662);
            this.insert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(100, 28);
            this.insert.TabIndex = 3;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name.Enabled = false;
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.Location = new System.Drawing.Point(229, 580);
            this.name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(288, 22);
            this.name.TabIndex = 4;
            this.name.TextChanged += new System.EventHandler(this.name_Changed);
            // 
            // email
            // 
            this.email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email.Enabled = false;
            this.email.ForeColor = System.Drawing.Color.Black;
            this.email.Location = new System.Drawing.Point(229, 612);
            this.email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(288, 22);
            this.email.TabIndex = 6;
            this.email.TextChanged += new System.EventHandler(this.email_Changed);
            // 
            // update
            // 
            this.update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.update.Location = new System.Drawing.Point(752, 662);
            this.update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(100, 28);
            this.update.TabIndex = 5;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // rmv
            // 
            this.rmv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rmv.Enabled = false;
            this.rmv.Location = new System.Drawing.Point(860, 662);
            this.rmv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rmv.Name = "rmv";
            this.rmv.Size = new System.Drawing.Size(100, 28);
            this.rmv.TabIndex = 7;
            this.rmv.Text = "Delete";
            this.rmv.UseVisualStyleBackColor = true;
            this.rmv.Click += new System.EventHandler(this.rmv_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 580);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name:";
            // 
            // number
            // 
            this.number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.number.Enabled = false;
            this.number.ForeColor = System.Drawing.Color.Black;
            this.number.Location = new System.Drawing.Point(229, 644);
            this.number.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(288, 22);
            this.number.TabIndex = 9;
            this.number.TextChanged += new System.EventHandler(this.number_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 612);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 644);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Phone Number:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(344, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(369, 39);
            this.label4.TabIndex = 12;
            this.label4.Text = "Manage Administrator";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(533, 581);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Password:";
            // 
            // pass
            // 
            this.pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pass.Enabled = false;
            this.pass.ForeColor = System.Drawing.Color.Black;
            this.pass.Location = new System.Drawing.Point(752, 581);
            this.pass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(240, 22);
            this.pass.TabIndex = 15;
            this.pass.UseSystemPasswordChar = true;
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(533, 612);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Confirm Password:";
            // 
            // cpass
            // 
            this.cpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cpass.Enabled = false;
            this.cpass.ForeColor = System.Drawing.Color.Black;
            this.cpass.Location = new System.Drawing.Point(752, 613);
            this.cpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cpass.Name = "cpass";
            this.cpass.Size = new System.Drawing.Size(240, 22);
            this.cpass.TabIndex = 17;
            this.cpass.UseSystemPasswordChar = true;
            // 
            // birth
            // 
            this.birth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.birth.Enabled = false;
            this.birth.Location = new System.Drawing.Point(229, 676);
            this.birth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(288, 22);
            this.birth.TabIndex = 20;
            this.birth.Value = new System.DateTime(2025, 9, 20, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 676);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Birthdate:";
            // 
            // cbRol
            // 
            this.cbRol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRol.Enabled = false;
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Items.AddRange(new object[] {
            "Manager",
            "Cashier"});
            this.cbRol.Location = new System.Drawing.Point(752, 517);
            this.cbRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(239, 24);
            this.cbRol.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(533, 517);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Position:";
            // 
            // save
            // 
            this.save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.save.Enabled = false;
            this.save.Location = new System.Drawing.Point(695, 698);
            this.save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 28);
            this.save.TabIndex = 25;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancel.Enabled = false;
            this.cancel.Location = new System.Drawing.Point(803, 698);
            this.cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 28);
            this.cancel.TabIndex = 24;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 518);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "Id:";
            // 
            // id
            // 
            this.id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.id.Enabled = false;
            this.id.ForeColor = System.Drawing.Color.Black;
            this.id.Location = new System.Drawing.Point(229, 521);
            this.id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(288, 22);
            this.id.TabIndex = 27;
            // 
            // spass
            // 
            this.spass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.spass.Enabled = false;
            this.spass.Location = new System.Drawing.Point(997, 581);
            this.spass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spass.Name = "spass";
            this.spass.Size = new System.Drawing.Size(25, 26);
            this.spass.TabIndex = 28;
            this.spass.Text = "S";
            this.spass.UseVisualStyleBackColor = true;
            this.spass.Click += new System.EventHandler(this.spass_Click);
            // 
            // debug
            // 
            this.debug.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.debug.Location = new System.Drawing.Point(952, 15);
            this.debug.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(71, 26);
            this.debug.TabIndex = 29;
            this.debug.Text = "Debug";
            this.debug.UseVisualStyleBackColor = true;
            this.debug.Click += new System.EventHandler(this.debug_Click);
            // 
            // search
            // 
            this.search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search.Location = new System.Drawing.Point(861, 53);
            this.search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(132, 22);
            this.search.TabIndex = 30;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(800, 57);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Search:";
            // 
            // Strator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1039, 745);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.search);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.spass);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.save);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbRol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.birth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cpass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rmv);
            this.Controls.Add(this.email);
            this.Controls.Add(this.update);
            this.Controls.Add(this.name);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.dgv);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Strator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Administrator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button rmv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cpass;
        private System.Windows.Forms.DateTimePicker birth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button spass;
        private System.Windows.Forms.Button debug;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label10;
    }
}

