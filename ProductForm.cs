using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YehiaStore
{
    public partial class ProductForm : Form
    {
        DBConnection db1 = new DBConnection();
        private bool isUpdate;
        private int productID;
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            isUpdate = false;


            //to display the table in the datagrid once the page loaded.
            dgvProducts.DataSource = db1.DBGetProductsData();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // When you double click on the row, its data appears in the text boxes
            btnDelete.Visible = true;
            productID = int.Parse(dgvProducts.CurrentRow.Cells[0].Value.ToString());

            // Fetch product data from the database
            var productData = db1.DBGetProductData(productID);

            if (productData.Rows.Count > 0)
            {
                txtProductName.Text = productData.Rows[0]["ProductName"].ToString();
                txtCategory.Text = productData.Rows[0]["Category"].ToString();
                txtPrice.Text = productData.Rows[0]["Price"].ToString();
                txtStock.Text = productData.Rows[0]["Stock"].ToString();
                isUpdate = true;
            }
        }

        private void clearInputs()
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] != null)
                {
                    if (Controls[i].GetType() == typeof(TextBox))
                    {
                        TextBox txt = (TextBox)Controls[i];
                        txt.Text = "";
                    }
                }
            }
        }


        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            // Check if the text boxes contain data
            if (txtProductName.Text != "")
            {
                if (txtCategory.Text != "")
                {
                    if (txtPrice.Text != "")
                    {
                        if (txtStock.Text != "")
                        {
                            if (isUpdate)
                            {
                                // Update in the database
                                db1.UpdateProduct(txtProductName.Text, txtCategory.Text, decimal.Parse(txtPrice.Text), int.Parse(txtStock.Text), productID);
                                // Update the data in the data grid
                                dgvProducts.DataSource = db1.DBGetProductsData();
                                MessageBox.Show("All Changes Successfully Updated ..");
                                isUpdate = false;

                                // Clear the text boxes after updating
                                clearInputs();
                            }
                            else
                            {
                                // Insert
                                db1.InsertProduct(txtProductName.Text, txtCategory.Text, decimal.Parse(txtPrice.Text), int.Parse(txtStock.Text));
                                dgvProducts.DataSource = db1.DBGetProductsData();
                                MessageBox.Show("All Changes Successfully Inserted ..");
                                isUpdate = false;
                                clearInputs();
                            }
                            btnDelete.Visible = false;
                        }
                    }
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Make sure that the user wants to delete
            DialogResult result = MessageBox.Show("Would you like to delete the selected product?", "Question", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                // Call the delete function and send the ID after converting it to int
                db1.DeleteProduct(int.Parse(dgvProducts.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("Product Deleted Successfully");
                dgvProducts.DataSource = db1.DBGetProductsData();
                isUpdate = false;
                clearInputs();
            }
            else
            {
                dgvProducts.DataSource = db1.DBGetProductsData();
                isUpdate = false;
                clearInputs();
            }
            btnDelete.Visible = false;
        }

        
    }
}
