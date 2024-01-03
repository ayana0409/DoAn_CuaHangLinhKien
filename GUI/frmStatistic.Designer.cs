namespace GUI
{
    partial class frmStatistic
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
            panel1 = new Panel();
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            dtgvStatistic = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colStaff = new DataGridViewTextBoxColumn();
            colCustomer = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            splitContainer2 = new SplitContainer();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label4 = new Label();
            label5 = new Label();
            txtTotal = new Label();
            txtQuantity = new Label();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            dtpkFrom = new DateTimePicker();
            dtpkTo = new DateTimePicker();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvStatistic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 66);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1264, 66);
            label1.TabIndex = 0;
            label1.Text = "THỐNG KÊ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            splitContainer1.Panel1.Controls.Add(dtgvStatistic);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1264, 615);
            splitContainer1.SplitterDistance = 850;
            splitContainer1.TabIndex = 1;
            // 
            // dtgvStatistic
            // 
            dtgvStatistic.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvStatistic.BackgroundColor = Color.FromArgb(194, 231, 255);
            dtgvStatistic.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvStatistic.Columns.AddRange(new DataGridViewColumn[] { colID, colStaff, colCustomer, colDate });
            dtgvStatistic.Dock = DockStyle.Fill;
            dtgvStatistic.Enabled = false;
            dtgvStatistic.Location = new Point(0, 0);
            dtgvStatistic.MultiSelect = false;
            dtgvStatistic.Name = "dtgvStatistic";
            dtgvStatistic.ReadOnly = true;
            dtgvStatistic.Size = new Size(850, 615);
            dtgvStatistic.TabIndex = 0;
            // 
            // colID
            // 
            colID.HeaderText = "Mã";
            colID.Name = "colID";
            colID.ReadOnly = true;
            // 
            // colStaff
            // 
            colStaff.HeaderText = "Tên sản phẩm";
            colStaff.Name = "colStaff";
            colStaff.ReadOnly = true;
            // 
            // colCustomer
            // 
            colCustomer.HeaderText = "Số lượng";
            colCustomer.Name = "colCustomer";
            colCustomer.ReadOnly = true;
            // 
            // colDate
            // 
            colDate.HeaderText = "Giá";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.FixedPanel = FixedPanel.Panel1;
            splitContainer2.ImeMode = ImeMode.NoControl;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(groupBox2);
            splitContainer2.Panel1.Controls.Add(groupBox1);
            splitContainer2.Size = new Size(410, 615);
            splitContainer2.SplitterDistance = 378;
            splitContainer2.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 224);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(410, 154);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.51485F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.4851456F));
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(label5, 0, 1);
            tableLayoutPanel2.Controls.Add(txtTotal, 1, 1);
            tableLayoutPanel2.Controls.Add(txtQuantity, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 23);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40.5555573F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 59.4444427F));
            tableLayoutPanel2.Size = new Size(404, 128);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 51);
            label4.TabIndex = 1;
            label4.Text = "Số lượng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label5.ForeColor = Color.Brown;
            label5.Location = new Point(3, 51);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 1;
            label5.Text = "Tổng tiền:";
            // 
            // txtTotal
            // 
            txtTotal.AutoSize = true;
            txtTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtTotal.ForeColor = Color.Black;
            txtTotal.Location = new Point(98, 51);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(39, 20);
            txtTotal.TabIndex = 1;
            txtTotal.Text = "Tiền";
            // 
            // txtQuantity
            // 
            txtQuantity.AutoSize = true;
            txtQuantity.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtQuantity.ForeColor = Color.Black;
            txtQuantity.Location = new Point(98, 0);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(71, 20);
            txtQuantity.TabIndex = 1;
            txtQuantity.Text = "Số lượng";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(410, 224);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tùy chỉnh";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.7821789F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.21782F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(dtpkFrom, 1, 0);
            tableLayoutPanel1.Controls.Add(dtpkTo, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 23);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.3870964F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.6129036F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 102F));
            tableLayoutPanel1.Size = new Size(404, 198);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(91, 98);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(310, 97);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 253, 239);
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button1.ForeColor = Color.Brown;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(97, 43);
            button1.TabIndex = 0;
            button1.Text = "Phiếu nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 253, 239);
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button2.ForeColor = Color.Brown;
            button2.Location = new Point(106, 3);
            button2.Name = "button2";
            button2.Size = new Size(97, 43);
            button2.TabIndex = 0;
            button2.Text = "Đơn hàng";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 253, 239);
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button3.ForeColor = Color.Brown;
            button3.Location = new Point(209, 3);
            button3.Name = "button3";
            button3.Size = new Size(97, 43);
            button3.TabIndex = 0;
            button3.Text = "Xuất file";
            button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 46);
            label2.TabIndex = 1;
            label2.Text = "Từ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(3, 46);
            label3.Name = "label3";
            label3.Size = new Size(82, 49);
            label3.TabIndex = 1;
            label3.Text = "Đến:";
            // 
            // dtpkFrom
            // 
            dtpkFrom.Dock = DockStyle.Fill;
            dtpkFrom.Location = new Point(91, 3);
            dtpkFrom.Name = "dtpkFrom";
            dtpkFrom.Size = new Size(310, 27);
            dtpkFrom.TabIndex = 2;
            // 
            // dtpkTo
            // 
            dtpkTo.Dock = DockStyle.Fill;
            dtpkTo.Location = new Point(91, 49);
            dtpkTo.Name = "dtpkTo";
            dtpkTo.Size = new Size(310, 27);
            dtpkTo.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(splitContainer1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(1264, 615);
            panel2.TabIndex = 2;
            // 
            // frmStatistic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmStatistic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê";
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvStatistic).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private SplitContainer splitContainer1;
        private DataGridView dtgvStatistic;
        private SplitContainer splitContainer2;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpkFrom;
        private DateTimePicker dtpkTo;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label4;
        private Label label5;
        private Panel panel2;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colStaff;
        private DataGridViewTextBoxColumn colCustomer;
        private DataGridViewTextBoxColumn colDate;
        private Label txtTotal;
        private Label txtQuantity;
    }
}