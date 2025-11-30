namespace FoodCourt
{
    partial class MIngredients
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label qtyLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.welcome = new System.Windows.Forms.Label();
            this.menuDataGridView = new System.Windows.Forms.DataGridView();
            this.actionColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.unitComboBox = new System.Windows.Forms.ComboBox();
            this.qtyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.menuIngredientDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IngredientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuIngredientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nameLabel = new System.Windows.Forms.Label();
            qtyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuIngredientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuIngredientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(15, 29);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(119, 16);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Choose Ingredient:";
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Location = new System.Drawing.Point(15, 58);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new System.Drawing.Size(30, 16);
            qtyLabel.TabIndex = 3;
            qtyLabel.Text = "Qty:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(73, 48);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(285, 22);
            this.search.TabIndex = 10;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(12, 9);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(366, 32);
            this.welcome.TabIndex = 9;
            this.welcome.Text = "Manage Menu Ingredients";
            // 
            // menuDataGridView
            // 
            this.menuDataGridView.AllowUserToAddRows = false;
            this.menuDataGridView.AllowUserToDeleteRows = false;
            this.menuDataGridView.AutoGenerateColumns = false;
            this.menuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.menuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.actionColumn});
            this.menuDataGridView.DataSource = this.menuBindingSource;
            this.menuDataGridView.Location = new System.Drawing.Point(18, 85);
            this.menuDataGridView.Name = "menuDataGridView";
            this.menuDataGridView.ReadOnly = true;
            this.menuDataGridView.RowHeadersWidth = 51;
            this.menuDataGridView.RowTemplate.Height = 24;
            this.menuDataGridView.Size = new System.Drawing.Size(347, 357);
            this.menuDataGridView.TabIndex = 12;
            this.menuDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.menuDataGridView_CellClick);
            // 
            // actionColumn
            // 
            this.actionColumn.HeaderText = "Action";
            this.actionColumn.MinimumWidth = 6;
            this.actionColumn.Name = "actionColumn";
            this.actionColumn.ReadOnly = true;
            this.actionColumn.Text = "Edit Ingredients";
            this.actionColumn.UseColumnTextForLinkValue = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.unitComboBox);
            this.groupBox1.Controls.Add(qtyLabel);
            this.groupBox1.Controls.Add(this.qtyNumericUpDown);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.nameComboBox);
            this.groupBox1.Controls.Add(this.menuIngredientDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(371, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 357);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingredients";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(479, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(355, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(339, 56);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 24);
            this.button5.TabIndex = 7;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // unitComboBox
            // 
            this.unitComboBox.DisplayMember = "Name";
            this.unitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitComboBox.Enabled = false;
            this.unitComboBox.FormattingEnabled = true;
            this.unitComboBox.Location = new System.Drawing.Point(212, 54);
            this.unitComboBox.Name = "unitComboBox";
            this.unitComboBox.Size = new System.Drawing.Size(121, 24);
            this.unitComboBox.TabIndex = 6;
            this.unitComboBox.ValueMember = "ID";
            // 
            // qtyNumericUpDown
            // 
            this.qtyNumericUpDown.Enabled = false;
            this.qtyNumericUpDown.Location = new System.Drawing.Point(140, 56);
            this.qtyNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.qtyNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qtyNumericUpDown.Name = "qtyNumericUpDown";
            this.qtyNumericUpDown.Size = new System.Drawing.Size(66, 22);
            this.qtyNumericUpDown.TabIndex = 4;
            this.qtyNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nameComboBox
            // 
            this.nameComboBox.DisplayMember = "Name";
            this.nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameComboBox.Enabled = false;
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(140, 26);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(193, 24);
            this.nameComboBox.TabIndex = 2;
            this.nameComboBox.ValueMember = "ID";
            // 
            // menuIngredientDataGridView
            // 
            this.menuIngredientDataGridView.AllowUserToAddRows = false;
            this.menuIngredientDataGridView.AllowUserToDeleteRows = false;
            this.menuIngredientDataGridView.AutoGenerateColumns = false;
            this.menuIngredientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.menuIngredientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuIngredientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5,
            this.actionColumn2,
            this.IngredientID,
            this.UnitID,
            this.MenuID});
            this.menuIngredientDataGridView.DataSource = this.menuIngredientBindingSource;
            this.menuIngredientDataGridView.Location = new System.Drawing.Point(18, 84);
            this.menuIngredientDataGridView.Name = "menuIngredientDataGridView";
            this.menuIngredientDataGridView.ReadOnly = true;
            this.menuIngredientDataGridView.RowHeadersWidth = 51;
            this.menuIngredientDataGridView.RowTemplate.Height = 24;
            this.menuIngredientDataGridView.Size = new System.Drawing.Size(579, 220);
            this.menuIngredientDataGridView.TabIndex = 0;
            this.menuIngredientDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.menuIngredientDataGridView_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // actionColumn2
            // 
            this.actionColumn2.HeaderText = "Action";
            this.actionColumn2.MinimumWidth = 6;
            this.actionColumn2.Name = "actionColumn2";
            this.actionColumn2.ReadOnly = true;
            this.actionColumn2.Text = "Remove";
            this.actionColumn2.UseColumnTextForButtonValue = true;
            // 
            // IngredientID
            // 
            this.IngredientID.DataPropertyName = "IngredientID";
            this.IngredientID.HeaderText = "IngredientID";
            this.IngredientID.MinimumWidth = 6;
            this.IngredientID.Name = "IngredientID";
            this.IngredientID.ReadOnly = true;
            this.IngredientID.Visible = false;
            // 
            // UnitID
            // 
            this.UnitID.DataPropertyName = "UnitID";
            this.UnitID.HeaderText = "UnitID";
            this.UnitID.MinimumWidth = 6;
            this.UnitID.Name = "UnitID";
            this.UnitID.ReadOnly = true;
            this.UnitID.Visible = false;
            // 
            // MenuID
            // 
            this.MenuID.DataPropertyName = "MenuID";
            this.MenuID.HeaderText = "MenuID";
            this.MenuID.MinimumWidth = 6;
            this.MenuID.Name = "MenuID";
            this.MenuID.ReadOnly = true;
            this.MenuID.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IngredientName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ingredient Name";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Qty";
            this.dataGridViewTextBoxColumn6.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "UnitName";
            this.dataGridViewTextBoxColumn5.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // menuIngredientBindingSource
            // 
            this.menuIngredientBindingSource.DataSource = typeof(FoodCourt.MenuIngredient);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Menu";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataSource = typeof(FoodCourt.Menu);
            this.menuBindingSource.CurrentChanged += new System.EventHandler(this.menuBindingSource_CurrentChanged);
            // 
            // MIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 455);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.welcome);
            this.Name = "MIngredients";
            this.Text = "MIngredients";
            this.Load += new System.EventHandler(this.MIngredients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuIngredientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuIngredientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private System.Windows.Forms.DataGridView menuDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewLinkColumn actionColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView menuIngredientDataGridView;
        private System.Windows.Forms.BindingSource menuIngredientBindingSource;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.NumericUpDown qtyNumericUpDown;
        private System.Windows.Forms.ComboBox unitComboBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn actionColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngredientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuID;
    }
}