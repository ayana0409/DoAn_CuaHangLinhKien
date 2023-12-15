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
    public partial class frmManage : Form
    {
        public Account loginAccount;
        public frmManage()
        {
            InitializeComponent();
        }

        private void frmManage_Load(object sender, EventArgs e)
        {
            CheckRole();



            #region FAKE
            string query = "select * from ThongTinPhieuNhap";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            
            Product SP1 = new(1, 1, 1, "San pham 1", "Mo ta san pham 1", 12, 20000, "3019283102938103.jpg");
            Product SP2 = new(1, 1, 1, "San pham 2", "Mo ta san pham 1", 12, 20000, "3019283102938103.jpg");
            Product SP3 = new(1, 1, 1, "San pham 1", "Mo ta san pham 1", 12, 20000, "3019283102938103.jpg");
            Product SP4 = new(1, 1, 1, "San pham 1", "Mo ta san pham 1", 12, 20000, "3019283102938103.jpg");
            Product SP5 = new(1, 1, 1, "San pham 1", "Mo ta san pham 1", 12, 20000, "3019283102938103.jpg");
            Product SP6 = new(1, 1, 1, "San pham 1", "Mo ta san pham 1", 12, 20000, "3019283102938103.jpg");
            Product SP7 = new(1, 1, 1, "San pham 1", "Mo ta san pham 1", 12, 20000, "3019283102938103.jpg");
            Product SP8 = new(1, 1, 1, "San pham 1", "Mo ta san pham 1", 12, 20000, "3019283102938103.jpg");
            Product SP9 = new(1, 1, 1, "San pham 1", "Mo ta san pham 1", 12, 20000, "3019283102938103.jpg");
            Product SP10 = new(1, 1, 1, "San pham 1", "Mo ta san pham 1", 12, 20000, "3019283102938103.jpg");
            Product SP11 = new(1, 1, 1, "San pham 1", "Mo ta san pham 1", 12, 20000, "3019283102938103.jpg");
            Product SP12 = new(1, 1, 1, "San pham 1", "Mo ta san pham 1", 12, 20000, "3019283102938103.jpg");
            Product SP13 = new(1, 1, 1, "San pham 1", "Mo ta san pham 1", 12, 20000, "3019283102938103.jpg");

            List<Product> list = new();

            list.Add(SP1); list.Add(SP2);
            list.Add(SP3);
            list.Add(SP4);
            list.Add(SP5);
            list.Add(SP6);
            list.Add(SP7);
            list.Add(SP8);
            list.Add(SP9);
            list.Add(SP10);
            list.Add(SP11);
            list.Add(SP12);
            list.Add(SP13);


            foreach (Product p in list)
            {
                SPViewer view = new(p);
                view.WasClicked += FlowLayOutPanel_Controls_WasClicked;
                flpProduct.Controls.Add(view);
            }
            #endregion
        }
        // LoadCustomer -- source = CustomerDAL.I.Get....

        private void CheckRole()
        {
            AccountType type = AccountTypeDAL.Instance.GetAccountType(loginAccount.TypeID);
            if (type.TypeName == "Nhân viên")
            {
                TabControl.TabPages.Remove(tpProduct);
                TabControl.TabPages.Remove(tpCategory);
                TabControl.TabPages.Remove(tpManufacturer);
                TabControl.TabPages.Remove(tpGRN);
                TabControl.TabPages.Remove(tpStaff);
                TabControl.TabPages.Remove(tpAccount);
            }
            else if (type.TypeName == "Quản lý")
            {
                TabControl.TabPages.Remove(tpAccount);
            }
        }

        void FlowLayOutPanel_Controls_WasClicked(object sender, EventArgs e)
        {
            // Set IsSelected for all UCs in the FlowLayoutPanel to false. 
            foreach (Control c in flpProduct.Controls)
            {
                if (c is SPViewer)
                {
                    ((SPViewer)c).IsSelected = false;
                }
            }
        }
    }
}
