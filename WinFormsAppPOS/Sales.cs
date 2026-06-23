using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppPOS
{
    public partial class frmSales : Form
    {
        public frmSales(string _activeUser)
        {
            InitializeComponent();
            lblActive.Text = _activeUser;
        }

    }
}
