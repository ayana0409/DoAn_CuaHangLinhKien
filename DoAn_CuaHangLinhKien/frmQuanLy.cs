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
        List<Product> listProduct;
        List<Category> listCategory;
        List<Manufacturer> listManufacturer;

        string? _tempImageName = null;
        public frmManage()
        {
            InitializeComponent();
        }

        private void frmManage_Load(object sender, EventArgs e)
        {
            CheckRole();
            listCategory = CategoryDAL.Instance.GetListCategory();
            listManufacturer = ManufacturerDAL.Instance.GetListManufacturer();  

            LoadProduct();

        }
        // LoadCustomer -- source = CustomerDAL.I.Get....


        private void LoadProduct()
        {
            listProduct = ProductDAL.Instance.GetListProduct();
            flpProduct.Controls.Clear();
            foreach (Product p in listProduct)
            {
                SPViewer ctrViewer = new(p);
                ctrViewer.WasClicked += FlowLayOutPanel_Controls_WasClicked;
                flpProduct.Controls.Add(ctrViewer);
            }
            cbProductCategory.DataSource = listCategory;
            cbProductManufacturer.DataSource = listManufacturer;
        }
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
            SPViewer v = sender as SPViewer;
            txtProductID.Text = v.Product.ProductID.ToString();
            txtProductName.Text = v.Product.ProductName;
            txtProductPrice.Text = v.Product.Price.ToString();
            rtbProductInfomation.Text = v.Product.Information;
            nmudQuantity.Value = v.Product.Quantity;
            cbProductCategory.Text = v.Product.CategoryID.ToString();
            cbProductManufacturer.Text = v.Product.ManufacturerID.ToString();
            if (v.Product.Image != String.Empty)
            {
                pbProductImage.Image = Image.FromFile(Application.StartupPath.Split("\\DoAn_CuaHangLinhKien", StringSplitOptions.None)[0] + @"\DoAn_CuaHangLinhKien\BLL\product-images\" + v.Product.Image);
            }

        }

        private void btnSelectProductImage_Click(object sender, EventArgs e)
        {
            ofdSelectProductImage.ShowDialog();
            string fileName = ofdSelectProductImage.FileName;

            _tempImageName = fileName;
            pbProductImage.Image = Image.FromFile(fileName);
            //string newFileName = Guid.NewGuid().ToString() + Path.GetExtension(fileName);

            //File.Copy(fileName, Application.StartupPath.Split("\\DoAn_CuaHangLinhKien", StringSplitOptions.None)[0] + @"\DoAn_CuaHangLinhKien\BLL\product-images\"+ newFileName);
            //string productPath = Path.Combine(wwwRootPath, @"images\product")
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (btnSaveProduct.Enabled)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có muốn hủy thao tác?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
                if (result == DialogResult.Yes )
                {
                    ClearInputBox();
                    btnUpdateProduct.Enabled = true;
                    btnSaveProduct.Enabled = false;
                    return;
                }
            }
            else
            {
                btnAddProduct.Enabled = true;
                btnUpdateProduct.Enabled = false;
                btnSaveProduct.Enabled = true;

                ClearInputBox();
            }
            
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            
            if (btnSaveProduct.Enabled)
            {
                if (txtProductName.Text == String.Empty ||
                    txtProductPrice.Text ==  String.Empty ||
                    cbProductCategory.Text ==  String.Empty ||
                    cbProductManufacturer.Text ==  String.Empty ||
                    _tempImageName == String.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!");
                    return;
                }

                string name = txtProductName.Text;
                string info = rtbProductInfomation.Text;
                double price = Double.Parse(txtProductPrice.Text);
                int quantity = (int)nmudQuantity.Value;

                string fileName = _tempImageName;
                string newFileName = Guid.NewGuid().ToString() + Path.GetExtension(fileName);
                File.Copy(fileName, 
                    Application.StartupPath.Split("\\DoAn_CuaHangLinhKien", StringSplitOptions.None)[0] 
                    + @"\DoAn_CuaHangLinhKien\BLL\product-images\" + newFileName);
                Category productCategory = cbProductCategory.SelectedItem as Category;
                Manufacturer productManufacturer = cbProductManufacturer.SelectedItem as Manufacturer;


                if (ProductDAL.Instance.InsertProduct(name, productCategory.CategoryID, productManufacturer.ManufacturerID, info, price, quantity, newFileName))
                {
                    MessageBox.Show("Thêm thành công rồi, vui vãi");
                    LoadProduct();
                }
                else
                {
                    MessageBox.Show("Lỗi rồi");
                }
            }
        }

        private void ClearInputBox()
        {
            txtProductID.Text = String.Empty;
            txtProductName.Text = String.Empty;
            txtProductPrice.Text = String.Empty;
            rtbProductInfomation.Text = String.Empty;
            nmudQuantity.Value = 0;
            cbProductCategory.Text = String.Empty;
            cbProductManufacturer.Text = String.Empty;
            pbProductImage.Image = null;
        }
    }
}
