using System;
using System.Collections;
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
    public partial class EmployeesForm : Form
    {

        // db connection
        DBConnection db1 = new DBConnection();
        private int employeeID;
        private bool isUpdate;
        public EmployeesForm()
        {
            InitializeComponent();
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            isUpdate = false;

            //to display the table in the datagrid once the page loaded.
            dgvEmployees.DataSource = db1.DBGetEmployeeData();

        }

        private void dgvEmployees_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            //When you double click on the row its data appear in the text boxes
            btnDelete.Visible = true;
            employeeID = int.Parse(dgvEmployees.CurrentRow.Cells[0].Value.ToString());
            txtFirstName.Text = db1.DBGetEmployeeData(employeeID).Rows[0]["FirstName"].ToString();
            txtLastName.Text = db1.DBGetEmployeeData(employeeID).Rows[0]["LastName"].ToString();
            txtPosition.Text = db1.DBGetEmployeeData(employeeID).Rows[0]["Position"].ToString();
            txtPhoneNumber.Text = db1.DBGetEmployeeData(employeeID).Rows[0]["PhoneNumber"].ToString();
            txtEmail.Text = db1.DBGetEmployeeData(employeeID).Rows[0]["Email"].ToString();
            txtSalary.Text = db1.DBGetEmployeeData(employeeID).Rows[0]["salary"].ToString();
            isUpdate = true;
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
            //check if the text boxes contains data
            if (txtFirstName.Text != "")
            {
                if(txtLastName.Text != "")
                {
                    if (txtPosition.Text != "")
                    {
                        if (txtPhoneNumber.Text != "")
                        {
                            if (txtEmail.Text != "")
                            {
                                if (txtSalary.Text != "")
                                {
                                    if (isUpdate)
                                    {
                                        // Update in the database
                                        db1.UpdateEmployee(txtFirstName.Text, txtLastName.Text, txtPosition.Text, txtPhoneNumber.Text, txtEmail.Text, int.Parse(txtSalary.Text), employeeID);
                                        //update the data in the data grid 
                                        dgvEmployees.DataSource = db1.DBGetEmployeeData();
                                        MessageBox.Show("All Changes Succesfully Updated ..");
                                        isUpdate = false;

                                        //clear the text boxes after updating
                                        clearInputs();
                                    }
                                    else
                                    {
                                        // Insert
                                        db1.InsertEmployee(txtFirstName.Text, txtLastName.Text, txtPosition.Text, txtPhoneNumber.Text, txtEmail.Text, int.Parse(txtSalary.Text));
                                        dgvEmployees.DataSource = db1.DBGetEmployeeData();
                                        MessageBox.Show("All Changes Succesfully Inserted ..");
                                        isUpdate = false;
                                        clearInputs();

                                    }
                                    btnDelete.Visible = false;
                                }
                            }
                        }
                    }
                }
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //make sure that user what to delete
            DialogResult result = MessageBox.Show("Would you like to delete the selected employee ?", "Question", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                //call the delete func and send to it the id after convertinbg it to int
                db1.DeleteEmployee(int.Parse(dgvEmployees.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("Employee Deleted Successfully");
                dgvEmployees.DataSource = db1.DBGetEmployeeData();
                isUpdate = false;
                clearInputs();
            }
            else
            {
                dgvEmployees.DataSource = db1.DBGetEmployeeData();
                isUpdate = false;
                clearInputs();
            }
            btnDelete.Visible = false;
        }
    }
}
