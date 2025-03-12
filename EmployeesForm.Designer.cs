namespace YehiaStore
{
    partial class EmployeesForm
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
            dgvEmployees = new DataGridView();
            btnSaveChanges = new Button();
            btnDelete = new Button();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtSalary = new TextBox();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblPosition = new Label();
            lblSalary = new Label();
            lblPhoneNumber = new Label();
            lblEmail = new Label();
            txtPosition = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.AllowUserToResizeColumns = false;
            dgvEmployees.AllowUserToResizeRows = false;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.BackgroundColor = Color.White;
            dgvEmployees.ColumnHeadersHeight = 29;
            dgvEmployees.GridColor = Color.LightGray;
            dgvEmployees.Location = new Point(20, 250);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.Size = new Size(600, 200);
            dgvEmployees.TabIndex = 0;
            dgvEmployees.MouseDoubleClick += dgvEmployees_MouseDoubleClick;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.FromArgb(135, 206, 250);
            btnSaveChanges.FlatStyle = FlatStyle.Flat;
            btnSaveChanges.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnSaveChanges.Location = new Point(400, 20);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(100, 30);
            btnSaveChanges.TabIndex = 1;
            btnSaveChanges.Text = "Save ";
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
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Arial", 10F);
            txtFirstName.Location = new Point(150, 20);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 27);
            txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Arial", 10F);
            txtLastName.Location = new Point(150, 60);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 27);
            txtLastName.TabIndex = 5;
            // 
            // txtSalary
            // 
            txtSalary.Font = new Font("Arial", 10F);
            txtSalary.Location = new Point(150, 140);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(200, 27);
            txtSalary.TabIndex = 7;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Arial", 10F);
            txtPhoneNumber.Location = new Point(150, 180);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(200, 27);
            txtPhoneNumber.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 10F);
            txtEmail.Location = new Point(150, 220);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 9;
            // 
            // lblFirstName
            // 
            lblFirstName.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblFirstName.ForeColor = Color.DarkBlue;
            lblFirstName.Location = new Point(20, 20);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(100, 23);
            lblFirstName.TabIndex = 10;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblLastName.ForeColor = Color.DarkBlue;
            lblLastName.Location = new Point(20, 60);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(100, 23);
            lblLastName.TabIndex = 11;
            lblLastName.Text = "Last Name:";
            // 
            // lblPosition
            // 
            lblPosition.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblPosition.ForeColor = Color.DarkBlue;
            lblPosition.Location = new Point(20, 100);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(100, 23);
            lblPosition.TabIndex = 12;
            lblPosition.Text = "Position:";
            // 
            // lblSalary
            // 
            lblSalary.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblSalary.ForeColor = Color.DarkBlue;
            lblSalary.Location = new Point(20, 140);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(100, 23);
            lblSalary.TabIndex = 13;
            lblSalary.Text = "Salary:";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblPhoneNumber.ForeColor = Color.DarkBlue;
            lblPhoneNumber.Location = new Point(20, 180);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(100, 23);
            lblPhoneNumber.TabIndex = 14;
            lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblEmail.ForeColor = Color.DarkBlue;
            lblEmail.Location = new Point(20, 220);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "Email:";
            // 
            // txtPosition
            // 
            txtPosition.Font = new Font("Arial", 10F);
            txtPosition.Location = new Point(150, 100);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(200, 27);
            txtPosition.TabIndex = 16;
            // 
            // EmployeesForm
            // 
            BackColor = Color.FromArgb(240, 248, 255);
            ClientSize = new Size(650, 558);
            Controls.Add(txtPosition);
            Controls.Add(dgvEmployees);
            Controls.Add(btnSaveChanges);
            Controls.Add(btnDelete);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtSalary);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Controls.Add(lblPosition);
            Controls.Add(lblSalary);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblEmail);
            Name = "EmployeesForm";
            Text = "Employee Management";
            Load += EmployeesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dgvEmployees;
        private Button btnSaveChanges;
        private Button btnDelete;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtSalary;
        private TextBox txtPhoneNumber;
        private TextBox txtEmail;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblPosition;
        private Label lblSalary;
        private Label lblPhoneNumber;
        private Label lblEmail;
        #endregion

        private TextBox txtPosition;
    }
}