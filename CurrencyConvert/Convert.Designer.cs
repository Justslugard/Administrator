namespace CurrencyConvert
{
    partial class Convert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Convert));
            this.label1 = new System.Windows.Forms.Label();
            this.periodCb = new System.Windows.Forms.ComboBox();
            this.periodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currencyConverterDataSet = new CurrencyConvert.CurrencyConverterDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.periodTableAdapter = new CurrencyConvert.CurrencyConverterDataSetTableAdapters.PeriodTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.oriCb = new System.Windows.Forms.ComboBox();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oriTb = new System.Windows.Forms.TextBox();
            this.originAmount = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.convertCb = new System.Windows.Forms.ComboBox();
            this.currencyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.convertAmount = new System.Windows.Forms.Label();
            this.convertTb = new System.Windows.Forms.TextBox();
            this.currencyTableAdapter = new CurrencyConvert.CurrencyConverterDataSetTableAdapters.CurrencyTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.periodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyConverterDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Currency Converter";
            // 
            // periodCb
            // 
            this.periodCb.DataSource = this.periodBindingSource;
            this.periodCb.DisplayMember = "name";
            this.periodCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodCb.FormattingEnabled = true;
            this.periodCb.Location = new System.Drawing.Point(180, 89);
            this.periodCb.Name = "periodCb";
            this.periodCb.Size = new System.Drawing.Size(470, 21);
            this.periodCb.TabIndex = 1;
            this.periodCb.ValueMember = "id";
            this.periodCb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // periodBindingSource
            // 
            this.periodBindingSource.DataMember = "Period";
            this.periodBindingSource.DataSource = this.currencyConverterDataSet;
            this.periodBindingSource.CurrentChanged += new System.EventHandler(this.periodBindingSource_CurrentChanged);
            // 
            // currencyConverterDataSet
            // 
            this.currencyConverterDataSet.DataSetName = "CurrencyConverterDataSet";
            this.currencyConverterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Period";
            // 
            // periodTableAdapter
            // 
            this.periodTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.oriCb);
            this.groupBox1.Controls.Add(this.oriTb);
            this.groupBox1.Controls.Add(this.originAmount);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 93);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Origin Amount:";
            // 
            // oriCb
            // 
            this.oriCb.DataSource = this.currencyBindingSource;
            this.oriCb.DisplayMember = "abbreviation";
            this.oriCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.oriCb.FormattingEnabled = true;
            this.oriCb.Location = new System.Drawing.Point(171, 49);
            this.oriCb.Name = "oriCb";
            this.oriCb.Size = new System.Drawing.Size(68, 24);
            this.oriCb.TabIndex = 5;
            this.oriCb.ValueMember = "id";
            this.oriCb.DropDownClosed += new System.EventHandler(this.oriCb_DropDownClosed);
            this.oriCb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.oriCb.Enter += new System.EventHandler(this.convertCb_Enter);
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataMember = "Currency";
            this.currencyBindingSource.DataSource = this.currencyConverterDataSet;
            this.currencyBindingSource.CurrentChanged += new System.EventHandler(this.periodBindingSource_CurrentChanged);
            // 
            // oriTb
            // 
            this.oriTb.Location = new System.Drawing.Point(6, 49);
            this.oriTb.Name = "oriTb";
            this.oriTb.Size = new System.Drawing.Size(159, 22);
            this.oriTb.TabIndex = 6;
            this.oriTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // originAmount
            // 
            this.originAmount.AutoSize = true;
            this.originAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.currencyBindingSource, "name", true));
            this.originAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originAmount.Location = new System.Drawing.Point(6, 30);
            this.originAmount.Name = "originAmount";
            this.originAmount.Size = new System.Drawing.Size(30, 16);
            this.originAmount.TabIndex = 5;
            this.originAmount.Text = "ORI";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.convertCb);
            this.groupBox2.Controls.Add(this.convertAmount);
            this.groupBox2.Controls.Add(this.convertTb);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(503, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 93);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Converted to:";
            // 
            // convertCb
            // 
            this.convertCb.DataSource = this.currencyBindingSource1;
            this.convertCb.DisplayMember = "abbreviation";
            this.convertCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.convertCb.FormattingEnabled = true;
            this.convertCb.Location = new System.Drawing.Point(171, 47);
            this.convertCb.Name = "convertCb";
            this.convertCb.Size = new System.Drawing.Size(68, 24);
            this.convertCb.TabIndex = 7;
            this.convertCb.ValueMember = "id";
            this.convertCb.DropDownClosed += new System.EventHandler(this.oriCb_DropDownClosed);
            this.convertCb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.convertCb.Enter += new System.EventHandler(this.convertCb_Enter);
            // 
            // currencyBindingSource1
            // 
            this.currencyBindingSource1.DataMember = "Currency";
            this.currencyBindingSource1.DataSource = this.currencyConverterDataSet;
            this.currencyBindingSource1.CurrentChanged += new System.EventHandler(this.periodBindingSource_CurrentChanged);
            // 
            // convertAmount
            // 
            this.convertAmount.AutoSize = true;
            this.convertAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.currencyBindingSource1, "name", true));
            this.convertAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertAmount.Location = new System.Drawing.Point(6, 30);
            this.convertAmount.Name = "convertAmount";
            this.convertAmount.Size = new System.Drawing.Size(73, 16);
            this.convertAmount.TabIndex = 6;
            this.convertAmount.Text = "CONVERT";
            // 
            // convertTb
            // 
            this.convertTb.Enabled = false;
            this.convertTb.Location = new System.Drawing.Point(6, 49);
            this.convertTb.Name = "convertTb";
            this.convertTb.Size = new System.Drawing.Size(159, 22);
            this.convertTb.TabIndex = 8;
            // 
            // currencyTableAdapter
            // 
            this.currencyTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(343, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Convert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 296);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.periodCb);
            this.Controls.Add(this.label1);
            this.Name = "Convert";
            this.Text = "Currency Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.periodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyConverterDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox periodCb;
        private System.Windows.Forms.Label label2;
        private CurrencyConverterDataSet currencyConverterDataSet;
        private System.Windows.Forms.BindingSource periodBindingSource;
        private CurrencyConverterDataSetTableAdapters.PeriodTableAdapter periodTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label originAmount;
        private System.Windows.Forms.Label convertAmount;
        private System.Windows.Forms.TextBox oriTb;
        private System.Windows.Forms.ComboBox oriCb;
        private System.Windows.Forms.ComboBox convertCb;
        private System.Windows.Forms.TextBox convertTb;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private CurrencyConverterDataSetTableAdapters.CurrencyTableAdapter currencyTableAdapter;
        private System.Windows.Forms.BindingSource currencyBindingSource1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

