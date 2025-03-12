namespace YehiaStore
{
    partial class MainMenu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            titleLabel = new Label();
            btnEmployees = new Button();
            btnProducts = new Button();
            btnInvoices = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            titleLabel.ForeColor = Color.DarkSlateBlue;
            titleLabel.Location = new Point(0, 80); // Center it horizontally
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(1000, 80); // Set the same width as the form
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Cosmetics Store";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = Color.FromArgb(102, 153, 255);
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnEmployees.ForeColor = Color.White;
            btnEmployees.Location = new Point(400, 250);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(250, 90);
            btnEmployees.TabIndex = 1;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = false;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.FromArgb(102, 153, 255);
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(400, 370);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(250, 90);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnInvoices
            // 
            btnInvoices.BackColor = Color.FromArgb(102, 153, 255);
            btnInvoices.FlatStyle = FlatStyle.Flat;
            btnInvoices.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnInvoices.ForeColor = Color.White;
            btnInvoices.Location = new Point(400, 490);
            btnInvoices.Name = "btnInvoices";
            btnInvoices.Size = new Size(250, 90);
            btnInvoices.TabIndex = 3;
            btnInvoices.Text = "Invoices";
            btnInvoices.UseVisualStyleBackColor = false;
            btnInvoices.Click += btnSales_Click;
            // 
            // MainMenu
            // 
            BackColor = Color.FromArgb(240, 248, 255);
            ClientSize = new Size(1000, 800); // Even larger form size
            Controls.Add(titleLabel);
            Controls.Add(btnEmployees);
            Controls.Add(btnProducts);
            Controls.Add(btnInvoices);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            ResumeLayout(false);
        }

        private Label titleLabel;
        private Button btnEmployees;
        private Button btnProducts;
        private Button btnInvoices;
    }
}
