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
            txtProductId.Enabled = false;
            txtProductName.Enabled = false;
            txtPrice.Enabled = false;
            cmbCategory.Enabled = false;
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
            cmbCategory.SelectedIndex=0;
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
                string category= cmbCategory.Text;
                dgvProducts.Rows.Add(id,name,price,category);

                Clear();
            }

            

        }
    }
}
