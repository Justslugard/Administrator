namespace Score
{
    partial class MTeacher
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label birthDateLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label roleLabel;
            System.Windows.Forms.Label teacherIDLabel;
            System.Windows.Forms.Label teacherNameLabel;
            System.Windows.Forms.Label label2;
            this.teacherDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.birthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.teacherIDTextBox = new System.Windows.Forms.TextBox();
            this.teacherNameTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lB = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.mRB = new System.Windows.Forms.RadioButton();
            this.fRB = new System.Windows.Forms.RadioButton();
            birthDateLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            roleLabel = new System.Windows.Forms.Label();
            teacherIDLabel = new System.Windows.Forms.Label();
            teacherNameLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new System.Drawing.Point(9, 340);
            birthDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(57, 13);
            birthDateLabel.TabIndex = 2;
            birthDateLabel.Text = "Birth Date:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(271, 288);
            emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(270, 266);
            genderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(45, 13);
            genderLabel.TabIndex = 6;
            genderLabel.Text = "Gender:";
            genderLabel.Click += new System.EventHandler(this.genderLabel_Click);
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(271, 313);
            passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 8;
            passwordLabel.Text = "Password:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(9, 315);
            phoneNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            phoneNumberLabel.TabIndex = 10;
            phoneNumberLabel.Text = "Phone Number:";
            phoneNumberLabel.Click += new System.EventHandler(this.phoneNumberLabel_Click);
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Location = new System.Drawing.Point(271, 338);
            roleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new System.Drawing.Size(32, 13);
            roleLabel.TabIndex = 12;
            roleLabel.Text = "Role:";
            // 
            // teacherIDLabel
            // 
            teacherIDLabel.AutoSize = true;
            teacherIDLabel.Location = new System.Drawing.Point(9, 266);
            teacherIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            teacherIDLabel.Name = "teacherIDLabel";
            teacherIDLabel.Size = new System.Drawing.Size(64, 13);
            teacherIDLabel.TabIndex = 14;
            teacherIDLabel.Text = "Teacher ID:";
            // 
            // teacherNameLabel
            // 
            teacherNameLabel.AutoSize = true;
            teacherNameLabel.Location = new System.Drawing.Point(9, 290);
            teacherNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            teacherNameLabel.Name = "teacherNameLabel";
            teacherNameLabel.Size = new System.Drawing.Size(38, 13);
            teacherNameLabel.TabIndex = 16;
            teacherNameLabel.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(629, 26);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(41, 13);
            label2.TabIndex = 21;
            label2.Text = "Search";
            // 
            // teacherDataGridView
            // 
            this.teacherDataGridView.AllowUserToAddRows = false;
            this.teacherDataGridView.AllowUserToDeleteRows = false;
            this.teacherDataGridView.AutoGenerateColumns = false;
            this.teacherDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.teacherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.teacherDataGridView.DataSource = this.teacherBindingSource;
            this.teacherDataGridView.Location = new System.Drawing.Point(9, 62);
            this.teacherDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.teacherDataGridView.Name = "teacherDataGridView";
            this.teacherDataGridView.ReadOnly = true;
            this.teacherDataGridView.RowHeadersWidth = 51;
            this.teacherDataGridView.RowTemplate.Height = 24;
            this.teacherDataGridView.Size = new System.Drawing.Size(772, 179);
            this.teacherDataGridView.TabIndex = 1;
            this.teacherDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teacherDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TeacherID";
            this.dataGridViewTextBoxColumn1.HeaderText = "TeacherID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TeacherName";
            this.dataGridViewTextBoxColumn2.HeaderText = "TeacherName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BirthDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "BirthDate";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn4.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn5.HeaderText = "PhoneNumber";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn6.HeaderText = "Email";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn7.HeaderText = "Password";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Role";
            this.dataGridViewTextBoxColumn8.HeaderText = "Role";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(Score.Teacher);
            this.teacherBindingSource.CurrentChanged += new System.EventHandler(this.teacherBindingSource_CurrentChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Master Teacher";
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.birthDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.teacherBindingSource, "BirthDate", true));
            this.birthDateDateTimePicker.Enabled = false;
            this.birthDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(89, 337);
            this.birthDateDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.birthDateDateTimePicker.TabIndex = 3;
            this.birthDateDateTimePicker.ValueChanged += new System.EventHandler(this.birthDateDateTimePicker_ValueChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Email", true));
            this.emailTextBox.Enabled = false;
            this.emailTextBox.Location = new System.Drawing.Point(351, 285);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(151, 20);
            this.emailTextBox.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Password", true));
            this.passwordTextBox.Enabled = false;
            this.passwordTextBox.Location = new System.Drawing.Point(351, 310);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(151, 20);
            this.passwordTextBox.TabIndex = 9;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Enabled = false;
            this.phoneNumberTextBox.Location = new System.Drawing.Point(89, 313);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(151, 20);
            this.phoneNumberTextBox.TabIndex = 11;
            this.phoneNumberTextBox.TextChanged += new System.EventHandler(this.phoneNumberTextBox_TextChanged);
            // 
            // teacherIDTextBox
            // 
            this.teacherIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "TeacherID", true));
            this.teacherIDTextBox.Enabled = false;
            this.teacherIDTextBox.Location = new System.Drawing.Point(89, 263);
            this.teacherIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.teacherIDTextBox.Name = "teacherIDTextBox";
            this.teacherIDTextBox.Size = new System.Drawing.Size(151, 20);
            this.teacherIDTextBox.TabIndex = 15;
            // 
            // teacherNameTextBox
            // 
            this.teacherNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "TeacherName", true));
            this.teacherNameTextBox.Enabled = false;
            this.teacherNameTextBox.Location = new System.Drawing.Point(89, 288);
            this.teacherNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.teacherNameTextBox.Name = "teacherNameTextBox";
            this.teacherNameTextBox.Size = new System.Drawing.Size(151, 20);
            this.teacherNameTextBox.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Role", true));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Evaluator"});
            this.comboBox1.Location = new System.Drawing.Point(351, 336);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(632, 41);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(151, 20);
            this.searchTextBox.TabIndex = 22;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(694, 290);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 28);
            this.button1.TabIndex = 23;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lB
            // 
            this.lB.BackColor = System.Drawing.Color.MediumPurple;
            this.lB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lB.Location = new System.Drawing.Point(542, 290);
            this.lB.Margin = new System.Windows.Forms.Padding(2);
            this.lB.Name = "lB";
            this.lB.Size = new System.Drawing.Size(74, 28);
            this.lB.TabIndex = 24;
            this.lB.Text = "Insert";
            this.lB.UseVisualStyleBackColor = false;
            this.lB.Click += new System.EventHandler(this.lB_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.MediumPurple;
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Location = new System.Drawing.Point(617, 290);
            this.update.Margin = new System.Windows.Forms.Padding(2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(74, 28);
            this.update.TabIndex = 25;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.MediumPurple;
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.Enabled = false;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Location = new System.Drawing.Point(576, 321);
            this.save.Margin = new System.Windows.Forms.Padding(2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(74, 28);
            this.save.TabIndex = 27;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.IndianRed;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Enabled = false;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(652, 321);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 28);
            this.button4.TabIndex = 26;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // mRB
            // 
            this.mRB.AutoSize = true;
            this.mRB.Enabled = false;
            this.mRB.Location = new System.Drawing.Point(351, 264);
            this.mRB.Margin = new System.Windows.Forms.Padding(2);
            this.mRB.Name = "mRB";
            this.mRB.Size = new System.Drawing.Size(48, 17);
            this.mRB.TabIndex = 28;
            this.mRB.TabStop = true;
            this.mRB.Text = "Male";
            this.mRB.UseVisualStyleBackColor = true;
            // 
            // fRB
            // 
            this.fRB.AutoSize = true;
            this.fRB.Enabled = false;
            this.fRB.Location = new System.Drawing.Point(446, 263);
            this.fRB.Margin = new System.Windows.Forms.Padding(2);
            this.fRB.Name = "fRB";
            this.fRB.Size = new System.Drawing.Size(59, 17);
            this.fRB.TabIndex = 29;
            this.fRB.TabStop = true;
            this.fRB.Text = "Female";
            this.fRB.UseVisualStyleBackColor = true;
            // 
            // MTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 383);
            this.Controls.Add(this.fRB);
            this.Controls.Add(this.mRB);
            this.Controls.Add(this.save);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.update);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lB);
            this.Controls.Add(label2);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(birthDateLabel);
            this.Controls.Add(this.birthDateDateTimePicker);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(roleLabel);
            this.Controls.Add(teacherIDLabel);
            this.Controls.Add(this.teacherIDTextBox);
            this.Controls.Add(teacherNameLabel);
            this.Controls.Add(this.teacherNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teacherDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MTeacher";
            this.Text = "Master Teacher";
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.DataGridView teacherDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker birthDateDateTimePicker;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox teacherIDTextBox;
        private System.Windows.Forms.TextBox teacherNameTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button lB;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton mRB;
        private System.Windows.Forms.RadioButton fRB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}