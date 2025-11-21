namespace Score
{
    partial class MSubject
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
            System.Windows.Forms.Label subjectIDLabel;
            System.Windows.Forms.Label subjectNameLabel;
            System.Windows.Forms.Label minimumCriteriaLabel;
            this.subjectDataGridView = new System.Windows.Forms.DataGridView();
            this.save = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lB = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.subjectIDTextBox = new System.Windows.Forms.TextBox();
            this.subjectNameTextBox = new System.Windows.Forms.TextBox();
            this.minimumCriteriaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.isPracticeCheckBox = new System.Windows.Forms.CheckBox();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label2 = new System.Windows.Forms.Label();
            subjectIDLabel = new System.Windows.Forms.Label();
            subjectNameLabel = new System.Windows.Forms.Label();
            minimumCriteriaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumCriteriaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(443, 14);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(41, 13);
            label2.TabIndex = 37;
            label2.Text = "Search";
            // 
            // subjectIDLabel
            // 
            subjectIDLabel.AutoSize = true;
            subjectIDLabel.Location = new System.Drawing.Point(23, 303);
            subjectIDLabel.Name = "subjectIDLabel";
            subjectIDLabel.Size = new System.Drawing.Size(60, 13);
            subjectIDLabel.TabIndex = 47;
            subjectIDLabel.Text = "Subject ID:";
            // 
            // subjectNameLabel
            // 
            subjectNameLabel.AutoSize = true;
            subjectNameLabel.Location = new System.Drawing.Point(23, 329);
            subjectNameLabel.Name = "subjectNameLabel";
            subjectNameLabel.Size = new System.Drawing.Size(38, 13);
            subjectNameLabel.TabIndex = 49;
            subjectNameLabel.Text = "Name:";
            // 
            // minimumCriteriaLabel
            // 
            minimumCriteriaLabel.AutoSize = true;
            minimumCriteriaLabel.Location = new System.Drawing.Point(23, 352);
            minimumCriteriaLabel.Name = "minimumCriteriaLabel";
            minimumCriteriaLabel.Size = new System.Drawing.Size(86, 13);
            minimumCriteriaLabel.TabIndex = 50;
            minimumCriteriaLabel.Text = "Minimum Criteria:";
            // 
            // subjectDataGridView
            // 
            this.subjectDataGridView.AllowUserToAddRows = false;
            this.subjectDataGridView.AllowUserToDeleteRows = false;
            this.subjectDataGridView.AutoGenerateColumns = false;
            this.subjectDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.subjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.subjectDataGridView.DataSource = this.subjectBindingSource;
            this.subjectDataGridView.Location = new System.Drawing.Point(12, 58);
            this.subjectDataGridView.Name = "subjectDataGridView";
            this.subjectDataGridView.ReadOnly = true;
            this.subjectDataGridView.Size = new System.Drawing.Size(585, 220);
            this.subjectDataGridView.TabIndex = 1;
            this.subjectDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subjectDataGridView_CellClick);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.MediumPurple;
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.Enabled = false;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Location = new System.Drawing.Point(405, 352);
            this.save.Margin = new System.Windows.Forms.Padding(2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(74, 28);
            this.save.TabIndex = 43;
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
            this.button4.Location = new System.Drawing.Point(481, 352);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 28);
            this.button4.TabIndex = 42;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.MediumPurple;
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Location = new System.Drawing.Point(446, 321);
            this.update.Margin = new System.Windows.Forms.Padding(2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(74, 28);
            this.update.TabIndex = 41;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(523, 321);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 28);
            this.button1.TabIndex = 39;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lB
            // 
            this.lB.BackColor = System.Drawing.Color.MediumPurple;
            this.lB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lB.Location = new System.Drawing.Point(371, 321);
            this.lB.Margin = new System.Windows.Forms.Padding(2);
            this.lB.Name = "lB";
            this.lB.Size = new System.Drawing.Size(74, 28);
            this.lB.TabIndex = 40;
            this.lB.Text = "Insert";
            this.lB.UseVisualStyleBackColor = false;
            this.lB.Click += new System.EventHandler(this.lB_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(446, 29);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(151, 20);
            this.searchTextBox.TabIndex = 38;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Master Subject";
            // 
            // subjectIDTextBox
            // 
            this.subjectIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjectBindingSource, "SubjectID", true));
            this.subjectIDTextBox.Enabled = false;
            this.subjectIDTextBox.Location = new System.Drawing.Point(115, 300);
            this.subjectIDTextBox.Name = "subjectIDTextBox";
            this.subjectIDTextBox.Size = new System.Drawing.Size(120, 20);
            this.subjectIDTextBox.TabIndex = 48;
            // 
            // subjectNameTextBox
            // 
            this.subjectNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjectBindingSource, "SubjectName", true));
            this.subjectNameTextBox.Enabled = false;
            this.subjectNameTextBox.Location = new System.Drawing.Point(115, 326);
            this.subjectNameTextBox.Name = "subjectNameTextBox";
            this.subjectNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.subjectNameTextBox.TabIndex = 50;
            // 
            // minimumCriteriaNumericUpDown
            // 
            this.minimumCriteriaNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.subjectBindingSource, "MinimumCriteria", true));
            this.minimumCriteriaNumericUpDown.Enabled = false;
            this.minimumCriteriaNumericUpDown.Location = new System.Drawing.Point(115, 352);
            this.minimumCriteriaNumericUpDown.Name = "minimumCriteriaNumericUpDown";
            this.minimumCriteriaNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.minimumCriteriaNumericUpDown.TabIndex = 51;
            // 
            // isPracticeCheckBox
            // 
            this.isPracticeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.subjectBindingSource, "IsPractice", true));
            this.isPracticeCheckBox.Enabled = false;
            this.isPracticeCheckBox.Location = new System.Drawing.Point(115, 378);
            this.isPracticeCheckBox.Name = "isPracticeCheckBox";
            this.isPracticeCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isPracticeCheckBox.TabIndex = 52;
            this.isPracticeCheckBox.Text = "isPractice";
            this.isPracticeCheckBox.UseVisualStyleBackColor = true;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(Score.Subject);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SubjectID";
            this.dataGridViewTextBoxColumn1.HeaderText = "SubjectID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SubjectName";
            this.dataGridViewTextBoxColumn2.HeaderText = "SubjectName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MinimumCriteria";
            this.dataGridViewTextBoxColumn3.HeaderText = "MinimumCriteria";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IsPractice";
            this.dataGridViewTextBoxColumn4.HeaderText = "IsPractice";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // MSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 426);
            this.Controls.Add(this.isPracticeCheckBox);
            this.Controls.Add(minimumCriteriaLabel);
            this.Controls.Add(this.minimumCriteriaNumericUpDown);
            this.Controls.Add(subjectIDLabel);
            this.Controls.Add(this.subjectIDTextBox);
            this.Controls.Add(subjectNameLabel);
            this.Controls.Add(this.subjectNameTextBox);
            this.Controls.Add(this.save);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.update);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lB);
            this.Controls.Add(label2);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subjectDataGridView);
            this.Name = "MSubject";
            this.Text = "Master Subject";
            ((System.ComponentModel.ISupportInitialize)(this.subjectDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumCriteriaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource subjectBindingSource;
        private System.Windows.Forms.DataGridView subjectDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button lB;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox subjectIDTextBox;
        private System.Windows.Forms.TextBox subjectNameTextBox;
        private System.Windows.Forms.NumericUpDown minimumCriteriaNumericUpDown;
        private System.Windows.Forms.CheckBox isPracticeCheckBox;
    }
}