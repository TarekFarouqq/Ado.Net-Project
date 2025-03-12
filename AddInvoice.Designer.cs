namespace YehiaStore
{
    partial class AddInvoice
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
            lblProductName = new Label();
            lblEmployeeID = new Label();
            lblQuantitySold = new Label();
            cbxProductName = new ComboBox();
            numericUpDownQuantity = new NumericUpDown();
            cbxEmployee = new ComboBox();
            btnAddProdcut = new Button();
            dgvAddedProducts = new DataGridView();
            btnSubmitInvoice = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAddedProducts).BeginInit();
            SuspendLayout();
            // 
            // lblProductName
            // 
            lblProductName.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblProductName.ForeColor = Color.DarkSlateBlue;
            lblProductName.Location = new Point(51, 115);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(148, 23);
            lblProductName.TabIndex = 18;
            lblProductName.Text = "Product Name:";
            // 
            // lblEmployeeID
            // 
            lblEmployeeID.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblEmployeeID.ForeColor = Color.DarkSlateBlue;
            lblEmployeeID.Location = new Point(51, 51);
            lblEmployeeID.Name = "lblEmployeeID";
            lblEmployeeID.Size = new Size(100, 23);
            lblEmployeeID.TabIndex = 19;
            lblEmployeeID.Text = "Employee ID:";
            // 
            // lblQuantitySold
            // 
            lblQuantitySold.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblQuantitySold.ForeColor = Color.DarkSlateBlue;
            lblQuantitySold.Location = new Point(472, 121);
            lblQuantitySold.Name = "lblQuantitySold";
            lblQuantitySold.Size = new Size(100, 23);
            lblQuantitySold.TabIndex = 21;
            lblQuantitySold.Text = "Quantity Sold:";
            // 
            // cbxProductName
            // 
            cbxProductName.FormattingEnabled = true;
            cbxProductName.Location = new Point(205, 115);
            cbxProductName.Name = "cbxProductName";
            cbxProductName.Size = new Size(257, 28);
            cbxProductName.TabIndex = 22;
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(553, 118);
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(50, 27);
            numericUpDownQuantity.TabIndex = 24;
            // 
            // cbxEmployee
            // 
            cbxEmployee.FormattingEnabled = true;
            cbxEmployee.Location = new Point(205, 47);
            cbxEmployee.Name = "cbxEmployee";
            cbxEmployee.Size = new Size(257, 28);
            cbxEmployee.TabIndex = 25;
            // 
            // btnAddProdcut
            // 
            btnAddProdcut.BackColor = Color.FromArgb(135, 206, 250);
            btnAddProdcut.FlatStyle = FlatStyle.Flat;
            btnAddProdcut.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnAddProdcut.Location = new Point(634, 115);
            btnAddProdcut.Name = "btnAddProdcut";
            btnAddProdcut.Size = new Size(133, 30);
            btnAddProdcut.TabIndex = 26;
            btnAddProdcut.Text = "Add Product";
            btnAddProdcut.UseVisualStyleBackColor = false;
            btnAddProdcut.Click += btnAdd_Click;
            // 
            // dgvAddedProducts
            // 
            dgvAddedProducts.AllowUserToAddRows = false;
            dgvAddedProducts.AllowUserToDeleteRows = false;
            dgvAddedProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAddedProducts.Location = new Point(51, 204);
            dgvAddedProducts.Name = "dgvAddedProducts";
            dgvAddedProducts.ReadOnly = true;
            dgvAddedProducts.RowHeadersWidth = 51;
            dgvAddedProducts.Size = new Size(702, 156);
            dgvAddedProducts.TabIndex = 27;
            // 
            // btnSubmitInvoice
            // 
            btnSubmitInvoice.BackColor = Color.FromArgb(135, 206, 250);
            btnSubmitInvoice.FlatStyle = FlatStyle.Flat;
            btnSubmitInvoice.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnSubmitInvoice.Location = new Point(329, 383);
            btnSubmitInvoice.Name = "btnSubmitInvoice";
            btnSubmitInvoice.Size = new Size(133, 55);
            btnSubmitInvoice.TabIndex = 28;
            btnSubmitInvoice.Text = "Submit";
            btnSubmitInvoice.UseVisualStyleBackColor = false;
            btnSubmitInvoice.Click += btnSubmitInvoice_Click;
            // 
            // AddInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmitInvoice);
            Controls.Add(dgvAddedProducts);
            Controls.Add(btnAddProdcut);
            Controls.Add(cbxEmployee);
            Controls.Add(numericUpDownQuantity);
            Controls.Add(cbxProductName);
            Controls.Add(lblProductName);
            Controls.Add(lblEmployeeID);
            Controls.Add(lblQuantitySold);
            Name = "AddInvoice";
            Text = "AddInvoice";
            Load += AddInvoice_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAddedProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblProductName;
        private Label lblEmployeeID;
        private Label lblQuantitySold;
        private ComboBox cbxProductName;
        private NumericUpDown numericUpDownQuantity;
        private ComboBox cbxEmployee;
        private Button btnAddProdcut;
        private DataGridView dgvAddedProducts;
        private Button btnSubmitInvoice;
    }
}