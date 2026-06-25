using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

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
        public decimal _subTotal, total;

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
        public void ResetOrderFields()
        {
            loadProducts();
            loadCustomers();
            txtProductName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtSearchCustomer.Text = string.Empty;
            txtSearchProduct.Text = string.Empty;

        }
        public void getTotal()
        {
            total = 0;
            for (int i = 0; i < dgvSalesReceipt.Rows.Count - 1; i++)
            {
                decimal _subT = decimal.Parse(dgvSalesReceipt.Rows[i].Cells["SubTotal"].Value.ToString());
                total = total + _subT;
                lblTotal.Text = total.ToString();
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

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            decimal price = decimal.Parse(txtPrice.Text);
            int qty = int.Parse(txtQuantity.Text);
            _subTotal = price * qty;
            dgvSalesReceipt.Rows.Add(prodID, txtPrice.Text, txtQuantity.Text, _subTotal.ToString());
            ResetOrderFields();
            getTotal();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (txtCash.Text != string.Empty)
            {
                decimal cashR = decimal.Parse(txtCash.Text);
                decimal _result = cashR - total;
                if (cashR > total)
                {
                    txtChange.Text = _result.ToString();
                }
                else
                {
                    MessageBox.Show("Insufficient cash payment","Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            
        }
    }
}
