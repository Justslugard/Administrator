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
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label idLabel;
            this.answerComboBox = new System.Windows.Forms.ComboBox();
            this.cancel = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.optionDTextBox = new System.Windows.Forms.TextBox();
            this.optionBTextBox = new System.Windows.Forms.TextBox();
            this.optionCTextBox = new System.Windows.Forms.TextBox();
            this.optionATextBox = new System.Windows.Forms.TextBox();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
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
            // optionBTextBox
            // 
            this.optionBTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.optionBTextBox.Location = new System.Drawing.Point(45, 174);
            this.optionBTextBox.Multiline = true;
            this.optionBTextBox.Name = "optionBTextBox";
            this.optionBTextBox.Size = new System.Drawing.Size(225, 46);
            this.optionBTextBox.TabIndex = 63;
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
            // optionATextBox
            // 
            this.optionATextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.optionATextBox.Location = new System.Drawing.Point(45, 95);
            this.optionATextBox.Multiline = true;
            this.optionATextBox.Name = "optionATextBox";
            this.optionATextBox.Size = new System.Drawing.Size(225, 46);
            this.optionATextBox.TabIndex = 59;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(10, 246);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(61, 16);
            label7.TabIndex = 74;
            label7.Text = "Answer:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(432, 175);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(22, 16);
            label5.TabIndex = 73;
            label5.Text = "D.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(15, 175);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(21, 16);
            label6.TabIndex = 72;
            label6.Text = "B.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(433, 95);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(21, 16);
            label4.TabIndex = 71;
            label4.Text = "C.";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(17, 95);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 16);
            idLabel.TabIndex = 70;
            idLabel.Text = "A.";
            // 
            // NewQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 310);
            this.Controls.Add(label7);
            this.Controls.Add(label5);
            this.Controls.Add(label6);
            this.Controls.Add(label4);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.optionATextBox);
            this.Controls.Add(this.optionBTextBox);
            this.Controls.Add(this.optionCTextBox);
            this.Controls.Add(this.optionDTextBox);
            this.Controls.Add(this.answerComboBox);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.submit);
            this.Name = "NewQuestion";
            this.Text = "New Question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox answerComboBox;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox optionDTextBox;
        private System.Windows.Forms.TextBox optionBTextBox;
        private System.Windows.Forms.TextBox optionCTextBox;
        private System.Windows.Forms.TextBox optionATextBox;
        private System.Windows.Forms.TextBox questionTextBox;
    }
}