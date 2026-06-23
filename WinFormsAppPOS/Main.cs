namespace WinFormsAppPOS
{
    public partial class frmMain : Form
    {
        string activeUser;
        public frmMain(String _user)
        {
            InitializeComponent();
            lblUser.Text = _user;
            activeUser = _user;
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            pnlMaintenance.Visible = true;
            pnlSales.Visible = false;
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            pnlMaintenance.Visible = false;
            pnlSales.Visible = true;
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            frmProduct pm = new frmProduct();
            pm.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            frmCategory _category = new frmCategory();
            _category.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {

        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            frmSales sales = new frmSales(activeUser);
            sales.Show();
        }
    }
}
