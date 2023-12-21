namespace GUI
{
    partial class frmOrder
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
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtCustomerName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPhone = new TextBox();
            rtbCustomerAdress = new RichTextBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtOrderID = new TextBox();
            label9 = new Label();
            splitContainer3 = new SplitContainer();
            btnCancel = new Button();
            btnPayment = new Button();
            btnDeleteProduct = new Button();
            btnAddProduct = new Button();
            txtTotal = new TextBox();
            dtpkDate = new DateTimePicker();
            cbStatus = new ComboBox();
            lbNewCustomer = new Label();
            label5 = new Label();
            dtgvDetail = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvDetail).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4, 3, 4, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dtgvDetail);
            splitContainer1.Size = new Size(1806, 1135);
            splitContainer1.SplitterDistance = 412;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new Padding(4, 3, 4, 3);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(tableLayoutPanel3);
            splitContainer2.Panel1.Controls.Add(label1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer2.Panel2.Controls.Add(label5);
            splitContainer2.Size = new Size(1806, 412);
            splitContainer2.SplitterDistance = 908;
            splitContainer2.SplitterWidth = 6;
            splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.2546577F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.74534F));
            tableLayoutPanel3.Controls.Add(txtCustomerName, 1, 1);
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(label3, 0, 1);
            tableLayoutPanel3.Controls.Add(label4, 0, 2);
            tableLayoutPanel3.Controls.Add(txtPhone, 1, 0);
            tableLayoutPanel3.Controls.Add(rtbCustomerAdress, 1, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50.9090919F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 49.0909081F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 205F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel3.Size = new Size(908, 412);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // txtCustomerName
            // 
            txtCustomerName.BackColor = Color.FromArgb(255, 253, 239);
            txtCustomerName.Dock = DockStyle.Fill;
            txtCustomerName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtCustomerName.Location = new Point(178, 70);
            txtCustomerName.Margin = new Padding(4, 3, 4, 3);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(726, 27);
            txtCustomerName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Azure;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(4, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 0;
            label2.Text = "SĐT khách hàng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Azure;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(4, 67);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 1;
            label3.Text = "Họ và tên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Azure;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(4, 131);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 2;
            label4.Text = "Địa chỉ:";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(255, 253, 239);
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtPhone.Location = new Point(178, 3);
            txtPhone.Margin = new Padding(4, 3, 4, 3);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(726, 27);
            txtPhone.TabIndex = 3;
            txtPhone.TextChanged += txtPhone_Leave;
            txtPhone.Leave += txtPhone_Leave;
            // 
            // rtbCustomerAdress
            // 
            rtbCustomerAdress.BackColor = Color.FromArgb(255, 253, 239);
            rtbCustomerAdress.Dock = DockStyle.Fill;
            rtbCustomerAdress.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            rtbCustomerAdress.Location = new Point(178, 136);
            rtbCustomerAdress.Margin = new Padding(4, 5, 4, 5);
            rtbCustomerAdress.Name = "rtbCustomerAdress";
            rtbCustomerAdress.Size = new Size(726, 195);
            rtbCustomerAdress.TabIndex = 5;
            rtbCustomerAdress.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(189, 25);
            label1.TabIndex = 0;
            label1.Text = "Thông tin khách hàng ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.73399F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.26601F));
            tableLayoutPanel1.Controls.Add(label6, 0, 0);
            tableLayoutPanel1.Controls.Add(label7, 0, 1);
            tableLayoutPanel1.Controls.Add(label8, 0, 2);
            tableLayoutPanel1.Controls.Add(txtOrderID, 1, 0);
            tableLayoutPanel1.Controls.Add(label9, 0, 3);
            tableLayoutPanel1.Controls.Add(splitContainer3, 1, 4);
            tableLayoutPanel1.Controls.Add(txtTotal, 1, 3);
            tableLayoutPanel1.Controls.Add(dtpkDate, 1, 1);
            tableLayoutPanel1.Controls.Add(cbStatus, 1, 2);
            tableLayoutPanel1.Controls.Add(lbNewCustomer, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.0566025F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.9433975F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 163F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.Size = new Size(892, 412);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Azure;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label6.ForeColor = Color.Brown;
            label6.Location = new Point(4, 0);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 1;
            label6.Text = "Mã đơn hàng:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Azure;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label7.ForeColor = Color.Brown;
            label7.Location = new Point(4, 55);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 2;
            label7.Text = "Ngày nhập:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Azure;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label8.ForeColor = Color.Brown;
            label8.Location = new Point(4, 113);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(84, 20);
            label8.TabIndex = 3;
            label8.Text = "Trạng thái:";
            // 
            // txtOrderID
            // 
            txtOrderID.BackColor = Color.FromArgb(255, 253, 239);
            txtOrderID.Dock = DockStyle.Fill;
            txtOrderID.Enabled = false;
            txtOrderID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtOrderID.Location = new Point(162, 3);
            txtOrderID.Margin = new Padding(4, 3, 4, 3);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(726, 27);
            txtOrderID.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Azure;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label9.ForeColor = Color.Brown;
            label9.Location = new Point(4, 175);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(98, 20);
            label9.TabIndex = 4;
            label9.Text = "Tổng giá trị: ";
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(162, 251);
            splitContainer3.Margin = new Padding(4, 3, 4, 3);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(btnCancel);
            splitContainer3.Panel1.Controls.Add(btnPayment);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(btnDeleteProduct);
            splitContainer3.Panel2.Controls.Add(btnAddProduct);
            splitContainer3.Size = new Size(726, 158);
            splitContainer3.SplitterDistance = 72;
            splitContainer3.SplitterWidth = 5;
            splitContainer3.TabIndex = 12;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Azure;
            btnCancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnCancel.ForeColor = Color.Brown;
            btnCancel.Location = new Point(540, -2);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(173, 72);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Hủy đơn";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnPayment
            // 
            btnPayment.BackColor = Color.Azure;
            btnPayment.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnPayment.ForeColor = Color.Brown;
            btnPayment.Location = new Point(359, -2);
            btnPayment.Margin = new Padding(4, 3, 4, 3);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(173, 72);
            btnPayment.TabIndex = 0;
            btnPayment.Text = "Thanh toán";
            btnPayment.UseVisualStyleBackColor = false;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.BackColor = Color.Azure;
            btnDeleteProduct.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnDeleteProduct.ForeColor = Color.Brown;
            btnDeleteProduct.Location = new Point(540, 3);
            btnDeleteProduct.Margin = new Padding(4, 3, 4, 3);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(173, 72);
            btnDeleteProduct.TabIndex = 3;
            btnDeleteProduct.Text = "Xóa SP";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.Azure;
            btnAddProduct.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnAddProduct.ForeColor = Color.Brown;
            btnAddProduct.Location = new Point(359, 3);
            btnAddProduct.Margin = new Padding(4, 3, 4, 3);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(173, 72);
            btnAddProduct.TabIndex = 2;
            btnAddProduct.Text = "Thêm SP";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.FromArgb(255, 253, 239);
            txtTotal.Dock = DockStyle.Fill;
            txtTotal.Enabled = false;
            txtTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtTotal.Location = new Point(162, 180);
            txtTotal.Margin = new Padding(4, 5, 4, 5);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(726, 27);
            txtTotal.TabIndex = 14;
            // 
            // dtpkDate
            // 
            dtpkDate.Dock = DockStyle.Fill;
            dtpkDate.Enabled = false;
            dtpkDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpkDate.Location = new Point(162, 60);
            dtpkDate.Margin = new Padding(4, 5, 4, 5);
            dtpkDate.Name = "dtpkDate";
            dtpkDate.Size = new Size(726, 27);
            dtpkDate.TabIndex = 15;
            // 
            // cbStatus
            // 
            cbStatus.BackColor = Color.FromArgb(255, 253, 239);
            cbStatus.Dock = DockStyle.Fill;
            cbStatus.Enabled = false;
            cbStatus.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(162, 118);
            cbStatus.Margin = new Padding(4, 5, 4, 5);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(726, 28);
            cbStatus.TabIndex = 16;
            // 
            // lbNewCustomer
            // 
            lbNewCustomer.AutoSize = true;
            lbNewCustomer.BackColor = Color.Azure;
            lbNewCustomer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNewCustomer.ForeColor = Color.RoyalBlue;
            lbNewCustomer.Location = new Point(4, 248);
            lbNewCustomer.Margin = new Padding(4, 0, 4, 0);
            lbNewCustomer.Name = "lbNewCustomer";
            lbNewCustomer.Size = new Size(147, 100);
            lbNewCustomer.TabIndex = 4;
            lbNewCustomer.Text = "Khách hàng mới sẽ tự động được lưu vào hệ thống";
            lbNewCustomer.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 0);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(175, 25);
            label5.TabIndex = 0;
            label5.Text = "Thông tin đơn hàng ";
            // 
            // dtgvDetail
            // 
            dtgvDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvDetail.BackgroundColor = Color.FromArgb(194, 231, 255);
            dtgvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDetail.Columns.AddRange(new DataGridViewColumn[] { ProductID, ProductName, Quantity, Price });
            dtgvDetail.Dock = DockStyle.Fill;
            dtgvDetail.Location = new Point(0, 0);
            dtgvDetail.Margin = new Padding(4, 3, 4, 3);
            dtgvDetail.MultiSelect = false;
            dtgvDetail.Name = "dtgvDetail";
            dtgvDetail.ReadOnly = true;
            dtgvDetail.RowHeadersWidth = 51;
            dtgvDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvDetail.Size = new Size(1806, 718);
            dtgvDetail.TabIndex = 0;
            // 
            // ProductID
            // 
            ProductID.HeaderText = "Mã sản phẩm";
            ProductID.Name = "ProductID";
            ProductID.ReadOnly = true;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Tên sản phẩm";
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Số lượng mua";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // Price
            // 
            Price.HeaderText = "Giá bán";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.73399F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.26601F));
            tableLayoutPanel2.Controls.Add(label10, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 0);
            label10.Name = "label10";
            label10.Size = new Size(28, 100);
            label10.TabIndex = 1;
            label10.Text = "Mã đơn hàng:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 120);
            label11.Name = "label11";
            label11.Size = new Size(29, 80);
            label11.TabIndex = 2;
            label11.Text = "Ngày nhập:";
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1806, 1135);
            Controls.Add(splitContainer1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmOrder";
            Text = "frmDonHang";
            Load += frmDonHang_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvDetail).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtOrderID;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label10;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtCustomerName;
        private TextBox txtPhone;
        private SplitContainer splitContainer3;
        private Button btnCancel;
        private Button btnPayment;
        private Button btnDeleteProduct;
        private Button btnAddProduct;
        private DataGridView dtgvDetail;
        private TextBox txtTotal;
        private DateTimePicker dtpkDate;
        private RichTextBox rtbCustomerAdress;
        private ComboBox cbStatus;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private Label lbNewCustomer;
    }
}