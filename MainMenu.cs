﻿using System;
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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

        }


        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            EmployeesForm employeesForm = new EmployeesForm();
            employeesForm.ShowDialog();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            Invoices soldProductsForm = new Invoices();
            soldProductsForm.ShowDialog();
        }
    }
}
