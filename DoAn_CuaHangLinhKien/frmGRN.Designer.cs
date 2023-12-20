﻿namespace GUI
{
    partial class frmGRN
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
            pbGRNImage = new PictureBox();
            splitContainer2 = new SplitContainer();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtGRNUnit = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtGRNID = new TextBox();
            dtpkGRNDate = new DateTimePicker();
            flowLayoutPanel3 = new FlowLayoutPanel();
            btnAddProduct = new Button();
            btnDeleteProduct = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAddGRNImage = new Button();
            btnDeleteGRNImage = new Button();
            txtTotal = new TextBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            splitContainer3 = new SplitContainer();
            dtgvListInsertProduct = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            flowLayoutPanel2 = new FlowLayoutPanel();
            cbCommit = new CheckBox();
            btnInsertProduct = new Button();
            btnCancel = new Button();
            ofdSelectImage = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbGRNImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvListInsertProduct).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4, 3, 4, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pbGRNImage);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1806, 1135);
            splitContainer1.SplitterDistance = 934;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            // 
            // pbGRNImage
            // 
            pbGRNImage.Dock = DockStyle.Fill;
            pbGRNImage.Location = new Point(0, 0);
            pbGRNImage.Margin = new Padding(4, 3, 4, 3);
            pbGRNImage.Name = "pbGRNImage";
            pbGRNImage.Size = new Size(934, 1135);
            pbGRNImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGRNImage.TabIndex = 0;
            pbGRNImage.TabStop = false;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new Padding(4, 3, 4, 3);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(groupBox2);
            splitContainer2.Size = new Size(866, 1135);
            splitContainer2.SplitterDistance = 400;
            splitContainer2.SplitterWidth = 5;
            splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(866, 400);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu nhập ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.94118F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.05882F));
            tableLayoutPanel1.Controls.Add(txtGRNUnit, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(txtGRNID, 1, 0);
            tableLayoutPanel1.Controls.Add(dtpkGRNDate, 1, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel3, 1, 4);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 4);
            tableLayoutPanel1.Controls.Add(txtTotal, 1, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            tableLayoutPanel1.Location = new Point(4, 27);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(858, 370);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtGRNUnit
            // 
            txtGRNUnit.BackColor = Color.FromArgb(255, 253, 239);
            txtGRNUnit.Dock = DockStyle.Fill;
            txtGRNUnit.Location = new Point(200, 51);
            txtGRNUnit.Margin = new Padding(4, 3, 4, 3);
            txtGRNUnit.Name = "txtGRNUnit";
            txtGRNUnit.Size = new Size(654, 27);
            txtGRNUnit.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(188, 48);
            label1.TabIndex = 0;
            label1.Text = "Mã phiếu nhập:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(4, 48);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(188, 48);
            label2.TabIndex = 1;
            label2.Text = "Đơn vị nhập:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(4, 96);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(188, 48);
            label3.TabIndex = 2;
            label3.Text = "Ngày nhập:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtGRNID
            // 
            txtGRNID.BackColor = Color.FromArgb(255, 253, 239);
            txtGRNID.Dock = DockStyle.Fill;
            txtGRNID.Location = new Point(200, 3);
            txtGRNID.Margin = new Padding(4, 3, 4, 3);
            txtGRNID.Name = "txtGRNID";
            txtGRNID.ReadOnly = true;
            txtGRNID.Size = new Size(654, 27);
            txtGRNID.TabIndex = 3;
            // 
            // dtpkGRNDate
            // 
            dtpkGRNDate.Dock = DockStyle.Fill;
            dtpkGRNDate.Location = new Point(200, 101);
            dtpkGRNDate.Margin = new Padding(4, 5, 4, 5);
            dtpkGRNDate.Name = "dtpkGRNDate";
            dtpkGRNDate.Size = new Size(654, 27);
            dtpkGRNDate.TabIndex = 5;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Anchor = AnchorStyles.Bottom;
            flowLayoutPanel3.Controls.Add(btnAddProduct);
            flowLayoutPanel3.Controls.Add(btnDeleteProduct);
            flowLayoutPanel3.Location = new Point(208, 278);
            flowLayoutPanel3.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(637, 87);
            flowLayoutPanel3.TabIndex = 2;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddProduct.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnAddProduct.ForeColor = Color.Brown;
            btnAddProduct.Location = new Point(4, 5);
            btnAddProduct.Margin = new Padding(4, 5, 4, 5);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(304, 62);
            btnAddProduct.TabIndex = 7;
            btnAddProduct.Text = "Thêm SP";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteProduct.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnDeleteProduct.ForeColor = Color.Brown;
            btnDeleteProduct.Location = new Point(316, 5);
            btnDeleteProduct.Margin = new Padding(4, 5, 4, 5);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(304, 62);
            btnDeleteProduct.TabIndex = 7;
            btnDeleteProduct.Text = "Xóa SP";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnAddGRNImage);
            flowLayoutPanel1.Controls.Add(btnDeleteGRNImage);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(4, 207);
            flowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(188, 158);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // btnAddGRNImage
            // 
            btnAddGRNImage.Anchor = AnchorStyles.None;
            btnAddGRNImage.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnAddGRNImage.ForeColor = Color.Brown;
            btnAddGRNImage.Location = new Point(4, 5);
            btnAddGRNImage.Margin = new Padding(4, 5, 4, 5);
            btnAddGRNImage.Name = "btnAddGRNImage";
            btnAddGRNImage.Size = new Size(154, 63);
            btnAddGRNImage.TabIndex = 0;
            btnAddGRNImage.Text = "Chọn hình";
            btnAddGRNImage.UseVisualStyleBackColor = true;
            btnAddGRNImage.Click += btnAddGRNImage_Click;
            // 
            // btnDeleteGRNImage
            // 
            btnDeleteGRNImage.Anchor = AnchorStyles.None;
            btnDeleteGRNImage.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnDeleteGRNImage.ForeColor = Color.Brown;
            btnDeleteGRNImage.Location = new Point(4, 78);
            btnDeleteGRNImage.Margin = new Padding(4, 5, 4, 5);
            btnDeleteGRNImage.Name = "btnDeleteGRNImage";
            btnDeleteGRNImage.Size = new Size(154, 63);
            btnDeleteGRNImage.TabIndex = 1;
            btnDeleteGRNImage.Text = "Xóa hình";
            btnDeleteGRNImage.UseVisualStyleBackColor = true;
            btnDeleteGRNImage.Click += btnDeleteGRNImage_Click;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.FromArgb(194, 231, 255);
            txtTotal.Dock = DockStyle.Fill;
            txtTotal.Enabled = false;
            txtTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(200, 149);
            txtTotal.Margin = new Padding(4, 5, 4, 5);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(654, 33);
            txtTotal.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(4, 144);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(188, 58);
            label4.TabIndex = 2;
            label4.Text = "Tổng:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(splitContainer3);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(866, 730);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm đã nhập ";
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.FixedPanel = FixedPanel.Panel2;
            splitContainer3.IsSplitterFixed = true;
            splitContainer3.Location = new Point(4, 29);
            splitContainer3.Margin = new Padding(4, 5, 4, 5);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(dtgvListInsertProduct);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(flowLayoutPanel2);
            splitContainer3.Size = new Size(858, 696);
            splitContainer3.SplitterDistance = 527;
            splitContainer3.SplitterWidth = 7;
            splitContainer3.TabIndex = 3;
            // 
            // dtgvListInsertProduct
            // 
            dtgvListInsertProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvListInsertProduct.BackgroundColor = Color.FromArgb(194, 231, 255);
            dtgvListInsertProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvListInsertProduct.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dtgvListInsertProduct.Dock = DockStyle.Fill;
            dtgvListInsertProduct.Location = new Point(0, 0);
            dtgvListInsertProduct.Margin = new Padding(4, 5, 4, 5);
            dtgvListInsertProduct.MultiSelect = false;
            dtgvListInsertProduct.Name = "dtgvListInsertProduct";
            dtgvListInsertProduct.ReadOnly = true;
            dtgvListInsertProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvListInsertProduct.Size = new Size(858, 527);
            dtgvListInsertProduct.TabIndex = 0;
            dtgvListInsertProduct.CellClick += dtgvListInsertProduct_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã SP";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên SP";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Số lượng";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Giá nhập";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(cbCommit);
            flowLayoutPanel2.Controls.Add(btnInsertProduct);
            flowLayoutPanel2.Controls.Add(btnCancel);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(858, 162);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // cbCommit
            // 
            cbCommit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbCommit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbCommit.ForeColor = Color.Red;
            cbCommit.Location = new Point(4, 5);
            cbCommit.Margin = new Padding(4, 5, 4, 5);
            cbCommit.Name = "cbCommit";
            cbCommit.Size = new Size(829, 40);
            cbCommit.TabIndex = 3;
            cbCommit.Text = "Tôi xác nhận thông tin trên khớp với hình ảnh trong phiếu";
            cbCommit.UseVisualStyleBackColor = true;
            cbCommit.CheckedChanged += cbCommit_CheckedChanged;
            // 
            // btnInsertProduct
            // 
            btnInsertProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnInsertProduct.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnInsertProduct.ForeColor = Color.Brown;
            btnInsertProduct.Location = new Point(4, 55);
            btnInsertProduct.Margin = new Padding(4, 5, 4, 5);
            btnInsertProduct.Name = "btnInsertProduct";
            btnInsertProduct.Size = new Size(367, 67);
            btnInsertProduct.TabIndex = 1;
            btnInsertProduct.Text = "Nhập hàng ";
            btnInsertProduct.UseVisualStyleBackColor = true;
            btnInsertProduct.Click += btnInsertProduct_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnCancel.ForeColor = Color.Brown;
            btnCancel.Location = new Point(379, 55);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(353, 67);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Hủy thao tác ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ofdSelectImage
            // 
            ofdSelectImage.FileName = "openFileDialog1";
            // 
            // frmGRN
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1806, 1135);
            Controls.Add(splitContainer1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmGRN";
            Text = "frmPhieuNhap";
            Load += frmGRN_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbGRNImage).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvListInsertProduct).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox pbGRNImage;
        private SplitContainer splitContainer2;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtGRNID;
        private TextBox txtGRNUnit;
        private DateTimePicker dtpkGRNDate;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAddGRNImage;
        private Button btnDeleteGRNImage;
        private Button btnAddProduct;
        private GroupBox groupBox2;
        private Button btnInsertProduct;
        private Button btnCancel;
        private SplitContainer splitContainer3;
        private DataGridView dtgvListInsertProduct;
        private FlowLayoutPanel flowLayoutPanel2;
        private OpenFileDialog ofdSelectImage;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button btnDeleteProduct;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private CheckBox cbCommit;
        private TextBox txtTotal;
        private Label label4;
    }
}