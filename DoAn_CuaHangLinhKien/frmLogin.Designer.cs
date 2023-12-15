namespace GUI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            btnLogin = new Button();
            btnExit = new Button();
            txtAccountID = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.56168F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.5091858F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.8425179F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.61154842F));
            tableLayoutPanel2.Controls.Add(panel1, 2, 3);
            tableLayoutPanel2.Controls.Add(txtAccountID, 2, 1);
            tableLayoutPanel2.Controls.Add(txtPassword, 2, 2);
            tableLayoutPanel2.Controls.Add(label2, 1, 2);
            tableLayoutPanel2.Controls.Add(label1, 1, 1);
            tableLayoutPanel2.Location = new Point(122, 153);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15.6862745F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 84.31373F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel2.Size = new Size(381, 159);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(btnExit);
            panel1.Location = new Point(127, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 49);
            panel1.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogin.BackColor = Color.FromArgb(152, 188, 226);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.MidnightBlue;
            btnLogin.Location = new Point(0, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(121, 43);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(152, 188, 226);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.MidnightBlue;
            btnExit.Image = Properties.Resources.icons8_export_26;
            btnExit.Location = new Point(174, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(43, 43);
            btnExit.TabIndex = 2;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // txtAccountID
            // 
            txtAccountID.BackColor = Color.LavenderBlush;
            txtAccountID.Location = new Point(127, 12);
            txtAccountID.Name = "txtAccountID";
            txtAccountID.Size = new Size(220, 33);
            txtAccountID.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.LavenderBlush;
            txtPassword.Location = new Point(127, 62);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(220, 33);
            txtPassword.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.Lavender;
            label2.Location = new Point(27, 59);
            label2.Name = "label2";
            label2.Size = new Size(94, 36);
            label2.TabIndex = 0;
            label2.Text = "Mật khẩu:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.Lavender;
            label1.Location = new Point(27, 19);
            label1.Name = "label1";
            label1.Size = new Size(94, 29);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Lavender;
            label3.Location = new Point(133, 118);
            label3.Name = "label3";
            label3.Size = new Size(358, 32);
            label3.TabIndex = 1;
            label3.Text = "ĐĂNG NHẬP VÀO ỨNG DỤNG";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(624, 441);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(label3);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 3, 5, 3);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += frmLogin_FormClosing;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnLogin;
        private Label label1;
        private Label label2;
        private TextBox txtAccountID;
        private TextBox txtPassword;
        private Label label3;
        private Button btnExit;
        private Panel panel1;
    }
}