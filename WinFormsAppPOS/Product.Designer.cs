namespace WinFormsAppPOS
{
    partial class frmProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvProducts = new DataGridView();
            txtProductName = new TextBox();
            txtPrice = new TextBox();
            txtProductId = new TextBox();
            cmbCategory = new ComboBox();
            label5 = new Label();
            rtbDesc = new RichTextBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            txtStockQuantity = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 29);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "Product id :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 72);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 1;
            label2.Text = "Product Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(541, 31);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 2;
            label3.Text = "Price :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(515, 72);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 3;
            label4.Text = "Category :";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(710, 291);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 31);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(710, 327);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(86, 29);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(710, 360);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(710, 391);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 33);
            btnClear.TabIndex = 7;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.BackgroundColor = SystemColors.Control;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(46, 224);
            dgvProducts.Margin = new Padding(3, 4, 3, 4);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(621, 289);
            dgvProducts.TabIndex = 8;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(192, 68);
            txtProductName.Margin = new Padding(3, 4, 3, 4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(305, 27);
            txtProductName.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(597, 27);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(198, 27);
            txtPrice.TabIndex = 11;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(192, 25);
            txtProductId.Margin = new Padding(3, 4, 3, 4);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(305, 27);
            txtProductId.TabIndex = 9;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(597, 68);
            cmbCategory.Margin = new Padding(3, 4, 3, 4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(198, 28);
            cmbCategory.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 127);
            label5.Name = "label5";
            label5.Size = new Size(147, 20);
            label5.TabIndex = 13;
            label5.Text = "Product Description :";
            // 
            // rtbDesc
            // 
            rtbDesc.Location = new Point(192, 111);
            rtbDesc.Margin = new Padding(3, 4, 3, 4);
            rtbDesc.Name = "rtbDesc";
            rtbDesc.Size = new Size(305, 48);
            rtbDesc.TabIndex = 14;
            rtbDesc.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(521, 140);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 15;
            label6.Text = "Barcode :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Location = new Point(597, 137);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 55);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(77, 179);
            label7.Name = "label7";
            label7.Size = new Size(112, 20);
            label7.TabIndex = 17;
            label7.Text = "Stock Quantity :";
            // 
            // txtStockQuantity
            // 
            txtStockQuantity.Location = new Point(192, 175);
            txtStockQuantity.Margin = new Padding(3, 4, 3, 4);
            txtStockQuantity.Name = "txtStockQuantity";
            txtStockQuantity.Size = new Size(115, 27);
            txtStockQuantity.TabIndex = 18;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(846, 528);
            Controls.Add(txtStockQuantity);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(rtbDesc);
            Controls.Add(label5);
            Controls.Add(cmbCategory);
            Controls.Add(dgvProducts);
            Controls.Add(txtPrice);
            Controls.Add(txtProductId);
            Controls.Add(txtProductName);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Maintenance";
            Load += frmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvProducts;
        private TextBox txtProductName;
        private TextBox txtPrice;
        private TextBox txtProductId;
        private ComboBox cmbCategory;
        private Label label5;
        private RichTextBox rtbDesc;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label7;
        private TextBox txtStockQuantity;
    }
}