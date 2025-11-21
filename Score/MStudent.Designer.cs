namespace Score
{
    partial class MStudent
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label birthDateLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label studentClassLabel;
            System.Windows.Forms.Label studentIDLabel;
            System.Windows.Forms.Label studentNameLabel;
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.save = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lB = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.birthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.fRB = new System.Windows.Forms.RadioButton();
            this.mRB = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            studentClassLabel = new System.Windows.Forms.Label();
            studentIDLabel = new System.Windows.Forms.Label();
            studentNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(665, 15);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(41, 13);
            label2.TabIndex = 29;
            label2.Text = "Search";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(313, 318);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 35;
            addressLabel.Text = "Address:";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new System.Drawing.Point(12, 342);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(57, 13);
            birthDateLabel.TabIndex = 37;
            birthDateLabel.Text = "Birth Date:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(313, 287);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(45, 13);
            genderLabel.TabIndex = 39;
            genderLabel.Text = "Gender:";
            // 
            // studentClassLabel
            // 
            studentClassLabel.AutoSize = true;
            studentClassLabel.Location = new System.Drawing.Point(316, 366);
            studentClassLabel.Name = "studentClassLabel";
            studentClassLabel.Size = new System.Drawing.Size(35, 13);
            studentClassLabel.TabIndex = 41;
            studentClassLabel.Text = "Class:";
            // 
            // studentIDLabel
            // 
            studentIDLabel.AutoSize = true;
            studentIDLabel.Location = new System.Drawing.Point(12, 288);
            studentIDLabel.Name = "studentIDLabel";
            studentIDLabel.Size = new System.Drawing.Size(61, 13);
            studentIDLabel.TabIndex = 43;
            studentIDLabel.Text = "Student ID:";
            // 
            // studentNameLabel
            // 
            studentNameLabel.AutoSize = true;
            studentNameLabel.Location = new System.Drawing.Point(12, 314);
            studentNameLabel.Name = "studentNameLabel";
            studentNameLabel.Size = new System.Drawing.Size(38, 13);
            studentNameLabel.TabIndex = 45;
            studentNameLabel.Text = "Name:";
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.AllowUserToAddRows = false;
            this.studentDataGridView.AllowUserToDeleteRows = false;
            this.studentDataGridView.AutoGenerateColumns = false;
            this.studentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.studentDataGridView.DataSource = this.studentBindingSource;
            this.studentDataGridView.Location = new System.Drawing.Point(12, 53);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.ReadOnly = true;
            this.studentDataGridView.Size = new System.Drawing.Size(807, 220);
            this.studentDataGridView.TabIndex = 1;
            this.studentDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StudentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "StudentID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StudentName";
            this.dataGridViewTextBoxColumn2.HeaderText = "StudentName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BirthDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "BirthDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn4.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn5.HeaderText = "Address";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "StudentClass";
            this.dataGridViewTextBoxColumn6.HeaderText = "StudentClass";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Score.Student);
            this.studentBindingSource.CurrentChanged += new System.EventHandler(this.studentBindingSource_CurrentChanged);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.MediumPurple;
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.Enabled = false;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Location = new System.Drawing.Point(615, 330);
            this.save.Margin = new System.Windows.Forms.Padding(2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(74, 28);
            this.save.TabIndex = 35;
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
            this.button4.Location = new System.Drawing.Point(691, 330);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 28);
            this.button4.TabIndex = 34;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.MediumPurple;
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Location = new System.Drawing.Point(656, 299);
            this.update.Margin = new System.Windows.Forms.Padding(2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(74, 28);
            this.update.TabIndex = 33;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(733, 299);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 28);
            this.button1.TabIndex = 31;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lB
            // 
            this.lB.BackColor = System.Drawing.Color.MediumPurple;
            this.lB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lB.Location = new System.Drawing.Point(581, 299);
            this.lB.Margin = new System.Windows.Forms.Padding(2);
            this.lB.Name = "lB";
            this.lB.Size = new System.Drawing.Size(74, 28);
            this.lB.TabIndex = 32;
            this.lB.Text = "Insert";
            this.lB.UseVisualStyleBackColor = false;
            this.lB.Click += new System.EventHandler(this.lB_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(668, 30);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(151, 20);
            this.searchTextBox.TabIndex = 30;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Master Student";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Address", true));
            this.addressTextBox.Enabled = false;
            this.addressTextBox.Location = new System.Drawing.Point(363, 311);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(154, 47);
            this.addressTextBox.TabIndex = 36;
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.birthDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentBindingSource, "BirthDate", true));
            this.birthDateDateTimePicker.Enabled = false;
            this.birthDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(96, 338);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthDateDateTimePicker.TabIndex = 38;
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "StudentID", true));
            this.studentIDTextBox.Enabled = false;
            this.studentIDTextBox.Location = new System.Drawing.Point(96, 285);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.studentIDTextBox.TabIndex = 44;
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "StudentName", true));
            this.studentNameTextBox.Enabled = false;
            this.studentNameTextBox.Location = new System.Drawing.Point(96, 311);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.studentNameTextBox.TabIndex = 46;
            // 
            // fRB
            // 
            this.fRB.AutoSize = true;
            this.fRB.Enabled = false;
            this.fRB.Location = new System.Drawing.Point(458, 284);
            this.fRB.Margin = new System.Windows.Forms.Padding(2);
            this.fRB.Name = "fRB";
            this.fRB.Size = new System.Drawing.Size(59, 17);
            this.fRB.TabIndex = 48;
            this.fRB.TabStop = true;
            this.fRB.Text = "Female";
            this.fRB.UseVisualStyleBackColor = true;
            // 
            // mRB
            // 
            this.mRB.AutoSize = true;
            this.mRB.Enabled = false;
            this.mRB.Location = new System.Drawing.Point(363, 285);
            this.mRB.Margin = new System.Windows.Forms.Padding(2);
            this.mRB.Name = "mRB";
            this.mRB.Size = new System.Drawing.Size(48, 17);
            this.mRB.TabIndex = 47;
            this.mRB.TabStop = true;
            this.mRB.Text = "Male";
            this.mRB.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "StudentClass", true));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "XII-RPL",
            "XII-TKJ",
            "XII-MM"});
            this.comboBox1.Location = new System.Drawing.Point(363, 363);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 21);
            this.comboBox1.TabIndex = 49;
            // 
            // MStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 426);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.fRB);
            this.Controls.Add(this.mRB);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(birthDateLabel);
            this.Controls.Add(this.birthDateDateTimePicker);
            this.Controls.Add(genderLabel);
            this.Controls.Add(studentClassLabel);
            this.Controls.Add(studentIDLabel);
            this.Controls.Add(this.studentIDTextBox);
            this.Controls.Add(studentNameLabel);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(this.save);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.update);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lB);
            this.Controls.Add(label2);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentDataGridView);
            this.Name = "MStudent";
            this.Text = "Master Student";
            this.Load += new System.EventHandler(this.MStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button lB;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.DateTimePicker birthDateDateTimePicker;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.RadioButton fRB;
        private System.Windows.Forms.RadioButton mRB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}