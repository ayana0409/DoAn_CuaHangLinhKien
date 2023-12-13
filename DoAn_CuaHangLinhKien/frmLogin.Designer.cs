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
            panel1 = new Panel();
            txbUserName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            txtPassWord = new TextBox();
            label3 = new Label();
            btnLogin = new Button();
            btnExit = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txbUserName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(10, 38);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 30);
            panel1.TabIndex = 0;
            // 
            // txbUserName
            // 
            txbUserName.BackColor = Color.FromArgb(255, 253, 239);
            txbUserName.ForeColor = Color.Wheat;
            txbUserName.Location = new Point(139, 5);
            txbUserName.Margin = new Padding(3, 2, 3, 2);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(318, 23);
            txbUserName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.Location = new Point(5, 7);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên đăng nhập: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(196, 9);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 1;
            label1.Text = "ĐĂNG NHẬP ";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtPassWord);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(10, 73);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(467, 30);
            panel2.TabIndex = 2;
            // 
            // txtPassWord
            // 
            txtPassWord.BackColor = Color.FromArgb(255, 253, 239);
            txtPassWord.ForeColor = Color.Wheat;
            txtPassWord.Location = new Point(139, 5);
            txtPassWord.Margin = new Padding(3, 2, 3, 2);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(318, 23);
            txtPassWord.TabIndex = 1;
            txtPassWord.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.Location = new Point(5, 7);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightGray;
            btnLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnLogin.ForeColor = Color.Brown;
            btnLogin.Location = new Point(224, 8);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(96, 25);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Đăng nhập ";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightGray;
            btnExit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnExit.ForeColor = Color.Brown;
            btnExit.Location = new Point(347, 8);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(96, 25);
            btnExit.TabIndex = 4;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnLogin);
            panel3.Controls.Add(btnExit);
            panel3.Location = new Point(10, 107);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(467, 39);
            panel3.TabIndex = 5;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(488, 155);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += frmLogin_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txbUserName;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private TextBox txtPassWord;
        private Label label3;
        private Button btnLogin;
        private Button btnExit;
        private Panel panel3;
    }
}