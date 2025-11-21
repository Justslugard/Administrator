namespace Score
{
    partial class ViewReport
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
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.reportDgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Label();
            this.scoreDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.AllowUserToAddRows = false;
            this.studentDataGridView.AllowUserToDeleteRows = false;
            this.studentDataGridView.AutoGenerateColumns = false;
            this.studentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.studentDataGridView.DataSource = this.studentBindingSource;
            this.studentDataGridView.Location = new System.Drawing.Point(12, 85);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.ReadOnly = true;
            this.studentDataGridView.Size = new System.Drawing.Size(300, 344);
            this.studentDataGridView.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(9, 45);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(41, 13);
            label2.TabIndex = 39;
            label2.Text = "Search";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(12, 60);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(151, 20);
            this.searchTextBox.TabIndex = 40;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // reportDgv
            // 
            this.reportDgv.AllowUserToAddRows = false;
            this.reportDgv.AllowUserToDeleteRows = false;
            this.reportDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reportDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scoreDate,
            this.evaluator,
            this.subjectName,
            this.score,
            this.status});
            this.reportDgv.Location = new System.Drawing.Point(318, 85);
            this.reportDgv.Name = "reportDgv";
            this.reportDgv.ReadOnly = true;
            this.reportDgv.Size = new System.Drawing.Size(616, 344);
            this.reportDgv.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(733, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "View Report Student";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(315, 67);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(67, 13);
            this.name.TabIndex = 44;
            this.name.Text = "Welcome, ";
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Location = new System.Drawing.Point(315, 47);
            this.welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(85, 13);
            this.welcome.TabIndex = 43;
            this.welcome.Text = "Report Score for";
            // 
            // scoreDate
            // 
            this.scoreDate.HeaderText = "ScoreDate";
            this.scoreDate.Name = "scoreDate";
            this.scoreDate.ReadOnly = true;
            // 
            // evaluator
            // 
            this.evaluator.HeaderText = "Evaluator";
            this.evaluator.Name = "evaluator";
            this.evaluator.ReadOnly = true;
            // 
            // subjectName
            // 
            this.subjectName.HeaderText = "SubjectName";
            this.subjectName.Name = "subjectName";
            this.subjectName.ReadOnly = true;
            // 
            // score
            // 
            this.score.HeaderText = "Score";
            this.score.Name = "score";
            this.score.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StudentClass";
            this.dataGridViewTextBoxColumn3.HeaderText = "StudentClass";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Score.Student);
            this.studentBindingSource.CurrentChanged += new System.EventHandler(this.studentBindingSource_CurrentChanged);
            // 
            // ViewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 441);
            this.Controls.Add(this.name);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportDgv);
            this.Controls.Add(label2);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.studentDataGridView);
            this.Name = "ViewReport";
            this.Text = "View Report Student";
            this.Load += new System.EventHandler(this.ViewReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridView reportDgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluator;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}