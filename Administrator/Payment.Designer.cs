﻿namespace Winform_Login
{
    partial class Payment
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
            this.id = new System.Windows.Forms.TextBox();
            this.asd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cNumber = new System.Windows.Forms.TextBox();
            this.cash = new System.Windows.Forms.RadioButton();
            this.card = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Button();
            this.pay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.id.ForeColor = System.Drawing.Color.Black;
            this.id.Location = new System.Drawing.Point(150, 20);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(161, 20);
            this.id.TabIndex = 31;
            // 
            // asd
            // 
            this.asd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.asd.AutoSize = true;
            this.asd.BackColor = System.Drawing.Color.Transparent;
            this.asd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asd.Location = new System.Drawing.Point(29, 18);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(115, 20);
            this.asd.TabIndex = 30;
            this.asd.Text = "Customer ID:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Card Number:";
            // 
            // cNumber
            // 
            this.cNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cNumber.Enabled = false;
            this.cNumber.ForeColor = System.Drawing.Color.Black;
            this.cNumber.Location = new System.Drawing.Point(150, 154);
            this.cNumber.Name = "cNumber";
            this.cNumber.Size = new System.Drawing.Size(217, 20);
            this.cNumber.TabIndex = 28;
            // 
            // cash
            // 
            this.cash.AutoSize = true;
            this.cash.Checked = true;
            this.cash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cash.Location = new System.Drawing.Point(161, 112);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(49, 17);
            this.cash.TabIndex = 32;
            this.cash.TabStop = true;
            this.cash.Text = "Cash";
            this.cash.UseVisualStyleBackColor = true;
            this.cash.CheckedChanged += new System.EventHandler(this.card_CheckedChanged);
            // 
            // card
            // 
            this.card.AutoSize = true;
            this.card.Cursor = System.Windows.Forms.Cursors.Hand;
            this.card.Location = new System.Drawing.Point(216, 112);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(47, 17);
            this.card.TabIndex = 33;
            this.card.Text = "Card";
            this.card.UseVisualStyleBackColor = true;
            this.card.CheckedChanged += new System.EventHandler(this.card_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Payment Type:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Total:";
            // 
            // total
            // 
            this.total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.total.AutoSize = true;
            this.total.BackColor = System.Drawing.Color.Transparent;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(156, 66);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(18, 20);
            this.total.TabIndex = 77;
            this.total.Text = "0";
            // 
            // check
            // 
            this.check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check.Location = new System.Drawing.Point(317, 20);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(88, 20);
            this.check.TabIndex = 78;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // pay
            // 
            this.pay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pay.Enabled = false;
            this.pay.Location = new System.Drawing.Point(180, 196);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(88, 20);
            this.pay.TabIndex = 79;
            this.pay.Text = "Pay";
            this.pay.UseVisualStyleBackColor = true;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 228);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.card);
            this.Controls.Add(this.check);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id);
            this.Controls.Add(this.asd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cNumber);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label asd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cNumber;
        private System.Windows.Forms.RadioButton cash;
        private System.Windows.Forms.RadioButton card;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button pay;
    }
}