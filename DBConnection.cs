using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace YehiaStore
{
    internal class DBConnection
    {
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = CosmeticsStore2; Integrated Security = True; Trust Server Certificate=True");


        //------------------------------------------------------------------------------------------------------- done

        //data retrived in form of columns and rows from emp table  .
        public DataTable DBGetEmployeeData()
        {
            DataTable temp = new DataTable();
            using (SqlCommand cmd = new SqlCommand("select * from employees", con))
            {
                if (con.State == ConnectionState.Closed) { con.Open(); }

                temp.Load(cmd.ExecuteReader());
                con.Close();
            }

            return temp;
        }

        //UpdateEmployee
        public void UpdateEmployee(string fName, string lName, string position, string pNumber, string eMail, int salary, int id)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE Employees SET FirstName=@fName,LastName=@lName,Position=@position,PhoneNumber=@pNumber,Email=eMail,salary=@salary WHERE EmployeeID=@id", con))
            {
                if (con.State == ConnectionState.Closed) { con.Open(); }
                cmd.Parameters.AddWithValue("fName", fName);
                cmd.Parameters.AddWithValue("lName", lName);
                cmd.Parameters.AddWithValue("position", position);
                cmd.Parameters.AddWithValue("pNumber", pNumber);
                cmd.Parameters.AddWithValue("eMail", eMail);
                cmd.Parameters.AddWithValue("salary", salary);
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //insert employee
        public void InsertEmployee(string fName, string lName, string position, string pNumber, string eMail, int salary)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Employees (FirstName, LastName, Position, PhoneNumber, Email, salary) VALUES (@fName, @lName, @position, @pNumber, @eMail, @salary);", con))
            {
                if (con.State == ConnectionState.Closed) { con.Open(); }
                cmd.Parameters.AddWithValue("fName", fName);
                cmd.Parameters.AddWithValue("lName", lName);
                cmd.Parameters.AddWithValue("position", position);
                cmd.Parameters.AddWithValue("pNumber", pNumber);
                cmd.Parameters.AddWithValue("eMail", eMail);
                cmd.Parameters.AddWithValue("salary", salary);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //delete employee
        public void DeleteEmployee(int id)
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Employees WHERE EmployeeID=@id;", con))
            {
                if (con.State == ConnectionState.Closed) { con.Open(); }
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        //data retrived from emp table but only one row by the id 
        public DataTable DBGetEmployeeData(int id)
        {

            DataTable temp = new DataTable();
            using (SqlCommand cmd = new SqlCommand("select * from employees where employeeid = @id", con))
            {
                if (con.State == ConnectionState.Closed) { con.Open(); }
                cmd.Parameters.AddWithValue("id", id);
                temp.Load(cmd.ExecuteReader());
                con.Close();
            }

            return temp;
        }

        //-------------------------------------------------------------------------------------------------------- done

        //data retrived in form of columns and rows from products table.
        public DataTable DBGetProductsData()
        {

            DataTable temp = new DataTable();
            using (SqlCommand cmd = new SqlCommand("select * from products", con))
            {
                if (con.State == ConnectionState.Closed) { con.Open(); }

                temp.Load(cmd.ExecuteReader());
                con.Close();
            }

            return temp;
        }

        // Update Product
        public void UpdateProduct(string productName, string category, decimal price, int stock, int productId)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE Products SET ProductName=@productName, Category=@category, Price=@price, Stock=@stock WHERE ProductID=@productId", con))
            {
                if (con.State == ConnectionState.Closed) { con.Open(); }
                cmd.Parameters.AddWithValue("productName", productName);
                cmd.Parameters.AddWithValue("category", category);
                cmd.Parameters.AddWithValue("price", price);
                cmd.Parameters.AddWithValue("stock", stock);
                cmd.Parameters.AddWithValue("productId", productId);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        // Insert Product
        public void InsertProduct(string productName, string category, decimal price, int stock)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Products (ProductName, Category, Price, Stock) VALUES (@productName, @category, @price, @stock);", con))
            {
                if (con.State == ConnectionState.Closed) { con.Open(); }
                cmd.Parameters.AddWithValue("productName", productName);
                cmd.Parameters.AddWithValue("category", category);
                cmd.Parameters.AddWithValue("price", price);
                cmd.Parameters.AddWithValue("stock", stock);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        // Delete Product
        public void DeleteProduct(int productId)
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Products WHERE ProductID=@productId;", con))
            {
                if (con.State == ConnectionState.Closed) { con.Open(); }
                cmd.Parameters.AddWithValue("productId", productId);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        // Retrieve Product by ID
        public DataTable DBGetProductData(int productId)
        {
            DataTable temp = new DataTable();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Products WHERE ProductID = @productId", con))
            {
                if (con.State == ConnectionState.Closed) { con.Open(); }
                cmd.Parameters.AddWithValue("productId", productId);
                temp.Load(cmd.ExecuteReader());
                con.Close();
            }

            return temp;
        }



        //-------------------------------------------------------------------------------------------------------- done


        //data retrived in form of columns and rows from invoice table.
        public DataTable DBGetInvoiceData()
        {
            DataTable temp = new DataTable();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Invoice", con))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                temp.Load(cmd.ExecuteReader());
                con.Close();
            }

            return temp;
        }

        // Retrieve invoice data by ID
        public DataTable DBGetInvoiceData(int saleId)
        {
            DataTable temp = new DataTable();
            using (SqlCommand cmd = new SqlCommand("select s.saleid ,s.product_id,p.productName, p.category,p.price, s.sale_Quantity from SoldProductsDetails s join products p on p.productid = s.product_id   where saleid =@saleid;", con))
            {
                if (con.State == ConnectionState.Closed) { con.Open(); }
                cmd.Parameters.AddWithValue("saleid", saleId);
                temp.Load(cmd.ExecuteReader());
                con.Close();
            }

            return temp;
        }

        //Catching the new invoice id in oredr to add it to the soldProduct item 
        public int GetNewInvoiceId()
        {
            int lastId = 0; // Initialize a variable to store the result
            string query = "SELECT MAX(SaleID) AS LastID FROM Invoice;"; // Query to get the last ID

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                if (con.State == ConnectionState.Closed) { con.Open(); }

                object result = cmd.ExecuteScalar(); // Execute the query and get the result
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    lastId = id; // Parse and store the last ID
                }

                con.Close();
            }

            return lastId; // Return the last ID
        }


        // Insert new invoice
        public int CreateInvoice(int empid)
        {
            DateTime currentDate = DateTime.Today;
            string query = "INSERT INTO Invoice (EmployeeID, saledate) VALUES (@empid, @saledate);" + "SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.AddWithValue("@empid", empid);
                cmd.Parameters.AddWithValue("@saledate", currentDate);
                int newInvoiceID = (int)cmd.ExecuteScalar();
                con.Close();

                return newInvoiceID;
            }

            
        }



        //calc the total price of the ivnoice.
        public decimal CalculateTotalPrice(int invoiceID)
        {
            decimal totalPrice = 0;

            con.Open();

            string query = @"SELECT SUM(p.Price * s.sale_Quantity) AS TotalPrice FROM SoldProductsDetails s
                                INNER JOIN Products p ON s.product_ID = p.ProductID WHERE s.SaleID = @InvoiceID";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@InvoiceID", invoiceID);

                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    totalPrice = Convert.ToDecimal(result);
                }
            }


            return totalPrice;
        }


        //sending th total price calculated 
        public void UpdatePrice(int invoiceID, decimal totalPrice)
        {
            string query = "UPDATE Invoice SET TotalPrice = @totalPrice WHERE SaleID = @invoiceID";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.AddWithValue("@totalPrice", totalPrice);
                cmd.Parameters.AddWithValue("@invoiceID", invoiceID);
                int rowsAffected = cmd.ExecuteNonQuery();

                con.Close();
            }
        }


        //---------------------------------------------------------------------------------------------------------------


        // insert new soldProduct to add it in the new invoice 
        public void createProductSale(int productID, int saleQuantity, int saleID)
        {
            string query = "INSERT INTO SoldProductsDetails (product_id,sale_Quantity, saleid) VALUES (  @productID, @sale_Quantity, @saleid);";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.AddWithValue("@productid", productID);
                cmd.Parameters.AddWithValue("@sale_Quantity", saleQuantity); 
                cmd.Parameters.AddWithValue("@saleid", saleID);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


    }
}


