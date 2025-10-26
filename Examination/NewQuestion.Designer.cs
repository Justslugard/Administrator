namespace Examination
{
    partial class NewQuestion
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
            this.answerComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.optionDTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.optionBTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.optionCTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.optionATextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // answerComboBox
            // 
            this.answerComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.answerComboBox.FormattingEnabled = true;
            this.answerComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.answerComboBox.Location = new System.Drawing.Point(74, 246);
            this.answerComboBox.Name = "answerComboBox";
            this.answerComboBox.Size = new System.Drawing.Size(36, 21);
            this.answerComboBox.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 18);
            this.label8.TabIndex = 68;
            this.label8.Text = "Answer:";
            // 
            // cancel
            // 
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(382, 280);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(76, 23);
            this.cancel.TabIndex = 67;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // submit
            // 
            this.submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(248, 280);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(76, 23);
            this.submit.TabIndex = 66;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // optionDTextBox
            // 
            this.optionDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.optionDTextBox.Location = new System.Drawing.Point(460, 174);
            this.optionDTextBox.Multiline = true;
            this.optionDTextBox.Name = "optionDTextBox";
            this.optionDTextBox.Size = new System.Drawing.Size(225, 46);
            this.optionDTextBox.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(424, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 18);
            this.label6.TabIndex = 64;
            this.label6.Text = "D.";
            // 
            // optionBTextBox
            // 
            this.optionBTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.optionBTextBox.Location = new System.Drawing.Point(45, 174);
            this.optionBTextBox.Multiline = true;
            this.optionBTextBox.Name = "optionBTextBox";
            this.optionBTextBox.Size = new System.Drawing.Size(225, 46);
            this.optionBTextBox.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 18);
            this.label7.TabIndex = 62;
            this.label7.Text = "B.";
            // 
            // optionCTextBox
            // 
            this.optionCTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.optionCTextBox.Location = new System.Drawing.Point(460, 95);
            this.optionCTextBox.Multiline = true;
            this.optionCTextBox.Name = "optionCTextBox";
            this.optionCTextBox.Size = new System.Drawing.Size(225, 46);
            this.optionCTextBox.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(424, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 18);
            this.label5.TabIndex = 60;
            this.label5.Text = "C.";
            // 
            // optionATextBox
            // 
            this.optionATextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.optionATextBox.Location = new System.Drawing.Point(45, 95);
            this.optionATextBox.Multiline = true;
            this.optionATextBox.Name = "optionATextBox";
            this.optionATextBox.Size = new System.Drawing.Size(225, 46);
            this.optionATextBox.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 18);
            this.label4.TabIndex = 58;
            this.label4.Text = "A.";
            // 
            // questionTextBox
            // 
            this.questionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.questionTextBox.Location = new System.Drawing.Point(15, 12);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(670, 66);
            this.questionTextBox.TabIndex = 57;
            // 
            // NewQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 310);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.optionATextBox);
            this.Controls.Add(this.optionBTextBox);
            this.Controls.Add(this.optionCTextBox);
            this.Controls.Add(this.optionDTextBox);
            this.Controls.Add(this.answerComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.submit);
            this.Name = "NewQuestion";
            this.Text = "New Question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox answerComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox optionDTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox optionBTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox optionCTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox optionATextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox questionTextBox;
    }
}