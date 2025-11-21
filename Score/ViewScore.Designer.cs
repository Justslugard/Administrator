namespace Score
{
    partial class ViewScore
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
            this.scoreDgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.studentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tots = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreDgv
            // 
            this.scoreDgv.AllowUserToAddRows = false;
            this.scoreDgv.AllowUserToDeleteRows = false;
            this.scoreDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.scoreDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentID,
            this.studentName,
            this.studentClass,
            this.tots});
            this.scoreDgv.Location = new System.Drawing.Point(12, 74);
            this.scoreDgv.Name = "scoreDgv";
            this.scoreDgv.ReadOnly = true;
            this.scoreDgv.Size = new System.Drawing.Size(1148, 308);
            this.scoreDgv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1021, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sort By:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(543, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "View Score";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(178, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 26);
            this.button2.TabIndex = 9;
            this.button2.Text = "Show Data";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Student - Top",
            "Student - Bottom",
            "TotalScore - Top",
            "TotalScore - Bottom"});
            this.comboBox1.Location = new System.Drawing.Point(1024, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.TextChanged += new System.EventHandler(this.button2_Click);
            // 
            // studentID
            // 
            this.studentID.HeaderText = "ID";
            this.studentID.MinimumWidth = 6;
            this.studentID.Name = "studentID";
            this.studentID.ReadOnly = true;
            this.studentID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.studentID.Width = 43;
            // 
            // studentName
            // 
            this.studentName.HeaderText = "Name";
            this.studentName.MinimumWidth = 6;
            this.studentName.Name = "studentName";
            this.studentName.ReadOnly = true;
            this.studentName.Width = 60;
            // 
            // studentClass
            // 
            this.studentClass.HeaderText = "Class";
            this.studentClass.MinimumWidth = 6;
            this.studentClass.Name = "studentClass";
            this.studentClass.ReadOnly = true;
            this.studentClass.Width = 57;
            // 
            // tots
            // 
            this.tots.HeaderText = "TotalScore";
            this.tots.Name = "tots";
            this.tots.ReadOnly = true;
            this.tots.Width = 84;
            // 
            // ViewScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 394);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreDgv);
            this.Name = "ViewScore";
            this.Text = "View Score";
            ((System.ComponentModel.ISupportInitialize)(this.scoreDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView scoreDgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn tots;
    }
}