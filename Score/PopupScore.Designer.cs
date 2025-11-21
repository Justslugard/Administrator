namespace Score
{
    partial class PopupScore
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.scoreDetailDataGridView = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.name = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.minimumCriteriaTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sMKScoreDataSet = new Score.SMKScoreDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.subjectTableAdapter = new Score.SMKScoreDataSetTableAdapters.SubjectTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDetailDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMKScoreDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreDetailDataGridView
            // 
            this.scoreDetailDataGridView.AllowUserToAddRows = false;
            this.scoreDetailDataGridView.AllowUserToDeleteRows = false;
            this.scoreDetailDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.scoreDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreDetailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3,
            this.action});
            this.scoreDetailDataGridView.Location = new System.Drawing.Point(12, 50);
            this.scoreDetailDataGridView.Name = "scoreDetailDataGridView";
            this.scoreDetailDataGridView.ReadOnly = true;
            this.scoreDetailDataGridView.Size = new System.Drawing.Size(464, 242);
            this.scoreDetailDataGridView.TabIndex = 1;
            this.scoreDetailDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.scoreDetailDataGridView_CellContentClick);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SubjectID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Score";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Status";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // action
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Salmon;
            this.action.DefaultCellStyle = dataGridViewCellStyle3;
            this.action.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.action.HeaderText = "Action";
            this.action.Name = "action";
            this.action.ReadOnly = true;
            this.action.Text = "Remove";
            this.action.UseColumnTextForButtonValue = true;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(84, 34);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(67, 13);
            this.name.TabIndex = 5;
            this.name.Text = "Welcome, ";
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Location = new System.Drawing.Point(12, 34);
            this.welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(75, 13);
            this.welcome.TabIndex = 4;
            this.welcome.Text = "Student Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.minimumCriteriaTextBox);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(491, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 176);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Subject";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDown1.Location = new System.Drawing.Point(113, 84);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(117, 20);
            this.numericUpDown1.TabIndex = 11;
            // 
            // minimumCriteriaTextBox
            // 
            this.minimumCriteriaTextBox.Enabled = false;
            this.minimumCriteriaTextBox.Location = new System.Drawing.Point(113, 58);
            this.minimumCriteriaTextBox.Name = "minimumCriteriaTextBox";
            this.minimumCriteriaTextBox.Size = new System.Drawing.Size(117, 20);
            this.minimumCriteriaTextBox.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DataSource = this.subjectBindingSource;
            this.comboBox1.DisplayMember = "SubjectName";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "SubjectID";
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "Subject";
            this.subjectBindingSource.DataSource = this.sMKScoreDataSet;
            // 
            // sMKScoreDataSet
            // 
            this.sMKScoreDataSet.DataSetName = "SMKScoreDataSet";
            this.sMKScoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(152, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Minimum Criteria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(491, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submit Finalize";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // PopupScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 304);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.scoreDetailDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PopupScore";
            this.Text = "Scoring Student";
            this.Load += new System.EventHandler(this.PopupScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scoreDetailDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMKScoreDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView scoreDetailDataGridView;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox minimumCriteriaTextBox;
        private SMKScoreDataSet sMKScoreDataSet;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private SMKScoreDataSetTableAdapters.SubjectTableAdapter subjectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn action;
    }
}