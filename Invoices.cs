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
    public partial class Invoices : Form
    {
        DBConnection db1 = new DBConnection();
        private int invoiceID;
        public Invoices()
        {
            InitializeComponent();
        }

        private void Invoices_Load(object sender, EventArgs e)
        {
            dgvInvoices.DataSource = db1.DBGetInvoiceData();

        }


        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            AddInvoice addInvoice = new AddInvoice();
            addInvoice.ShowDialog();

        }

        private void dgvInvoices_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            invoiceID = int.Parse(dgvInvoices.CurrentRow.Cells[0].Value.ToString());
            dvgCurrentInvoice.DataSource = db1.DBGetInvoiceData(invoiceID);

        }



        //
        private void btnDisplay_Click(object sender, EventArgs e)
        {

        }

        private void dgvInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvInvoices_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblAllInvoices_Click(object sender, EventArgs e)
        {

        }
    }
}
