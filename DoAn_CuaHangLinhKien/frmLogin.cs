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
        private string productImagePath = Application.StartupPath.Split("\\DoAn_CuaHangLinhKien", StringSplitOptions.None)[0]
                        + @"\DoAn_CuaHangLinhKien\BLL\product-images\";
        private List<string> productImageDelete = new();
        public frmLogin()
        {
            InitializeComponent();
        }
        private void deleteProductImage(List<String> list)
        {
            foreach (string name in list)
            {
                File.Delete(productImagePath + name);
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
                foreach (string name in frm.listDeleteProductImage)
                    productImageDelete.Add(name);
                this.Show();
            }
            else
                MessageBox.Show("Sai thông tin đăng nhập.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            deleteProductImage(productImageDelete);
            this.Close();
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình ? ", "Thông báo ", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        #endregion

        private bool Login(string username, string password)
        {
            return AccountDAL.Instance.Login(username, password);
        }

    }
}
