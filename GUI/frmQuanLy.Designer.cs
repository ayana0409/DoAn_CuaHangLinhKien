namespace GUI
{
    partial class frmManage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManage));
            TabControl = new TabControl();
            tpCustomer = new TabPage();
            splitContainer1 = new SplitContainer();
            dtgvCustomer = new DataGridView();
            sdt = new DataGridViewTextBoxColumn();
            cusName = new DataGridViewTextBoxColumn();
            cusAddress = new DataGridViewTextBoxColumn();
            splitContainer2 = new SplitContainer();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSearchCustomer = new Button();
            label1 = new Label();
            txtSearchName = new TextBox();
            txtSearchNumberPhone = new TextBox();
            label2 = new Label();
            splitContainer3 = new SplitContainer();
            groupBox3 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtNumberPhone = new TextBox();
            rtbAddress = new RichTextBox();
            groupBox2 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAddCustomer = new Button();
            btnUpdateCustomer = new Button();
            btnCustomerAddOrder = new Button();
            tpOrder = new TabPage();
            splitContainer4 = new SplitContainer();
            dtgvOrder = new DataGridView();
            OrderID = new DataGridViewTextBoxColumn();
            OrderCustomer = new DataGridViewTextBoxColumn();
            OrderCustomerPhone = new DataGridViewTextBoxColumn();
            OrderStatus = new DataGridViewTextBoxColumn();
            OrderTotal = new DataGridViewTextBoxColumn();
            OrderDate = new DataGridViewTextBoxColumn();
            OrderStaff = new DataGridViewTextBoxColumn();
            splitContainer5 = new SplitContainer();
            groupBox4 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label6 = new Label();
            txtSearchOrderID = new TextBox();
            label7 = new Label();
            label11 = new Label();
            dtpkSearchOrderTo = new DateTimePicker();
            dtpkSearchOrderFrom = new DateTimePicker();
            panel2 = new Panel();
            btnSearchOrderCancel = new Button();
            btnSearchOrder = new Button();
            splitContainer6 = new SplitContainer();
            groupBox5 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label39 = new Label();
            panel6 = new Panel();
            label69 = new Label();
            panel5 = new Panel();
            txtOrderTotal = new Label();
            label13 = new Label();
            txtOrderCustomerName = new Label();
            txtOrderStaff = new Label();
            txtOrderStatus = new Label();
            txtOrderID = new Label();
            groupBox6 = new GroupBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnAddOrder = new Button();
            btnView = new Button();
            tpProduct = new TabPage();
            splitContainer10 = new SplitContainer();
            flpProduct = new FlowLayoutPanel();
            splitContainer11 = new SplitContainer();
            groupBox9 = new GroupBox();
            splitContainer33 = new SplitContainer();
            tableLayoutPanel7 = new TableLayoutPanel();
            label21 = new Label();
            txtSearchProductID = new TextBox();
            label22 = new Label();
            txtSearchProductName = new TextBox();
            btnSearchProduct = new Button();
            splitContainer12 = new SplitContainer();
            groupBox10 = new GroupBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            txtProductName = new TextBox();
            rtbProductInfomation = new RichTextBox();
            label25 = new Label();
            cbProductCategory = new ComboBox();
            label34 = new Label();
            cbProductManufacturer = new ComboBox();
            label35 = new Label();
            panel = new Panel();
            label60 = new Label();
            txtProductPrice = new TextBox();
            label23 = new Label();
            txtProductID = new Label();
            txtProductQuantity = new TextBox();
            splitContainer32 = new SplitContainer();
            panel7 = new Panel();
            pbProductImage = new PictureBox();
            groupBox11 = new GroupBox();
            btnSelectProductImage = new Button();
            btnDeleteProductImage = new Button();
            btnUpdateProduct = new Button();
            btnAddProduct = new Button();
            tpManufacturer = new TabPage();
            splitContainer14 = new SplitContainer();
            dtgvManufacturer = new DataGridView();
            ManuID = new DataGridViewTextBoxColumn();
            ManuName = new DataGridViewTextBoxColumn();
            splitContainer15 = new SplitContainer();
            groupBox12 = new GroupBox();
            tableLayoutPanel9 = new TableLayoutPanel();
            btnSearchManufacturer = new Button();
            label29 = new Label();
            txtSearchManuName = new TextBox();
            txtSearchManuID = new TextBox();
            label30 = new Label();
            splitContainer16 = new SplitContainer();
            groupBox13 = new GroupBox();
            tableLayoutPanel10 = new TableLayoutPanel();
            label31 = new Label();
            label32 = new Label();
            txtManufacturerName = new TextBox();
            txtManufacturerID = new Label();
            groupBox14 = new GroupBox();
            flowLayoutPanel6 = new FlowLayoutPanel();
            btnAddManufacturer = new Button();
            btnUpdateManufacturer = new Button();
            tpCategory = new TabPage();
            splitContainer17 = new SplitContainer();
            dtgvCategory = new DataGridView();
            CateID = new DataGridViewTextBoxColumn();
            CateName = new DataGridViewTextBoxColumn();
            splitContainer18 = new SplitContainer();
            groupBox15 = new GroupBox();
            tableLayoutPanel11 = new TableLayoutPanel();
            btnSearchCate = new Button();
            label33 = new Label();
            txtSearchCateName = new TextBox();
            txtSearchCateID = new TextBox();
            label36 = new Label();
            splitContainer19 = new SplitContainer();
            groupBox16 = new GroupBox();
            tableLayoutPanel12 = new TableLayoutPanel();
            label37 = new Label();
            label38 = new Label();
            txtCateName = new TextBox();
            txtCategoryID = new Label();
            groupBox17 = new GroupBox();
            btnAddCate = new Button();
            btnUpdateCate = new Button();
            tpGRN = new TabPage();
            splitContainer20 = new SplitContainer();
            dtgvGRN = new DataGridView();
            Column10 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            splitContainer21 = new SplitContainer();
            groupBox18 = new GroupBox();
            tableLayoutPanel13 = new TableLayoutPanel();
            label40 = new Label();
            txtSearchGRNID = new TextBox();
            label41 = new Label();
            label42 = new Label();
            dtpkSearchGRNTo = new DateTimePicker();
            dtpkSearchGRNFrom = new DateTimePicker();
            panel1 = new Panel();
            btnSearchGRNCancel = new Button();
            btnSearchGRN = new Button();
            splitContainer22 = new SplitContainer();
            groupBox19 = new GroupBox();
            tableLayoutPanel14 = new TableLayoutPanel();
            txtGRNStaff = new Label();
            label45 = new Label();
            label46 = new Label();
            label47 = new Label();
            label43 = new Label();
            panel4 = new Panel();
            txtGRNTotal = new Label();
            label12 = new Label();
            label68 = new Label();
            txtGRNUnit = new Label();
            txtGRNID = new Label();
            txtGRNDate = new Label();
            groupBox20 = new GroupBox();
            flowLayoutPanel8 = new FlowLayoutPanel();
            btnDetailAndUpdateGRN = new Button();
            btnAddGRN = new Button();
            tpStaff = new TabPage();
            splitContainer23 = new SplitContainer();
            dtgvStaff = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            splitContainer24 = new SplitContainer();
            groupBox21 = new GroupBox();
            tableLayoutPanel15 = new TableLayoutPanel();
            btnSearchStaff = new Button();
            label44 = new Label();
            txtSearchStaffName = new TextBox();
            txtSearchStaffID = new TextBox();
            label48 = new Label();
            splitContainer25 = new SplitContainer();
            groupBox22 = new GroupBox();
            tableLayoutPanel16 = new TableLayoutPanel();
            txtStaffID = new Label();
            label49 = new Label();
            label50 = new Label();
            txtStaffName = new TextBox();
            label52 = new Label();
            label53 = new Label();
            label54 = new Label();
            cbStaffGender = new ComboBox();
            label51 = new Label();
            label66 = new Label();
            rtbStaffAdress = new RichTextBox();
            label67 = new Label();
            cbStaffRole = new ComboBox();
            cboStaffStatus = new ComboBox();
            txtStaffPhone = new TextBox();
            dtpStaffBornDate = new DateTimePicker();
            groupBox23 = new GroupBox();
            flowLayoutPanel9 = new FlowLayoutPanel();
            btnAddStaff = new Button();
            btnUpdateStaff = new Button();
            tpAccount = new TabPage();
            splitContainer29 = new SplitContainer();
            dtgvAccount = new DataGridView();
            AccountID = new DataGridViewTextBoxColumn();
            accountType = new DataGridViewTextBoxColumn();
            accountStaff = new DataGridViewTextBoxColumn();
            splitContainer30 = new SplitContainer();
            groupBox26 = new GroupBox();
            tableLayoutPanel19 = new TableLayoutPanel();
            label59 = new Label();
            txtSearchLoginName = new TextBox();
            btnSearchAccount = new Button();
            splitContainer31 = new SplitContainer();
            groupBox27 = new GroupBox();
            tableLayoutPanel20 = new TableLayoutPanel();
            label61 = new Label();
            label62 = new Label();
            txtPassword = new TextBox();
            txtLoginName = new TextBox();
            cbAccountType = new ComboBox();
            label64 = new Label();
            label65 = new Label();
            cbAccountStaff = new ComboBox();
            groupBox28 = new GroupBox();
            flowLayoutPanel10 = new FlowLayoutPanel();
            btnAddAccount = new Button();
            btnUpdateAccount = new Button();
            staffBindingSource = new BindingSource(components);
            dataGridView3 = new DataGridView();
            splitContainer8 = new SplitContainer();
            groupBox7 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label14 = new Label();
            textBox11 = new TextBox();
            label15 = new Label();
            label16 = new Label();
            button11 = new Button();
            label17 = new Label();
            dateTimePicker3 = new DateTimePicker();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            label18 = new Label();
            dateTimePicker4 = new DateTimePicker();
            splitContainer9 = new SplitContainer();
            groupBox8 = new GroupBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            label19 = new Label();
            label20 = new Label();
            splitContainer7 = new SplitContainer();
            ofdSelectProductImage = new OpenFileDialog();
            splitContainer26 = new SplitContainer();
            dataGridView8 = new DataGridView();
            splitContainer27 = new SplitContainer();
            groupBox24 = new GroupBox();
            tableLayoutPanel17 = new TableLayoutPanel();
            button34 = new Button();
            label55 = new Label();
            textBox36 = new TextBox();
            textBox37 = new TextBox();
            label56 = new Label();
            splitContainer28 = new SplitContainer();
            groupBox25 = new GroupBox();
            tableLayoutPanel18 = new TableLayoutPanel();
            label57 = new Label();
            label58 = new Label();
            tabPage1 = new TabPage();
            toolStrip1 = new ToolStrip();
            tslStaffName = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbStatistics = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbLogout = new ToolStripButton();
            panel3 = new Panel();
            TabControl.SuspendLayout();
            tpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).BeginInit();
            splitContainer5.Panel1.SuspendLayout();
            splitContainer5.Panel2.SuspendLayout();
            splitContainer5.SuspendLayout();
            groupBox4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer6).BeginInit();
            splitContainer6.Panel1.SuspendLayout();
            splitContainer6.Panel2.SuspendLayout();
            splitContainer6.SuspendLayout();
            groupBox5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            groupBox6.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tpProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer10).BeginInit();
            splitContainer10.Panel1.SuspendLayout();
            splitContainer10.Panel2.SuspendLayout();
            splitContainer10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer11).BeginInit();
            splitContainer11.Panel1.SuspendLayout();
            splitContainer11.Panel2.SuspendLayout();
            splitContainer11.SuspendLayout();
            groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer33).BeginInit();
            splitContainer33.Panel1.SuspendLayout();
            splitContainer33.Panel2.SuspendLayout();
            splitContainer33.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer12).BeginInit();
            splitContainer12.Panel1.SuspendLayout();
            splitContainer12.Panel2.SuspendLayout();
            splitContainer12.SuspendLayout();
            groupBox10.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer32).BeginInit();
            splitContainer32.Panel1.SuspendLayout();
            splitContainer32.Panel2.SuspendLayout();
            splitContainer32.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            groupBox11.SuspendLayout();
            tpManufacturer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer14).BeginInit();
            splitContainer14.Panel1.SuspendLayout();
            splitContainer14.Panel2.SuspendLayout();
            splitContainer14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvManufacturer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer15).BeginInit();
            splitContainer15.Panel1.SuspendLayout();
            splitContainer15.Panel2.SuspendLayout();
            splitContainer15.SuspendLayout();
            groupBox12.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer16).BeginInit();
            splitContainer16.Panel1.SuspendLayout();
            splitContainer16.Panel2.SuspendLayout();
            splitContainer16.SuspendLayout();
            groupBox13.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            groupBox14.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            tpCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer17).BeginInit();
            splitContainer17.Panel1.SuspendLayout();
            splitContainer17.Panel2.SuspendLayout();
            splitContainer17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer18).BeginInit();
            splitContainer18.Panel1.SuspendLayout();
            splitContainer18.Panel2.SuspendLayout();
            splitContainer18.SuspendLayout();
            groupBox15.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer19).BeginInit();
            splitContainer19.Panel1.SuspendLayout();
            splitContainer19.Panel2.SuspendLayout();
            splitContainer19.SuspendLayout();
            groupBox16.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            groupBox17.SuspendLayout();
            tpGRN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer20).BeginInit();
            splitContainer20.Panel1.SuspendLayout();
            splitContainer20.Panel2.SuspendLayout();
            splitContainer20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvGRN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer21).BeginInit();
            splitContainer21.Panel1.SuspendLayout();
            splitContainer21.Panel2.SuspendLayout();
            splitContainer21.SuspendLayout();
            groupBox18.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer22).BeginInit();
            splitContainer22.Panel1.SuspendLayout();
            splitContainer22.Panel2.SuspendLayout();
            splitContainer22.SuspendLayout();
            groupBox19.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            panel4.SuspendLayout();
            groupBox20.SuspendLayout();
            flowLayoutPanel8.SuspendLayout();
            tpStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer23).BeginInit();
            splitContainer23.Panel1.SuspendLayout();
            splitContainer23.Panel2.SuspendLayout();
            splitContainer23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvStaff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer24).BeginInit();
            splitContainer24.Panel1.SuspendLayout();
            splitContainer24.Panel2.SuspendLayout();
            splitContainer24.SuspendLayout();
            groupBox21.SuspendLayout();
            tableLayoutPanel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer25).BeginInit();
            splitContainer25.Panel1.SuspendLayout();
            splitContainer25.Panel2.SuspendLayout();
            splitContainer25.SuspendLayout();
            groupBox22.SuspendLayout();
            tableLayoutPanel16.SuspendLayout();
            groupBox23.SuspendLayout();
            flowLayoutPanel9.SuspendLayout();
            tpAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer29).BeginInit();
            splitContainer29.Panel1.SuspendLayout();
            splitContainer29.Panel2.SuspendLayout();
            splitContainer29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer30).BeginInit();
            splitContainer30.Panel1.SuspendLayout();
            splitContainer30.Panel2.SuspendLayout();
            splitContainer30.SuspendLayout();
            groupBox26.SuspendLayout();
            tableLayoutPanel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer31).BeginInit();
            splitContainer31.Panel1.SuspendLayout();
            splitContainer31.Panel2.SuspendLayout();
            splitContainer31.SuspendLayout();
            groupBox27.SuspendLayout();
            tableLayoutPanel20.SuspendLayout();
            groupBox28.SuspendLayout();
            flowLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)staffBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer8).BeginInit();
            splitContainer8.Panel1.SuspendLayout();
            splitContainer8.SuspendLayout();
            groupBox7.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer9).BeginInit();
            splitContainer9.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer7).BeginInit();
            splitContainer7.Panel1.SuspendLayout();
            splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer26).BeginInit();
            splitContainer26.Panel1.SuspendLayout();
            splitContainer26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer27).BeginInit();
            splitContainer27.Panel1.SuspendLayout();
            splitContainer27.SuspendLayout();
            groupBox24.SuspendLayout();
            tableLayoutPanel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer28).BeginInit();
            splitContainer28.SuspendLayout();
            tableLayoutPanel18.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(tpCustomer);
            TabControl.Controls.Add(tpOrder);
            TabControl.Controls.Add(tpProduct);
            TabControl.Controls.Add(tpManufacturer);
            TabControl.Controls.Add(tpCategory);
            TabControl.Controls.Add(tpGRN);
            TabControl.Controls.Add(tpStaff);
            TabControl.Controls.Add(tpAccount);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(0, 0);
            TabControl.Margin = new Padding(3, 4, 3, 4);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1264, 656);
            TabControl.TabIndex = 0;
            // 
            // tpCustomer
            // 
            tpCustomer.BackColor = Color.Azure;
            tpCustomer.Controls.Add(splitContainer1);
            tpCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tpCustomer.Location = new Point(4, 29);
            tpCustomer.Margin = new Padding(3, 4, 3, 4);
            tpCustomer.Name = "tpCustomer";
            tpCustomer.Padding = new Padding(3, 4, 3, 4);
            tpCustomer.Size = new Size(1256, 623);
            tpCustomer.TabIndex = 0;
            tpCustomer.Text = "Khách hàng";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dtgvCustomer);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Panel2MinSize = 400;
            splitContainer1.Size = new Size(1250, 615);
            splitContainer1.SplitterDistance = 842;
            splitContainer1.TabIndex = 2;
            // 
            // dtgvCustomer
            // 
            dtgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCustomer.BackgroundColor = Color.FromArgb(194, 231, 255);
            dtgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCustomer.Columns.AddRange(new DataGridViewColumn[] { sdt, cusName, cusAddress });
            dtgvCustomer.Dock = DockStyle.Fill;
            dtgvCustomer.Location = new Point(0, 0);
            dtgvCustomer.MultiSelect = false;
            dtgvCustomer.Name = "dtgvCustomer";
            dtgvCustomer.ReadOnly = true;
            dtgvCustomer.RowHeadersWidth = 62;
            dtgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvCustomer.Size = new Size(842, 615);
            dtgvCustomer.TabIndex = 0;
            dtgvCustomer.CellClick += dtgvCustomer_CellClick;
            // 
            // sdt
            // 
            sdt.HeaderText = "SĐT";
            sdt.Name = "sdt";
            sdt.ReadOnly = true;
            // 
            // cusName
            // 
            cusName.HeaderText = "Họ và tên";
            cusName.Name = "cusName";
            cusName.ReadOnly = true;
            // 
            // cusAddress
            // 
            cusAddress.HeaderText = "Địa chỉ";
            cusAddress.Name = "cusAddress";
            cusAddress.ReadOnly = true;
            // 
            // splitContainer2
            // 
            splitContainer2.BackColor = Color.Azure;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.FixedPanel = FixedPanel.Panel1;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(groupBox1);
            splitContainer2.Panel1MinSize = 200;
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer3);
            splitContainer2.Panel2MinSize = 250;
            splitContainer2.Size = new Size(404, 615);
            splitContainer2.SplitterDistance = 211;
            splitContainer2.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Azure;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(404, 211);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bộ lọc tìm kiếm";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77F));
            tableLayoutPanel1.Controls.Add(btnSearchCustomer, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtSearchName, 1, 1);
            tableLayoutPanel1.Controls.Add(txtSearchNumberPhone, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel1.Size = new Size(398, 183);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // btnSearchCustomer
            // 
            btnSearchCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSearchCustomer.ForeColor = Color.Brown;
            btnSearchCustomer.Image = (Image)resources.GetObject("btnSearchCustomer.Image");
            btnSearchCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchCustomer.Location = new Point(94, 113);
            btnSearchCustomer.Name = "btnSearchCustomer";
            btnSearchCustomer.Size = new Size(122, 44);
            btnSearchCustomer.TabIndex = 2;
            btnSearchCustomer.Text = "Tìm kiếm";
            btnSearchCustomer.TextAlign = ContentAlignment.MiddleRight;
            btnSearchCustomer.UseVisualStyleBackColor = true;
            btnSearchCustomer.Click += btnSearchCustomer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 55);
            label1.TabIndex = 0;
            label1.Text = "SDT:";
            // 
            // txtSearchName
            // 
            txtSearchName.BackColor = Color.FromArgb(255, 253, 239);
            txtSearchName.Dock = DockStyle.Fill;
            txtSearchName.Location = new Point(94, 58);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(301, 29);
            txtSearchName.TabIndex = 1;
            // 
            // txtSearchNumberPhone
            // 
            txtSearchNumberPhone.BackColor = Color.FromArgb(255, 253, 239);
            txtSearchNumberPhone.Dock = DockStyle.Fill;
            txtSearchNumberPhone.Location = new Point(94, 3);
            txtSearchNumberPhone.Name = "txtSearchNumberPhone";
            txtSearchNumberPhone.Size = new Size(301, 29);
            txtSearchNumberPhone.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(3, 55);
            label2.Name = "label2";
            label2.Size = new Size(85, 55);
            label2.TabIndex = 0;
            label2.Text = "Họ và tên:";
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.FixedPanel = FixedPanel.Panel1;
            splitContainer3.IsSplitterFixed = true;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(groupBox3);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(groupBox2);
            splitContainer3.Size = new Size(404, 400);
            splitContainer3.SplitterDistance = 248;
            splitContainer3.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Azure;
            groupBox3.Controls.Add(tableLayoutPanel2);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(404, 248);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chi tiết";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Azure;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.75F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.25F));
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(label4, 0, 1);
            tableLayoutPanel2.Controls.Add(label5, 0, 2);
            tableLayoutPanel2.Controls.Add(txtName, 1, 1);
            tableLayoutPanel2.Controls.Add(txtNumberPhone, 1, 0);
            tableLayoutPanel2.Controls.Add(rtbAddress, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 25);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20.5741634F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20.5741634F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 58.3732071F));
            tableLayoutPanel2.Size = new Size(398, 220);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Azure;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 45);
            label3.TabIndex = 0;
            label3.Text = "SDT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(3, 45);
            label4.Name = "label4";
            label4.Size = new Size(84, 45);
            label4.TabIndex = 0;
            label4.Text = "Họ và tên:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Azure;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Brown;
            label5.Location = new Point(3, 90);
            label5.Name = "label5";
            label5.Size = new Size(84, 130);
            label5.TabIndex = 0;
            label5.Text = "Địa chỉ:";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(255, 253, 239);
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(93, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(302, 29);
            txtName.TabIndex = 1;
            // 
            // txtNumberPhone
            // 
            txtNumberPhone.BackColor = Color.FromArgb(255, 253, 239);
            txtNumberPhone.Dock = DockStyle.Fill;
            txtNumberPhone.Location = new Point(93, 3);
            txtNumberPhone.Name = "txtNumberPhone";
            txtNumberPhone.Size = new Size(302, 29);
            txtNumberPhone.TabIndex = 0;
            // 
            // rtbAddress
            // 
            rtbAddress.BackColor = Color.FromArgb(255, 253, 239);
            rtbAddress.Dock = DockStyle.Fill;
            rtbAddress.Location = new Point(93, 93);
            rtbAddress.Name = "rtbAddress";
            rtbAddress.Size = new Size(302, 124);
            rtbAddress.TabIndex = 2;
            rtbAddress.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flowLayoutPanel1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(404, 148);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnAddCustomer);
            flowLayoutPanel1.Controls.Add(btnUpdateCustomer);
            flowLayoutPanel1.Controls.Add(btnCustomerAddOrder);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 25);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(398, 120);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddCustomer.ForeColor = Color.Brown;
            btnAddCustomer.Image = (Image)resources.GetObject("btnAddCustomer.Image");
            btnAddCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddCustomer.Location = new Point(3, 3);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(121, 43);
            btnAddCustomer.TabIndex = 0;
            btnAddCustomer.Text = "Thêm KH";
            btnAddCustomer.TextAlign = ContentAlignment.MiddleRight;
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpdateCustomer.ForeColor = Color.Brown;
            btnUpdateCustomer.Image = (Image)resources.GetObject("btnUpdateCustomer.Image");
            btnUpdateCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateCustomer.Location = new Point(130, 3);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(121, 43);
            btnUpdateCustomer.TabIndex = 1;
            btnUpdateCustomer.Text = "Sửa KH";
            btnUpdateCustomer.TextAlign = ContentAlignment.MiddleRight;
            btnUpdateCustomer.UseVisualStyleBackColor = true;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            // 
            // btnCustomerAddOrder
            // 
            btnCustomerAddOrder.BackColor = Color.FromArgb(194, 231, 255);
            btnCustomerAddOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCustomerAddOrder.ForeColor = Color.Brown;
            btnCustomerAddOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomerAddOrder.ImageKey = "(none)";
            btnCustomerAddOrder.Location = new Point(3, 52);
            btnCustomerAddOrder.Name = "btnCustomerAddOrder";
            btnCustomerAddOrder.Size = new Size(248, 43);
            btnCustomerAddOrder.TabIndex = 2;
            btnCustomerAddOrder.Text = "Thêm đơn hàng";
            btnCustomerAddOrder.UseVisualStyleBackColor = false;
            btnCustomerAddOrder.Click += btnCustomerAddOrder_Click;
            // 
            // tpOrder
            // 
            tpOrder.BackColor = Color.Azure;
            tpOrder.Controls.Add(splitContainer4);
            tpOrder.Location = new Point(4, 24);
            tpOrder.Margin = new Padding(3, 4, 3, 4);
            tpOrder.Name = "tpOrder";
            tpOrder.Padding = new Padding(3, 4, 3, 4);
            tpOrder.Size = new Size(1256, 628);
            tpOrder.TabIndex = 1;
            tpOrder.Text = "Đơn hàng";
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.IsSplitterFixed = true;
            splitContainer4.Location = new Point(3, 4);
            splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(dtgvOrder);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(splitContainer5);
            splitContainer4.Panel2MinSize = 400;
            splitContainer4.Size = new Size(1250, 620);
            splitContainer4.SplitterDistance = 842;
            splitContainer4.TabIndex = 3;
            // 
            // dtgvOrder
            // 
            dtgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvOrder.BackgroundColor = Color.FromArgb(194, 231, 255);
            dtgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvOrder.Columns.AddRange(new DataGridViewColumn[] { OrderID, OrderCustomer, OrderCustomerPhone, OrderStatus, OrderTotal, OrderDate, OrderStaff });
            dtgvOrder.Dock = DockStyle.Fill;
            dtgvOrder.Location = new Point(0, 0);
            dtgvOrder.MultiSelect = false;
            dtgvOrder.Name = "dtgvOrder";
            dtgvOrder.ReadOnly = true;
            dtgvOrder.RowHeadersWidth = 62;
            dtgvOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvOrder.Size = new Size(842, 620);
            dtgvOrder.TabIndex = 0;
            dtgvOrder.CellClick += dtgvOrder_CellClick;
            // 
            // OrderID
            // 
            OrderID.HeaderText = "Mã đơn";
            OrderID.Name = "OrderID";
            OrderID.ReadOnly = true;
            // 
            // OrderCustomer
            // 
            OrderCustomer.HeaderText = "Khách hàng";
            OrderCustomer.Name = "OrderCustomer";
            OrderCustomer.ReadOnly = true;
            // 
            // OrderCustomerPhone
            // 
            OrderCustomerPhone.HeaderText = "SĐT";
            OrderCustomerPhone.Name = "OrderCustomerPhone";
            OrderCustomerPhone.ReadOnly = true;
            // 
            // OrderStatus
            // 
            OrderStatus.HeaderText = "Trạng thái";
            OrderStatus.Name = "OrderStatus";
            OrderStatus.ReadOnly = true;
            // 
            // OrderTotal
            // 
            OrderTotal.HeaderText = "Tổng tiền";
            OrderTotal.Name = "OrderTotal";
            OrderTotal.ReadOnly = true;
            // 
            // OrderDate
            // 
            OrderDate.HeaderText = "Ngày tạo";
            OrderDate.Name = "OrderDate";
            OrderDate.ReadOnly = true;
            // 
            // OrderStaff
            // 
            OrderStaff.HeaderText = "Nhân viên";
            OrderStaff.Name = "OrderStaff";
            OrderStaff.ReadOnly = true;
            // 
            // splitContainer5
            // 
            splitContainer5.Dock = DockStyle.Fill;
            splitContainer5.FixedPanel = FixedPanel.Panel1;
            splitContainer5.IsSplitterFixed = true;
            splitContainer5.Location = new Point(0, 0);
            splitContainer5.Name = "splitContainer5";
            splitContainer5.Orientation = Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            splitContainer5.Panel1.Controls.Add(groupBox4);
            splitContainer5.Panel1MinSize = 200;
            // 
            // splitContainer5.Panel2
            // 
            splitContainer5.Panel2.Controls.Add(splitContainer6);
            splitContainer5.Panel2MinSize = 250;
            splitContainer5.Size = new Size(404, 620);
            splitContainer5.SplitterDistance = 234;
            splitContainer5.TabIndex = 4;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tableLayoutPanel3);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(404, 234);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Bộ lọc tìm kiếm";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.6130657F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.38693F));
            tableLayoutPanel3.Controls.Add(label6, 0, 0);
            tableLayoutPanel3.Controls.Add(txtSearchOrderID, 1, 0);
            tableLayoutPanel3.Controls.Add(label7, 0, 1);
            tableLayoutPanel3.Controls.Add(label11, 0, 2);
            tableLayoutPanel3.Controls.Add(dtpkSearchOrderTo, 1, 2);
            tableLayoutPanel3.Controls.Add(dtpkSearchOrderFrom, 1, 1);
            tableLayoutPanel3.Controls.Add(panel2, 1, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 23);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 51.2605057F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 48.7394943F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayoutPanel3.Size = new Size(398, 208);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label6.ForeColor = Color.Brown;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(84, 40);
            label6.TabIndex = 0;
            label6.Text = "Mã đơn:";
            // 
            // txtSearchOrderID
            // 
            txtSearchOrderID.BackColor = Color.FromArgb(255, 253, 239);
            txtSearchOrderID.Dock = DockStyle.Fill;
            txtSearchOrderID.Location = new Point(93, 3);
            txtSearchOrderID.Name = "txtSearchOrderID";
            txtSearchOrderID.Size = new Size(302, 27);
            txtSearchOrderID.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label7.ForeColor = Color.Brown;
            label7.Location = new Point(3, 40);
            label7.Name = "label7";
            label7.Size = new Size(84, 38);
            label7.TabIndex = 0;
            label7.Text = "Từ ngày:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label11.ForeColor = Color.Brown;
            label11.Location = new Point(3, 78);
            label11.Name = "label11";
            label11.Size = new Size(84, 39);
            label11.TabIndex = 3;
            label11.Text = "Đến ngày:";
            // 
            // dtpkSearchOrderTo
            // 
            dtpkSearchOrderTo.CalendarForeColor = Color.FromArgb(255, 253, 239);
            dtpkSearchOrderTo.CalendarMonthBackground = Color.FromArgb(255, 253, 239);
            dtpkSearchOrderTo.Dock = DockStyle.Fill;
            dtpkSearchOrderTo.Location = new Point(93, 81);
            dtpkSearchOrderTo.Name = "dtpkSearchOrderTo";
            dtpkSearchOrderTo.Size = new Size(302, 27);
            dtpkSearchOrderTo.TabIndex = 2;
            // 
            // dtpkSearchOrderFrom
            // 
            dtpkSearchOrderFrom.CalendarForeColor = Color.FromArgb(255, 253, 239);
            dtpkSearchOrderFrom.CalendarMonthBackground = Color.FromArgb(255, 253, 239);
            dtpkSearchOrderFrom.Dock = DockStyle.Fill;
            dtpkSearchOrderFrom.Location = new Point(93, 43);
            dtpkSearchOrderFrom.Name = "dtpkSearchOrderFrom";
            dtpkSearchOrderFrom.Size = new Size(302, 27);
            dtpkSearchOrderFrom.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSearchOrderCancel);
            panel2.Controls.Add(btnSearchOrder);
            panel2.Location = new Point(93, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 85);
            panel2.TabIndex = 10;
            // 
            // btnSearchOrderCancel
            // 
            btnSearchOrderCancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnSearchOrderCancel.ForeColor = Color.Brown;
            btnSearchOrderCancel.Image = (Image)resources.GetObject("btnSearchOrderCancel.Image");
            btnSearchOrderCancel.Location = new Point(184, 3);
            btnSearchOrderCancel.Name = "btnSearchOrderCancel";
            btnSearchOrderCancel.Size = new Size(43, 43);
            btnSearchOrderCancel.TabIndex = 1;
            btnSearchOrderCancel.UseVisualStyleBackColor = true;
            btnSearchOrderCancel.Click += btnSearchOrderCancel_Click;
            // 
            // btnSearchOrder
            // 
            btnSearchOrder.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnSearchOrder.ForeColor = Color.Brown;
            btnSearchOrder.Image = (Image)resources.GetObject("btnSearchOrder.Image");
            btnSearchOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchOrder.Location = new Point(3, 3);
            btnSearchOrder.Name = "btnSearchOrder";
            btnSearchOrder.Size = new Size(121, 43);
            btnSearchOrder.TabIndex = 0;
            btnSearchOrder.Text = "Tìm kiếm";
            btnSearchOrder.TextAlign = ContentAlignment.MiddleRight;
            btnSearchOrder.UseVisualStyleBackColor = true;
            btnSearchOrder.Click += btnSearchOrder_Click;
            // 
            // splitContainer6
            // 
            splitContainer6.Dock = DockStyle.Fill;
            splitContainer6.FixedPanel = FixedPanel.Panel1;
            splitContainer6.IsSplitterFixed = true;
            splitContainer6.Location = new Point(0, 0);
            splitContainer6.Name = "splitContainer6";
            splitContainer6.Orientation = Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            splitContainer6.Panel1.Controls.Add(groupBox5);
            // 
            // splitContainer6.Panel2
            // 
            splitContainer6.Panel2.Controls.Add(groupBox6);
            splitContainer6.Size = new Size(404, 382);
            splitContainer6.SplitterDistance = 248;
            splitContainer6.TabIndex = 1;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(tableLayoutPanel4);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Location = new Point(0, 0);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(404, 248);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Thông tin";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.75F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.25F));
            tableLayoutPanel4.Controls.Add(label8, 0, 0);
            tableLayoutPanel4.Controls.Add(label9, 0, 1);
            tableLayoutPanel4.Controls.Add(label10, 0, 2);
            tableLayoutPanel4.Controls.Add(label39, 0, 3);
            tableLayoutPanel4.Controls.Add(panel6, 0, 4);
            tableLayoutPanel4.Controls.Add(panel5, 1, 4);
            tableLayoutPanel4.Controls.Add(txtOrderCustomerName, 1, 1);
            tableLayoutPanel4.Controls.Add(txtOrderStaff, 1, 2);
            tableLayoutPanel4.Controls.Add(txtOrderStatus, 1, 3);
            tableLayoutPanel4.Controls.Add(txtOrderID, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 23);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.6134453F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 34.45378F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 31.9327736F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel4.Size = new Size(398, 222);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label8.ForeColor = Color.Brown;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(84, 41);
            label8.TabIndex = 0;
            label8.Text = "Mã đơn:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label9.ForeColor = Color.Brown;
            label9.Location = new Point(3, 41);
            label9.Name = "label9";
            label9.Size = new Size(84, 42);
            label9.TabIndex = 0;
            label9.Text = "Tên KH:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label10.ForeColor = Color.Brown;
            label10.Location = new Point(3, 83);
            label10.Name = "label10";
            label10.Size = new Size(84, 39);
            label10.TabIndex = 0;
            label10.Text = "Nhân viên:";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Dock = DockStyle.Fill;
            label39.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label39.ForeColor = Color.Brown;
            label39.Location = new Point(3, 122);
            label39.Name = "label39";
            label39.Size = new Size(84, 40);
            label39.TabIndex = 3;
            label39.Text = "Trạng thái:";
            // 
            // panel6
            // 
            panel6.Controls.Add(label69);
            panel6.Location = new Point(3, 165);
            panel6.Name = "panel6";
            panel6.Size = new Size(84, 54);
            panel6.TabIndex = 10;
            // 
            // label69
            // 
            label69.AutoSize = true;
            label69.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label69.ForeColor = Color.Brown;
            label69.Location = new Point(0, 3);
            label69.Name = "label69";
            label69.Size = new Size(80, 20);
            label69.TabIndex = 3;
            label69.Text = "Tổng tiền:";
            // 
            // panel5
            // 
            panel5.Controls.Add(txtOrderTotal);
            panel5.Controls.Add(label13);
            panel5.Location = new Point(93, 165);
            panel5.Name = "panel5";
            panel5.Size = new Size(302, 44);
            panel5.TabIndex = 12;
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtOrderTotal.BackColor = Color.FromArgb(255, 253, 239);
            txtOrderTotal.BorderStyle = BorderStyle.Fixed3D;
            txtOrderTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtOrderTotal.ForeColor = Color.Black;
            txtOrderTotal.Location = new Point(0, 6);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.Size = new Size(251, 22);
            txtOrderTotal.TabIndex = 0;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label13.ForeColor = Color.Brown;
            label13.Location = new Point(257, 6);
            label13.Name = "label13";
            label13.Size = new Size(42, 20);
            label13.TabIndex = 7;
            label13.Text = "VNĐ";
            // 
            // txtOrderCustomerName
            // 
            txtOrderCustomerName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtOrderCustomerName.BackColor = Color.FromArgb(255, 253, 239);
            txtOrderCustomerName.BorderStyle = BorderStyle.Fixed3D;
            txtOrderCustomerName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtOrderCustomerName.ForeColor = Color.Black;
            txtOrderCustomerName.Location = new Point(93, 41);
            txtOrderCustomerName.Name = "txtOrderCustomerName";
            txtOrderCustomerName.Size = new Size(302, 28);
            txtOrderCustomerName.TabIndex = 1;
            // 
            // txtOrderStaff
            // 
            txtOrderStaff.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtOrderStaff.BackColor = Color.FromArgb(255, 253, 239);
            txtOrderStaff.BorderStyle = BorderStyle.Fixed3D;
            txtOrderStaff.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtOrderStaff.ForeColor = Color.Black;
            txtOrderStaff.Location = new Point(93, 83);
            txtOrderStaff.Name = "txtOrderStaff";
            txtOrderStaff.Size = new Size(302, 28);
            txtOrderStaff.TabIndex = 2;
            // 
            // txtOrderStatus
            // 
            txtOrderStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtOrderStatus.BackColor = Color.FromArgb(255, 253, 239);
            txtOrderStatus.BorderStyle = BorderStyle.Fixed3D;
            txtOrderStatus.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtOrderStatus.ForeColor = Color.Black;
            txtOrderStatus.Location = new Point(93, 122);
            txtOrderStatus.Name = "txtOrderStatus";
            txtOrderStatus.Size = new Size(302, 28);
            txtOrderStatus.TabIndex = 3;
            // 
            // txtOrderID
            // 
            txtOrderID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtOrderID.BackColor = Color.FromArgb(255, 253, 239);
            txtOrderID.BorderStyle = BorderStyle.Fixed3D;
            txtOrderID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtOrderID.ForeColor = Color.Black;
            txtOrderID.Location = new Point(93, 0);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(302, 28);
            txtOrderID.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(flowLayoutPanel2);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.Location = new Point(0, 0);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(404, 130);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "Chức năng";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnAddOrder);
            flowLayoutPanel2.Controls.Add(btnView);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 23);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(398, 104);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnAddOrder.ForeColor = Color.Brown;
            btnAddOrder.Image = (Image)resources.GetObject("btnAddOrder.Image");
            btnAddOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddOrder.Location = new Point(3, 3);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(121, 43);
            btnAddOrder.TabIndex = 0;
            btnAddOrder.Text = "Thêm đơn";
            btnAddOrder.TextAlign = ContentAlignment.MiddleRight;
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // btnView
            // 
            btnView.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnView.ForeColor = Color.Brown;
            btnView.Location = new Point(130, 3);
            btnView.Name = "btnView";
            btnView.Size = new Size(121, 43);
            btnView.TabIndex = 1;
            btnView.Text = "Xem chi tiết";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // tpProduct
            // 
            tpProduct.BackColor = Color.Azure;
            tpProduct.Controls.Add(splitContainer10);
            tpProduct.Location = new Point(4, 24);
            tpProduct.Name = "tpProduct";
            tpProduct.Padding = new Padding(3);
            tpProduct.Size = new Size(1256, 628);
            tpProduct.TabIndex = 2;
            tpProduct.Text = "Sản phẩm";
            // 
            // splitContainer10
            // 
            splitContainer10.Dock = DockStyle.Fill;
            splitContainer10.IsSplitterFixed = true;
            splitContainer10.Location = new Point(3, 3);
            splitContainer10.Name = "splitContainer10";
            // 
            // splitContainer10.Panel1
            // 
            splitContainer10.Panel1.Controls.Add(flpProduct);
            // 
            // splitContainer10.Panel2
            // 
            splitContainer10.Panel2.Controls.Add(splitContainer11);
            splitContainer10.Panel2MinSize = 400;
            splitContainer10.Size = new Size(1250, 622);
            splitContainer10.SplitterDistance = 846;
            splitContainer10.TabIndex = 4;
            // 
            // flpProduct
            // 
            flpProduct.AutoScroll = true;
            flpProduct.BackColor = Color.FromArgb(194, 231, 255);
            flpProduct.Dock = DockStyle.Fill;
            flpProduct.Location = new Point(0, 0);
            flpProduct.Name = "flpProduct";
            flpProduct.Size = new Size(846, 622);
            flpProduct.TabIndex = 0;
            // 
            // splitContainer11
            // 
            splitContainer11.Dock = DockStyle.Fill;
            splitContainer11.FixedPanel = FixedPanel.Panel1;
            splitContainer11.IsSplitterFixed = true;
            splitContainer11.Location = new Point(0, 0);
            splitContainer11.Name = "splitContainer11";
            splitContainer11.Orientation = Orientation.Horizontal;
            // 
            // splitContainer11.Panel1
            // 
            splitContainer11.Panel1.Controls.Add(groupBox9);
            splitContainer11.Panel1MinSize = 80;
            // 
            // splitContainer11.Panel2
            // 
            splitContainer11.Panel2.Controls.Add(splitContainer12);
            splitContainer11.Panel2MinSize = 80;
            splitContainer11.Size = new Size(400, 622);
            splitContainer11.SplitterDistance = 92;
            splitContainer11.TabIndex = 4;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(splitContainer33);
            groupBox9.Dock = DockStyle.Fill;
            groupBox9.Location = new Point(0, 0);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(400, 92);
            groupBox9.TabIndex = 0;
            groupBox9.TabStop = false;
            groupBox9.Text = "Bộ lọc tìm kiếm";
            // 
            // splitContainer33
            // 
            splitContainer33.Dock = DockStyle.Fill;
            splitContainer33.IsSplitterFixed = true;
            splitContainer33.Location = new Point(3, 23);
            splitContainer33.Name = "splitContainer33";
            // 
            // splitContainer33.Panel1
            // 
            splitContainer33.Panel1.Controls.Add(tableLayoutPanel7);
            // 
            // splitContainer33.Panel2
            // 
            splitContainer33.Panel2.Controls.Add(btnSearchProduct);
            splitContainer33.Size = new Size(394, 66);
            splitContainer33.SplitterDistance = 275;
            splitContainer33.TabIndex = 4;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.81818F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.1818161F));
            tableLayoutPanel7.Controls.Add(label21, 0, 0);
            tableLayoutPanel7.Controls.Add(txtSearchProductID, 1, 0);
            tableLayoutPanel7.Controls.Add(label22, 0, 1);
            tableLayoutPanel7.Controls.Add(txtSearchProductName, 1, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(275, 66);
            tableLayoutPanel7.TabIndex = 3;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Dock = DockStyle.Fill;
            label21.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label21.ForeColor = Color.Brown;
            label21.Location = new Point(3, 0);
            label21.Name = "label21";
            label21.Size = new Size(87, 33);
            label21.TabIndex = 0;
            label21.Text = "Mã SP:";
            // 
            // txtSearchProductID
            // 
            txtSearchProductID.BackColor = Color.FromArgb(255, 253, 239);
            txtSearchProductID.Dock = DockStyle.Fill;
            txtSearchProductID.Location = new Point(96, 3);
            txtSearchProductID.Name = "txtSearchProductID";
            txtSearchProductID.Size = new Size(176, 27);
            txtSearchProductID.TabIndex = 0;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Dock = DockStyle.Fill;
            label22.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label22.ForeColor = Color.Brown;
            label22.Location = new Point(3, 33);
            label22.Name = "label22";
            label22.Size = new Size(87, 33);
            label22.TabIndex = 0;
            label22.Text = "Tên SP:";
            // 
            // txtSearchProductName
            // 
            txtSearchProductName.BackColor = Color.FromArgb(255, 253, 239);
            txtSearchProductName.Dock = DockStyle.Fill;
            txtSearchProductName.Location = new Point(96, 36);
            txtSearchProductName.Name = "txtSearchProductName";
            txtSearchProductName.Size = new Size(176, 27);
            txtSearchProductName.TabIndex = 1;
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnSearchProduct.ForeColor = Color.Brown;
            btnSearchProduct.Image = (Image)resources.GetObject("btnSearchProduct.Image");
            btnSearchProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchProduct.Location = new Point(2, 3);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new Size(110, 60);
            btnSearchProduct.TabIndex = 0;
            btnSearchProduct.Text = "Tìm kiếm";
            btnSearchProduct.TextAlign = ContentAlignment.MiddleRight;
            btnSearchProduct.UseVisualStyleBackColor = true;
            btnSearchProduct.Click += btnSearchProduct_Click;
            // 
            // splitContainer12
            // 
            splitContainer12.Dock = DockStyle.Fill;
            splitContainer12.FixedPanel = FixedPanel.Panel1;
            splitContainer12.Location = new Point(0, 0);
            splitContainer12.Name = "splitContainer12";
            splitContainer12.Orientation = Orientation.Horizontal;
            // 
            // splitContainer12.Panel1
            // 
            splitContainer12.Panel1.Controls.Add(groupBox10);
            // 
            // splitContainer12.Panel2
            // 
            splitContainer12.Panel2.Controls.Add(splitContainer32);
            splitContainer12.Size = new Size(400, 526);
            splitContainer12.SplitterDistance = 310;
            splitContainer12.TabIndex = 1;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(tableLayoutPanel8);
            groupBox10.Dock = DockStyle.Fill;
            groupBox10.Location = new Point(0, 0);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(400, 310);
            groupBox10.TabIndex = 0;
            groupBox10.TabStop = false;
            groupBox10.Text = "Thông tin";
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.3502541F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.64975F));
            tableLayoutPanel8.Controls.Add(label26, 0, 0);
            tableLayoutPanel8.Controls.Add(label27, 0, 1);
            tableLayoutPanel8.Controls.Add(label28, 0, 2);
            tableLayoutPanel8.Controls.Add(txtProductName, 1, 1);
            tableLayoutPanel8.Controls.Add(rtbProductInfomation, 1, 3);
            tableLayoutPanel8.Controls.Add(label25, 0, 4);
            tableLayoutPanel8.Controls.Add(cbProductCategory, 1, 4);
            tableLayoutPanel8.Controls.Add(label34, 0, 5);
            tableLayoutPanel8.Controls.Add(cbProductManufacturer, 1, 5);
            tableLayoutPanel8.Controls.Add(label35, 0, 6);
            tableLayoutPanel8.Controls.Add(panel, 1, 6);
            tableLayoutPanel8.Controls.Add(label23, 0, 3);
            tableLayoutPanel8.Controls.Add(txtProductID, 1, 0);
            tableLayoutPanel8.Controls.Add(txtProductQuantity, 1, 2);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 23);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 7;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 33.0188675F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 34.90566F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 32.07547F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel8.Size = new Size(394, 284);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Dock = DockStyle.Fill;
            label26.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label26.ForeColor = Color.Brown;
            label26.Location = new Point(3, 0);
            label26.Name = "label26";
            label26.Size = new Size(86, 35);
            label26.TabIndex = 0;
            label26.Text = "Mã SP:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Dock = DockStyle.Fill;
            label27.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label27.ForeColor = Color.Brown;
            label27.Location = new Point(3, 35);
            label27.Name = "label27";
            label27.Size = new Size(86, 37);
            label27.TabIndex = 0;
            label27.Text = "Tên SP:";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Dock = DockStyle.Fill;
            label28.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label28.ForeColor = Color.Brown;
            label28.Location = new Point(3, 72);
            label28.Name = "label28";
            label28.Size = new Size(86, 34);
            label28.TabIndex = 0;
            label28.Text = "Số lượng:";
            // 
            // txtProductName
            // 
            txtProductName.BackColor = Color.FromArgb(255, 253, 239);
            txtProductName.Dock = DockStyle.Fill;
            txtProductName.Location = new Point(95, 38);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(296, 27);
            txtProductName.TabIndex = 1;
            // 
            // rtbProductInfomation
            // 
            rtbProductInfomation.BackColor = Color.FromArgb(255, 253, 239);
            rtbProductInfomation.Dock = DockStyle.Fill;
            rtbProductInfomation.Location = new Point(95, 109);
            rtbProductInfomation.Name = "rtbProductInfomation";
            rtbProductInfomation.Size = new Size(296, 62);
            rtbProductInfomation.TabIndex = 3;
            rtbProductInfomation.Text = "";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label25.ForeColor = Color.Brown;
            label25.Location = new Point(3, 174);
            label25.Name = "label25";
            label25.Size = new Size(84, 20);
            label25.TabIndex = 7;
            label25.Text = "Danh mục:";
            // 
            // cbProductCategory
            // 
            cbProductCategory.BackColor = Color.FromArgb(255, 253, 239);
            cbProductCategory.Dock = DockStyle.Fill;
            cbProductCategory.FormattingEnabled = true;
            cbProductCategory.Location = new Point(95, 177);
            cbProductCategory.Name = "cbProductCategory";
            cbProductCategory.Size = new Size(296, 28);
            cbProductCategory.TabIndex = 4;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label34.ForeColor = Color.Brown;
            label34.Location = new Point(3, 210);
            label34.Name = "label34";
            label34.Size = new Size(72, 20);
            label34.TabIndex = 9;
            label34.Text = "Hãng SX:";
            // 
            // cbProductManufacturer
            // 
            cbProductManufacturer.BackColor = Color.FromArgb(255, 253, 239);
            cbProductManufacturer.Dock = DockStyle.Fill;
            cbProductManufacturer.FormattingEnabled = true;
            cbProductManufacturer.Location = new Point(95, 213);
            cbProductManufacturer.Name = "cbProductManufacturer";
            cbProductManufacturer.Size = new Size(296, 28);
            cbProductManufacturer.TabIndex = 5;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label35.ForeColor = Color.Brown;
            label35.Location = new Point(3, 244);
            label35.Name = "label35";
            label35.Size = new Size(36, 20);
            label35.TabIndex = 10;
            label35.Text = "Giá:";
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel.Controls.Add(label60);
            panel.Controls.Add(txtProductPrice);
            panel.Location = new Point(95, 247);
            panel.Name = "panel";
            panel.Size = new Size(296, 34);
            panel.TabIndex = 14;
            // 
            // label60
            // 
            label60.AutoSize = true;
            label60.Dock = DockStyle.Right;
            label60.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label60.ForeColor = Color.Brown;
            label60.Location = new Point(254, 0);
            label60.Name = "label60";
            label60.Size = new Size(42, 20);
            label60.TabIndex = 7;
            label60.Text = "VNĐ";
            // 
            // txtProductPrice
            // 
            txtProductPrice.BackColor = Color.FromArgb(255, 253, 239);
            txtProductPrice.Dock = DockStyle.Left;
            txtProductPrice.Location = new Point(0, 0);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(248, 27);
            txtProductPrice.TabIndex = 0;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label23.ForeColor = Color.Brown;
            label23.Location = new Point(3, 106);
            label23.Name = "label23";
            label23.Size = new Size(63, 20);
            label23.TabIndex = 3;
            label23.Text = "Chi tiết:";
            // 
            // txtProductID
            // 
            txtProductID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtProductID.BackColor = Color.FromArgb(255, 253, 239);
            txtProductID.BorderStyle = BorderStyle.Fixed3D;
            txtProductID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtProductID.ForeColor = Color.Black;
            txtProductID.Location = new Point(95, 0);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(296, 28);
            txtProductID.TabIndex = 0;
            // 
            // txtProductQuantity
            // 
            txtProductQuantity.BackColor = Color.FromArgb(255, 253, 239);
            txtProductQuantity.Dock = DockStyle.Fill;
            txtProductQuantity.Location = new Point(95, 75);
            txtProductQuantity.Name = "txtProductQuantity";
            txtProductQuantity.Size = new Size(296, 27);
            txtProductQuantity.TabIndex = 1;
            // 
            // splitContainer32
            // 
            splitContainer32.Dock = DockStyle.Fill;
            splitContainer32.FixedPanel = FixedPanel.Panel2;
            splitContainer32.IsSplitterFixed = true;
            splitContainer32.Location = new Point(0, 0);
            splitContainer32.Name = "splitContainer32";
            splitContainer32.Orientation = Orientation.Horizontal;
            // 
            // splitContainer32.Panel1
            // 
            splitContainer32.Panel1.Controls.Add(panel7);
            // 
            // splitContainer32.Panel2
            // 
            splitContainer32.Panel2.Controls.Add(groupBox11);
            splitContainer32.Panel2MinSize = 80;
            splitContainer32.Size = new Size(400, 212);
            splitContainer32.SplitterDistance = 128;
            splitContainer32.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Controls.Add(pbProductImage);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(400, 128);
            panel7.TabIndex = 1;
            // 
            // pbProductImage
            // 
            pbProductImage.BackgroundImageLayout = ImageLayout.None;
            pbProductImage.BorderStyle = BorderStyle.FixedSingle;
            pbProductImage.Dock = DockStyle.Fill;
            pbProductImage.Location = new Point(0, 0);
            pbProductImage.Name = "pbProductImage";
            pbProductImage.Size = new Size(400, 128);
            pbProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProductImage.TabIndex = 0;
            pbProductImage.TabStop = false;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(btnSelectProductImage);
            groupBox11.Controls.Add(btnDeleteProductImage);
            groupBox11.Controls.Add(btnUpdateProduct);
            groupBox11.Controls.Add(btnAddProduct);
            groupBox11.Dock = DockStyle.Fill;
            groupBox11.Location = new Point(0, 0);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(400, 80);
            groupBox11.TabIndex = 0;
            groupBox11.TabStop = false;
            groupBox11.Text = "Chức năng";
            // 
            // btnSelectProductImage
            // 
            btnSelectProductImage.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnSelectProductImage.ForeColor = Color.Brown;
            btnSelectProductImage.Location = new Point(6, 22);
            btnSelectProductImage.Name = "btnSelectProductImage";
            btnSelectProductImage.Size = new Size(90, 43);
            btnSelectProductImage.TabIndex = 0;
            btnSelectProductImage.Text = "Chọn hình";
            btnSelectProductImage.UseVisualStyleBackColor = true;
            btnSelectProductImage.Click += btnSelectProductImage_Click;
            // 
            // btnDeleteProductImage
            // 
            btnDeleteProductImage.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnDeleteProductImage.ForeColor = Color.Brown;
            btnDeleteProductImage.Location = new Point(102, 22);
            btnDeleteProductImage.Name = "btnDeleteProductImage";
            btnDeleteProductImage.Size = new Size(90, 43);
            btnDeleteProductImage.TabIndex = 1;
            btnDeleteProductImage.Text = "Xóa hình";
            btnDeleteProductImage.UseVisualStyleBackColor = true;
            btnDeleteProductImage.Click += btnDeleteProductImage_Click;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.BackColor = Color.FromArgb(194, 231, 255);
            btnUpdateProduct.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnUpdateProduct.ForeColor = Color.Brown;
            btnUpdateProduct.Location = new Point(307, 22);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(90, 43);
            btnUpdateProduct.TabIndex = 3;
            btnUpdateProduct.Text = "Sửa SP";
            btnUpdateProduct.UseVisualStyleBackColor = false;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.FromArgb(194, 231, 255);
            btnAddProduct.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnAddProduct.ForeColor = Color.Brown;
            btnAddProduct.Location = new Point(211, 22);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(90, 43);
            btnAddProduct.TabIndex = 2;
            btnAddProduct.Text = "Thêm SP";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // tpManufacturer
            // 
            tpManufacturer.BackColor = Color.Azure;
            tpManufacturer.Controls.Add(splitContainer14);
            tpManufacturer.Location = new Point(4, 24);
            tpManufacturer.Name = "tpManufacturer";
            tpManufacturer.Padding = new Padding(3);
            tpManufacturer.Size = new Size(1256, 628);
            tpManufacturer.TabIndex = 3;
            tpManufacturer.Text = "Hãng SX";
            // 
            // splitContainer14
            // 
            splitContainer14.Dock = DockStyle.Fill;
            splitContainer14.IsSplitterFixed = true;
            splitContainer14.Location = new Point(3, 3);
            splitContainer14.Name = "splitContainer14";
            // 
            // splitContainer14.Panel1
            // 
            splitContainer14.Panel1.Controls.Add(dtgvManufacturer);
            // 
            // splitContainer14.Panel2
            // 
            splitContainer14.Panel2.Controls.Add(splitContainer15);
            splitContainer14.Panel2MinSize = 400;
            splitContainer14.Size = new Size(1250, 622);
            splitContainer14.SplitterDistance = 842;
            splitContainer14.TabIndex = 3;
            // 
            // dtgvManufacturer
            // 
            dtgvManufacturer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvManufacturer.BackgroundColor = Color.FromArgb(194, 231, 255);
            dtgvManufacturer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvManufacturer.Columns.AddRange(new DataGridViewColumn[] { ManuID, ManuName });
            dtgvManufacturer.Dock = DockStyle.Fill;
            dtgvManufacturer.Location = new Point(0, 0);
            dtgvManufacturer.MultiSelect = false;
            dtgvManufacturer.Name = "dtgvManufacturer";
            dtgvManufacturer.ReadOnly = true;
            dtgvManufacturer.RowHeadersWidth = 62;
            dtgvManufacturer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvManufacturer.Size = new Size(842, 622);
            dtgvManufacturer.TabIndex = 0;
            dtgvManufacturer.CellClick += dtgvManufacturer_CellClick;
            // 
            // ManuID
            // 
            ManuID.HeaderText = "Mã hãng SX";
            ManuID.Name = "ManuID";
            ManuID.ReadOnly = true;
            // 
            // ManuName
            // 
            ManuName.HeaderText = "Tên hãng";
            ManuName.Name = "ManuName";
            ManuName.ReadOnly = true;
            // 
            // splitContainer15
            // 
            splitContainer15.Dock = DockStyle.Fill;
            splitContainer15.FixedPanel = FixedPanel.Panel1;
            splitContainer15.IsSplitterFixed = true;
            splitContainer15.Location = new Point(0, 0);
            splitContainer15.Name = "splitContainer15";
            splitContainer15.Orientation = Orientation.Horizontal;
            // 
            // splitContainer15.Panel1
            // 
            splitContainer15.Panel1.Controls.Add(groupBox12);
            splitContainer15.Panel1MinSize = 200;
            // 
            // splitContainer15.Panel2
            // 
            splitContainer15.Panel2.Controls.Add(splitContainer16);
            splitContainer15.Panel2MinSize = 250;
            splitContainer15.Size = new Size(404, 622);
            splitContainer15.SplitterDistance = 211;
            splitContainer15.TabIndex = 4;
            // 
            // groupBox12
            // 
            groupBox12.Controls.Add(tableLayoutPanel9);
            groupBox12.Dock = DockStyle.Fill;
            groupBox12.Location = new Point(0, 0);
            groupBox12.Name = "groupBox12";
            groupBox12.Size = new Size(404, 211);
            groupBox12.TabIndex = 0;
            groupBox12.TabStop = false;
            groupBox12.Text = "Bộ lọc tìm kiếm";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77F));
            tableLayoutPanel9.Controls.Add(btnSearchManufacturer, 1, 2);
            tableLayoutPanel9.Controls.Add(label29, 0, 0);
            tableLayoutPanel9.Controls.Add(txtSearchManuName, 1, 1);
            tableLayoutPanel9.Controls.Add(txtSearchManuID, 1, 0);
            tableLayoutPanel9.Controls.Add(label30, 0, 1);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 23);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 3;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tableLayoutPanel9.Size = new Size(398, 185);
            tableLayoutPanel9.TabIndex = 3;
            // 
            // btnSearchManufacturer
            // 
            btnSearchManufacturer.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnSearchManufacturer.ForeColor = Color.Brown;
            btnSearchManufacturer.Image = (Image)resources.GetObject("btnSearchManufacturer.Image");
            btnSearchManufacturer.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchManufacturer.Location = new Point(94, 107);
            btnSearchManufacturer.Name = "btnSearchManufacturer";
            btnSearchManufacturer.Size = new Size(110, 44);
            btnSearchManufacturer.TabIndex = 2;
            btnSearchManufacturer.Text = "Tìm kiếm";
            btnSearchManufacturer.TextAlign = ContentAlignment.MiddleRight;
            btnSearchManufacturer.UseVisualStyleBackColor = true;
            btnSearchManufacturer.Click += btnSearchManufactuer_Click;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Dock = DockStyle.Fill;
            label29.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label29.ForeColor = Color.Brown;
            label29.Location = new Point(3, 0);
            label29.Name = "label29";
            label29.Size = new Size(85, 52);
            label29.TabIndex = 0;
            label29.Text = "Mã hãng:";
            // 
            // txtSearchManuName
            // 
            txtSearchManuName.BackColor = Color.FromArgb(255, 253, 239);
            txtSearchManuName.Dock = DockStyle.Fill;
            txtSearchManuName.Location = new Point(94, 55);
            txtSearchManuName.Name = "txtSearchManuName";
            txtSearchManuName.Size = new Size(301, 27);
            txtSearchManuName.TabIndex = 1;
            // 
            // txtSearchManuID
            // 
            txtSearchManuID.BackColor = Color.FromArgb(255, 253, 239);
            txtSearchManuID.Dock = DockStyle.Fill;
            txtSearchManuID.Location = new Point(94, 3);
            txtSearchManuID.Name = "txtSearchManuID";
            txtSearchManuID.Size = new Size(301, 27);
            txtSearchManuID.TabIndex = 0;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Dock = DockStyle.Fill;
            label30.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label30.ForeColor = Color.Brown;
            label30.Location = new Point(3, 52);
            label30.Name = "label30";
            label30.Size = new Size(85, 52);
            label30.TabIndex = 0;
            label30.Text = "Tên hãng:";
            // 
            // splitContainer16
            // 
            splitContainer16.Dock = DockStyle.Fill;
            splitContainer16.FixedPanel = FixedPanel.Panel1;
            splitContainer16.IsSplitterFixed = true;
            splitContainer16.Location = new Point(0, 0);
            splitContainer16.Name = "splitContainer16";
            splitContainer16.Orientation = Orientation.Horizontal;
            // 
            // splitContainer16.Panel1
            // 
            splitContainer16.Panel1.Controls.Add(groupBox13);
            // 
            // splitContainer16.Panel2
            // 
            splitContainer16.Panel2.Controls.Add(groupBox14);
            splitContainer16.Size = new Size(404, 407);
            splitContainer16.SplitterDistance = 248;
            splitContainer16.TabIndex = 1;
            // 
            // groupBox13
            // 
            groupBox13.Controls.Add(tableLayoutPanel10);
            groupBox13.Dock = DockStyle.Fill;
            groupBox13.Location = new Point(0, 0);
            groupBox13.Name = "groupBox13";
            groupBox13.Size = new Size(404, 248);
            groupBox13.TabIndex = 0;
            groupBox13.TabStop = false;
            groupBox13.Text = "Chi tiết";
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 2;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.75F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.25F));
            tableLayoutPanel10.Controls.Add(label31, 0, 0);
            tableLayoutPanel10.Controls.Add(label32, 0, 1);
            tableLayoutPanel10.Controls.Add(txtManufacturerName, 1, 1);
            tableLayoutPanel10.Controls.Add(txtManufacturerID, 1, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(3, 23);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 3;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 20.5741634F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 20.5741634F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 58.3732071F));
            tableLayoutPanel10.Size = new Size(398, 222);
            tableLayoutPanel10.TabIndex = 0;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Dock = DockStyle.Fill;
            label31.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label31.ForeColor = Color.Brown;
            label31.Location = new Point(3, 0);
            label31.Name = "label31";
            label31.Size = new Size(84, 45);
            label31.TabIndex = 0;
            label31.Text = "Mã hãng:";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Dock = DockStyle.Fill;
            label32.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label32.ForeColor = Color.Brown;
            label32.Location = new Point(3, 45);
            label32.Name = "label32";
            label32.Size = new Size(84, 45);
            label32.TabIndex = 0;
            label32.Text = "Tên hãng:";
            // 
            // txtManufacturerName
            // 
            txtManufacturerName.BackColor = Color.FromArgb(255, 253, 239);
            txtManufacturerName.Dock = DockStyle.Fill;
            txtManufacturerName.Location = new Point(93, 48);
            txtManufacturerName.Name = "txtManufacturerName";
            txtManufacturerName.Size = new Size(302, 27);
            txtManufacturerName.TabIndex = 1;
            // 
            // txtManufacturerID
            // 
            txtManufacturerID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtManufacturerID.BackColor = Color.FromArgb(255, 253, 239);
            txtManufacturerID.BorderStyle = BorderStyle.Fixed3D;
            txtManufacturerID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtManufacturerID.ForeColor = Color.Black;
            txtManufacturerID.Location = new Point(93, 0);
            txtManufacturerID.Name = "txtManufacturerID";
            txtManufacturerID.Size = new Size(302, 28);
            txtManufacturerID.TabIndex = 0;
            // 
            // groupBox14
            // 
            groupBox14.Controls.Add(flowLayoutPanel6);
            groupBox14.Dock = DockStyle.Fill;
            groupBox14.Location = new Point(0, 0);
            groupBox14.Name = "groupBox14";
            groupBox14.Size = new Size(404, 155);
            groupBox14.TabIndex = 2;
            groupBox14.TabStop = false;
            groupBox14.Text = "Chức năng";
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(btnAddManufacturer);
            flowLayoutPanel6.Controls.Add(btnUpdateManufacturer);
            flowLayoutPanel6.Dock = DockStyle.Fill;
            flowLayoutPanel6.Location = new Point(3, 23);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(398, 129);
            flowLayoutPanel6.TabIndex = 0;
            // 
            // btnAddManufacturer
            // 
            btnAddManufacturer.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnAddManufacturer.ForeColor = Color.Brown;
            btnAddManufacturer.Image = (Image)resources.GetObject("btnAddManufacturer.Image");
            btnAddManufacturer.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddManufacturer.Location = new Point(3, 3);
            btnAddManufacturer.Name = "btnAddManufacturer";
            btnAddManufacturer.Size = new Size(121, 43);
            btnAddManufacturer.TabIndex = 0;
            btnAddManufacturer.Text = "Thêm hãng";
            btnAddManufacturer.TextAlign = ContentAlignment.MiddleRight;
            btnAddManufacturer.UseVisualStyleBackColor = true;
            btnAddManufacturer.Click += btnAddManufacturer_Click;
            // 
            // btnUpdateManufacturer
            // 
            btnUpdateManufacturer.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnUpdateManufacturer.ForeColor = Color.Brown;
            btnUpdateManufacturer.Image = (Image)resources.GetObject("btnUpdateManufacturer.Image");
            btnUpdateManufacturer.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateManufacturer.Location = new Point(130, 3);
            btnUpdateManufacturer.Name = "btnUpdateManufacturer";
            btnUpdateManufacturer.Size = new Size(121, 43);
            btnUpdateManufacturer.TabIndex = 1;
            btnUpdateManufacturer.Text = "Sửa hãng";
            btnUpdateManufacturer.TextAlign = ContentAlignment.MiddleRight;
            btnUpdateManufacturer.UseVisualStyleBackColor = true;
            btnUpdateManufacturer.Click += btnUpdateManufacturer_Click;
            // 
            // tpCategory
            // 
            tpCategory.BackColor = Color.Azure;
            tpCategory.Controls.Add(splitContainer17);
            tpCategory.Location = new Point(4, 24);
            tpCategory.Name = "tpCategory";
            tpCategory.Padding = new Padding(3);
            tpCategory.Size = new Size(1256, 628);
            tpCategory.TabIndex = 4;
            tpCategory.Text = "Danh mục";
            // 
            // splitContainer17
            // 
            splitContainer17.Dock = DockStyle.Fill;
            splitContainer17.IsSplitterFixed = true;
            splitContainer17.Location = new Point(3, 3);
            splitContainer17.Name = "splitContainer17";
            // 
            // splitContainer17.Panel1
            // 
            splitContainer17.Panel1.Controls.Add(dtgvCategory);
            // 
            // splitContainer17.Panel2
            // 
            splitContainer17.Panel2.Controls.Add(splitContainer18);
            splitContainer17.Panel2MinSize = 400;
            splitContainer17.Size = new Size(1250, 622);
            splitContainer17.SplitterDistance = 842;
            splitContainer17.TabIndex = 4;
            // 
            // dtgvCategory
            // 
            dtgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCategory.BackgroundColor = Color.FromArgb(194, 231, 255);
            dtgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCategory.Columns.AddRange(new DataGridViewColumn[] { CateID, CateName });
            dtgvCategory.Dock = DockStyle.Fill;
            dtgvCategory.Location = new Point(0, 0);
            dtgvCategory.MultiSelect = false;
            dtgvCategory.Name = "dtgvCategory";
            dtgvCategory.ReadOnly = true;
            dtgvCategory.RowHeadersWidth = 62;
            dtgvCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvCategory.Size = new Size(842, 622);
            dtgvCategory.TabIndex = 0;
            dtgvCategory.CellClick += dtgvCategory_CellClick;
            // 
            // CateID
            // 
            CateID.HeaderText = "Mã danh mục";
            CateID.Name = "CateID";
            CateID.ReadOnly = true;
            // 
            // CateName
            // 
            CateName.HeaderText = "Tên danh mục";
            CateName.Name = "CateName";
            CateName.ReadOnly = true;
            // 
            // splitContainer18
            // 
            splitContainer18.Dock = DockStyle.Fill;
            splitContainer18.FixedPanel = FixedPanel.Panel1;
            splitContainer18.IsSplitterFixed = true;
            splitContainer18.Location = new Point(0, 0);
            splitContainer18.Name = "splitContainer18";
            splitContainer18.Orientation = Orientation.Horizontal;
            // 
            // splitContainer18.Panel1
            // 
            splitContainer18.Panel1.Controls.Add(groupBox15);
            splitContainer18.Panel1MinSize = 200;
            // 
            // splitContainer18.Panel2
            // 
            splitContainer18.Panel2.Controls.Add(splitContainer19);
            splitContainer18.Panel2MinSize = 250;
            splitContainer18.Size = new Size(404, 622);
            splitContainer18.SplitterDistance = 211;
            splitContainer18.TabIndex = 4;
            // 
            // groupBox15
            // 
            groupBox15.Controls.Add(tableLayoutPanel11);
            groupBox15.Dock = DockStyle.Fill;
            groupBox15.Location = new Point(0, 0);
            groupBox15.Name = "groupBox15";
            groupBox15.Size = new Size(404, 211);
            groupBox15.TabIndex = 0;
            groupBox15.TabStop = false;
            groupBox15.Text = "Bộ lọc tìm kiếm";
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77F));
            tableLayoutPanel11.Controls.Add(btnSearchCate, 1, 2);
            tableLayoutPanel11.Controls.Add(label33, 0, 0);
            tableLayoutPanel11.Controls.Add(txtSearchCateName, 1, 1);
            tableLayoutPanel11.Controls.Add(txtSearchCateID, 1, 0);
            tableLayoutPanel11.Controls.Add(label36, 0, 1);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(3, 23);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 3;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tableLayoutPanel11.Size = new Size(398, 185);
            tableLayoutPanel11.TabIndex = 3;
            // 
            // btnSearchCate
            // 
            btnSearchCate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnSearchCate.ForeColor = Color.Brown;
            btnSearchCate.Image = (Image)resources.GetObject("btnSearchCate.Image");
            btnSearchCate.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchCate.Location = new Point(94, 107);
            btnSearchCate.Name = "btnSearchCate";
            btnSearchCate.Size = new Size(110, 44);
            btnSearchCate.TabIndex = 2;
            btnSearchCate.Text = "Tìm kiếm";
            btnSearchCate.TextAlign = ContentAlignment.MiddleRight;
            btnSearchCate.UseVisualStyleBackColor = true;
            btnSearchCate.Click += btnSearchCate_Click;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Dock = DockStyle.Fill;
            label33.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label33.ForeColor = Color.Brown;
            label33.Location = new Point(3, 0);
            label33.Name = "label33";
            label33.Size = new Size(85, 52);
            label33.TabIndex = 0;
            label33.Text = "Mã DM:";
            // 
            // txtSearchCateName
            // 
            txtSearchCateName.BackColor = Color.FromArgb(255, 253, 239);
            txtSearchCateName.Dock = DockStyle.Fill;
            txtSearchCateName.Location = new Point(94, 55);
            txtSearchCateName.Name = "txtSearchCateName";
            txtSearchCateName.Size = new Size(301, 27);
            txtSearchCateName.TabIndex = 1;
            // 
            // txtSearchCateID
            // 
            txtSearchCateID.BackColor = Color.FromArgb(255, 253, 239);
            txtSearchCateID.Dock = DockStyle.Fill;
            txtSearchCateID.Location = new Point(94, 3);
            txtSearchCateID.Name = "txtSearchCateID";
            txtSearchCateID.Size = new Size(301, 27);
            txtSearchCateID.TabIndex = 0;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Dock = DockStyle.Fill;
            label36.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label36.ForeColor = Color.Brown;
            label36.Location = new Point(3, 52);
            label36.Name = "label36";
            label36.Size = new Size(85, 52);
            label36.TabIndex = 0;
            label36.Text = "Tên DM:";
            // 
            // splitContainer19
            // 
            splitContainer19.Dock = DockStyle.Fill;
            splitContainer19.FixedPanel = FixedPanel.Panel1;
            splitContainer19.IsSplitterFixed = true;
            splitContainer19.Location = new Point(0, 0);
            splitContainer19.Name = "splitContainer19";
            splitContainer19.Orientation = Orientation.Horizontal;
            // 
            // splitContainer19.Panel1
            // 
            splitContainer19.Panel1.Controls.Add(groupBox16);
            // 
            // splitContainer19.Panel2
            // 
            splitContainer19.Panel2.Controls.Add(groupBox17);
            splitContainer19.Size = new Size(404, 407);
            splitContainer19.SplitterDistance = 248;
            splitContainer19.TabIndex = 1;
            // 
            // groupBox16
            // 
            groupBox16.Controls.Add(tableLayoutPanel12);
            groupBox16.Dock = DockStyle.Fill;
            groupBox16.Location = new Point(0, 0);
            groupBox16.Name = "groupBox16";
            groupBox16.Size = new Size(404, 248);
            groupBox16.TabIndex = 0;
            groupBox16.TabStop = false;
            groupBox16.Text = "Chi tiết";
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 2;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.75F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.25F));
            tableLayoutPanel12.Controls.Add(label37, 0, 0);
            tableLayoutPanel12.Controls.Add(label38, 0, 1);
            tableLayoutPanel12.Controls.Add(txtCateName, 1, 1);
            tableLayoutPanel12.Controls.Add(txtCategoryID, 1, 0);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(3, 23);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 3;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 20.5741634F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 20.5741634F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 58.3732071F));
            tableLayoutPanel12.Size = new Size(398, 222);
            tableLayoutPanel12.TabIndex = 0;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Dock = DockStyle.Fill;
            label37.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label37.ForeColor = Color.Brown;
            label37.Location = new Point(3, 0);
            label37.Name = "label37";
            label37.Size = new Size(84, 45);
            label37.TabIndex = 0;
            label37.Text = "Mã DM:";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Dock = DockStyle.Fill;
            label38.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label38.ForeColor = Color.Brown;
            label38.Location = new Point(3, 45);
            label38.Name = "label38";
            label38.Size = new Size(84, 45);
            label38.TabIndex = 0;
            label38.Text = "Tên DM:";
            // 
            // txtCateName
            // 
            txtCateName.BackColor = Color.FromArgb(255, 253, 239);
            txtCateName.Dock = DockStyle.Fill;
            txtCateName.Location = new Point(93, 48);
            txtCateName.Name = "txtCateName";
            txtCateName.Size = new Size(302, 27);
            txtCateName.TabIndex = 1;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCategoryID.BackColor = Color.FromArgb(255, 253, 239);
            txtCategoryID.BorderStyle = BorderStyle.Fixed3D;
            txtCategoryID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtCategoryID.ForeColor = Color.Black;
            txtCategoryID.Location = new Point(93, 0);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(302, 28);
            txtCategoryID.TabIndex = 0;
            // 
            // groupBox17
            // 
            groupBox17.Controls.Add(btnAddCate);
            groupBox17.Controls.Add(btnUpdateCate);
            groupBox17.Dock = DockStyle.Fill;
            groupBox17.Location = new Point(0, 0);
            groupBox17.Name = "groupBox17";
            groupBox17.Size = new Size(404, 155);
            groupBox17.TabIndex = 0;
            groupBox17.TabStop = false;
            groupBox17.Text = "Chức năng";
            // 
            // btnAddCate
            // 
            btnAddCate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnAddCate.ForeColor = Color.Brown;
            btnAddCate.Image = (Image)resources.GetObject("btnAddCate.Image");
            btnAddCate.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddCate.Location = new Point(6, 26);
            btnAddCate.Name = "btnAddCate";
            btnAddCate.Size = new Size(121, 43);
            btnAddCate.TabIndex = 0;
            btnAddCate.Text = "Thêm DM";
            btnAddCate.TextAlign = ContentAlignment.MiddleRight;
            btnAddCate.UseVisualStyleBackColor = true;
            btnAddCate.Click += btnAddCate_Click;
            // 
            // btnUpdateCate
            // 
            btnUpdateCate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnUpdateCate.ForeColor = Color.Brown;
            btnUpdateCate.Image = (Image)resources.GetObject("btnUpdateCate.Image");
            btnUpdateCate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateCate.Location = new Point(133, 26);
            btnUpdateCate.Name = "btnUpdateCate";
            btnUpdateCate.Size = new Size(121, 43);
            btnUpdateCate.TabIndex = 1;
            btnUpdateCate.Text = "Sửa DM";
            btnUpdateCate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdateCate.UseVisualStyleBackColor = true;
            btnUpdateCate.Click += btnUpdateCate_Click;
            // 
            // tpGRN
            // 
            tpGRN.BackColor = Color.Azure;
            tpGRN.Controls.Add(splitContainer20);
            tpGRN.Location = new Point(4, 24);
            tpGRN.Name = "tpGRN";
            tpGRN.Padding = new Padding(3);
            tpGRN.Size = new Size(1256, 628);
            tpGRN.TabIndex = 5;
            tpGRN.Text = "Phiếu nhập";
            // 
            // splitContainer20
            // 
            splitContainer20.Dock = DockStyle.Fill;
            splitContainer20.IsSplitterFixed = true;
            splitContainer20.Location = new Point(3, 3);
            splitContainer20.Name = "splitContainer20";
            // 
            // splitContainer20.Panel1
            // 
            splitContainer20.Panel1.Controls.Add(dtgvGRN);
            // 
            // splitContainer20.Panel2
            // 
            splitContainer20.Panel2.Controls.Add(splitContainer21);
            splitContainer20.Panel2MinSize = 400;
            splitContainer20.Size = new Size(1250, 622);
            splitContainer20.SplitterDistance = 842;
            splitContainer20.TabIndex = 4;
            // 
            // dtgvGRN
            // 
            dtgvGRN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvGRN.BackgroundColor = Color.FromArgb(194, 231, 255);
            dtgvGRN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvGRN.Columns.AddRange(new DataGridViewColumn[] { Column10, Column12, Column11, Column13, Column14 });
            dtgvGRN.Dock = DockStyle.Fill;
            dtgvGRN.Location = new Point(0, 0);
            dtgvGRN.MultiSelect = false;
            dtgvGRN.Name = "dtgvGRN";
            dtgvGRN.ReadOnly = true;
            dtgvGRN.RowHeadersWidth = 62;
            dtgvGRN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvGRN.Size = new Size(842, 622);
            dtgvGRN.TabIndex = 0;
            dtgvGRN.CellClick += dtgvGRN_CellClick;
            // 
            // Column10
            // 
            Column10.HeaderText = "Mã phiếu nhập";
            Column10.MinimumWidth = 8;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // Column12
            // 
            Column12.HeaderText = "Đơn vị";
            Column12.MinimumWidth = 8;
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            // 
            // Column11
            // 
            Column11.HeaderText = "Nhân viên";
            Column11.MinimumWidth = 8;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            // 
            // Column13
            // 
            Column13.HeaderText = "Ngày nhập";
            Column13.MinimumWidth = 8;
            Column13.Name = "Column13";
            Column13.ReadOnly = true;
            // 
            // Column14
            // 
            Column14.HeaderText = "Tổng giá trị";
            Column14.MinimumWidth = 8;
            Column14.Name = "Column14";
            Column14.ReadOnly = true;
            // 
            // splitContainer21
            // 
            splitContainer21.Dock = DockStyle.Fill;
            splitContainer21.FixedPanel = FixedPanel.Panel1;
            splitContainer21.Location = new Point(0, 0);
            splitContainer21.Name = "splitContainer21";
            splitContainer21.Orientation = Orientation.Horizontal;
            // 
            // splitContainer21.Panel1
            // 
            splitContainer21.Panel1.Controls.Add(groupBox18);
            splitContainer21.Panel1MinSize = 200;
            // 
            // splitContainer21.Panel2
            // 
            splitContainer21.Panel2.Controls.Add(splitContainer22);
            splitContainer21.Panel2MinSize = 250;
            splitContainer21.Size = new Size(404, 622);
            splitContainer21.SplitterDistance = 211;
            splitContainer21.TabIndex = 4;
            // 
            // groupBox18
            // 
            groupBox18.Controls.Add(tableLayoutPanel13);
            groupBox18.Dock = DockStyle.Fill;
            groupBox18.Location = new Point(0, 0);
            groupBox18.Name = "groupBox18";
            groupBox18.Size = new Size(404, 211);
            groupBox18.TabIndex = 0;
            groupBox18.TabStop = false;
            groupBox18.Text = "Bộ lọc tìm kiếm";
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 2;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.6130657F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.38693F));
            tableLayoutPanel13.Controls.Add(label40, 0, 0);
            tableLayoutPanel13.Controls.Add(txtSearchGRNID, 1, 0);
            tableLayoutPanel13.Controls.Add(label41, 0, 1);
            tableLayoutPanel13.Controls.Add(label42, 0, 2);
            tableLayoutPanel13.Controls.Add(dtpkSearchGRNTo, 1, 2);
            tableLayoutPanel13.Controls.Add(dtpkSearchGRNFrom, 1, 1);
            tableLayoutPanel13.Controls.Add(panel1, 1, 3);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(3, 23);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 5;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 47.9452057F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 52.0547943F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel13.Size = new Size(398, 185);
            tableLayoutPanel13.TabIndex = 3;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Dock = DockStyle.Fill;
            label40.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label40.ForeColor = Color.Brown;
            label40.Location = new Point(3, 0);
            label40.Name = "label40";
            label40.Size = new Size(84, 35);
            label40.TabIndex = 0;
            label40.Text = "Mã phiếu:";
            // 
            // txtSearchGRNID
            // 
            txtSearchGRNID.BackColor = Color.FromArgb(255, 253, 239);
            txtSearchGRNID.Dock = DockStyle.Fill;
            txtSearchGRNID.Location = new Point(93, 3);
            txtSearchGRNID.Name = "txtSearchGRNID";
            txtSearchGRNID.Size = new Size(302, 27);
            txtSearchGRNID.TabIndex = 0;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Dock = DockStyle.Fill;
            label41.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label41.ForeColor = Color.Brown;
            label41.Location = new Point(3, 35);
            label41.Name = "label41";
            label41.Size = new Size(84, 38);
            label41.TabIndex = 0;
            label41.Text = "Từ ngày:";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Dock = DockStyle.Fill;
            label42.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label42.ForeColor = Color.Brown;
            label42.Location = new Point(3, 73);
            label42.Name = "label42";
            label42.Size = new Size(84, 34);
            label42.TabIndex = 3;
            label42.Text = "Đến ngày:";
            // 
            // dtpkSearchGRNTo
            // 
            dtpkSearchGRNTo.Dock = DockStyle.Fill;
            dtpkSearchGRNTo.Location = new Point(93, 76);
            dtpkSearchGRNTo.Name = "dtpkSearchGRNTo";
            dtpkSearchGRNTo.Size = new Size(302, 27);
            dtpkSearchGRNTo.TabIndex = 2;
            // 
            // dtpkSearchGRNFrom
            // 
            dtpkSearchGRNFrom.Dock = DockStyle.Fill;
            dtpkSearchGRNFrom.Location = new Point(93, 38);
            dtpkSearchGRNFrom.Name = "dtpkSearchGRNFrom";
            dtpkSearchGRNFrom.Size = new Size(302, 27);
            dtpkSearchGRNFrom.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearchGRNCancel);
            panel1.Controls.Add(btnSearchGRN);
            panel1.Location = new Point(93, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 44);
            panel1.TabIndex = 10;
            // 
            // btnSearchGRNCancel
            // 
            btnSearchGRNCancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnSearchGRNCancel.ForeColor = Color.Brown;
            btnSearchGRNCancel.Image = (Image)resources.GetObject("btnSearchGRNCancel.Image");
            btnSearchGRNCancel.Location = new Point(200, 1);
            btnSearchGRNCancel.Name = "btnSearchGRNCancel";
            btnSearchGRNCancel.Size = new Size(43, 43);
            btnSearchGRNCancel.TabIndex = 1;
            btnSearchGRNCancel.UseVisualStyleBackColor = true;
            btnSearchGRNCancel.Click += btnSearchGRNCancel_Click;
            // 
            // btnSearchGRN
            // 
            btnSearchGRN.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnSearchGRN.ForeColor = Color.Brown;
            btnSearchGRN.Image = (Image)resources.GetObject("btnSearchGRN.Image");
            btnSearchGRN.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchGRN.Location = new Point(3, 0);
            btnSearchGRN.Name = "btnSearchGRN";
            btnSearchGRN.Size = new Size(110, 43);
            btnSearchGRN.TabIndex = 0;
            btnSearchGRN.Text = "Tìm kiếm";
            btnSearchGRN.TextAlign = ContentAlignment.MiddleRight;
            btnSearchGRN.UseVisualStyleBackColor = true;
            btnSearchGRN.Click += btnSearchGRN_Click;
            // 
            // splitContainer22
            // 
            splitContainer22.Dock = DockStyle.Fill;
            splitContainer22.FixedPanel = FixedPanel.Panel1;
            splitContainer22.IsSplitterFixed = true;
            splitContainer22.Location = new Point(0, 0);
            splitContainer22.Name = "splitContainer22";
            splitContainer22.Orientation = Orientation.Horizontal;
            // 
            // splitContainer22.Panel1
            // 
            splitContainer22.Panel1.Controls.Add(groupBox19);
            // 
            // splitContainer22.Panel2
            // 
            splitContainer22.Panel2.Controls.Add(groupBox20);
            splitContainer22.Size = new Size(404, 407);
            splitContainer22.SplitterDistance = 248;
            splitContainer22.TabIndex = 1;
            // 
            // groupBox19
            // 
            groupBox19.Controls.Add(tableLayoutPanel14);
            groupBox19.Dock = DockStyle.Fill;
            groupBox19.Location = new Point(0, 0);
            groupBox19.Name = "groupBox19";
            groupBox19.Size = new Size(404, 248);
            groupBox19.TabIndex = 0;
            groupBox19.TabStop = false;
            groupBox19.Text = "Thông tin";
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.ColumnCount = 2;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.75F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.25F));
            tableLayoutPanel14.Controls.Add(txtGRNStaff, 1, 2);
            tableLayoutPanel14.Controls.Add(label45, 0, 0);
            tableLayoutPanel14.Controls.Add(label46, 0, 1);
            tableLayoutPanel14.Controls.Add(label47, 0, 2);
            tableLayoutPanel14.Controls.Add(label43, 0, 4);
            tableLayoutPanel14.Controls.Add(panel4, 1, 4);
            tableLayoutPanel14.Controls.Add(label68, 0, 3);
            tableLayoutPanel14.Controls.Add(txtGRNUnit, 1, 1);
            tableLayoutPanel14.Controls.Add(txtGRNID, 1, 0);
            tableLayoutPanel14.Controls.Add(txtGRNDate, 1, 3);
            tableLayoutPanel14.Dock = DockStyle.Fill;
            tableLayoutPanel14.Location = new Point(3, 23);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 5;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 32.4324341F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 34.2342339F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            tableLayoutPanel14.Size = new Size(398, 222);
            tableLayoutPanel14.TabIndex = 0;
            // 
            // txtGRNStaff
            // 
            txtGRNStaff.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGRNStaff.BackColor = Color.FromArgb(255, 253, 239);
            txtGRNStaff.BorderStyle = BorderStyle.Fixed3D;
            txtGRNStaff.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtGRNStaff.ForeColor = Color.Black;
            txtGRNStaff.Location = new Point(93, 69);
            txtGRNStaff.Name = "txtGRNStaff";
            txtGRNStaff.Size = new Size(302, 28);
            txtGRNStaff.TabIndex = 2;
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Dock = DockStyle.Fill;
            label45.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label45.ForeColor = Color.Brown;
            label45.Location = new Point(3, 0);
            label45.Name = "label45";
            label45.Size = new Size(84, 34);
            label45.TabIndex = 0;
            label45.Text = "Mã phiếu:";
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Dock = DockStyle.Fill;
            label46.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label46.ForeColor = Color.Brown;
            label46.Location = new Point(3, 34);
            label46.Name = "label46";
            label46.Size = new Size(84, 35);
            label46.TabIndex = 0;
            label46.Text = "Đơn vị nhập:";
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label47.ForeColor = Color.Brown;
            label47.Location = new Point(3, 69);
            label47.Name = "label47";
            label47.Size = new Size(84, 20);
            label47.TabIndex = 0;
            label47.Text = "Nhân viên:";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label43.ForeColor = Color.Brown;
            label43.Location = new Point(3, 143);
            label43.Name = "label43";
            label43.Size = new Size(74, 20);
            label43.TabIndex = 4;
            label43.Text = "Tổng giá:";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(txtGRNTotal);
            panel4.Controls.Add(label12);
            panel4.Location = new Point(93, 146);
            panel4.Name = "panel4";
            panel4.Size = new Size(302, 27);
            panel4.TabIndex = 11;
            // 
            // txtGRNTotal
            // 
            txtGRNTotal.BackColor = Color.FromArgb(255, 253, 239);
            txtGRNTotal.BorderStyle = BorderStyle.Fixed3D;
            txtGRNTotal.Dock = DockStyle.Left;
            txtGRNTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtGRNTotal.ForeColor = Color.Black;
            txtGRNTotal.Location = new Point(0, 0);
            txtGRNTotal.Name = "txtGRNTotal";
            txtGRNTotal.Size = new Size(251, 27);
            txtGRNTotal.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Right;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label12.ForeColor = Color.Brown;
            label12.Location = new Point(260, 0);
            label12.Name = "label12";
            label12.Size = new Size(42, 20);
            label12.TabIndex = 7;
            label12.Text = "VNĐ";
            // 
            // label68
            // 
            label68.AutoSize = true;
            label68.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label68.ForeColor = Color.Brown;
            label68.Location = new Point(3, 105);
            label68.Name = "label68";
            label68.Size = new Size(50, 38);
            label68.TabIndex = 0;
            label68.Text = "Ngày nhập:";
            // 
            // txtGRNUnit
            // 
            txtGRNUnit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGRNUnit.BackColor = Color.FromArgb(255, 253, 239);
            txtGRNUnit.BorderStyle = BorderStyle.Fixed3D;
            txtGRNUnit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtGRNUnit.ForeColor = Color.Black;
            txtGRNUnit.Location = new Point(93, 34);
            txtGRNUnit.Name = "txtGRNUnit";
            txtGRNUnit.Size = new Size(302, 28);
            txtGRNUnit.TabIndex = 1;
            // 
            // txtGRNID
            // 
            txtGRNID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGRNID.BackColor = Color.FromArgb(255, 253, 239);
            txtGRNID.BorderStyle = BorderStyle.Fixed3D;
            txtGRNID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtGRNID.ForeColor = Color.Black;
            txtGRNID.Location = new Point(93, 0);
            txtGRNID.Name = "txtGRNID";
            txtGRNID.Size = new Size(302, 28);
            txtGRNID.TabIndex = 0;
            // 
            // txtGRNDate
            // 
            txtGRNDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGRNDate.BackColor = Color.FromArgb(255, 253, 239);
            txtGRNDate.BorderStyle = BorderStyle.Fixed3D;
            txtGRNDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtGRNDate.ForeColor = Color.Black;
            txtGRNDate.Location = new Point(93, 105);
            txtGRNDate.Name = "txtGRNDate";
            txtGRNDate.Size = new Size(302, 28);
            txtGRNDate.TabIndex = 3;
            // 
            // groupBox20
            // 
            groupBox20.Controls.Add(flowLayoutPanel8);
            groupBox20.Dock = DockStyle.Fill;
            groupBox20.Location = new Point(0, 0);
            groupBox20.Name = "groupBox20";
            groupBox20.Size = new Size(404, 155);
            groupBox20.TabIndex = 2;
            groupBox20.TabStop = false;
            groupBox20.Text = "Chức năng";
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.Controls.Add(btnDetailAndUpdateGRN);
            flowLayoutPanel8.Controls.Add(btnAddGRN);
            flowLayoutPanel8.Dock = DockStyle.Fill;
            flowLayoutPanel8.Location = new Point(3, 23);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(398, 129);
            flowLayoutPanel8.TabIndex = 0;
            // 
            // btnDetailAndUpdateGRN
            // 
            btnDetailAndUpdateGRN.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnDetailAndUpdateGRN.ForeColor = Color.Brown;
            btnDetailAndUpdateGRN.Location = new Point(3, 3);
            btnDetailAndUpdateGRN.Name = "btnDetailAndUpdateGRN";
            btnDetailAndUpdateGRN.Size = new Size(190, 43);
            btnDetailAndUpdateGRN.TabIndex = 0;
            btnDetailAndUpdateGRN.Text = "Xem chi tiết";
            btnDetailAndUpdateGRN.UseVisualStyleBackColor = true;
            btnDetailAndUpdateGRN.Click += btnDetailAndUpdateGRN_Click;
            // 
            // btnAddGRN
            // 
            btnAddGRN.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnAddGRN.ForeColor = Color.Brown;
            btnAddGRN.Location = new Point(199, 3);
            btnAddGRN.Name = "btnAddGRN";
            btnAddGRN.Size = new Size(185, 43);
            btnAddGRN.TabIndex = 1;
            btnAddGRN.Text = "Thêm phiếu nhập";
            btnAddGRN.UseVisualStyleBackColor = true;
            btnAddGRN.Click += btnAddGRN_Click;
            // 
            // tpStaff
            // 
            tpStaff.BackColor = Color.Azure;
            tpStaff.Controls.Add(splitContainer23);
            tpStaff.Location = new Point(4, 24);
            tpStaff.Name = "tpStaff";
            tpStaff.Padding = new Padding(3);
            tpStaff.Size = new Size(1256, 628);
            tpStaff.TabIndex = 6;
            tpStaff.Text = "Nhân viên";
            // 
            // splitContainer23
            // 
            splitContainer23.Dock = DockStyle.Fill;
            splitContainer23.IsSplitterFixed = true;
            splitContainer23.Location = new Point(3, 3);
            splitContainer23.Name = "splitContainer23";
            // 
            // splitContainer23.Panel1
            // 
            splitContainer23.Panel1.Controls.Add(dtgvStaff);
            // 
            // splitContainer23.Panel2
            // 
            splitContainer23.Panel2.Controls.Add(splitContainer24);
            splitContainer23.Panel2MinSize = 400;
            splitContainer23.Size = new Size(1250, 622);
            splitContainer23.SplitterDistance = 842;
            splitContainer23.TabIndex = 3;
            // 
            // dtgvStaff
            // 
            dtgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvStaff.BackgroundColor = Color.FromArgb(194, 231, 255);
            dtgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvStaff.Columns.AddRange(new DataGridViewColumn[] { Column1, Column5, Column2, Column9, Column3, Column4, Column6, Column7, Column8 });
            dtgvStaff.Dock = DockStyle.Fill;
            dtgvStaff.ImeMode = ImeMode.NoControl;
            dtgvStaff.Location = new Point(0, 0);
            dtgvStaff.MultiSelect = false;
            dtgvStaff.Name = "dtgvStaff";
            dtgvStaff.ReadOnly = true;
            dtgvStaff.RowHeadersWidth = 62;
            dtgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvStaff.Size = new Size(842, 622);
            dtgvStaff.TabIndex = 0;
            dtgvStaff.CellClick += dtgvStaff_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "StaffID";
            Column1.HeaderText = "Mã NV";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "RoleID";
            Column5.HeaderText = "Chức vụ";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "StaffName";
            Column2.HeaderText = "Họ và tên";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "Status";
            Column9.HeaderText = "Trạng thái";
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Sex";
            Column3.HeaderText = "Giới tính";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "PhoneNumber";
            Column4.HeaderText = "SDT";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "Date";
            Column6.HeaderText = "Ngày sinh";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "Address";
            Column7.HeaderText = "Địa chỉ";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "AccountID";
            Column8.HeaderText = "Tài khoản";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // splitContainer24
            // 
            splitContainer24.Dock = DockStyle.Fill;
            splitContainer24.FixedPanel = FixedPanel.Panel1;
            splitContainer24.IsSplitterFixed = true;
            splitContainer24.Location = new Point(0, 0);
            splitContainer24.Name = "splitContainer24";
            splitContainer24.Orientation = Orientation.Horizontal;
            // 
            // splitContainer24.Panel1
            // 
            splitContainer24.Panel1.Controls.Add(groupBox21);
            splitContainer24.Panel1MinSize = 150;
            // 
            // splitContainer24.Panel2
            // 
            splitContainer24.Panel2.Controls.Add(splitContainer25);
            splitContainer24.Panel2MinSize = 250;
            splitContainer24.Size = new Size(404, 622);
            splitContainer24.SplitterDistance = 150;
            splitContainer24.TabIndex = 4;
            // 
            // groupBox21
            // 
            groupBox21.Controls.Add(tableLayoutPanel15);
            groupBox21.Dock = DockStyle.Fill;
            groupBox21.Location = new Point(0, 0);
            groupBox21.Name = "groupBox21";
            groupBox21.Size = new Size(404, 150);
            groupBox21.TabIndex = 0;
            groupBox21.TabStop = false;
            groupBox21.Text = "Bộ lọc tìm kiếm";
            // 
            // tableLayoutPanel15
            // 
            tableLayoutPanel15.ColumnCount = 2;
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23F));
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77F));
            tableLayoutPanel15.Controls.Add(btnSearchStaff, 1, 2);
            tableLayoutPanel15.Controls.Add(label44, 0, 0);
            tableLayoutPanel15.Controls.Add(txtSearchStaffName, 1, 1);
            tableLayoutPanel15.Controls.Add(txtSearchStaffID, 1, 0);
            tableLayoutPanel15.Controls.Add(label48, 0, 1);
            tableLayoutPanel15.Dock = DockStyle.Fill;
            tableLayoutPanel15.Location = new Point(3, 23);
            tableLayoutPanel15.Name = "tableLayoutPanel15";
            tableLayoutPanel15.RowCount = 3;
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 49.03846F));
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 50.96154F));
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel15.Size = new Size(398, 124);
            tableLayoutPanel15.TabIndex = 3;
            // 
            // btnSearchStaff
            // 
            btnSearchStaff.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchStaff.ForeColor = Color.Brown;
            btnSearchStaff.Image = (Image)resources.GetObject("btnSearchStaff.Image");
            btnSearchStaff.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchStaff.Location = new Point(94, 76);
            btnSearchStaff.Name = "btnSearchStaff";
            btnSearchStaff.Size = new Size(110, 44);
            btnSearchStaff.TabIndex = 2;
            btnSearchStaff.Text = "Tìm kiếm";
            btnSearchStaff.TextAlign = ContentAlignment.MiddleRight;
            btnSearchStaff.UseVisualStyleBackColor = true;
            btnSearchStaff.Click += btnSearchStaff_Click;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Dock = DockStyle.Fill;
            label44.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label44.ForeColor = Color.Brown;
            label44.Location = new Point(3, 0);
            label44.Name = "label44";
            label44.Size = new Size(85, 36);
            label44.TabIndex = 0;
            label44.Text = "Mã NV:";
            // 
            // txtSearchStaffName
            // 
            txtSearchStaffName.BackColor = Color.FromArgb(255, 253, 239);
            txtSearchStaffName.Dock = DockStyle.Fill;
            txtSearchStaffName.Location = new Point(94, 39);
            txtSearchStaffName.Name = "txtSearchStaffName";
            txtSearchStaffName.Size = new Size(301, 27);
            txtSearchStaffName.TabIndex = 1;
            // 
            // txtSearchStaffID
            // 
            txtSearchStaffID.BackColor = Color.FromArgb(255, 253, 239);
            txtSearchStaffID.Dock = DockStyle.Fill;
            txtSearchStaffID.Location = new Point(94, 3);
            txtSearchStaffID.Name = "txtSearchStaffID";
            txtSearchStaffID.Size = new Size(301, 27);
            txtSearchStaffID.TabIndex = 0;
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.Dock = DockStyle.Fill;
            label48.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label48.ForeColor = Color.Brown;
            label48.Location = new Point(3, 36);
            label48.Name = "label48";
            label48.Size = new Size(85, 37);
            label48.TabIndex = 0;
            label48.Text = "Họ và tên:";
            // 
            // splitContainer25
            // 
            splitContainer25.Dock = DockStyle.Fill;
            splitContainer25.FixedPanel = FixedPanel.Panel1;
            splitContainer25.IsSplitterFixed = true;
            splitContainer25.Location = new Point(0, 0);
            splitContainer25.Name = "splitContainer25";
            splitContainer25.Orientation = Orientation.Horizontal;
            // 
            // splitContainer25.Panel1
            // 
            splitContainer25.Panel1.Controls.Add(groupBox22);
            // 
            // splitContainer25.Panel2
            // 
            splitContainer25.Panel2.Controls.Add(groupBox23);
            splitContainer25.Size = new Size(404, 468);
            splitContainer25.SplitterDistance = 331;
            splitContainer25.TabIndex = 1;
            // 
            // groupBox22
            // 
            groupBox22.Controls.Add(tableLayoutPanel16);
            groupBox22.Dock = DockStyle.Fill;
            groupBox22.Location = new Point(0, 0);
            groupBox22.Name = "groupBox22";
            groupBox22.Size = new Size(404, 331);
            groupBox22.TabIndex = 0;
            groupBox22.TabStop = false;
            groupBox22.Text = "Chi tiết";
            // 
            // tableLayoutPanel16
            // 
            tableLayoutPanel16.ColumnCount = 2;
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.86935F));
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.13065F));
            tableLayoutPanel16.Controls.Add(txtStaffID, 1, 0);
            tableLayoutPanel16.Controls.Add(label49, 0, 0);
            tableLayoutPanel16.Controls.Add(label50, 0, 1);
            tableLayoutPanel16.Controls.Add(txtStaffName, 1, 1);
            tableLayoutPanel16.Controls.Add(label52, 0, 2);
            tableLayoutPanel16.Controls.Add(label53, 0, 3);
            tableLayoutPanel16.Controls.Add(label54, 0, 4);
            tableLayoutPanel16.Controls.Add(cbStaffGender, 1, 2);
            tableLayoutPanel16.Controls.Add(label51, 0, 6);
            tableLayoutPanel16.Controls.Add(label66, 0, 5);
            tableLayoutPanel16.Controls.Add(rtbStaffAdress, 1, 7);
            tableLayoutPanel16.Controls.Add(label67, 0, 7);
            tableLayoutPanel16.Controls.Add(cbStaffRole, 1, 6);
            tableLayoutPanel16.Controls.Add(cboStaffStatus, 1, 5);
            tableLayoutPanel16.Controls.Add(txtStaffPhone, 1, 4);
            tableLayoutPanel16.Controls.Add(dtpStaffBornDate, 1, 3);
            tableLayoutPanel16.Dock = DockStyle.Fill;
            tableLayoutPanel16.Location = new Point(3, 23);
            tableLayoutPanel16.Name = "tableLayoutPanel16";
            tableLayoutPanel16.RowCount = 8;
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 33.84615F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 33.0769234F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 33.0769234F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel16.Size = new Size(398, 305);
            tableLayoutPanel16.TabIndex = 0;
            // 
            // txtStaffID
            // 
            txtStaffID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStaffID.BackColor = Color.FromArgb(255, 253, 239);
            txtStaffID.BorderStyle = BorderStyle.Fixed3D;
            txtStaffID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtStaffID.ForeColor = Color.Black;
            txtStaffID.Location = new Point(98, 0);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new Size(297, 28);
            txtStaffID.TabIndex = 0;
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.Dock = DockStyle.Fill;
            label49.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label49.ForeColor = Color.Brown;
            label49.Location = new Point(3, 0);
            label49.Name = "label49";
            label49.Size = new Size(89, 37);
            label49.TabIndex = 0;
            label49.Text = "Mã NV:";
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Dock = DockStyle.Fill;
            label50.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label50.ForeColor = Color.Brown;
            label50.Location = new Point(3, 37);
            label50.Name = "label50";
            label50.Size = new Size(89, 36);
            label50.TabIndex = 0;
            label50.Text = "Họ và tên:";
            // 
            // txtStaffName
            // 
            txtStaffName.BackColor = Color.FromArgb(255, 253, 239);
            txtStaffName.Dock = DockStyle.Fill;
            txtStaffName.Location = new Point(98, 40);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(297, 27);
            txtStaffName.TabIndex = 1;
            // 
            // label52
            // 
            label52.AutoSize = true;
            label52.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label52.ForeColor = Color.Brown;
            label52.Location = new Point(3, 73);
            label52.Name = "label52";
            label52.Size = new Size(73, 20);
            label52.TabIndex = 2;
            label52.Text = "Giới tính:";
            // 
            // label53
            // 
            label53.AutoSize = true;
            label53.Dock = DockStyle.Fill;
            label53.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label53.ForeColor = Color.Brown;
            label53.Location = new Point(3, 109);
            label53.Name = "label53";
            label53.Size = new Size(89, 35);
            label53.TabIndex = 3;
            label53.Text = "Ngày sinh:";
            // 
            // label54
            // 
            label54.AutoSize = true;
            label54.Dock = DockStyle.Fill;
            label54.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label54.ForeColor = Color.Brown;
            label54.Location = new Point(3, 144);
            label54.Name = "label54";
            label54.Size = new Size(89, 35);
            label54.TabIndex = 4;
            label54.Text = "SDT:";
            // 
            // cbStaffGender
            // 
            cbStaffGender.BackColor = Color.FromArgb(255, 253, 239);
            cbStaffGender.Dock = DockStyle.Fill;
            cbStaffGender.FormattingEnabled = true;
            cbStaffGender.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cbStaffGender.Location = new Point(98, 76);
            cbStaffGender.Name = "cbStaffGender";
            cbStaffGender.Size = new Size(297, 28);
            cbStaffGender.TabIndex = 2;
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.Dock = DockStyle.Fill;
            label51.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label51.ForeColor = Color.Brown;
            label51.Location = new Point(3, 215);
            label51.Name = "label51";
            label51.Size = new Size(89, 30);
            label51.TabIndex = 0;
            label51.Text = "Chức vụ:";
            // 
            // label66
            // 
            label66.AutoSize = true;
            label66.Dock = DockStyle.Fill;
            label66.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label66.ForeColor = Color.Brown;
            label66.Location = new Point(3, 179);
            label66.Name = "label66";
            label66.Size = new Size(89, 36);
            label66.TabIndex = 4;
            label66.Text = "Trạng thái:";
            // 
            // rtbStaffAdress
            // 
            rtbStaffAdress.BackColor = Color.FromArgb(255, 253, 239);
            rtbStaffAdress.Dock = DockStyle.Fill;
            rtbStaffAdress.Location = new Point(98, 248);
            rtbStaffAdress.Name = "rtbStaffAdress";
            rtbStaffAdress.Size = new Size(297, 54);
            rtbStaffAdress.TabIndex = 7;
            rtbStaffAdress.Text = "";
            // 
            // label67
            // 
            label67.AutoSize = true;
            label67.Dock = DockStyle.Fill;
            label67.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label67.ForeColor = Color.Brown;
            label67.Location = new Point(3, 245);
            label67.Name = "label67";
            label67.Size = new Size(89, 60);
            label67.TabIndex = 0;
            label67.Text = "Địa chỉ:";
            // 
            // cbStaffRole
            // 
            cbStaffRole.BackColor = Color.FromArgb(255, 253, 239);
            cbStaffRole.Dock = DockStyle.Fill;
            cbStaffRole.FormattingEnabled = true;
            cbStaffRole.Location = new Point(98, 218);
            cbStaffRole.Name = "cbStaffRole";
            cbStaffRole.Size = new Size(297, 28);
            cbStaffRole.TabIndex = 6;
            // 
            // cboStaffStatus
            // 
            cboStaffStatus.BackColor = Color.FromArgb(255, 253, 239);
            cboStaffStatus.Dock = DockStyle.Fill;
            cboStaffStatus.FormattingEnabled = true;
            cboStaffStatus.Items.AddRange(new object[] { "Đang làm", "Tạm nghỉ", "Nghỉ luôn" });
            cboStaffStatus.Location = new Point(98, 182);
            cboStaffStatus.Name = "cboStaffStatus";
            cboStaffStatus.Size = new Size(297, 28);
            cboStaffStatus.TabIndex = 5;
            // 
            // txtStaffPhone
            // 
            txtStaffPhone.BackColor = Color.FromArgb(255, 253, 239);
            txtStaffPhone.Dock = DockStyle.Fill;
            txtStaffPhone.Location = new Point(98, 147);
            txtStaffPhone.Name = "txtStaffPhone";
            txtStaffPhone.Size = new Size(297, 27);
            txtStaffPhone.TabIndex = 4;
            // 
            // dtpStaffBornDate
            // 
            dtpStaffBornDate.Dock = DockStyle.Fill;
            dtpStaffBornDate.Location = new Point(98, 112);
            dtpStaffBornDate.Name = "dtpStaffBornDate";
            dtpStaffBornDate.Size = new Size(297, 27);
            dtpStaffBornDate.TabIndex = 3;
            // 
            // groupBox23
            // 
            groupBox23.Controls.Add(flowLayoutPanel9);
            groupBox23.Dock = DockStyle.Fill;
            groupBox23.Location = new Point(0, 0);
            groupBox23.Name = "groupBox23";
            groupBox23.Size = new Size(404, 133);
            groupBox23.TabIndex = 2;
            groupBox23.TabStop = false;
            groupBox23.Text = "Chức năng";
            // 
            // flowLayoutPanel9
            // 
            flowLayoutPanel9.Controls.Add(btnAddStaff);
            flowLayoutPanel9.Controls.Add(btnUpdateStaff);
            flowLayoutPanel9.Dock = DockStyle.Fill;
            flowLayoutPanel9.Location = new Point(3, 23);
            flowLayoutPanel9.Name = "flowLayoutPanel9";
            flowLayoutPanel9.Size = new Size(398, 107);
            flowLayoutPanel9.TabIndex = 0;
            // 
            // btnAddStaff
            // 
            btnAddStaff.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnAddStaff.ForeColor = Color.Brown;
            btnAddStaff.Image = (Image)resources.GetObject("btnAddStaff.Image");
            btnAddStaff.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddStaff.Location = new Point(3, 3);
            btnAddStaff.Name = "btnAddStaff";
            btnAddStaff.Size = new Size(121, 43);
            btnAddStaff.TabIndex = 0;
            btnAddStaff.Text = "Thêm NV";
            btnAddStaff.TextAlign = ContentAlignment.MiddleRight;
            btnAddStaff.UseVisualStyleBackColor = true;
            btnAddStaff.Click += btnAddStaff_Click;
            // 
            // btnUpdateStaff
            // 
            btnUpdateStaff.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnUpdateStaff.ForeColor = Color.Brown;
            btnUpdateStaff.Image = (Image)resources.GetObject("btnUpdateStaff.Image");
            btnUpdateStaff.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateStaff.Location = new Point(130, 3);
            btnUpdateStaff.Name = "btnUpdateStaff";
            btnUpdateStaff.Size = new Size(121, 43);
            btnUpdateStaff.TabIndex = 1;
            btnUpdateStaff.Text = "Sửa NV";
            btnUpdateStaff.TextAlign = ContentAlignment.MiddleRight;
            btnUpdateStaff.UseVisualStyleBackColor = true;
            btnUpdateStaff.Click += btnUpdateStaff_Click;
            // 
            // tpAccount
            // 
            tpAccount.BackColor = Color.Azure;
            tpAccount.Controls.Add(splitContainer29);
            tpAccount.Location = new Point(4, 24);
            tpAccount.Name = "tpAccount";
            tpAccount.Padding = new Padding(3);
            tpAccount.Size = new Size(1256, 628);
            tpAccount.TabIndex = 7;
            tpAccount.Text = "Tài khoản";
            // 
            // splitContainer29
            // 
            splitContainer29.Dock = DockStyle.Fill;
            splitContainer29.IsSplitterFixed = true;
            splitContainer29.Location = new Point(3, 3);
            splitContainer29.Name = "splitContainer29";
            // 
            // splitContainer29.Panel1
            // 
            splitContainer29.Panel1.Controls.Add(dtgvAccount);
            // 
            // splitContainer29.Panel2
            // 
            splitContainer29.Panel2.Controls.Add(splitContainer30);
            splitContainer29.Panel2MinSize = 400;
            splitContainer29.Size = new Size(1250, 622);
            splitContainer29.SplitterDistance = 842;
            splitContainer29.TabIndex = 5;
            // 
            // dtgvAccount
            // 
            dtgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvAccount.BackgroundColor = Color.FromArgb(194, 231, 255);
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Columns.AddRange(new DataGridViewColumn[] { AccountID, accountType, accountStaff });
            dtgvAccount.Dock = DockStyle.Fill;
            dtgvAccount.Location = new Point(0, 0);
            dtgvAccount.MultiSelect = false;
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.ReadOnly = true;
            dtgvAccount.RowHeadersWidth = 62;
            dtgvAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvAccount.Size = new Size(842, 622);
            dtgvAccount.TabIndex = 0;
            dtgvAccount.CellClick += dtgvAccount_CellClick;
            // 
            // AccountID
            // 
            AccountID.HeaderText = "Mã tài khoản";
            AccountID.Name = "AccountID";
            AccountID.ReadOnly = true;
            // 
            // accountType
            // 
            accountType.HeaderText = "Loại";
            accountType.Name = "accountType";
            accountType.ReadOnly = true;
            // 
            // accountStaff
            // 
            accountStaff.HeaderText = "Nhân viên";
            accountStaff.Name = "accountStaff";
            accountStaff.ReadOnly = true;
            // 
            // splitContainer30
            // 
            splitContainer30.Dock = DockStyle.Fill;
            splitContainer30.FixedPanel = FixedPanel.Panel1;
            splitContainer30.IsSplitterFixed = true;
            splitContainer30.Location = new Point(0, 0);
            splitContainer30.Name = "splitContainer30";
            splitContainer30.Orientation = Orientation.Horizontal;
            // 
            // splitContainer30.Panel1
            // 
            splitContainer30.Panel1.Controls.Add(groupBox26);
            splitContainer30.Panel1MinSize = 200;
            // 
            // splitContainer30.Panel2
            // 
            splitContainer30.Panel2.Controls.Add(splitContainer31);
            splitContainer30.Panel2MinSize = 250;
            splitContainer30.Size = new Size(404, 622);
            splitContainer30.SplitterDistance = 211;
            splitContainer30.TabIndex = 4;
            // 
            // groupBox26
            // 
            groupBox26.Controls.Add(tableLayoutPanel19);
            groupBox26.Dock = DockStyle.Fill;
            groupBox26.Location = new Point(0, 0);
            groupBox26.Name = "groupBox26";
            groupBox26.Size = new Size(404, 211);
            groupBox26.TabIndex = 0;
            groupBox26.TabStop = false;
            groupBox26.Text = "Bộ lọc tìm kiếm";
            // 
            // tableLayoutPanel19
            // 
            tableLayoutPanel19.ColumnCount = 2;
            tableLayoutPanel19.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23F));
            tableLayoutPanel19.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77F));
            tableLayoutPanel19.Controls.Add(label59, 0, 0);
            tableLayoutPanel19.Controls.Add(txtSearchLoginName, 1, 0);
            tableLayoutPanel19.Controls.Add(btnSearchAccount, 1, 1);
            tableLayoutPanel19.Dock = DockStyle.Fill;
            tableLayoutPanel19.Location = new Point(3, 23);
            tableLayoutPanel19.Name = "tableLayoutPanel19";
            tableLayoutPanel19.RowCount = 3;
            tableLayoutPanel19.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel19.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel19.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tableLayoutPanel19.Size = new Size(398, 185);
            tableLayoutPanel19.TabIndex = 3;
            // 
            // label59
            // 
            label59.AutoSize = true;
            label59.Dock = DockStyle.Fill;
            label59.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label59.ForeColor = Color.Brown;
            label59.Location = new Point(3, 0);
            label59.Name = "label59";
            label59.Size = new Size(85, 52);
            label59.TabIndex = 0;
            label59.Text = "Tên đăng nhập:";
            // 
            // txtSearchLoginName
            // 
            txtSearchLoginName.BackColor = Color.FromArgb(255, 253, 239);
            txtSearchLoginName.Dock = DockStyle.Fill;
            txtSearchLoginName.Location = new Point(94, 3);
            txtSearchLoginName.Name = "txtSearchLoginName";
            txtSearchLoginName.Size = new Size(301, 27);
            txtSearchLoginName.TabIndex = 0;
            // 
            // btnSearchAccount
            // 
            btnSearchAccount.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnSearchAccount.ForeColor = Color.Brown;
            btnSearchAccount.Image = (Image)resources.GetObject("btnSearchAccount.Image");
            btnSearchAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchAccount.Location = new Point(94, 55);
            btnSearchAccount.Name = "btnSearchAccount";
            btnSearchAccount.Size = new Size(110, 44);
            btnSearchAccount.TabIndex = 1;
            btnSearchAccount.Text = "Tìm kiếm";
            btnSearchAccount.TextAlign = ContentAlignment.MiddleRight;
            btnSearchAccount.UseVisualStyleBackColor = true;
            btnSearchAccount.Click += btnSearchAccount_Click;
            // 
            // splitContainer31
            // 
            splitContainer31.Dock = DockStyle.Fill;
            splitContainer31.FixedPanel = FixedPanel.Panel1;
            splitContainer31.IsSplitterFixed = true;
            splitContainer31.Location = new Point(0, 0);
            splitContainer31.Name = "splitContainer31";
            splitContainer31.Orientation = Orientation.Horizontal;
            // 
            // splitContainer31.Panel1
            // 
            splitContainer31.Panel1.Controls.Add(groupBox27);
            // 
            // splitContainer31.Panel2
            // 
            splitContainer31.Panel2.Controls.Add(groupBox28);
            splitContainer31.Size = new Size(404, 407);
            splitContainer31.SplitterDistance = 295;
            splitContainer31.TabIndex = 1;
            // 
            // groupBox27
            // 
            groupBox27.Controls.Add(tableLayoutPanel20);
            groupBox27.Dock = DockStyle.Fill;
            groupBox27.Location = new Point(0, 0);
            groupBox27.Name = "groupBox27";
            groupBox27.Size = new Size(404, 295);
            groupBox27.TabIndex = 0;
            groupBox27.TabStop = false;
            groupBox27.Text = "Chi tiết";
            // 
            // tableLayoutPanel20
            // 
            tableLayoutPanel20.ColumnCount = 2;
            tableLayoutPanel20.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.75F));
            tableLayoutPanel20.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.25F));
            tableLayoutPanel20.Controls.Add(label61, 0, 0);
            tableLayoutPanel20.Controls.Add(label62, 0, 1);
            tableLayoutPanel20.Controls.Add(txtPassword, 1, 1);
            tableLayoutPanel20.Controls.Add(txtLoginName, 1, 0);
            tableLayoutPanel20.Controls.Add(cbAccountType, 1, 2);
            tableLayoutPanel20.Controls.Add(label64, 0, 2);
            tableLayoutPanel20.Controls.Add(label65, 0, 3);
            tableLayoutPanel20.Controls.Add(cbAccountStaff, 1, 3);
            tableLayoutPanel20.Dock = DockStyle.Fill;
            tableLayoutPanel20.Location = new Point(3, 23);
            tableLayoutPanel20.Name = "tableLayoutPanel20";
            tableLayoutPanel20.RowCount = 5;
            tableLayoutPanel20.RowStyles.Add(new RowStyle(SizeType.Percent, 32.9545441F));
            tableLayoutPanel20.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel20.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel20.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel20.RowStyles.Add(new RowStyle(SizeType.Absolute, 94F));
            tableLayoutPanel20.Size = new Size(398, 269);
            tableLayoutPanel20.TabIndex = 0;
            // 
            // label61
            // 
            label61.AutoSize = true;
            label61.Dock = DockStyle.Fill;
            label61.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label61.ForeColor = Color.Brown;
            label61.Location = new Point(3, 0);
            label61.Name = "label61";
            label61.Size = new Size(84, 41);
            label61.TabIndex = 0;
            label61.Text = "Tên đăng nhập:";
            // 
            // label62
            // 
            label62.AutoSize = true;
            label62.Dock = DockStyle.Fill;
            label62.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label62.ForeColor = Color.Brown;
            label62.Location = new Point(3, 41);
            label62.Name = "label62";
            label62.Size = new Size(84, 41);
            label62.TabIndex = 0;
            label62.Text = "Mật khẩu:";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(255, 253, 239);
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Location = new Point(93, 44);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(302, 27);
            txtPassword.TabIndex = 1;
            // 
            // txtLoginName
            // 
            txtLoginName.BackColor = Color.FromArgb(255, 253, 239);
            txtLoginName.Dock = DockStyle.Fill;
            txtLoginName.Location = new Point(93, 3);
            txtLoginName.Name = "txtLoginName";
            txtLoginName.Size = new Size(302, 27);
            txtLoginName.TabIndex = 0;
            // 
            // cbAccountType
            // 
            cbAccountType.BackColor = Color.FromArgb(255, 253, 239);
            cbAccountType.Dock = DockStyle.Fill;
            cbAccountType.FormattingEnabled = true;
            cbAccountType.Items.AddRange(new object[] { "Nhân viên", "Quản lý", "Quản trị viên" });
            cbAccountType.Location = new Point(93, 85);
            cbAccountType.Name = "cbAccountType";
            cbAccountType.Size = new Size(302, 28);
            cbAccountType.TabIndex = 2;
            // 
            // label64
            // 
            label64.AutoSize = true;
            label64.Dock = DockStyle.Fill;
            label64.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label64.ForeColor = Color.Brown;
            label64.Location = new Point(3, 82);
            label64.Name = "label64";
            label64.Size = new Size(84, 41);
            label64.TabIndex = 3;
            label64.Text = "Loại TK:";
            // 
            // label65
            // 
            label65.AutoSize = true;
            label65.Dock = DockStyle.Fill;
            label65.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label65.ForeColor = Color.Brown;
            label65.Location = new Point(3, 123);
            label65.Name = "label65";
            label65.Size = new Size(84, 50);
            label65.TabIndex = 4;
            label65.Text = "Nhân viên";
            // 
            // cbAccountStaff
            // 
            cbAccountStaff.BackColor = Color.FromArgb(255, 253, 239);
            cbAccountStaff.Dock = DockStyle.Fill;
            cbAccountStaff.FormattingEnabled = true;
            cbAccountStaff.Location = new Point(93, 126);
            cbAccountStaff.Name = "cbAccountStaff";
            cbAccountStaff.Size = new Size(302, 28);
            cbAccountStaff.TabIndex = 3;
            // 
            // groupBox28
            // 
            groupBox28.Controls.Add(flowLayoutPanel10);
            groupBox28.Dock = DockStyle.Fill;
            groupBox28.Location = new Point(0, 0);
            groupBox28.Name = "groupBox28";
            groupBox28.Size = new Size(404, 108);
            groupBox28.TabIndex = 2;
            groupBox28.TabStop = false;
            groupBox28.Text = "Chức năng";
            // 
            // flowLayoutPanel10
            // 
            flowLayoutPanel10.Controls.Add(btnAddAccount);
            flowLayoutPanel10.Controls.Add(btnUpdateAccount);
            flowLayoutPanel10.Dock = DockStyle.Fill;
            flowLayoutPanel10.Location = new Point(3, 23);
            flowLayoutPanel10.Name = "flowLayoutPanel10";
            flowLayoutPanel10.Size = new Size(398, 82);
            flowLayoutPanel10.TabIndex = 0;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnAddAccount.ForeColor = Color.Brown;
            btnAddAccount.Image = (Image)resources.GetObject("btnAddAccount.Image");
            btnAddAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddAccount.Location = new Point(3, 3);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(121, 43);
            btnAddAccount.TabIndex = 0;
            btnAddAccount.Text = "Thêm TK";
            btnAddAccount.TextAlign = ContentAlignment.MiddleRight;
            btnAddAccount.UseVisualStyleBackColor = true;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // btnUpdateAccount
            // 
            btnUpdateAccount.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnUpdateAccount.ForeColor = Color.Brown;
            btnUpdateAccount.Image = (Image)resources.GetObject("btnUpdateAccount.Image");
            btnUpdateAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateAccount.Location = new Point(130, 3);
            btnUpdateAccount.Name = "btnUpdateAccount";
            btnUpdateAccount.Size = new Size(121, 43);
            btnUpdateAccount.TabIndex = 1;
            btnUpdateAccount.Text = "Sửa TK";
            btnUpdateAccount.TextAlign = ContentAlignment.MiddleRight;
            btnUpdateAccount.UseVisualStyleBackColor = true;
            btnUpdateAccount.Click += btnUpdateAccount_Click;
            // 
            // staffBindingSource
            // 
            staffBindingSource.DataSource = typeof(DTO.Staff);
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.Location = new Point(0, 0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.Size = new Size(143, 100);
            dataGridView3.TabIndex = 0;
            // 
            // splitContainer8
            // 
            splitContainer8.Dock = DockStyle.Fill;
            splitContainer8.FixedPanel = FixedPanel.Panel1;
            splitContainer8.Location = new Point(0, 0);
            splitContainer8.Name = "splitContainer8";
            splitContainer8.Orientation = Orientation.Horizontal;
            // 
            // splitContainer8.Panel1
            // 
            splitContainer8.Panel1.Controls.Add(groupBox7);
            splitContainer8.Size = new Size(150, 454);
            splitContainer8.TabIndex = 0;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(tableLayoutPanel5);
            groupBox7.Dock = DockStyle.Fill;
            groupBox7.Location = new Point(0, 0);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(150, 50);
            groupBox7.TabIndex = 1;
            groupBox7.TabStop = false;
            groupBox7.Text = "Bộ lọc tìm kiếm";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.6130657F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.38693F));
            tableLayoutPanel5.Controls.Add(label14, 0, 0);
            tableLayoutPanel5.Controls.Add(textBox11, 1, 0);
            tableLayoutPanel5.Controls.Add(label15, 0, 1);
            tableLayoutPanel5.Controls.Add(label16, 0, 2);
            tableLayoutPanel5.Controls.Add(button11, 1, 5);
            tableLayoutPanel5.Controls.Add(label17, 0, 3);
            tableLayoutPanel5.Controls.Add(dateTimePicker3, 1, 2);
            tableLayoutPanel5.Controls.Add(textBox12, 1, 3);
            tableLayoutPanel5.Controls.Add(textBox13, 1, 4);
            tableLayoutPanel5.Controls.Add(label18, 0, 4);
            tableLayoutPanel5.Controls.Add(dateTimePicker4, 1, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 19);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 6;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 52.77778F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 47.22222F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel5.Size = new Size(144, 28);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Fill;
            label14.Location = new Point(3, 0);
            label14.Name = "label14";
            label14.Size = new Size(26, 1);
            label14.TabIndex = 0;
            label14.Text = "Mã đơn:";
            // 
            // textBox11
            // 
            textBox11.Dock = DockStyle.Fill;
            textBox11.Location = new Point(35, 3);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(106, 23);
            textBox11.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Dock = DockStyle.Fill;
            label15.Location = new Point(3, -60);
            label15.Name = "label15";
            label15.Size = new Size(26, 1);
            label15.TabIndex = 0;
            label15.Text = "Từ ngày:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Dock = DockStyle.Fill;
            label16.Location = new Point(3, -113);
            label16.Name = "label16";
            label16.Size = new Size(26, 31);
            label16.TabIndex = 3;
            label16.Text = "Đến ngày:";
            // 
            // button11
            // 
            button11.Location = new Point(35, -13);
            button11.Name = "button11";
            button11.Size = new Size(106, 39);
            button11.TabIndex = 2;
            button11.Text = "Tìm kiếm";
            button11.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Dock = DockStyle.Fill;
            label17.Location = new Point(3, -82);
            label17.Name = "label17";
            label17.Size = new Size(26, 31);
            label17.TabIndex = 4;
            label17.Text = "Tổng giá:";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Dock = DockStyle.Fill;
            dateTimePicker3.Location = new Point(35, -110);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(106, 23);
            dateTimePicker3.TabIndex = 5;
            // 
            // textBox12
            // 
            textBox12.Dock = DockStyle.Fill;
            textBox12.Location = new Point(35, -79);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(106, 23);
            textBox12.TabIndex = 6;
            // 
            // textBox13
            // 
            textBox13.Dock = DockStyle.Fill;
            textBox13.Location = new Point(35, -48);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(106, 23);
            textBox13.TabIndex = 7;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Dock = DockStyle.Fill;
            label18.Location = new Point(3, -51);
            label18.Name = "label18";
            label18.Size = new Size(26, 35);
            label18.TabIndex = 8;
            label18.Text = "Trạng thái:";
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Dock = DockStyle.Fill;
            dateTimePicker4.Location = new Point(35, -57);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(106, 23);
            dateTimePicker4.TabIndex = 9;
            // 
            // splitContainer9
            // 
            splitContainer9.Dock = DockStyle.Fill;
            splitContainer9.FixedPanel = FixedPanel.Panel1;
            splitContainer9.IsSplitterFixed = true;
            splitContainer9.Location = new Point(0, 0);
            splitContainer9.Name = "splitContainer9";
            splitContainer9.Orientation = Orientation.Horizontal;
            splitContainer9.Size = new Size(150, 100);
            splitContainer9.TabIndex = 0;
            // 
            // groupBox8
            // 
            groupBox8.Location = new Point(0, 0);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(200, 100);
            groupBox8.TabIndex = 0;
            groupBox8.TabStop = false;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.75F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.25F));
            tableLayoutPanel6.Controls.Add(label19, 0, 0);
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.Size = new Size(200, 100);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Dock = DockStyle.Fill;
            label19.Location = new Point(3, 0);
            label19.Name = "label19";
            label19.Size = new Size(39, 100);
            label19.TabIndex = 0;
            label19.Text = "Mã đơn:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Dock = DockStyle.Fill;
            label20.Location = new Point(3, 30);
            label20.Name = "label20";
            label20.Size = new Size(39, 70);
            label20.TabIndex = 0;
            label20.Text = "Tên KH:";
            // 
            // splitContainer7
            // 
            splitContainer7.Dock = DockStyle.Fill;
            splitContainer7.IsSplitterFixed = true;
            splitContainer7.Location = new Point(3, 4);
            splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            splitContainer7.Panel1.Controls.Add(dataGridView3);
            splitContainer7.Size = new Size(429, 100);
            splitContainer7.SplitterDistance = 143;
            splitContainer7.TabIndex = 0;
            // 
            // ofdSelectProductImage
            // 
            ofdSelectProductImage.FileName = "openFileDialog1";
            // 
            // splitContainer26
            // 
            splitContainer26.Dock = DockStyle.Fill;
            splitContainer26.IsSplitterFixed = true;
            splitContainer26.Location = new Point(3, 3);
            splitContainer26.Name = "splitContainer26";
            // 
            // splitContainer26.Panel1
            // 
            splitContainer26.Panel1.Controls.Add(dataGridView8);
            splitContainer26.Size = new Size(429, 100);
            splitContainer26.SplitterDistance = 143;
            splitContainer26.TabIndex = 0;
            // 
            // dataGridView8
            // 
            dataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView8.Dock = DockStyle.Fill;
            dataGridView8.Location = new Point(0, 0);
            dataGridView8.Name = "dataGridView8";
            dataGridView8.RowHeadersWidth = 62;
            dataGridView8.Size = new Size(143, 100);
            dataGridView8.TabIndex = 0;
            // 
            // splitContainer27
            // 
            splitContainer27.Dock = DockStyle.Fill;
            splitContainer27.FixedPanel = FixedPanel.Panel1;
            splitContainer27.IsSplitterFixed = true;
            splitContainer27.Location = new Point(0, 0);
            splitContainer27.Name = "splitContainer27";
            splitContainer27.Orientation = Orientation.Horizontal;
            // 
            // splitContainer27.Panel1
            // 
            splitContainer27.Panel1.Controls.Add(groupBox24);
            splitContainer27.Size = new Size(150, 454);
            splitContainer27.TabIndex = 0;
            // 
            // groupBox24
            // 
            groupBox24.Controls.Add(tableLayoutPanel17);
            groupBox24.Dock = DockStyle.Fill;
            groupBox24.Location = new Point(0, 0);
            groupBox24.Name = "groupBox24";
            groupBox24.Size = new Size(150, 50);
            groupBox24.TabIndex = 1;
            groupBox24.TabStop = false;
            groupBox24.Text = "Bộ lọc tìm kiếm";
            // 
            // tableLayoutPanel17
            // 
            tableLayoutPanel17.ColumnCount = 2;
            tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23F));
            tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77F));
            tableLayoutPanel17.Controls.Add(button34, 1, 2);
            tableLayoutPanel17.Controls.Add(label55, 0, 0);
            tableLayoutPanel17.Controls.Add(textBox36, 1, 1);
            tableLayoutPanel17.Controls.Add(textBox37, 1, 0);
            tableLayoutPanel17.Controls.Add(label56, 0, 1);
            tableLayoutPanel17.Dock = DockStyle.Fill;
            tableLayoutPanel17.Location = new Point(3, 19);
            tableLayoutPanel17.Name = "tableLayoutPanel17";
            tableLayoutPanel17.RowCount = 3;
            tableLayoutPanel17.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel17.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel17.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tableLayoutPanel17.Size = new Size(144, 28);
            tableLayoutPanel17.TabIndex = 3;
            // 
            // button34
            // 
            button34.Location = new Point(36, -49);
            button34.Name = "button34";
            button34.Size = new Size(105, 44);
            button34.TabIndex = 2;
            button34.Text = "Tìm kiếm";
            button34.UseVisualStyleBackColor = true;
            // 
            // label55
            // 
            label55.AutoSize = true;
            label55.Dock = DockStyle.Fill;
            label55.Location = new Point(3, 0);
            label55.Name = "label55";
            label55.Size = new Size(27, 1);
            label55.TabIndex = 0;
            label55.Text = "Mã hãng:";
            // 
            // textBox36
            // 
            textBox36.Dock = DockStyle.Fill;
            textBox36.Location = new Point(36, -23);
            textBox36.Name = "textBox36";
            textBox36.Size = new Size(105, 23);
            textBox36.TabIndex = 1;
            // 
            // textBox37
            // 
            textBox37.Dock = DockStyle.Fill;
            textBox37.Location = new Point(36, 3);
            textBox37.Name = "textBox37";
            textBox37.Size = new Size(105, 23);
            textBox37.TabIndex = 1;
            // 
            // label56
            // 
            label56.AutoSize = true;
            label56.Dock = DockStyle.Fill;
            label56.Location = new Point(3, -26);
            label56.Name = "label56";
            label56.Size = new Size(27, 1);
            label56.TabIndex = 0;
            label56.Text = "Tên hãng:";
            // 
            // splitContainer28
            // 
            splitContainer28.Dock = DockStyle.Fill;
            splitContainer28.FixedPanel = FixedPanel.Panel1;
            splitContainer28.IsSplitterFixed = true;
            splitContainer28.Location = new Point(0, 0);
            splitContainer28.Name = "splitContainer28";
            splitContainer28.Orientation = Orientation.Horizontal;
            splitContainer28.Size = new Size(150, 100);
            splitContainer28.TabIndex = 0;
            // 
            // groupBox25
            // 
            groupBox25.Location = new Point(0, 0);
            groupBox25.Name = "groupBox25";
            groupBox25.Size = new Size(200, 100);
            groupBox25.TabIndex = 0;
            groupBox25.TabStop = false;
            // 
            // tableLayoutPanel18
            // 
            tableLayoutPanel18.ColumnCount = 2;
            tableLayoutPanel18.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.75F));
            tableLayoutPanel18.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.25F));
            tableLayoutPanel18.Controls.Add(label57, 0, 0);
            tableLayoutPanel18.Location = new Point(0, 0);
            tableLayoutPanel18.Name = "tableLayoutPanel18";
            tableLayoutPanel18.RowCount = 1;
            tableLayoutPanel18.Size = new Size(200, 100);
            tableLayoutPanel18.TabIndex = 0;
            // 
            // label57
            // 
            label57.AutoSize = true;
            label57.Dock = DockStyle.Fill;
            label57.Location = new Point(3, 0);
            label57.Name = "label57";
            label57.Size = new Size(39, 100);
            label57.TabIndex = 0;
            label57.Text = "Mã hãng:";
            // 
            // label58
            // 
            label58.AutoSize = true;
            label58.Dock = DockStyle.Fill;
            label58.Location = new Point(3, 30);
            label58.Name = "label58";
            label58.Size = new Size(39, 70);
            label58.TabIndex = 0;
            label58.Text = "Tên hãng:";
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(0, 0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(200, 100);
            tabPage1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tslStaffName, toolStripSeparator2, tsbStatistics, toolStripSeparator1, tsbLogout });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1264, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tslStaffName
            // 
            tslStaffName.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            tslStaffName.ForeColor = Color.Brown;
            tslStaffName.Image = (Image)resources.GetObject("tslStaffName.Image");
            tslStaffName.ImageAlign = ContentAlignment.MiddleRight;
            tslStaffName.Name = "tslStaffName";
            tslStaffName.Size = new Size(98, 22);
            tslStaffName.Text = "Nhân viên";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // tsbStatistics
            // 
            tsbStatistics.Image = (Image)resources.GetObject("tsbStatistics.Image");
            tsbStatistics.ImageTransparentColor = Color.Magenta;
            tsbStatistics.Name = "tsbStatistics";
            tsbStatistics.Size = new Size(76, 22);
            tsbStatistics.Text = "Thống kê";
            tsbStatistics.Click += tsbStatistics_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // tsbLogout
            // 
            tsbLogout.Image = (Image)resources.GetObject("tsbLogout.Image");
            tsbLogout.ImageTransparentColor = Color.Magenta;
            tsbLogout.Name = "tsbLogout";
            tsbLogout.Size = new Size(81, 22);
            tsbLogout.Text = "Đăng xuất";
            tsbLogout.Click += tsbLogout_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(TabControl);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(1264, 656);
            panel3.TabIndex = 2;
            // 
            // frmManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel3);
            Controls.Add(toolStrip1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmManage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý cửa hàng";
            FormClosing += frmManage_FormClosing;
            Load += frmManage_Load;
            TabControl.ResumeLayout(false);
            tpCustomer.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvCustomer).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            tpOrder.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvOrder).EndInit();
            splitContainer5.Panel1.ResumeLayout(false);
            splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer5).EndInit();
            splitContainer5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel2.ResumeLayout(false);
            splitContainer6.Panel1.ResumeLayout(false);
            splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer6).EndInit();
            splitContainer6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            groupBox6.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            tpProduct.ResumeLayout(false);
            splitContainer10.Panel1.ResumeLayout(false);
            splitContainer10.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer10).EndInit();
            splitContainer10.ResumeLayout(false);
            splitContainer11.Panel1.ResumeLayout(false);
            splitContainer11.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer11).EndInit();
            splitContainer11.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            splitContainer33.Panel1.ResumeLayout(false);
            splitContainer33.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer33).EndInit();
            splitContainer33.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            splitContainer12.Panel1.ResumeLayout(false);
            splitContainer12.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer12).EndInit();
            splitContainer12.ResumeLayout(false);
            groupBox10.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            splitContainer32.Panel1.ResumeLayout(false);
            splitContainer32.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer32).EndInit();
            splitContainer32.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
            groupBox11.ResumeLayout(false);
            tpManufacturer.ResumeLayout(false);
            splitContainer14.Panel1.ResumeLayout(false);
            splitContainer14.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer14).EndInit();
            splitContainer14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvManufacturer).EndInit();
            splitContainer15.Panel1.ResumeLayout(false);
            splitContainer15.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer15).EndInit();
            splitContainer15.ResumeLayout(false);
            groupBox12.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            splitContainer16.Panel1.ResumeLayout(false);
            splitContainer16.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer16).EndInit();
            splitContainer16.ResumeLayout(false);
            groupBox13.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            groupBox14.ResumeLayout(false);
            flowLayoutPanel6.ResumeLayout(false);
            tpCategory.ResumeLayout(false);
            splitContainer17.Panel1.ResumeLayout(false);
            splitContainer17.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer17).EndInit();
            splitContainer17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).EndInit();
            splitContainer18.Panel1.ResumeLayout(false);
            splitContainer18.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer18).EndInit();
            splitContainer18.ResumeLayout(false);
            groupBox15.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            splitContainer19.Panel1.ResumeLayout(false);
            splitContainer19.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer19).EndInit();
            splitContainer19.ResumeLayout(false);
            groupBox16.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            groupBox17.ResumeLayout(false);
            tpGRN.ResumeLayout(false);
            splitContainer20.Panel1.ResumeLayout(false);
            splitContainer20.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer20).EndInit();
            splitContainer20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvGRN).EndInit();
            splitContainer21.Panel1.ResumeLayout(false);
            splitContainer21.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer21).EndInit();
            splitContainer21.ResumeLayout(false);
            groupBox18.ResumeLayout(false);
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel13.PerformLayout();
            panel1.ResumeLayout(false);
            splitContainer22.Panel1.ResumeLayout(false);
            splitContainer22.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer22).EndInit();
            splitContainer22.ResumeLayout(false);
            groupBox19.ResumeLayout(false);
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox20.ResumeLayout(false);
            flowLayoutPanel8.ResumeLayout(false);
            tpStaff.ResumeLayout(false);
            splitContainer23.Panel1.ResumeLayout(false);
            splitContainer23.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer23).EndInit();
            splitContainer23.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvStaff).EndInit();
            splitContainer24.Panel1.ResumeLayout(false);
            splitContainer24.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer24).EndInit();
            splitContainer24.ResumeLayout(false);
            groupBox21.ResumeLayout(false);
            tableLayoutPanel15.ResumeLayout(false);
            tableLayoutPanel15.PerformLayout();
            splitContainer25.Panel1.ResumeLayout(false);
            splitContainer25.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer25).EndInit();
            splitContainer25.ResumeLayout(false);
            groupBox22.ResumeLayout(false);
            tableLayoutPanel16.ResumeLayout(false);
            tableLayoutPanel16.PerformLayout();
            groupBox23.ResumeLayout(false);
            flowLayoutPanel9.ResumeLayout(false);
            tpAccount.ResumeLayout(false);
            splitContainer29.Panel1.ResumeLayout(false);
            splitContainer29.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer29).EndInit();
            splitContainer29.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            splitContainer30.Panel1.ResumeLayout(false);
            splitContainer30.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer30).EndInit();
            splitContainer30.ResumeLayout(false);
            groupBox26.ResumeLayout(false);
            tableLayoutPanel19.ResumeLayout(false);
            tableLayoutPanel19.PerformLayout();
            splitContainer31.Panel1.ResumeLayout(false);
            splitContainer31.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer31).EndInit();
            splitContainer31.ResumeLayout(false);
            groupBox27.ResumeLayout(false);
            tableLayoutPanel20.ResumeLayout(false);
            tableLayoutPanel20.PerformLayout();
            groupBox28.ResumeLayout(false);
            flowLayoutPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)staffBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            splitContainer8.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer8).EndInit();
            splitContainer8.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer9).EndInit();
            splitContainer9.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            splitContainer7.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer7).EndInit();
            splitContainer7.ResumeLayout(false);
            splitContainer26.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer26).EndInit();
            splitContainer26.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView8).EndInit();
            splitContainer27.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer27).EndInit();
            splitContainer27.ResumeLayout(false);
            groupBox24.ResumeLayout(false);
            tableLayoutPanel17.ResumeLayout(false);
            tableLayoutPanel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer28).EndInit();
            splitContainer28.ResumeLayout(false);
            tableLayoutPanel18.ResumeLayout(false);
            tableLayoutPanel18.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl TabControl;
        private TabPage tpCustomer;
        private TabPage tpOrder;
        private GroupBox groupBox1;
        private SplitContainer splitContainer1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private RichTextBox rtbAddress;
        private Label label3;
        private Label label4;
        private Button btnSearchCustomer;
        private TextBox txtSearchNumberPhone;
        private TextBox txtSearchName;
        private Button btnAddCustomer;
        private Button btnUpdateCustomer;
        private TextBox txtNumberPhone;
        private TextBox txtName;
        private Label label5;
        private Button btnCustomerAddOrder;
        private SplitContainer splitContainer2;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer4;
        private DataGridView dtgvOrder;
        private SplitContainer splitContainer5;
        private GroupBox groupBox4;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label6;
        private TextBox txtSearchOrderID;
        private Label label7;
        private Button btnSearchOrder;
        private Label label11;
        private DateTimePicker dtpkSearchOrderTo;
        private SplitContainer splitContainer6;
        private GroupBox groupBox5;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label8;
        private Label label9;
        private Label label10;
        private GroupBox groupBox6;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnView;
        private Button btnAddOrder;
        private DateTimePicker dtpkSearchOrderFrom;
        private TabPage tpProduct;
        private TabPage tpManufacturer;
        private TabPage tpCategory;
        private SplitContainer splitContainer10;
        private SplitContainer splitContainer11;
        private GroupBox groupBox9;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label21;
        private TextBox txtSearchProductID;
        private Label label22;
        private SplitContainer splitContainer12;
        private GroupBox groupBox10;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label26;
        private Label label27;
        private Label label28;
        private TextBox txtProductName;
        private GroupBox groupBox11;
        private Button btnAddProduct;
        private Button btnUpdateProduct;
        private DataGridView dataGridView3;
        private SplitContainer splitContainer8;
        private GroupBox groupBox7;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label14;
        private TextBox textBox11;
        private Label label15;
        private Label label16;
        private Button button11;
        private Label label17;
        private DateTimePicker dateTimePicker3;
        private TextBox textBox12;
        private TextBox textBox13;
        private Label label18;
        private DateTimePicker dateTimePicker4;
        private SplitContainer splitContainer9;
        private GroupBox groupBox8;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label19;
        private Label label20;
        private SplitContainer splitContainer7;
        private Label label23;
        private RichTextBox rtbProductInfomation;
        private PictureBox pbProductImage;
        private Button btnSelectProductImage;
        private Button btnDeleteProductImage;
        private Label label25;
        private OpenFileDialog ofdSelectProductImage;
        private FlowLayoutPanel flpProduct;
        private Label label34;
        private Label label35;
        private SplitContainer splitContainer14;
        private DataGridView dtgvManufacturer;
        private SplitContainer splitContainer15;
        private GroupBox groupBox12;
        private TableLayoutPanel tableLayoutPanel9;
        private Button btnSearchManufacturer;
        private Label label29;
        private TextBox txtSearchManuName;
        private TextBox txtSearchManuID;
        private Label label30;
        private SplitContainer splitContainer16;
        private GroupBox groupBox13;
        private TableLayoutPanel tableLayoutPanel10;
        private Label label31;
        private Label label32;
        private TextBox txtManufacturerName;
        private GroupBox groupBox14;
        private FlowLayoutPanel flowLayoutPanel6;
        private ComboBox cbProductCategory;
        private ComboBox cbProductManufacturer;
        private TextBox txtSearchProductName;
        private SplitContainer splitContainer17;
        private DataGridView dtgvCategory;
        private SplitContainer splitContainer18;
        private GroupBox groupBox15;
        private TableLayoutPanel tableLayoutPanel11;
        private Button btnSearchCate;
        private Label label33;
        private TextBox txtSearchCateName;
        private TextBox txtSearchCateID;
        private Label label36;
        private SplitContainer splitContainer19;
        private GroupBox groupBox16;
        private TableLayoutPanel tableLayoutPanel12;
        private Label label37;
        private Label label38;
        private TextBox txtCateName;
        private GroupBox groupBox17;
        private TabPage tpGRN;
        private TabPage tpStaff;
        private TabPage tpAccount;
        private Label label39;
        private SplitContainer splitContainer20;
        private DataGridView dtgvGRN;
        private SplitContainer splitContainer21;
        private GroupBox groupBox18;
        private TableLayoutPanel tableLayoutPanel13;
        private Label label40;
        private TextBox txtSearchGRNID;
        private Label label41;
        private Label label42;
        private Button btnSearchGRN;
        private Label label43;
        private DateTimePicker dtpkSearchGRNTo;
        private DateTimePicker dtpkSearchGRNFrom;
        private SplitContainer splitContainer22;
        private GroupBox groupBox19;
        private TableLayoutPanel tableLayoutPanel14;
        private Label label45;
        private Label label46;
        private Label label47;
        private GroupBox groupBox20;
        private FlowLayoutPanel flowLayoutPanel8;
        private Button btnDetailAndUpdateGRN;
        private Button btnAddGRN;
        private SplitContainer splitContainer23;
        private DataGridView dtgvStaff;
        private SplitContainer splitContainer24;
        private GroupBox groupBox21;
        private TableLayoutPanel tableLayoutPanel15;
        private Button btnSearchStaff;
        private Label label44;
        private TextBox txtSearchStaffName;
        private TextBox txtSearchStaffID;
        private Label label48;
        private SplitContainer splitContainer25;
        private GroupBox groupBox22;
        private TableLayoutPanel tableLayoutPanel16;
        private Label label49;
        private Label label50;
        private Label label51;
        private TextBox txtStaffName;
        private GroupBox groupBox23;
        private Label label52;
        private Label label53;
        private Label label54;
        private ComboBox cbStaffGender;
        private ComboBox cboStaffStatus;
        private TextBox txtStaffPhone;
        private SplitContainer splitContainer29;
        private DataGridView dtgvAccount;
        private SplitContainer splitContainer30;
        private GroupBox groupBox26;
        private TableLayoutPanel tableLayoutPanel19;
        private Button btnSearchAccount;
        private Label label59;
        private TextBox txtSearchLoginName;
        private SplitContainer splitContainer31;
        private GroupBox groupBox27;
        private TableLayoutPanel tableLayoutPanel20;
        private Label label61;
        private Label label62;
        private TextBox txtPassword;
        private GroupBox groupBox28;
        private FlowLayoutPanel flowLayoutPanel10;
        private SplitContainer splitContainer26;
        private DataGridView dataGridView8;
        private SplitContainer splitContainer27;
        private GroupBox groupBox24;
        private TableLayoutPanel tableLayoutPanel17;
        private Button button34;
        private Label label55;
        private TextBox textBox36;
        private TextBox textBox37;
        private Label label56;
        private SplitContainer splitContainer28;
        private GroupBox groupBox25;
        private TableLayoutPanel tableLayoutPanel18;
        private Label label57;
        private Label label58;
        private TabPage tabPage1;
        private Label label64;
        private Label label65;
        private ComboBox cbAccountType;
        private ComboBox cbAccountStaff;
        private Button btnAddManufacturer;
        private Button btnUpdateManufacturer;
        private Button btnAddCate;
        private Button btnUpdateCate;
        private FlowLayoutPanel flowLayoutPanel9;
        private Button btnAddStaff;
        private Button btnUpdateStaff;
        private Button btnAddAccount;
        private Button btnUpdateAccount;
        private Button btnSearchProduct;
        private ComboBox cbStaffRole;
        private Label label66;
        private RichTextBox rtbStaffAdress;
        private Label label67;
        private DateTimePicker dtpStaffBornDate;
        private BindingSource staffBindingSource;
        private DataGridView dtgvCustomer;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Label label68;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private Panel panel1;
        private Button btnSearchGRNCancel;
        private DataGridViewTextBoxColumn sdt;
        private DataGridViewTextBoxColumn cusName;
        private DataGridViewTextBoxColumn cusAddress;
        private DataGridViewTextBoxColumn ManuID;
        private DataGridViewTextBoxColumn ManuName;
        private DataGridViewTextBoxColumn CateID;
        private DataGridViewTextBoxColumn CateName;
        private DataGridViewTextBoxColumn OrderID;
        private DataGridViewTextBoxColumn OrderCustomer;
        private DataGridViewTextBoxColumn OrderCustomerPhone;
        private DataGridViewTextBoxColumn OrderStatus;
        private DataGridViewTextBoxColumn OrderTotal;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn OrderStaff;
        private Label label69;
        private Panel panel2;
        private Button btnSearchOrderCancel;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbLogout;
        private ToolStripButton tsbStatistics;
        private ToolStripSeparator toolStripSeparator1;
        private Panel panel3;
        private ToolStripLabel tslStaffName;
        private ToolStripSeparator toolStripSeparator2;
        private Panel panel4;
        private Label label12;
        private Panel panel5;
        private Label label13;
        private Panel panel;
        private Label label60;
        private SplitContainer splitContainer32;
        private SplitContainer splitContainer33;
        private Label txtOrderTotal;
        private TextBox txtProductPrice;
        private Panel panel6;
        private Label txtOrderCustomerName;
        private Label txtOrderStaff;
        private Label txtOrderStatus;
        private Label txtOrderID;
        private Label txtProductID;
        private Label txtManufacturerID;
        private Label txtCategoryID;
        private Label txtGRNStaff;
        private Label txtGRNUnit;
        private Label txtGRNTotal;
        private Label txtGRNID;
        private Label txtGRNDate;
        private Label txtStaffID;
        private TextBox txtLoginName;
        private DataGridViewTextBoxColumn AccountID;
        private DataGridViewTextBoxColumn accountType;
        private DataGridViewTextBoxColumn accountStaff;
        private Panel panel7;
        private TextBox txtProductQuantity;
    }
}