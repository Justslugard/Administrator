namespace Examination
{
    partial class ViewCase
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
            this.search = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.optionATextBox = new System.Windows.Forms.TextBox();
            this.optionCTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.optionDTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.optionBTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fastBackward = new System.Windows.Forms.Button();
            this.backward = new System.Windows.Forms.Button();
            this.fastForward = new System.Windows.Forms.Button();
            this.forward = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.answerComboBox = new System.Windows.Forms.ComboBox();
            this.caseDataGridView = new System.Windows.Forms.DataGridView();
            this.CreatorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.examDataSet = new Examination.ExamDataSet();
            this.cases_detailsTableAdapter = new Examination.ExamDataSetTableAdapters.cases_detailsTableAdapter();
            this.caseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.caseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.Location = new System.Drawing.Point(711, 69);
            this.search.Margin = new System.Windows.Forms.Padding(4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(201, 22);
            this.search.TabIndex = 36;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(549, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Search by Creator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 41);
            this.label1.TabIndex = 33;
            this.label1.Text = "View Case";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 408);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Question ";
            // 
            // questionTextBox
            // 
            this.questionTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.questionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "question", true));
            this.questionTextBox.Enabled = false;
            this.questionTextBox.Location = new System.Drawing.Point(20, 438);
            this.questionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(892, 80);
            this.questionTextBox.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 538);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 24);
            this.label4.TabIndex = 39;
            this.label4.Text = "A.";
            // 
            // optionATextBox
            // 
            this.optionATextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "optionA", true));
            this.optionATextBox.Enabled = false;
            this.optionATextBox.Location = new System.Drawing.Point(60, 538);
            this.optionATextBox.Margin = new System.Windows.Forms.Padding(4);
            this.optionATextBox.Multiline = true;
            this.optionATextBox.Name = "optionATextBox";
            this.optionATextBox.Size = new System.Drawing.Size(299, 56);
            this.optionATextBox.TabIndex = 40;
            // 
            // optionCTextBox
            // 
            this.optionCTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "optionC", true));
            this.optionCTextBox.Enabled = false;
            this.optionCTextBox.Location = new System.Drawing.Point(613, 538);
            this.optionCTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.optionCTextBox.Multiline = true;
            this.optionCTextBox.Name = "optionCTextBox";
            this.optionCTextBox.Size = new System.Drawing.Size(299, 56);
            this.optionCTextBox.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(565, 538);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 24);
            this.label5.TabIndex = 41;
            this.label5.Text = "C.";
            // 
            // optionDTextBox
            // 
            this.optionDTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "optionD", true));
            this.optionDTextBox.Enabled = false;
            this.optionDTextBox.Location = new System.Drawing.Point(613, 635);
            this.optionDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.optionDTextBox.Multiline = true;
            this.optionDTextBox.Name = "optionDTextBox";
            this.optionDTextBox.Size = new System.Drawing.Size(299, 56);
            this.optionDTextBox.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(565, 635);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 24);
            this.label6.TabIndex = 45;
            this.label6.Text = "D.";
            // 
            // optionBTextBox
            // 
            this.optionBTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "optionB", true));
            this.optionBTextBox.Enabled = false;
            this.optionBTextBox.Location = new System.Drawing.Point(60, 635);
            this.optionBTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.optionBTextBox.Multiline = true;
            this.optionBTextBox.Name = "optionBTextBox";
            this.optionBTextBox.Size = new System.Drawing.Size(299, 56);
            this.optionBTextBox.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 635);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 24);
            this.label7.TabIndex = 43;
            this.label7.Text = "B.";
            // 
            // fastBackward
            // 
            this.fastBackward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fastBackward.Enabled = false;
            this.fastBackward.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fastBackward.Location = new System.Drawing.Point(248, 778);
            this.fastBackward.Margin = new System.Windows.Forms.Padding(4);
            this.fastBackward.Name = "fastBackward";
            this.fastBackward.Size = new System.Drawing.Size(101, 28);
            this.fastBackward.TabIndex = 47;
            this.fastBackward.Text = "<<";
            this.fastBackward.UseVisualStyleBackColor = true;
            this.fastBackward.Click += new System.EventHandler(this.fastBackward_Click);
            // 
            // backward
            // 
            this.backward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backward.Enabled = false;
            this.backward.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backward.Location = new System.Drawing.Point(357, 778);
            this.backward.Margin = new System.Windows.Forms.Padding(4);
            this.backward.Name = "backward";
            this.backward.Size = new System.Drawing.Size(101, 28);
            this.backward.TabIndex = 48;
            this.backward.Text = "<";
            this.backward.UseVisualStyleBackColor = true;
            this.backward.Click += new System.EventHandler(this.backward_Click);
            // 
            // fastForward
            // 
            this.fastForward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fastForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fastForward.Location = new System.Drawing.Point(576, 778);
            this.fastForward.Margin = new System.Windows.Forms.Padding(4);
            this.fastForward.Name = "fastForward";
            this.fastForward.Size = new System.Drawing.Size(101, 28);
            this.fastForward.TabIndex = 50;
            this.fastForward.Text = ">>";
            this.fastForward.UseVisualStyleBackColor = true;
            this.fastForward.Click += new System.EventHandler(this.fastForward_Click);
            // 
            // forward
            // 
            this.forward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forward.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forward.Location = new System.Drawing.Point(467, 778);
            this.forward.Margin = new System.Windows.Forms.Padding(4);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(101, 28);
            this.forward.TabIndex = 49;
            this.forward.Text = ">";
            this.forward.UseVisualStyleBackColor = true;
            this.forward.Click += new System.EventHandler(this.forward_Click);
            // 
            // cancel
            // 
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.Enabled = false;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(521, 814);
            this.cancel.Margin = new System.Windows.Forms.Padding(4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(101, 28);
            this.cancel.TabIndex = 53;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // save
            // 
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.Enabled = false;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(412, 814);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(101, 28);
            this.save.TabIndex = 52;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // update
            // 
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(303, 814);
            this.update.Margin = new System.Windows.Forms.Padding(4);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(101, 28);
            this.update.TabIndex = 51;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 722);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 24);
            this.label8.TabIndex = 54;
            this.label8.Text = "Answer:";
            // 
            // answerComboBox
            // 
            this.answerComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.answerComboBox.Enabled = false;
            this.answerComboBox.FormattingEnabled = true;
            this.answerComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.answerComboBox.Location = new System.Drawing.Point(104, 722);
            this.answerComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.answerComboBox.Name = "answerComboBox";
            this.answerComboBox.Size = new System.Drawing.Size(136, 24);
            this.answerComboBox.TabIndex = 55;
            // 
            // caseDataGridView
            // 
            this.caseDataGridView.AllowUserToAddRows = false;
            this.caseDataGridView.AllowUserToDeleteRows = false;
            this.caseDataGridView.AutoGenerateColumns = false;
            this.caseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.caseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.caseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.CreatorName,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.caseDataGridView.DataSource = this.caseBindingSource;
            this.caseDataGridView.Location = new System.Drawing.Point(12, 98);
            this.caseDataGridView.Name = "caseDataGridView";
            this.caseDataGridView.ReadOnly = true;
            this.caseDataGridView.RowHeadersWidth = 51;
            this.caseDataGridView.RowTemplate.Height = 24;
            this.caseDataGridView.Size = new System.Drawing.Size(908, 295);
            this.caseDataGridView.TabIndex = 56;
            this.caseDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.caseDataGridView_CellClick);
            // 
            // CreatorName
            // 
            this.CreatorName.DataPropertyName = "CreatorName";
            this.CreatorName.HeaderText = "creator";
            this.CreatorName.MinimumWidth = 6;
            this.CreatorName.Name = "CreatorName";
            this.CreatorName.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "totalQ", true));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(104, 408);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 24);
            this.label9.TabIndex = 58;
            // 
            // examDataSet
            // 
            this.examDataSet.DataSetName = "ExamDataSet";
            this.examDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cases_detailsTableAdapter
            // 
            this.cases_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // caseBindingSource
            // 
            this.caseBindingSource.DataSource = typeof(Examination.@case);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cases_details";
            this.dataGridViewTextBoxColumn2.HeaderText = "cases_details";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "code";
            this.dataGridViewTextBoxColumn3.HeaderText = "code";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "number_of_questions";
            this.dataGridViewTextBoxColumn4.HeaderText = "number_of_questions";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "created_at";
            this.dataGridViewTextBoxColumn5.HeaderText = "created_at";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "deleted_at";
            this.dataGridViewTextBoxColumn6.HeaderText = "deleted_at";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // ViewCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 862);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.caseDataGridView);
            this.Controls.Add(this.answerComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.update);
            this.Controls.Add(this.fastForward);
            this.Controls.Add(this.forward);
            this.Controls.Add(this.backward);
            this.Controls.Add(this.fastBackward);
            this.Controls.Add(this.optionDTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.optionBTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.optionCTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.optionATextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewCase";
            this.Text = "View Case";
            this.Load += new System.EventHandler(this.ViewCase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.caseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox optionATextBox;
        private System.Windows.Forms.TextBox optionCTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox optionDTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox optionBTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button fastBackward;
        private System.Windows.Forms.Button backward;
        private System.Windows.Forms.Button fastForward;
        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox answerComboBox;
        private System.Windows.Forms.BindingSource caseBindingSource;
        private System.Windows.Forms.DataGridView caseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label9;
        private ExamDataSet examDataSet;
        private ExamDataSetTableAdapters.cases_detailsTableAdapter cases_detailsTableAdapter;
    }
}