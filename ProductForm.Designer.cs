namespace YehiaStore
{
    partial class ProductForm
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
            dgvProducts = new DataGridView();
            btnSaveChanges = new Button();
            btnDelete = new Button();
            txtProductName = new TextBox();
            txtCategory = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            lblProductName = new Label();
            lblCategory = new Label();
            lblPrice = new Label();
            lblStock = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersHeight = 29;
            dgvProducts.GridColor = Color.LightGray;
            dgvProducts.Location = new Point(20, 250);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(600, 200);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.FromArgb(144, 238, 144);
            btnSaveChanges.FlatStyle = FlatStyle.Flat;
            btnSaveChanges.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnSaveChanges.Location = new Point(400, 20);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(100, 30);
            btnSaveChanges.TabIndex = 1;
            btnSaveChanges.Text = "Save";
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(240, 128, 128);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnDelete.Location = new Point(400, 60);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Arial", 10F);
            txtProductName.Location = new Point(150, 20);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(200, 27);
            txtProductName.TabIndex = 4;
            // 
            // txtCategory
            // 
            txtCategory.Font = new Font("Arial", 10F);
            txtCategory.Location = new Point(150, 60);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(200, 27);
            txtCategory.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Arial", 10F);
            txtPrice.Location = new Point(150, 100);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 27);
            txtPrice.TabIndex = 6;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Arial", 10F);
            txtStock.Location = new Point(150, 140);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(200, 27);
            txtStock.TabIndex = 7;
            // 
            // lblProductName
            // 
            lblProductName.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblProductName.ForeColor = Color.DarkGreen;
            lblProductName.Location = new Point(20, 20);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(100, 23);
            lblProductName.TabIndex = 8;
            lblProductName.Text = "Product Name:";
            // 
            // lblCategory
            // 
            lblCategory.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblCategory.ForeColor = Color.DarkGreen;
            lblCategory.Location = new Point(20, 60);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(100, 23);
            lblCategory.TabIndex = 9;
            lblCategory.Text = "Category:";
            // 
            // lblPrice
            // 
            lblPrice.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblPrice.ForeColor = Color.DarkGreen;
            lblPrice.Location = new Point(20, 100);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(100, 23);
            lblPrice.TabIndex = 10;
            lblPrice.Text = "Price:";
            // 
            // lblStock
            // 
            lblStock.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblStock.ForeColor = Color.DarkGreen;
            lblStock.Location = new Point(20, 140);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(100, 23);
            lblStock.TabIndex = 11;
            lblStock.Text = "Stock:";
            // 
            // ProductForm
            // 
            BackColor = Color.FromArgb(250, 250, 240);
            ClientSize = new Size(650, 500);
            Controls.Add(dgvProducts);
            Controls.Add(btnSaveChanges);
            Controls.Add(btnDelete);
            Controls.Add(txtProductName);
            Controls.Add(txtCategory);
            Controls.Add(txtPrice);
            Controls.Add(txtStock);
            Controls.Add(lblProductName);
            Controls.Add(lblCategory);
            Controls.Add(lblPrice);
            Controls.Add(lblStock);
            Name = "ProductForm";
            Text = "Product Management";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dgvProducts;
        private Button btnSaveChanges;
        private Button btnDelete;
        private TextBox txtProductName;
        private TextBox txtCategory;
        private TextBox txtPrice;
        private TextBox txtStock;
        private Label lblProductName;
        private Label lblCategory;
        private Label lblPrice;
        private Label lblStock;

        #endregion
    }
}