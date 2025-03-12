using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace YehiaStore
{
    public partial class AddInvoice : Form
    {
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = CosmeticsStore2; Integrated Security = True; Trust Server Certificate=True");
        DBConnection db1 = new DBConnection();
        int newInvoiceId;
        private bool isInvoiceSubmitted = true;
        public AddInvoice()
        {
            InitializeComponent();
        }

        private void AddInvoice_Load(object sender, EventArgs e)
        {

            LoadEmployees();
            LoadProducts();
            
            //setting the shap of the datagridview
            dgvAddedProducts.Columns.Add("Num", "Num");
            dgvAddedProducts.Columns.Add("ProductID", "ProductID");
            dgvAddedProducts.Columns.Add("quantity", "quantity");
        }

        private void btnSubmitInvoice_Click(object sender, EventArgs e)
        {
            if (isInvoiceSubmitted)
            {
                if (dgvAddedProducts.RowCount != 0)
                {
                    // creating invoice with id, empid and date only .
                    int selectedEmpId = Convert.ToInt32(cbxEmployee.SelectedValue);

                    //catching the id of the new invoice created to use it with creating the soldProduct
                    newInvoiceId = db1.CreateInvoice(selectedEmpId);

                    foreach (DataGridViewRow row in dgvAddedProducts.Rows)
                    {
                        // Skip the last empty row if AllowUserToAddRows is enabled
                        if (row.IsNewRow) continue;


                        int ProductID = Convert.ToInt32(row.Cells["ProductID"].Value);
                        int quantity = Convert.ToInt32(row.Cells["quantity"].Value);
                        int saleId = newInvoiceId;

                        db1.createProductSale(ProductID, quantity, saleId);
                    }

                    decimal totalPrice = db1.CalculateTotalPrice(newInvoiceId);
                    db1.UpdatePrice(newInvoiceId, totalPrice);
                    isInvoiceSubmitted = false;
                    MessageBox.Show("Invoice Submitted successfully.");
                    this.Close();
                }
                else { MessageBox.Show("You Must Add Products."); }
                
            }
            else {
                    MessageBox.Show("Invoice already submitted.");
                    return; // Prevent duplicate execution
                  }
            }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            //adding data to dvg
            int Num = dgvAddedProducts.RowCount + 1;
            int ProductID = Convert.ToInt32(cbxProductName.SelectedValue);
            int quantity = Convert.ToInt32(numericUpDownQuantity.Value);
            dgvAddedProducts.Rows.Add(Num, ProductID, quantity);
        }

        //--------------------------------------------------------------------------------------------------------------

        // Add emps names to the  invoice combobox 
        private void LoadEmployees()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT EmployeeID, FirstName + ' ' + LastName AS FullName FROM Employees", con))
            {
                if (con.State == ConnectionState.Closed) { con.Open(); }

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                // Bind the data to the ComboBox
                cbxEmployee.DataSource = dt;
                cbxEmployee.DisplayMember = "FullName";  // What the user will see in the dropdown
                cbxEmployee.ValueMember = "EmployeeID";  // The actual value (EmployeeID)

                con.Close();
            }
        }

        // Add Products names to the  invoice combobox 
        private void LoadProducts()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT ProductID, ProductName FROM Products", con))
            {
                if (con.State == ConnectionState.Closed) { con.Open(); }

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                // Bind the data to the ComboBox
                cbxProductName.DataSource = dt;
                cbxProductName.DisplayMember = "ProductName";  // What the user will see in the dropdown
                cbxProductName.ValueMember = "ProductID";  // The actual value (ProductID)

                con.Close();
            }
        }


        
    }
}
