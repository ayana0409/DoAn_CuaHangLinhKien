using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace GUI
{
    public partial class frmLogin : Form
    {
        private string productImagePath = "C:\\CuaHangLinhKien\\HinhAnhSanPham\\";
        private List<string> productImageDelete = [];

        public frmLogin()
        {
            InitializeComponent();
            Directory.CreateDirectory("C:\\CuaHangLinhKien\\HinhAnhSanPham\\");
        }
        private void deleteProductImage(List<String> list)
        {
            foreach (string name in list)
            {
                if (name != "Unknown")
                {
                    File.Delete(productImagePath + name);
                }
            }
        }

        #region EVENT
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtAccountID.Text == String.Empty || txtPassword.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (Login(txtAccountID.Text.ToLower(), txtPassword.Text))
            {
                frmManage frm = new frmManage();
                frm.loginAccount = AccountDAL.Instance.GetAccountByID(txtAccountID.Text);
                this.Hide();
                frm.ShowDialog();
                frm.Close();
                frm.Dispose();
                productImageDelete = frm.listDeleteProductImage;
                this.Show();
            }
            else
                MessageBox.Show("Sai thông tin đăng nhập.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình? ", "Thông báo ", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private bool Login(string username, string password)
        {
            return AccountDAL.Instance.Login(username, password);
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            deleteProductImage(productImageDelete);
        }
        #endregion

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtAccountID.Focus();
        }
    }
}
