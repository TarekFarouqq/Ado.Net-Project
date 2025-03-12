namespace YehiaStore
{
    partial class Invoices
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
            btnAddInvoice = new Button();
            dgvInvoices = new DataGridView();
            lblAllInvoices = new Label();
            dvgCurrentInvoice = new DataGridView();
            lblCurrentInvoiceData = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgCurrentInvoice).BeginInit();
            SuspendLayout();
            // 
            // btnAddInvoice
            // 
            btnAddInvoice.BackColor = Color.FromArgb(135, 206, 250);
            btnAddInvoice.FlatStyle = FlatStyle.Flat;
            btnAddInvoice.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnAddInvoice.Location = new Point(242, 383);
            btnAddInvoice.Name = "btnAddInvoice";
            btnAddInvoice.Size = new Size(156, 34);
            btnAddInvoice.TabIndex = 1;
            btnAddInvoice.Text = "Add New Invoice";
            btnAddInvoice.UseVisualStyleBackColor = false;
            btnAddInvoice.Click += btnAddInvoice_Click;
            // 
            // dgvInvoices
            // 
            dgvInvoices.AllowUserToAddRows = false;
            dgvInvoices.AllowUserToDeleteRows = false;
            dgvInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoices.Location = new Point(125, 22);
            dgvInvoices.Name = "dgvInvoices";
            dgvInvoices.ReadOnly = true;
            dgvInvoices.RowHeadersVisible = false;
            dgvInvoices.RowHeadersWidth = 51;
            dgvInvoices.Size = new Size(491, 191);
            dgvInvoices.TabIndex = 2;
            dgvInvoices.CellContentClick += dgvInvoices_CellContentClick_1;
            dgvInvoices.MouseDoubleClick += dgvInvoices_MouseDoubleClick;
            // 
            // lblAllInvoices
            // 
            lblAllInvoices.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblAllInvoices.ForeColor = Color.DarkBlue;
            lblAllInvoices.Location = new Point(12, 107);
            lblAllInvoices.Name = "lblAllInvoices";
            lblAllInvoices.Size = new Size(107, 35);
            lblAllInvoices.TabIndex = 11;
            lblAllInvoices.Text = "All Invoices";
            lblAllInvoices.Click += lblAllInvoices_Click;
            // 
            // dvgCurrentInvoice
            // 
            dvgCurrentInvoice.AllowUserToAddRows = false;
            dvgCurrentInvoice.AllowUserToDeleteRows = false;
            dvgCurrentInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgCurrentInvoice.Location = new Point(125, 255);
            dvgCurrentInvoice.Name = "dvgCurrentInvoice";
            dvgCurrentInvoice.ReadOnly = true;
            dvgCurrentInvoice.RowHeadersVisible = false;
            dvgCurrentInvoice.RowHeadersWidth = 51;
            dvgCurrentInvoice.Size = new Size(491, 99);
            dvgCurrentInvoice.TabIndex = 12;
            // 
            // lblCurrentInvoiceData
            // 
            lblCurrentInvoiceData.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblCurrentInvoiceData.ForeColor = Color.DarkBlue;
            lblCurrentInvoiceData.Location = new Point(12, 280);
            lblCurrentInvoiceData.Name = "lblCurrentInvoiceData";
            lblCurrentInvoiceData.Size = new Size(107, 59);
            lblCurrentInvoiceData.TabIndex = 13;
            lblCurrentInvoiceData.Text = "Selected Invoice Details";
            // 
            // Invoices
            // 
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(648, 450);
            Controls.Add(lblCurrentInvoiceData);
            Controls.Add(dvgCurrentInvoice);
            Controls.Add(lblAllInvoices);
            Controls.Add(dgvInvoices);
            Controls.Add(btnAddInvoice);
            Name = "Invoices";
            Text = "Invoices Management";
            Load += Invoices_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgCurrentInvoice).EndInit();
            ResumeLayout(false);
        }

        private Button btnAddInvoice;
        private DataGridView dgvInvoices;
        private Label lblAllInvoices;
        private DataGridView dvgCurrentInvoice;
        private Label lblCurrentInvoiceData;
    }
    #endregion
}
