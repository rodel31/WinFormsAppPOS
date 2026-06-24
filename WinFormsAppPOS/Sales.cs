using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsAppPOS
{
    public partial class frmSales : Form
    {
        public frmSales(string _activeUser)
        {
            InitializeComponent();
            lblActive.Text = _activeUser;
            loadProducts();
            loadCustomers();
        }
        public string connectionString = "Server=localhost;Database=pos_db;Uid=root;Pwd=P@ssw0rd";
        public int prodID, custID;

        public void loadProducts()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT ProductID,ProductName,Category,UnitPrice FROM products";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvSearchProduct.DataSource = dt;
                        Console.WriteLine("Products Load Successfully");
                    }
                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {

            }

        }
        public void loadCustomers()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT CustomerID,CustomerName,Address FROM customers";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvCustomerInfo.DataSource = dt;
                        Console.WriteLine("Products Load Successfully");
                    }
                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void dgvSearchProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSearchProduct.SelectedRows.Count > 0)
            {
                prodID = int.Parse(dgvSearchProduct.SelectedRows[0].Cells["ProductID"].Value.ToString());
                txtProductName.Text = dgvSearchProduct.SelectedRows[0].Cells["ProductName"].Value.ToString();
                txtPrice.Text = dgvSearchProduct.SelectedRows[0].Cells["UnitPrice"].Value.ToString();
            }
        }

        private void dgvCustomerInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCustomerInfo.SelectedRows.Count > 0)
            {
                custID = int.Parse(dgvCustomerInfo.SelectedRows[0].Cells["CustomerID"].Value.ToString());
                txtCustomer.Text = dgvCustomerInfo.SelectedRows[0].Cells["CustomerName"].Value.ToString();
                
            }
        }
    }
}
