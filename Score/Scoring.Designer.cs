namespace Score
{
    partial class Scoring
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
            System.Windows.Forms.Label subjectIDLabel;
            System.Windows.Forms.Label subjectNameLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreDate = new System.Windows.Forms.TextBox();
            this.evaluatorTextBox = new System.Windows.Forms.TextBox();
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            subjectIDLabel = new System.Windows.Forms.Label();
            subjectNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // subjectIDLabel
            // 
            subjectIDLabel.AutoSize = true;
            subjectIDLabel.Location = new System.Drawing.Point(14, 22);
            subjectIDLabel.Name = "subjectIDLabel";
            subjectIDLabel.Size = new System.Drawing.Size(64, 13);
            subjectIDLabel.TabIndex = 51;
            subjectIDLabel.Text = "Score Date:";
            // 
            // subjectNameLabel
            // 
            subjectNameLabel.AutoSize = true;
            subjectNameLabel.Location = new System.Drawing.Point(14, 48);
            subjectNameLabel.Name = "subjectNameLabel";
            subjectNameLabel.Size = new System.Drawing.Size(55, 13);
            subjectNameLabel.TabIndex = 53;
            subjectNameLabel.Text = "Evaluator:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(568, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "Submit Scoring Student";
            // 
            // scoreDate
            // 
            this.scoreDate.Enabled = false;
            this.scoreDate.Location = new System.Drawing.Point(106, 19);
            this.scoreDate.Name = "scoreDate";
            this.scoreDate.Size = new System.Drawing.Size(120, 20);
            this.scoreDate.TabIndex = 52;
            // 
            // evaluatorTextBox
            // 
            this.evaluatorTextBox.Enabled = false;
            this.evaluatorTextBox.Location = new System.Drawing.Point(106, 45);
            this.evaluatorTextBox.Name = "evaluatorTextBox";
            this.evaluatorTextBox.Size = new System.Drawing.Size(120, 20);
            this.evaluatorTextBox.TabIndex = 54;
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
            this.action});
            this.studentDataGridView.DataSource = this.studentBindingSource;
            this.studentDataGridView.Location = new System.Drawing.Point(12, 71);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.ReadOnly = true;
            this.studentDataGridView.Size = new System.Drawing.Size(785, 367);
            this.studentDataGridView.TabIndex = 55;
            this.studentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDataGridView_CellContentClick);
            // 
            // action
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.action.DefaultCellStyle = dataGridViewCellStyle1;
            this.action.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.action.HeaderText = "Action";
            this.action.Name = "action";
            this.action.ReadOnly = true;
            this.action.Text = "Input Score";
            this.action.UseColumnTextForButtonValue = true;
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
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StudentClass";
            this.dataGridViewTextBoxColumn3.HeaderText = "Class";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Score.Student);
            // 
            // Scoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.studentDataGridView);
            this.Controls.Add(subjectIDLabel);
            this.Controls.Add(this.scoreDate);
            this.Controls.Add(subjectNameLabel);
            this.Controls.Add(this.evaluatorTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Scoring";
            this.Text = "Submit Scoring";
            this.Load += new System.EventHandler(this.Scoring_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox scoreDate;
        private System.Windows.Forms.TextBox evaluatorTextBox;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn action;
    }
}