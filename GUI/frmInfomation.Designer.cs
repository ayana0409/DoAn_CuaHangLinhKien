﻿namespace GUI
{
    partial class frmInfomation
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
            flpProduct = new FlowLayoutPanel();
            splitContainer2 = new SplitContainer();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            txtSearchProductID = new TextBox();
            btnSearch = new Button();
            labelx = new Label();
            txtSearchProductName = new TextBox();
            groupBox2 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtPrice = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtID = new TextBox();
            btnAdd = new Button();
            nmQuantity = new NumericUpDown();
            rtbDetail = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmQuantity).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(flpProduct);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(944, 601);
            splitContainer1.SplitterDistance = 658;
            splitContainer1.TabIndex = 0;
            // 
            // flpProduct
            // 
            flpProduct.AutoScroll = true;
            flpProduct.Dock = DockStyle.Fill;
            flpProduct.Location = new Point(0, 0);
            flpProduct.Name = "flpProduct";
            flpProduct.Size = new Size(658, 601);
            flpProduct.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
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
            splitContainer2.Size = new Size(282, 601);
            splitContainer2.SplitterDistance = 202;
            splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(282, 202);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bộ lọc tìm kiếm ";
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 120);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.8289089F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.17109F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(txtSearchProductID, 1, 0);
            tableLayoutPanel2.Controls.Add(btnSearch, 1, 2);
            tableLayoutPanel2.Controls.Add(labelx, 0, 1);
            tableLayoutPanel2.Controls.Add(txtSearchProductName, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 54.5454559F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 45.4545441F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel2.Size = new Size(276, 120);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(35, 37);
            label1.TabIndex = 0;
            label1.Text = "Mã SP:";
            // 
            // txtSearchProductID
            // 
            txtSearchProductID.BackColor = Color.FromArgb(255, 253, 239);
            txtSearchProductID.Dock = DockStyle.Fill;
            txtSearchProductID.Location = new Point(63, 3);
            txtSearchProductID.Name = "txtSearchProductID";
            txtSearchProductID.Size = new Size(210, 27);
            txtSearchProductID.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnSearch.ForeColor = Color.Brown;
            btnSearch.Location = new Point(152, 70);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(121, 43);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Tìm kiếm ";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // labelx
            // 
            labelx.AutoSize = true;
            labelx.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            labelx.ForeColor = Color.Brown;
            labelx.Location = new Point(3, 37);
            labelx.Name = "labelx";
            labelx.Size = new Size(38, 30);
            labelx.TabIndex = 0;
            labelx.Text = "Tên SP:";
            // 
            // txtSearchProductName
            // 
            txtSearchProductName.BackColor = Color.FromArgb(255, 253, 239);
            txtSearchProductName.Dock = DockStyle.Fill;
            txtSearchProductName.Location = new Point(63, 40);
            txtSearchProductName.Name = "txtSearchProductName";
            txtSearchProductName.Size = new Size(210, 27);
            txtSearchProductName.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(282, 395);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sản phẩm ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(txtPrice, 1, 3);
            tableLayoutPanel1.Controls.Add(txtName, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 4);
            tableLayoutPanel1.Controls.Add(txtID, 1, 0);
            tableLayoutPanel1.Controls.Add(btnAdd, 1, 5);
            tableLayoutPanel1.Controls.Add(nmQuantity, 1, 2);
            tableLayoutPanel1.Controls.Add(rtbDetail, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 23);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(276, 262);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.FromArgb(194, 231, 255);
            txtPrice.Dock = DockStyle.Fill;
            txtPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtPrice.Location = new Point(68, 116);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(205, 27);
            txtPrice.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(255, 253, 239);
            txtName.Dock = DockStyle.Fill;
            txtName.Enabled = false;
            txtName.Location = new Point(68, 39);
            txtName.Name = "txtName";
            txtName.Size = new Size(205, 27);
            txtName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã SP:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(3, 74);
            label4.Name = "label4";
            label4.Size = new Size(54, 39);
            label4.TabIndex = 2;
            label4.Text = "Số lượng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(3, 36);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 1;
            label3.Text = "Tên SP:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label5.ForeColor = Color.Brown;
            label5.Location = new Point(3, 113);
            label5.Name = "label5";
            label5.Size = new Size(48, 39);
            label5.TabIndex = 3;
            label5.Text = "Giá nhập:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label6.ForeColor = Color.Brown;
            label6.Location = new Point(3, 152);
            label6.Name = "label6";
            label6.Size = new Size(59, 60);
            label6.TabIndex = 4;
            label6.Text = "Chi tiết sản phẩm: ";
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(255, 253, 239);
            txtID.Dock = DockStyle.Fill;
            txtID.Enabled = false;
            txtID.Location = new Point(68, 3);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(205, 27);
            txtID.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Brown;
            btnAdd.Location = new Point(152, 218);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 41);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm ";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // nmQuantity
            // 
            nmQuantity.BackColor = Color.FromArgb(194, 231, 255);
            nmQuantity.Dock = DockStyle.Fill;
            nmQuantity.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            nmQuantity.Location = new Point(68, 77);
            nmQuantity.Name = "nmQuantity";
            nmQuantity.Size = new Size(205, 27);
            nmQuantity.TabIndex = 9;
            // 
            // rtbDetail
            // 
            rtbDetail.BackColor = Color.FromArgb(255, 253, 239);
            rtbDetail.Dock = DockStyle.Fill;
            rtbDetail.Enabled = false;
            rtbDetail.Location = new Point(68, 155);
            rtbDetail.Name = "rtbDetail";
            rtbDetail.Size = new Size(205, 57);
            rtbDetail.TabIndex = 10;
            rtbDetail.Text = "";
            // 
            // frmInfomation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(944, 601);
            Controls.Add(splitContainer1);
            Name = "frmInfomation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm sản phẩm";
            Load += frmInfomationGRN_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmQuantity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private FlowLayoutPanel flpProduct;
        private SplitContainer splitContainer2;
        private GroupBox groupBox1;
        private Panel panel1;
        private Button btnSearch;
        private TextBox txtSearchProductID;
        private Label label1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtPrice;
        private TextBox txtName;
        private Label label6;
        private TextBox txtID;
        private Button btnAdd;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelx;
        private TextBox txtSearchProductName;
        private NumericUpDown nmQuantity;
        private RichTextBox rtbDetail;
    }
}