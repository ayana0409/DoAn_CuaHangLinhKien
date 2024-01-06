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
            btnLogin = new Button();
            btnExit = new Button();
            txtAccountID = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogin.BackColor = Color.FromArgb(152, 188, 226);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.MidnightBlue;
            btnLogin.Location = new Point(238, 258);
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
            btnExit.Location = new Point(448, 258);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(43, 43);
            btnExit.TabIndex = 1;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // txtAccountID
            // 
            txtAccountID.BackColor = Color.LavenderBlush;
            txtAccountID.Location = new Point(238, 167);
            txtAccountID.Name = "txtAccountID";
            txtAccountID.Size = new Size(253, 33);
            txtAccountID.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.LavenderBlush;
            txtPassword.Location = new Point(238, 219);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(253, 33);
            txtPassword.TabIndex = 4;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.Lavender;
            label2.Location = new Point(133, 218);
            label2.Name = "label2";
            label2.Size = new Size(94, 36);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.Lavender;
            label1.Location = new Point(133, 170);
            label1.Name = "label1";
            label1.Size = new Size(94, 29);
            label1.TabIndex = 1;
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
            label3.TabIndex = 0;
            label3.Text = "ĐĂNG NHẬP VÀO ỨNG DỤNG";
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = btnExit;
            ClientSize = new Size(624, 441);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtAccountID);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 3, 5, 3);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosed += frmLogin_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogin;
        private Label label1;
        private Label label2;
        private TextBox txtAccountID;
        private TextBox txtPassword;
        private Label label3;
        private Button btnExit;
    }
}