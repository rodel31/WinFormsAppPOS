namespace WinFormsAppPOS
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            pnlMenu = new Panel();
            btnSettings = new Button();
            btnReports = new Button();
            btnTransaction = new Button();
            btnMaintenance = new Button();
            pictureBox1 = new PictureBox();
            pnlMaintenance = new Panel();
            btnUser = new Button();
            btnCustomer = new Button();
            btnCategory = new Button();
            btnProducts = new Button();
            pnlSales = new Panel();
            btnSales = new Button();
            label1 = new Label();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlMaintenance.SuspendLayout();
            pnlSales.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(0, 192, 192);
            pnlMenu.Controls.Add(btnSettings);
            pnlMenu.Controls.Add(btnReports);
            pnlMenu.Controls.Add(btnTransaction);
            pnlMenu.Controls.Add(btnMaintenance);
            pnlMenu.Location = new Point(0, 115);
            pnlMenu.Margin = new Padding(3, 4, 3, 4);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(138, 487);
            pnlMenu.TabIndex = 0;
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(7, 399);
            btnSettings.Margin = new Padding(3, 4, 3, 4);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(113, 48);
            btnSettings.TabIndex = 3;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(7, 141);
            btnReports.Margin = new Padding(3, 4, 3, 4);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(113, 48);
            btnReports.TabIndex = 2;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnTransaction
            // 
            btnTransaction.Location = new Point(7, 85);
            btnTransaction.Margin = new Padding(3, 4, 3, 4);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.Size = new Size(113, 48);
            btnTransaction.TabIndex = 1;
            btnTransaction.Text = "Transaction";
            btnTransaction.UseVisualStyleBackColor = true;
            btnTransaction.Click += btnTransaction_Click;
            // 
            // btnMaintenance
            // 
            btnMaintenance.Location = new Point(7, 29);
            btnMaintenance.Margin = new Padding(3, 4, 3, 4);
            btnMaintenance.Name = "btnMaintenance";
            btnMaintenance.Size = new Size(113, 48);
            btnMaintenance.TabIndex = 0;
            btnMaintenance.Text = "Maintenance";
            btnMaintenance.UseVisualStyleBackColor = true;
            btnMaintenance.Click += btnMaintenance_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 192, 192);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pnlMaintenance
            // 
            pnlMaintenance.BackColor = Color.Transparent;
            pnlMaintenance.Controls.Add(btnUser);
            pnlMaintenance.Controls.Add(btnCustomer);
            pnlMaintenance.Controls.Add(btnCategory);
            pnlMaintenance.Controls.Add(btnProducts);
            pnlMaintenance.Location = new Point(153, 73);
            pnlMaintenance.Margin = new Padding(3, 4, 3, 4);
            pnlMaintenance.Name = "pnlMaintenance";
            pnlMaintenance.Size = new Size(752, 457);
            pnlMaintenance.TabIndex = 3;
            pnlMaintenance.Visible = false;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.PaleTurquoise;
            btnUser.Location = new Point(403, 274);
            btnUser.Margin = new Padding(3, 4, 3, 4);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(186, 109);
            btnUser.TabIndex = 3;
            btnUser.Text = "USER";
            btnUser.UseVisualStyleBackColor = false;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.PaleTurquoise;
            btnCustomer.Location = new Point(174, 274);
            btnCustomer.Margin = new Padding(3, 4, 3, 4);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(186, 109);
            btnCustomer.TabIndex = 2;
            btnCustomer.Text = "CUSTOMER";
            btnCustomer.UseVisualStyleBackColor = false;
            // 
            // btnCategory
            // 
            btnCategory.BackColor = Color.PaleTurquoise;
            btnCategory.Location = new Point(403, 100);
            btnCategory.Margin = new Padding(3, 4, 3, 4);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(186, 109);
            btnCategory.TabIndex = 1;
            btnCategory.Text = "CATEGORY";
            btnCategory.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.PaleTurquoise;
            btnProducts.Location = new Point(174, 98);
            btnProducts.Margin = new Padding(3, 4, 3, 4);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(186, 109);
            btnProducts.TabIndex = 0;
            btnProducts.Text = "PRODUCTS";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // pnlSales
            // 
            pnlSales.BackColor = Color.Transparent;
            pnlSales.Controls.Add(btnSales);
            pnlSales.Location = new Point(144, 90);
            pnlSales.Margin = new Padding(3, 4, 3, 4);
            pnlSales.Name = "pnlSales";
            pnlSales.Size = new Size(768, 404);
            pnlSales.TabIndex = 4;
            pnlSales.Visible = false;
            // 
            // btnSales
            // 
            btnSales.BackColor = Color.PaleTurquoise;
            btnSales.Location = new Point(251, 115);
            btnSales.Margin = new Padding(3, 4, 3, 4);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(186, 109);
            btnSales.TabIndex = 0;
            btnSales.Text = "SALES";
            btnSales.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Perpetua", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MintCream;
            label1.Location = new Point(261, 18);
            label1.Name = "label1";
            label1.Size = new Size(498, 39);
            label1.TabIndex = 5;
            label1.Text = "POINT OF SALES MAINTENANCE";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(917, 600);
            Controls.Add(pnlSales);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pnlMenu);
            Controls.Add(pnlMaintenance);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMain";
            Text = "POS Main";
            TransparencyKey = Color.Gray;
            pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlMaintenance.ResumeLayout(false);
            pnlSales.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMenu;
        private Button btnTransaction;
        private Button btnMaintenance;
        private PictureBox pictureBox1;
        private Button btnReports;
        private Button btnSettings;
        private Panel pnlMaintenance;
        private Button btnCustomer;
        private Button btnCategory;
        private Button btnProducts;
        private Button btnUser;
        private Panel pnlSales;
        private Button btnSales;
        private Label label1;
    }
}
