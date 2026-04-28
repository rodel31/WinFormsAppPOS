using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WinFormsAppPOS
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
            Reset();
        }

        public void Reset()
        {
            txtProductId.Enabled = false;
            txtProductName.Enabled = false;
            txtPrice.Enabled = false;
            cmbCategory.Enabled = false;
            cmbCategory.SelectedIndex = 0;
        }
        public void Clear()
        {
            txtProductId.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            cmbCategory.SelectedIndex = 0;
        }
        public void InputEnable()
        {
            txtProductId.Enabled = true;
            txtProductName.Enabled = true;
            txtPrice.Enabled = true;
            cmbCategory.Enabled = true;
            cmbCategory.SelectedIndex = 0;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (btnNew.Text == "NEW")
            {
                btnNew.Text = "ADD";
                InputEnable();
            }
            else if (btnNew.Text == "ADD")
            {
                string id = txtProductId.Text;
                string name = txtProductName.Text;
                string price = txtPrice.Text;
                string category = cmbCategory.Text;
                dgvProducts.Rows.Add(id, name, price, category);
                btnNew.Text = "NEW";
                Clear();
                Reset();
            }

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(btnEdit.Text == "EDIT")
            {
                if (dgvProducts.SelectedRows.Count > 0)
                {
                    btnEdit.Text = "UPDATE";
                    InputEnable();
                    txtProductId.Text = dgvProducts.SelectedRows[0].Cells["ID"].Value.ToString();
                    txtProductName.Text = dgvProducts.SelectedRows[0].Cells["NAME"].Value.ToString();
                    txtPrice.Text = dgvProducts.SelectedRows[0].Cells["PRICE"].Value.ToString();
                    cmbCategory.Text = dgvProducts.SelectedRows[0].Cells["CATEGORY"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Please select data on the list.");
                }
            }
            else if(btnEdit.Text == "UPDATE")
            {
                for (int i = 0; i<dgvProducts.Rows.Count-1; i++)
                {
                    if (dgvProducts.Rows[i].Cells["ID"].Value.ToString() == txtProductId.Text)
                    {
                        dgvProducts.Rows[i].Cells["ID"].Value = txtProductId.Text;
                        dgvProducts.Rows[i].Cells["NAME"].Value = txtProductName.Text;
                        dgvProducts.Rows[i].Cells["PRICE"].Value = txtPrice.Text;
                        dgvProducts.Rows[i].Cells["CATEGORY"].Value = cmbCategory.Text;
                        
                        MessageBox.Show("SUCCESSFULLY UPDATED");
                    }
                }
                btnEdit.Text = "EDIT";
                Clear();
                Reset();
            }
        }
    }
}
