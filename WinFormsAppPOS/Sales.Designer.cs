namespace WinFormsAppPOS
{
    partial class frmSales
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvSalesReceipt = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            dgvSearchProduct = new DataGridView();
            txtSearchProduct = new TextBox();
            label1 = new Label();
            txtCustomer = new TextBox();
            label2 = new Label();
            btnNewCustomer = new Button();
            label3 = new Label();
            txtSearchCustomer = new TextBox();
            dgvCustomerInfo = new DataGridView();
            label4 = new Label();
            txtProductName = new TextBox();
            label5 = new Label();
            label6 = new Label();
            lblActive = new Label();
            label7 = new Label();
            lblTotal = new Label();
            label9 = new Label();
            txtCash = new TextBox();
            txtChange = new TextBox();
            label10 = new Label();
            btnNewTrans = new Button();
            txtPrice = new TextBox();
            label8 = new Label();
            txtQuantity = new TextBox();
            label11 = new Label();
            btnAddOrder = new Button();
            btnVoid = new Button();
            btnProcess = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSalesReceipt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSearchProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerInfo).BeginInit();
            SuspendLayout();
            // 
            // dgvSalesReceipt
            // 
            dgvSalesReceipt.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSalesReceipt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSalesReceipt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalesReceipt.Columns.AddRange(new DataGridViewColumn[] { ProductID, UnitPrice, Quantity, SubTotal });
            dgvSalesReceipt.Location = new Point(914, 55);
            dgvSalesReceipt.MultiSelect = false;
            dgvSalesReceipt.Name = "dgvSalesReceipt";
            dgvSalesReceipt.RowHeadersVisible = false;
            dgvSalesReceipt.RowHeadersWidth = 51;
            dgvSalesReceipt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSalesReceipt.Size = new Size(509, 576);
            dgvSalesReceipt.TabIndex = 0;
            // 
            // ProductID
            // 
            ProductID.HeaderText = "ProductID";
            ProductID.MinimumWidth = 6;
            ProductID.Name = "ProductID";
            ProductID.Width = 125;
            // 
            // UnitPrice
            // 
            UnitPrice.HeaderText = "Unit Price";
            UnitPrice.MinimumWidth = 6;
            UnitPrice.Name = "UnitPrice";
            UnitPrice.Width = 125;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Qty";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "Sub-Total";
            SubTotal.MinimumWidth = 6;
            SubTotal.Name = "SubTotal";
            SubTotal.Width = 125;
            // 
            // dgvSearchProduct
            // 
            dgvSearchProduct.BackgroundColor = SystemColors.ActiveBorder;
            dgvSearchProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchProduct.Location = new Point(405, 202);
            dgvSearchProduct.Name = "dgvSearchProduct";
            dgvSearchProduct.RowHeadersVisible = false;
            dgvSearchProduct.RowHeadersWidth = 40;
            dgvSearchProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSearchProduct.Size = new Size(503, 429);
            dgvSearchProduct.TabIndex = 1;
            dgvSearchProduct.CellContentClick += dgvSearchProduct_CellContentClick;
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Location = new Point(618, 169);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new Size(243, 27);
            txtSearchProduct.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(437, 172);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 3;
            label1.Text = "Search by Product Name:";
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(159, 23);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(540, 27);
            txtCustomer.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(18, 27);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 5;
            label2.Text = "Customer Name:";
            // 
            // btnNewCustomer
            // 
            btnNewCustomer.Location = new Point(715, 23);
            btnNewCustomer.Name = "btnNewCustomer";
            btnNewCustomer.Size = new Size(120, 29);
            btnNewCustomer.TabIndex = 6;
            btnNewCustomer.Text = "New Customer";
            btnNewCustomer.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(18, 172);
            label3.Name = "label3";
            label3.Size = new Size(191, 20);
            label3.TabIndex = 9;
            label3.Text = "Search by Customer Name: ";
            // 
            // txtSearchCustomer
            // 
            txtSearchCustomer.Location = new Point(209, 169);
            txtSearchCustomer.Name = "txtSearchCustomer";
            txtSearchCustomer.Size = new Size(190, 27);
            txtSearchCustomer.TabIndex = 8;
            // 
            // dgvCustomerInfo
            // 
            dgvCustomerInfo.BackgroundColor = SystemColors.ActiveBorder;
            dgvCustomerInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerInfo.Location = new Point(18, 202);
            dgvCustomerInfo.Name = "dgvCustomerInfo";
            dgvCustomerInfo.RowHeadersVisible = false;
            dgvCustomerInfo.RowHeadersWidth = 51;
            dgvCustomerInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomerInfo.Size = new Size(381, 429);
            dgvCustomerInfo.TabIndex = 7;
            dgvCustomerInfo.CellContentClick += dgvCustomerInfo_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(30, 65);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 10;
            label4.Text = "Product Name:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(159, 65);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(540, 27);
            txtProductName.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(1040, 11);
            label5.Name = "label5";
            label5.Size = new Size(194, 34);
            label5.TabIndex = 12;
            label5.Text = "Transactions";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(18, 684);
            label6.Name = "label6";
            label6.Size = new Size(91, 28);
            label6.TabIndex = 13;
            label6.Text = "ACTIVE: ";
            // 
            // lblActive
            // 
            lblActive.AutoSize = true;
            lblActive.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActive.ForeColor = SystemColors.Control;
            lblActive.Location = new Point(105, 687);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(36, 28);
            lblActive.TabIndex = 14;
            lblActive.Text = "___";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Yellow;
            label7.Location = new Point(1054, 666);
            label7.Name = "label7";
            label7.Size = new Size(226, 41);
            label7.TabIndex = 15;
            label7.Text = "Total Amount: ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(1309, 676);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(65, 28);
            lblTotal.TabIndex = 16;
            lblTotal.Text = "00.00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.LimeGreen;
            label9.Location = new Point(320, 660);
            label9.Name = "label9";
            label9.Size = new Size(69, 28);
            label9.TabIndex = 17;
            label9.Text = "CASH:";
            // 
            // txtCash
            // 
            txtCash.Location = new Point(320, 689);
            txtCash.Name = "txtCash";
            txtCash.Size = new Size(184, 27);
            txtCash.TabIndex = 18;
            // 
            // txtChange
            // 
            txtChange.Location = new Point(544, 688);
            txtChange.Name = "txtChange";
            txtChange.Size = new Size(184, 27);
            txtChange.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkOrange;
            label10.Location = new Point(544, 659);
            label10.Name = "label10";
            label10.Size = new Size(99, 28);
            label10.TabIndex = 19;
            label10.Text = "CHANGE:";
            // 
            // btnNewTrans
            // 
            btnNewTrans.BackColor = Color.SpringGreen;
            btnNewTrans.Location = new Point(914, 16);
            btnNewTrans.Name = "btnNewTrans";
            btnNewTrans.Size = new Size(120, 29);
            btnNewTrans.TabIndex = 21;
            btnNewTrans.Text = "New";
            btnNewTrans.UseVisualStyleBackColor = false;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(381, 100);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(123, 27);
            txtPrice.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(315, 100);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 22;
            label8.Text = "Price:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(601, 100);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(99, 27);
            txtQuantity.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(535, 100);
            label11.Name = "label11";
            label11.Size = new Size(68, 20);
            label11.TabIndex = 24;
            label11.Text = "Quantity:";
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(715, 96);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(120, 29);
            btnAddOrder.TabIndex = 26;
            btnAddOrder.Text = "ADD ORDER";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // btnVoid
            // 
            btnVoid.BackColor = Color.FromArgb(192, 0, 0);
            btnVoid.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoid.ForeColor = Color.FromArgb(0, 192, 192);
            btnVoid.Location = new Point(914, 662);
            btnVoid.Name = "btnVoid";
            btnVoid.Size = new Size(120, 53);
            btnVoid.TabIndex = 27;
            btnVoid.Text = "VOID";
            btnVoid.UseVisualStyleBackColor = false;
            // 
            // btnProcess
            // 
            btnProcess.BackColor = Color.White;
            btnProcess.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProcess.ForeColor = Color.Red;
            btnProcess.Location = new Point(745, 663);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(153, 53);
            btnProcess.TabIndex = 28;
            btnProcess.Text = "PROCESS";
            btnProcess.UseVisualStyleBackColor = false;
            btnProcess.Click += btnProcess_Click;
            // 
            // frmSales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1435, 748);
            Controls.Add(btnProcess);
            Controls.Add(btnVoid);
            Controls.Add(btnAddOrder);
            Controls.Add(txtQuantity);
            Controls.Add(label11);
            Controls.Add(txtPrice);
            Controls.Add(label8);
            Controls.Add(btnNewTrans);
            Controls.Add(txtChange);
            Controls.Add(label10);
            Controls.Add(txtCash);
            Controls.Add(label9);
            Controls.Add(lblTotal);
            Controls.Add(label7);
            Controls.Add(lblActive);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtProductName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtSearchCustomer);
            Controls.Add(dgvCustomerInfo);
            Controls.Add(btnNewCustomer);
            Controls.Add(label2);
            Controls.Add(txtCustomer);
            Controls.Add(label1);
            Controls.Add(txtSearchProduct);
            Controls.Add(dgvSearchProduct);
            Controls.Add(dgvSalesReceipt);
            Name = "frmSales";
            Text = "Sales";
            ((System.ComponentModel.ISupportInitialize)dgvSalesReceipt).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSearchProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSalesReceipt;
        private DataGridView dgvSearchProduct;
        private TextBox txtSearchProduct;
        private Label label1;
        private TextBox txtCustomer;
        private Label label2;
        private Button btnNewCustomer;
        private Label label3;
        private TextBox txtSearchCustomer;
        private DataGridView dgvCustomerInfo;
        private Label label4;
        private TextBox txtProductName;
        private Label label5;
        private Label label6;
        private Label lblActive;
        private Label label7;
        private Label lblTotal;
        private Label label9;
        private TextBox txtCash;
        private TextBox txtChange;
        private Label label10;
        private Button btnNewTrans;
        private TextBox txtPrice;
        private Label label8;
        private TextBox txtQuantity;
        private Label label11;
        private Button btnAddOrder;
        private Button btnVoid;
        private Button btnProcess;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn SubTotal;
    }
}