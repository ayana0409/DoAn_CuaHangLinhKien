using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System.Drawing;

using DAL;
using DTO;
using Syncfusion.Pdf.Grid;
namespace GUI
{
    public partial class frmManage : Form
    {
        #region VAR
        public Account loginAccount = new();

        public List<string> listDeleteProductImage = [];

        string? _tempImageName = null;
        private string productImagePath = "C:\\CuaHangLinhKien\\HinhAnhSanPham\\";
        #endregion
        public frmManage()
        {
            InitializeComponent();
        }
        private void frmManage_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory("C:\\CuaHangLinhKien\\HinhAnhSanPham\\");
            CheckRole();

            LoadProduct();
            LoadStaff();
            LoadListRole();
            LoadGRN();
            LoadCustomer();
            LoadManufacturer();
            LoadCategory();
            LoadOrder();
            LoadAccount();

            SetSearchDate();
            CheckStaff();
        }
        #region METHOD
        #region OTHER METHOD
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
                tsbStatistics.Enabled = false;
            }
            else if (type.TypeName == "Quản lý")
            {
                TabControl.TabPages.Remove(tpAccount);
            }
        }
        private bool CheckNumber(string phone, bool _isNumberPhone = false)
        {
            bool result = false;
            char[] chars = phone.ToCharArray();
            if (_isNumberPhone) 
                if (chars.Length != 10 && chars.Length != 11)
                    return false;
            foreach (char c in chars)
            {
                switch (c)
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        result = true; continue;
                    default: return false;
                }
            }
            return result;
        }
        private void CheckStaff()
        {
            if (loginAccount.StaffID != null)
            {
                Staff staff = StaffDAL.Instance.GetStaff((int)loginAccount.StaffID);
                tslStaffName.Text = RoleDAL.Instance.GetRole(staff.RoleID)
                    + " " + staff.StaffName;
            }
            else
                tslStaffName.Text = "Nhân viên";
        }
        #endregion

        #region PRODUCT METHOD
        private void LoadProduct(List<Product>? listProduct = null)
        {
            if (listProduct == null)
                listProduct = ProductDAL.Instance.GetListProduct();
            flpProduct.Controls.Clear();
            foreach (Product p in listProduct)
            {
                SPViewer ctrViewer = new(p);
                ctrViewer.WasClicked += FlowLayOutPanel_Controls_WasClicked;
                flpProduct.Controls.Add(ctrViewer);
            }
            cbProductCategory.DataSource = CategoryDAL.Instance.GetListCategory();
            cbProductManufacturer.DataSource = ManufacturerDAL.Instance.GetListManufacturer();
            ClearProductInputBox();
            CheckImageButton();
        }
        private void ClearProductInputBox()
        {
            txtProductID.Text = String.Empty;
            txtProductName.Text = String.Empty;
            rtbProductInfomation.Text = String.Empty;
            txtProductQuantity.Text = String.Empty;
            cbProductCategory.Text = String.Empty;
            cbProductManufacturer.Text = String.Empty;
            pbProductImage.Image = null;
            txtOrderTotal.Text = String.Empty;
        }
        private void CheckImageButton()
        {
            if (pbProductImage.Image == null)
                btnDeleteProductImage.Enabled = false;
            else
                btnDeleteProductImage.Enabled = true;
        }

        #endregion

        #region STAFF METHOD
        private void LoadStaff(List<Staff>? listStaff = null)
        {
            if (listStaff == null)
                listStaff = StaffDAL.Instance.GetListStaff();
            dtgvStaff.Rows.Clear();
            foreach (Staff s in listStaff)
            {
                DataGridViewRow row = (DataGridViewRow)dtgvStaff.Rows[0].Clone(); ;
                row.Cells[0].Value = s.StaffID.ToString();
                row.Cells[1].Value = RoleDAL.Instance.GetRole(s.RoleID).RoleName;
                row.Cells[2].Value = s.StaffName;
                row.Cells[3].Value = s.Status;
                row.Cells[4].Value = s.Sex;
                row.Cells[5].Value = s.PhoneNumber;
                row.Cells[6].Value = s.Date.ToString("dd/MM/yyyy");
                row.Cells[7].Value = s.Address;
                row.Cells[8].Value = s.AccountID;
                dtgvStaff.Rows.Add(row);
            }
        }
        private void ClearStaffInputBox()
        {
            txtStaffID.Text = String.Empty;
            txtStaffName.Text = String.Empty;
            txtStaffPhone.Text = String.Empty;
            rtbStaffAdress.Text = String.Empty;
            cboStaffStatus.Text = String.Empty;
            cbStaffGender.Text = String.Empty;
        }
        private void LoadListRole()
        {
            cbStaffRole.DataSource = RoleDAL.Instance.GetListRole();
        }
        #endregion

        #region GRN METHOD
        private void LoadGRN(List<GRN>? listGRN = null)
        {
            if (listGRN == null)
                listGRN = GRNDAL.Instance.GetListGRN();
            dtgvGRN.Rows.Clear();
            foreach (GRN s in listGRN)
            {
                DataGridViewRow row = (DataGridViewRow)dtgvGRN.Rows[0].Clone(); ;
                row.Cells[0].Value = s.GRNID.ToString();
                row.Cells[1].Value = s.Unit.ToString();
                row.Cells[2].Value = StaffDAL.Instance.GetStaff(s.StaffID).StaffName;
                row.Cells[3].Value = s.Date.ToString("dd/MM/yyyy");
                row.Cells[4].Value = s.Total.ToString("#,###");
                dtgvGRN.Rows.Add(row);
            }
        }
        private void SetSearchDate()
        {
            dtpkSearchGRNFrom.Value = DateTime.Parse(String.Format(
                "{0}/{1}/{2}",
                1,
                DateTime.Now.Month,
                DateTime.Now.Year - 2
                ));
            dtpkSearchGRNTo.Value = DateTime.Parse(String.Format(
                "{0}/{1}/{2}",
                DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month),
                DateTime.Now.Month,
                DateTime.Now.Year
                ));
            dtpkSearchOrderFrom.Value = DateTime.Parse(String.Format(
                "{0}/{1}/{2}",
                1,
                DateTime.Now.Month,
                DateTime.Now.Year - 2
                ));
            dtpkSearchOrderTo.Value = DateTime.Parse(String.Format(
                "{0}/{1}/{2}",
                DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month),
                DateTime.Now.Month,
                DateTime.Now.Year
                ));
        }
        #endregion

        #region CUSTOMER METHOD
        private void LoadCustomer(List<Customer>? listCustomer = null)
        {
            if (listCustomer == null)
                listCustomer = CustomerDAL.Instance.GetListCustomer();
            dtgvCustomer.Rows.Clear();
            foreach (Customer c in listCustomer)
            {
                DataGridViewRow row = (DataGridViewRow)dtgvCustomer.Rows[0].Clone();
                row.Cells[0].Value = c.CustomerNumberPhone.ToString().Trim();
                row.Cells[1].Value = c.CustomerName.ToString();
                row.Cells[2].Value = c.CustomerAddress.ToString();
                dtgvCustomer.Rows.Add(row);
            }
        }

        private void ClearCustomer()
        {
            txtNumberPhone.Text = String.Empty;
            txtName.Text = String.Empty;
            rtbAddress.Text = String.Empty;
        }
        #endregion

        #region MANUFACTURER METHOD
        private void LoadManufacturer(List<Manufacturer>? listManufacturer = null)
        {
            if (listManufacturer == null)
                listManufacturer = ManufacturerDAL.Instance.GetListManufacturer();

            dtgvManufacturer.Rows.Clear();
            foreach (Manufacturer m in listManufacturer)
            {
                DataGridViewRow row = (DataGridViewRow)dtgvManufacturer.Rows[0].Clone();
                row.Cells[0].Value = m.ManufacturerID.ToString();
                row.Cells[1].Value = m.ManufacturerName.ToString();
                dtgvManufacturer.Rows.Add(row);
            }
        }

        private void ClearManufacturerInputBox()
        {
            txtManufacturerID.Text = String.Empty;
            txtManufacturerName.Text = String.Empty;
        }

        #endregion

        #region CATEGORY METHOD
        private void LoadCategory(List<Category>? listCategory = null)
        {
            if (listCategory == null)
                listCategory = CategoryDAL.Instance.GetListCategory();

            dtgvCategory.Rows.Clear();
            foreach (Category c in listCategory)
            {
                DataGridViewRow row = (DataGridViewRow)dtgvCategory.Rows[0].Clone();
                row.Cells[0].Value = c.CategoryID.ToString();
                row.Cells[1].Value = c.CategoryName.ToString();
                dtgvCategory.Rows.Add(row);
            }
        }

        private void ClearCategoryInputBox()
        {
            txtCategoryID.Text = String.Empty;
            txtCateName.Text = String.Empty;
        }
        #endregion

        #region ORDER METHOD
        private void LoadOrder(List<Order>? listOrder = null)
        {
            if (listOrder == null)
                listOrder = OrderDAL.Instance.GetListOrder();
            dtgvOrder.Rows.Clear();
            foreach (Order s in listOrder)
            {
                DataGridViewRow row = (DataGridViewRow)dtgvOrder.Rows[0].Clone(); ;
                row.Cells[0].Value = s.OrderID;
                row.Cells[1].Value = CustomerDAL.Instance.GetCustomer(s.CustomerNumberPhone).CustomerName;
                row.Cells[2].Value = s.CustomerNumberPhone;
                row.Cells[3].Value = s.Status;
                row.Cells[4].Value = s.Total.ToString("#,###");
                row.Cells[5].Value = s.Date.ToString("dd/MM/yyyy");
                row.Cells[6].Value = StaffDAL.Instance.GetStaff(s.StaffID).StaffName;
                dtgvOrder.Rows.Add(row);
            }
        }
        #endregion

        #region ACCOUNT METHOD
        private void LoadAccount(List<Account>? listAccount = null)
        {
            if (listAccount == null)
                listAccount = AccountDAL.Instance.GetListAccount();
            dtgvAccount.Rows.Clear();
            foreach (Account s in listAccount)
            {
                DataGridViewRow row = (DataGridViewRow)dtgvAccount.Rows[0].Clone(); ;
                row.Cells[0].Value = s.AccountID;
                row.Cells[1].Value = AccountTypeDAL.Instance.GetAccountType(s.TypeID).TypeName;

                if (s.StaffID != null)
                {
                    row.Cells[2].Value = StaffDAL.Instance.GetStaff((int)s.StaffID);
                }
                else
                {
                    row.Cells[2].Value = "Trống";
                }
                dtgvAccount.Rows.Add(row);
            }
            cbAccountStaff.DataSource = StaffDAL.Instance.GetListStaff();
            cbAccountType.DataSource = AccountTypeDAL.Instance.GetListAccountType();
        }

        private void ClearAccountInputBox()
        {
            txtLoginName.Text = String.Empty;
            txtPassword.Text = String.Empty;
            cbAccountType.Text = String.Empty;
            cbAccountStaff.Text = String.Empty;
        }

        #endregion

        #endregion

        // EVENT
        #region EVENT
        #region PRODUCT EVENT
        private void FlowLayOutPanel_Controls_WasClicked(object sender, EventArgs e)
        {
            foreach (Control c in flpProduct.Controls)
            {
                if (c is SPViewer)
                {
                    ((SPViewer)c).IsSelected = false;
                }
            }
            SPViewer v = (SPViewer)sender;
            txtProductID.Text = v.Product.ProductID.ToString();
            txtProductName.Text = v.Product.ProductName;
            txtProductPrice.Text = v.Product.Price.ToString("#,###");
            rtbProductInfomation.Text = v.Product.Information;
            txtProductQuantity.Text = v.Product.Quantity.ToString();
            cbProductCategory.Text = CategoryDAL.Instance.GetCategory(v.Product.CategoryID).CategoryName;
            cbProductManufacturer.Text = ManufacturerDAL.Instance.GetManufacturer(v.Product.ManufacturerID).ManufacturerName;

            if (v.Product.Image != "Unknown")
            {
                try
                {
                    _tempImageName = productImagePath + v.Product.Image;
                    using (Stream stream = File.OpenRead(_tempImageName))
                    {
                        pbProductImage.Image = Image.FromStream(stream);
                    };
                }
                catch
                {
                    pbProductImage.Image = null;
                    _tempImageName = null;
                }
            }
            else
                pbProductImage.Image = null;
            CheckImageButton();
        }
        private void btnSelectProductImage_Click(object sender, EventArgs e)
        {
            ofdSelectProductImage.ShowDialog();
            string fileName = ofdSelectProductImage.FileName;

            _tempImageName = fileName;
            try
            {
                using (Stream stream = File.OpenRead(_tempImageName))
                {
                    pbProductImage.Image = Image.FromStream(stream);
                };
            }
            catch
            {
                pbProductImage.Image = null;
            }
            ofdSelectProductImage.FileName = null;
            CheckImageButton();
        }
        private void btnDeleteProductImage_Click(object sender, EventArgs e)
        {
            if (pbProductImage.Image != null)
            {
                DialogResult result =
                    MessageBox.Show("Bạn muốn xóa hình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    pbProductImage.Image = null;
                    _tempImageName = null;
                }
                CheckImageButton();
            }
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            
            if (txtProductName.Text == String.Empty ||
                    txtProductPrice.Text == String.Empty ||
                    cbProductCategory.SelectedItem == null ||
                    cbProductManufacturer.SelectedItem == null ||
                    txtProductQuantity.Text == String.Empty ||
                    _tempImageName == null)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }

            if (!CheckNumber(txtProductQuantity.Text))
            {
                MessageBox.Show("Sai định dạng số lượng!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Sau khi thêm sẽ không thể xóa, bạn chắc chứ?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            string name = txtProductName.Text;
            string info = rtbProductInfomation.Text;
            double price = System.Convert.ToDouble(txtProductPrice.Text);
            int quantity = System.Convert.ToInt32(txtProductQuantity.Text);


            string fileName = _tempImageName;
            string newFileName = Guid.NewGuid().ToString() + Path.GetExtension(fileName);
            if (fileName != null)
                File.Copy(fileName, productImagePath + newFileName);
            Category productCategory = (Category)cbProductCategory.SelectedItem;
            Manufacturer productManufacturer = (Manufacturer)cbProductManufacturer.SelectedItem;

            if (ProductDAL.Instance.InsertProduct(name, productCategory.CategoryID, productManufacturer.ManufacturerID, info, price, quantity, newFileName))
            {
                MessageBox.Show("Thêm thành công");
                LoadProduct(ProductDAL.Instance.GetListProduct());
                ClearProductInputBox();
            }
            else
            {
                MessageBox.Show("Lỗi rồi");
            }
        }
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text == String.Empty ||
                txtProductName.Text == String.Empty ||
                txtProductPrice.Text == String.Empty ||
                cbProductCategory.SelectedItem == null ||
                cbProductManufacturer.SelectedItem == null ||
                _tempImageName == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }

            if (!CheckNumber(txtProductQuantity.Text))
            {
                MessageBox.Show("Sai định dạng số lượng!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có muốn sửa thông tin của sản phẩm?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            int id = System.Convert.ToInt32(txtProductID.Text);
            string name = txtProductName.Text;
            string info = rtbProductInfomation.Text;
            double price = Double.Parse(txtProductPrice.Text);
            int quantity = System.Convert.ToInt32(txtProductQuantity.Text);

            string oldImage = ProductDAL.Instance.GetProduct(id).Image;

            string fileName;
            if (_tempImageName != null)
                fileName = _tempImageName;
            else
                fileName = "Unknown";

            string newFileName;
            if (fileName != "Unknown")
            {
                newFileName = Guid.NewGuid().ToString() + Path.GetExtension(fileName);
                File.Copy(fileName, productImagePath + newFileName);
            }
            else
                newFileName = fileName;

            Category productCategory = (Category)cbProductCategory.SelectedItem;
            Manufacturer productManufacturer = (Manufacturer)cbProductManufacturer.SelectedItem;

            if (ProductDAL.Instance.UpdateProduct(id, name, productCategory.CategoryID, productManufacturer.ManufacturerID, info, price, quantity, newFileName))
            {
                MessageBox.Show("Sửa thành công");
                listDeleteProductImage.Add(oldImage);
                ClearProductInputBox();
                LoadProduct();
            }
            else
            {
                MessageBox.Show("Lỗi rồi");
            }
        }
        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            List<Product> listProduct = [];
            if (txtSearchProductID.Text != String.Empty || txtSearchProductName.Text != String.Empty)
                listProduct = ProductDAL.Instance.SearchProduct(txtSearchProductID.Text, txtSearchProductName.Text);
            else
                listProduct = ProductDAL.Instance.GetListProduct();
            txtSearchProductID.Text = String.Empty;
            txtSearchProductName.Text = String.Empty;
            LoadProduct(listProduct);
        }
        #endregion

        #region STAFF EVENT
        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            if (txtStaffID.Text == String.Empty ||
                txtStaffName.Text == String.Empty ||
                rtbStaffAdress.Text == String.Empty ||
                cbStaffGender.Text == String.Empty ||
                cboStaffStatus.SelectedItem == null ||
                cbStaffRole.SelectedItem == null ||
                txtStaffPhone.Text == String.Empty
                )
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }
            int id = System.Convert.ToInt32(txtStaffID.Text);
            string name = txtStaffName.Text;
            string adress = rtbStaffAdress.Text;
            string gender = cbStaffGender.Text;
            string status = cboStaffStatus.Text;
            string bornDate = dtpStaffBornDate.Value.ToString("yyyy/MM/dd");
            Role role = (Role)cbStaffRole.SelectedItem;
            string phone = txtStaffPhone.Text;

            if (!CheckNumber(phone, true))
            {
                MessageBox.Show("Sai định dạng số điện thoại!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin của\nnhân viên [" + name + "]?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            try
            {
                StaffDAL.Instance.UpdateStaff(role.RoleID, name, bornDate, gender, adress, phone, status, id);
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Sửa thất bại");
            }
            LoadStaff();
            LoadAccount();
            ClearStaffInputBox();
        }
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if (
                txtStaffName.Text == String.Empty ||
                rtbStaffAdress.Text == String.Empty ||
                cbStaffGender.Text == String.Empty ||
                cboStaffStatus.SelectedItem == null ||
                cbStaffRole.SelectedItem == null ||
                txtStaffPhone.Text == String.Empty
                )
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }
            string name = txtStaffName.Text;
            string adress = rtbStaffAdress.Text;
            string gender = cbStaffGender.Text;
            string status = cboStaffStatus.Text;
            string bornDate = dtpStaffBornDate.Value.ToString("yyyy/MM/dd");
            Role role = (Role)cbStaffRole.SelectedItem;
            string phone = txtStaffPhone.Text;

            if (!CheckNumber(phone, true))
            {
                MessageBox.Show("Sai định dạng số điện thoại!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có muốn thêm thông tin của\nnhân viên [" + name + "]?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            try
            {
                StaffDAL.Instance.InsertStaff(role.RoleID, name, bornDate, gender, adress, phone, status);
                MessageBox.Show("Thêm thành công");
                ClearStaffInputBox();
            }
            catch
            {
                MessageBox.Show("Thêm thất bại");
            }
            LoadStaff();
            LoadAccount();
            ClearStaffInputBox();
        }
        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            List<Staff> listStaff = [];
            if (txtSearchStaffID.Text != String.Empty || txtSearchStaffName.Text != String.Empty)
                listStaff = StaffDAL.Instance.SearchStaff(txtSearchStaffID.Text, txtSearchStaffName.Text);
            else
                listStaff = StaffDAL.Instance.GetListStaff();

            txtSearchStaffID.Text = String.Empty;
            txtSearchStaffName.Text = String.Empty;
            LoadStaff(listStaff);
        }
        private void dtgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvStaff.SelectedCells[0].Value != null)
            {
                DataGridViewRow row = dtgvStaff.SelectedRows[0]; ;
                txtStaffID.Text = row.Cells[0].Value.ToString();
                txtStaffName.Text = row.Cells[2].Value.ToString();
                cbStaffRole.Text = row.Cells[1].Value.ToString();
                cboStaffStatus.Text = row.Cells[3].Value.ToString();
                cbStaffGender.Text = row.Cells[4].Value.ToString();
                txtStaffPhone.Text = row.Cells[5].Value.ToString();
                dtpStaffBornDate.Text = row.Cells[6].Value.ToString();
                rtbStaffAdress.Text = row.Cells[7].Value.ToString();
            }
        }
        #endregion

        #region GRN EVENT (Good Received Note)
        private void btnAddGRN_Click(object sender, EventArgs e)
        {
            if (loginAccount.StaffID == null)
            {
                MessageBox.Show("Không thể tạo phiếu nhập\nTài khoản chưa xác định nhân viên");
                return;
            }
            frmGRN frm = new();
            frm.ShowDialog();
            GRN gRN = new();
            gRN = frm.GRN;
            gRN.StaffID = (int)loginAccount.StaffID;

            List<InformationGRN> listInstalProduct = frm.listInsertProduct;
            gRN.Total = frm.GRN.Total;

            if (!frm._isAdd)
                return;

            GRNDAL.Instance.InsertGRN(gRN.StaffID, gRN.Unit, gRN.Date.ToString("yyyy/MM/dd"), gRN.Total, gRN.Image);
            int gRNID = GRNDAL.Instance.GetHighestGRN().GRNID;
            foreach (InformationGRN i in listInstalProduct)
            {
                InformationGRNDAL.Instance.InsertInformation(gRNID, i.ProductID, i.Quantity, i.Price);
            }
            frm.Close();

            LoadGRN();
            LoadProduct();
        }

        private void dtgvGRN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvGRN.SelectedCells[0].Value != null)
            {
                DataGridViewRow row = dtgvGRN.SelectedRows[0];
                txtGRNID.Text = row.Cells[0].Value.ToString();
                txtGRNUnit.Text = row.Cells[1].Value.ToString();
                txtGRNStaff.Text = row.Cells[2].Value.ToString();
                txtGRNDate.Text = row.Cells[3].Value.ToString();
                txtGRNTotal.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnDetailAndUpdateGRN_Click(object sender, EventArgs e)
        {
            if (dtgvGRN.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgvGRN.SelectedRows[0];
                GRN gRN = GRNDAL.Instance.GetGRN(System.Convert.ToInt32(row.Cells[0].Value));
                frmGRN frm = new(gRN);

                frm.ShowDialog();

            }
        }

        private void btnSearchGRN_Click(object sender, EventArgs e)
        {
            List<GRN> listGRN = GRNDAL.Instance.SearchGRN(
                dtpkSearchGRNFrom.Value.ToString("yyyy/MM/dd"),
                dtpkSearchGRNTo.Value.ToString("yyyy/MM/dd"),
                txtSearchGRNID.Text);
            txtSearchGRNID.Text = String.Empty;
            LoadGRN(listGRN);
        }

        private void btnSearchGRNCancel_Click(object sender, EventArgs e)
        {
            SetSearchDate();
            txtSearchGRNID.Text = String.Empty;
            LoadGRN();
        }

        #endregion

        #region CUSTOMER EVENT
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txtNumberPhone.Text == String.Empty ||
               txtName.Text == String.Empty ||
               rtbAddress.Text == String.Empty
               )
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !");
                return;
            }

            if (!CheckNumber(txtNumberPhone.Text, true))
            {
                MessageBox.Show("Sai định dạng SDT");
                return;
            }

            string phone = txtNumberPhone.Text;
            string name = txtName.Text;
            string address = rtbAddress.Text;

            try
            {
                CustomerDAL.Instance.InsertCustomer(phone, name, address);
                LoadCustomer();
                ClearCustomer();
                MessageBox.Show("Thêm thành công");
            }
            catch
            {
                ClearCustomer();
                MessageBox.Show("Thêm thất bại");
            }
        }
        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            List<Customer> listCustomer = [];
            if (txtSearchNumberPhone.Text != String.Empty || txtSearchName.Text != String.Empty)
                listCustomer = CustomerDAL.Instance.SearchCustomer(txtSearchNumberPhone.Text, txtSearchName.Text);
            else
                listCustomer = CustomerDAL.Instance.GetListCustomer();
            txtSearchNumberPhone.Text = String.Empty;
            txtSearchName.Text = String.Empty;
            LoadCustomer(listCustomer);
        }
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (txtNumberPhone.Text == String.Empty ||
               txtName.Text == String.Empty ||
               rtbAddress.Text == String.Empty
               )
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !");
                return;
            }

            if (!CheckNumber(txtNumberPhone.Text, true))
            {
                MessageBox.Show("Sai định dạng SDT");
                return;
            }

            string phone = txtNumberPhone.Text.Trim();
            string name = txtName.Text;
            string address = rtbAddress.Text;
            string oldPhone = "";
            if (dtgvCustomer.SelectedRows.Count > 0)
            {
                oldPhone = dtgvCustomer.SelectedRows[0].Cells[0].Value.ToString().Trim();
            }

            DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin của\nkhách hàng [" + name + "]?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                if (oldPhone ==  phone)
                    CustomerDAL.Instance.UpdateCustomer(phone, name, address);
                else
                    CustomerDAL.Instance.UpdateCustomerPhone(phone, name, address, oldPhone);
                LoadCustomer();
                ClearCustomer();
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                ClearCustomer();
                MessageBox.Show("Sửa thất bại");
            }
        }
        private void dtgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvCustomer.SelectedCells[0].Value != null)
            {
                DataGridViewRow row = dtgvCustomer.SelectedRows[0];
                txtNumberPhone.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                rtbAddress.Text = row.Cells[2].Value.ToString();
            }
        }
        private void btnCustomerAddOrder_Click(object sender, EventArgs e)
        {
            if (dtgvCustomer.SelectedRows[0] == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng");
                return;
            }

            List<OrderDetail> listDetail = [];
            Order order = new();
            order.CustomerNumberPhone = txtNumberPhone.Text;

            frmOrder frm = new(order, false);
            frm.ShowDialog();

            if (!frm._isAdd)
                return;

            listDetail = frm.listDetail;
            order = frm.order;
            if (loginAccount.StaffID != null)
                order.StaffID = (int)loginAccount.StaffID;

            LoadCustomer();

            OrderDAL.Instance.InsertOrder(order.StaffID,
                order.CustomerNumberPhone,
                order.Date.ToString("yyyy/MM/dd"),
                order.Status, order.Total);

            foreach (OrderDetail detail in listDetail)
            {
                OrderDetailDAL.Instance.InsertOrderDetail(
                    OrderDAL.Instance.GetHighestOrder().OrderID,
                    detail.ProductID,
                    detail.Price,
                    detail.Quantity
                    );
            }
            frm.Close();

            MessageBox.Show("Cảm đơn vì đã mua hàng\nHóa đơn được xuất với tên: " + ExportOrder(OrderDAL.Instance.GetHighestOrder().OrderID));

            LoadCustomer();
            LoadOrder();
            LoadProduct();
        }
        #endregion

        #region MANUFACTURER EVENT
        private void dtgvManufacturer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvManufacturer.SelectedCells[0].Value != null)
            {
                DataGridViewRow row = dtgvManufacturer.SelectedRows[0];
                txtManufacturerID.Text = row.Cells[0].Value.ToString();
                txtManufacturerName.Text = row.Cells[1].Value.ToString();
            }
        }
        private void btnAddManufacturer_Click(object sender, EventArgs e)
        {
            if (txtManufacturerName.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !");
                return;
            }
            string name = txtManufacturerName.Text;

            DialogResult result = MessageBox.Show("Bạn có muốn thêm thông tin của\nnhà sản xuất [" + name + "]?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            try
            {
                ManufacturerDAL.Instance.InsertManufacturer(name);
                LoadManufacturer();
                MessageBox.Show("Thêm thành công");
            }
            catch
            {
                MessageBox.Show("Thêm thất bại");
            }
            ClearManufacturerInputBox();
            LoadProduct();
        }
        private void btnSearchManufactuer_Click(object sender, EventArgs e)
        {
            List<Manufacturer> listManufacturer = [];
            if (txtSearchManuID.Text != String.Empty || txtSearchManuName.Text != String.Empty)
                listManufacturer = ManufacturerDAL.Instance.SearchManufacturer(txtSearchManuID.Text, txtSearchManuName.Text);
            else
                listManufacturer = ManufacturerDAL.Instance.GetListManufacturer();
            txtSearchManuID.Text = String.Empty;
            txtSearchManuName.Text = String.Empty;
            LoadManufacturer(listManufacturer);
        }
        private void btnUpdateManufacturer_Click(object sender, EventArgs e)
        {
            if (txtManufacturerName.Text == String.Empty ||
               txtManufacturerID.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !");
                return;
            }

            int id = System.Convert.ToInt32(txtManufacturerID.Text);
            string name = txtManufacturerName.Text;

            DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin của\nnhà sản xuất [" + name + "]?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            try
            {
                ManufacturerDAL.Instance.UpdateManufacturer(id, name);
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Sửa thất bại");
            }

            LoadManufacturer();
            ClearManufacturerInputBox();
            LoadProduct();
        }
        #endregion

        #region CATEGORY EVENT
        private void dtgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvCategory.SelectedCells[0].Value != null)
            {
                DataGridViewRow row = dtgvCategory.SelectedRows[0];
                txtCategoryID.Text = row.Cells[0].Value.ToString();
                txtCateName.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnAddCate_Click(object sender, EventArgs e)
        {
            if (txtCateName.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !");
                return;
            }

            string name = txtCateName.Text;

            DialogResult result = MessageBox.Show("Bạn có muốn thêm thông tin của\ndanh mục [" + name + "]?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            try
            {
                CategoryDAL.Instance.InsertCategory(name);
                MessageBox.Show("Thêm thành công");
                LoadCategory();
                ClearCategoryInputBox();
            }
            catch
            {
                MessageBox.Show("Thêm thất bại");
            }
            LoadCategory();
            ClearCategoryInputBox();
            LoadProduct();
        }
        private void btnSearchCate_Click(object sender, EventArgs e)
        {
            List<Category> listCategory = [];
            if (txtSearchCateID.Text != String.Empty || txtSearchCateName.Text != String.Empty)
                listCategory = CategoryDAL.Instance.SearchCategory(txtSearchCateID.Text, txtSearchCateName.Text);
            else
                listCategory = CategoryDAL.Instance.GetListCategory();
            txtSearchCateID.Text = String.Empty;
            txtSearchCateName.Text = String.Empty;
            LoadCategory(listCategory);
        }
        private void btnUpdateCate_Click(object sender, EventArgs e)
        {
            if (txtCateName.Text == String.Empty ||
                txtCategoryID.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !");
                return;
            }
            int id = System.Convert.ToInt32(txtCategoryID.Text);
            string name = txtCateName.Text;

            DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin của\ndanh mục [" + name + "]?",
               "Thông báo",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            try
            {
                CategoryDAL.Instance.UpdateCategory(id, name);
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Sửa thất bại");
            }

            LoadCategory();
            ClearCategoryInputBox();
            LoadProduct();
        }
        #endregion

        #region ORDER EVENT
        private void dtgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvOrder.SelectedCells[0].Value != null)
            {
                DataGridViewRow row = dtgvOrder.SelectedRows[0];
                txtOrderID.Text = row.Cells[0].Value.ToString();
                txtOrderCustomerName.Text = row.Cells[1].Value.ToString();
                txtOrderStatus.Text = row.Cells[3].Value.ToString();
                txtOrderTotal.Text = row.Cells[4].Value.ToString();
                txtOrderStaff.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Order selectedOder = new();
            if (dtgvOrder.SelectedRows.Count > 0)
                if (dtgvOrder.SelectedRows[0].Cells[0].Value != null)
                    selectedOder = OrderDAL.Instance.GetOrder((int)dtgvOrder.SelectedRows[0].Cells[0].Value);
            frmOrder frm = new(selectedOder);
            frm.ShowDialog();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (loginAccount.StaffID == null)
            {
                MessageBox.Show("Không thể tạo đơn hàng\nTài khoản chưa xác định nhân viên");
                return;
            }
            List<OrderDetail> listDetail = [];
            Order order = new();

            frmOrder frm = new();
            frm.ShowDialog();

            if (!frm._isAdd)
                return;

            listDetail = frm.listDetail;
            order = frm.order;
            if (loginAccount.StaffID != null)
                order.StaffID = (int)loginAccount.StaffID;

            OrderDAL.Instance.InsertOrder(order.StaffID, order.CustomerNumberPhone, order.Date.ToString("yyyy/MM/dd"), order.Status, order.Total);
            foreach (OrderDetail detail in listDetail)
            {
                OrderDetailDAL.Instance.InsertOrderDetail(
                    OrderDAL.Instance.GetHighestOrder().OrderID,
                    detail.ProductID,
                    detail.Price,
                    detail.Quantity
                    );
            }
            frm.Close();

            MessageBox.Show("Cảm đơn vì đã mua hàng\nHóa đơn được xuất với tên: " + ExportOrder(OrderDAL.Instance.GetHighestOrder().OrderID));

            LoadCustomer();
            LoadOrder();
            LoadProduct();
        }
        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            string searchID = "";
            if (txtSearchOrderID.Text != String.Empty)
                searchID = txtSearchOrderID.Text;

            List<Order> listOrder = OrderDAL.Instance.SearchOrder(
                dtpkSearchOrderFrom.Value.ToString("yyyy/MM/dd"),
                dtpkSearchOrderTo.Value.ToString("yyyy/MM/dd"),
                searchID);

            LoadOrder(listOrder);
        }

        private void btnSearchOrderCancel_Click(object sender, EventArgs e)
        {
            txtSearchOrderID.Text = String.Empty;
            LoadOrder();
            SetSearchDate();
        }
        private string ExportOrder(int orderID)
        {
            Directory.CreateDirectory("C:\\CuaHangLinhKien\\HoaDon\\");
            string billPath = "C:\\CuaHangLinhKien\\HoaDon\\";
            Order order = OrderDAL.Instance.GetOrder(orderID);

            List<OrderDetail> list = OrderDetailDAL.Instance.GetListOrderDetailOrderID(orderID);
            DataTable dt = new();
            dt.Columns.Add("id");
            dt.Columns.Add("name");
            dt.Columns.Add("quantity");
            dt.Columns.Add("price");

            foreach (OrderDetail d in list)
            {
                dt.Rows.Add(new object[] { d.ProductID, ProductDAL.Instance.GetProduct(d.ProductID).ProductName, d.Quantity, d.Price });
            }

            PdfDocument document = new PdfDocument();
            document.PageSettings.Orientation = PdfPageOrientation.Portrait;
            document.PageSettings.Margins.All = 50;

            //Add a page to the document.
            PdfPage page = document.Pages.Add();

            //Create PDF graphics for the page.
            PdfGraphics graphics = page.Graphics;

            PdfFont font14 = new PdfTrueTypeFont(new Font("Times New Roman", 13), true);
            PdfFont font11 = new PdfTrueTypeFont(new Font("Times New Roman", 11), true);
            PdfBrush blackBrush = new PdfSolidBrush(new PdfColor(0, 0, 0));

            //Create a text element with the text and font.
            PdfTextElement element = new PdfTextElement("Cửa hàng A", new PdfTrueTypeFont(new Font("Times New Roman", 18, FontStyle.Bold), true), blackBrush);
            PdfLayoutResult result = element.Draw(page, new RectangleF(40, 0, page.Graphics.ClientSize.Width / 2, 200));

            element = new PdfTextElement("Chuyên bán các loại linh kiện máy tính\nBao rẻ nhất Việt Nam\n100% chính hãng", font11, blackBrush);
            result = element.Draw(page, new RectangleF(3, 30, page.Graphics.ClientSize.Width / 2, 200));

            element = new PdfTextElement("Địa chỉ: 23 hẻm 199, đường 30 tháng 4, phường Hưng Lợi, quận Ninh Kiều, thành phố Cần Thơ\nHỗ trợ: 0123456789", font11, blackBrush);
            element.Draw(page, new RectangleF(result.Bounds.Right + 3, result.Bounds.Top, page.Graphics.ClientSize.Width / 2, 150));

            //Draw the rectangle on PDF document
            PdfPen pen = new(PdfBrushes.Gray, 1f);
            RectangleF bounds = new(0, 0, 495, 75);
            page.Graphics.DrawRectangle(pen, bounds);

            element = new PdfTextElement("HÓA ĐƠN BÁN HÀNG");
            element.Font = new PdfTrueTypeFont(new Font("Times New Roman", 18, FontStyle.Bold), true);
            element.Brush = new PdfSolidBrush(new PdfColor(0, 0, 0));
            result = element.Draw(page, new RectangleF(result.Bounds.Width / 2 + 20, result.Bounds.Bottom + 15, page.Graphics.ClientSize.Width / 2, 200));

            element = new PdfTextElement("Mã đơn: " + order.OrderID, font14, blackBrush);
            element.Draw(page, new RectangleF(result.Bounds.Right - 140, result.Bounds.Bottom + 10, page.Graphics.ClientSize.Width / 2, 200));

            element = new PdfTextElement("Khách hàng: " + CustomerDAL.Instance.GetCustomer(order.CustomerNumberPhone).CustomerName, font14, blackBrush);
            result = element.Draw(page, new RectangleF(0, result.Bounds.Bottom + 10, page.Graphics.ClientSize.Width / 2, 200));

            element = new PdfTextElement("Nhân viên: " + StaffDAL.Instance.GetStaff(order.StaffID).StaffName, font14, blackBrush);
            element.Draw(page, new RectangleF(result.Bounds.Right + 3, result.Bounds.Bottom + 4, page.Graphics.ClientSize.Width / 2, 200));

            element = new PdfTextElement("SDT: " + order.CustomerNumberPhone, font14, blackBrush);
            result = element.Draw(page, new RectangleF(0, result.Bounds.Bottom + 3, page.Graphics.ClientSize.Width / 2, 200));

            element = new PdfTextElement("Địa chỉ: " + CustomerDAL.Instance.GetCustomer(order.CustomerNumberPhone).CustomerAddress, font14, blackBrush);
            result = element.Draw(page, new RectangleF(0, result.Bounds.Bottom + 3, page.Graphics.ClientSize.Width / 2, 200));

            element = new PdfTextElement("Ngày xuất hóa đơn: " + DateTime.Now.ToShortDateString(), font14, blackBrush);
            element.Draw(page, new RectangleF(result.Bounds.Right + 70, result.Bounds.Bottom + 10, page.Graphics.ClientSize.Width / 2, 200));

            element = new PdfTextElement("Danh sách sản phẩm", font14, blackBrush);
            result = element.Draw(page, new RectangleF(0, result.Bounds.Bottom + 10, page.Graphics.ClientSize.Width / 2, 200));

            //Creates a PDF grid.
            PdfGrid grid = new();
            //Adds the data source.
            grid.DataSource = dt;
            //Creates the grid row styles.
            PdfGridRowStyle pdfGridRowStyle = new();
            pdfGridRowStyle.Font = font11;
            PdfGridRow header = grid.Headers[0];

            //Applies the grid row styles
            grid.Rows.ApplyStyle(pdfGridRowStyle);
            //Creates the header style.
            PdfGridCellStyle headerStyle = new();
            headerStyle.TextBrush = blackBrush;
            headerStyle.Font = font14;

            //Applies the header style.
            header.Cells[0].StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            header.Cells[0].Value = "Mã sản phẩm";
            header.Cells[1].StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            header.Cells[1].Value = "Tên sản phẩm";
            header.Cells[2].StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            header.Cells[2].Value = "Số lượng";
            header.Cells[3].StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            header.Cells[3].Value = "Giá bán";

            header.ApplyStyle(headerStyle);

            //Creates the layout format for grid.
            PdfGridLayoutFormat layoutFormat = new();
            //Creates layout format settings to allow the table pagination.
            layoutFormat.Layout = PdfLayoutType.Paginate;
            //Draws the grid to the PDF page.
            result = grid.Draw(page, new RectangleF(new PointF(0, result.Bounds.Bottom + 5), new SizeF(graphics.ClientSize.Width, graphics.ClientSize.Height - 100)), layoutFormat);

            element = new PdfTextElement("Tổng tiền thanh toán: " + order.Total.ToString("#,###") + " VNĐ", font14, blackBrush);
            result = element.Draw(document.Pages[document.Pages.Count - 1], new PointF(10, result.Bounds.Bottom + 20));

            element = new PdfTextElement("Người bán hàng\nChữ ký số (nếu có)", font14, blackBrush);
            element.Draw(document.Pages[document.Pages.Count - 1], new RectangleF(result.Bounds.Right + 150, result.Bounds.Bottom + 20, page.Graphics.ClientSize.Width / 2, 200));

            element = new PdfTextElement("Người mua hàng\nChữ ký số (nếu có)", font14, blackBrush);
            element.Draw(document.Pages[document.Pages.Count - 1], new RectangleF(30, result.Bounds.Bottom + 20, page.Graphics.ClientSize.Width / 2, 200));

            string name = orderID.ToString() + "-" +
                CustomerDAL.Instance.GetCustomer(order.CustomerNumberPhone).CustomerName + "-" +
                order.CustomerNumberPhone + ".pdf";
            document.Save(billPath + name);

            return name;
        }
        #endregion

        #region ACCOUNT EVENT
        private void dtgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvAccount.SelectedCells[0].Value != null)
            {
                DataGridViewRow row = dtgvAccount.SelectedRows[0];
                txtLoginName.Text = row.Cells[0].Value.ToString();
                cbAccountType.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() != "Trống")
                    cbAccountStaff.Text = row.Cells[2].Value.ToString();
                else
                    cbAccountStaff.SelectedItem = null;
            }
        }
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if (
                txtLoginName.Text == String.Empty ||
                txtPassword.Text == String.Empty ||
                cbAccountType.SelectedItem == null ||
                cbAccountStaff.SelectedItem == null
                )
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }
            string loginName = txtLoginName.Text;
            string pass = txtPassword.Text;
            AccountType accType = (AccountType)cbAccountType.SelectedItem;
            Staff staff = (Staff)cbAccountStaff.SelectedItem;

            try
            {
                AccountDAL.Instance.DeleteAccountByStaffID(staff.StaffID);

                AccountDAL.Instance.InsertAccount(loginName, pass, accType.TypeID, staff.StaffID);
                StaffDAL.Instance.SetAccountStaff(staff.StaffID, loginName);
                MessageBox.Show("Thêm thành công");

                LoadStaff();
                LoadAccount();
            }
            catch
            {
                StaffDAL.Instance.SetAccountStaff(staff.StaffID, loginName);
                MessageBox.Show("Thêm thất bại");
            }
            ClearAccountInputBox();
        }
        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            if (
               txtLoginName.Text == String.Empty ||
               txtPassword.Text == String.Empty ||
               cbAccountType.SelectedItem == null ||
               cbAccountStaff.SelectedItem == null
               )
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }

            string loginName = txtLoginName.Text;
            string pass = txtPassword.Text;
            AccountType accType = (AccountType)cbAccountType.SelectedItem;
            Staff staff = (Staff)cbAccountStaff.SelectedItem;

            try
            {
                string? oldLoginName = dtgvAccount.SelectedRows[0].Cells[0].Value.ToString();
                if (oldLoginName == null)
                {
                    MessageBox.Show("Vui lòng chọn tài khoản");
                    return;
                }

                AccountDAL.Instance.DeleteAccountByStaffID(staff.StaffID);

                if (oldLoginName == loginName)
                    AccountDAL.Instance.UpdateAccount(loginName, pass, accType.TypeID, staff.StaffID);
                else
                    AccountDAL.Instance.UpdateAccountID(oldLoginName, loginName, pass, accType.TypeID, staff.StaffID);

                if (dtgvAccount.SelectedRows[0].Cells[2].Value.ToString() != "Trống")
                    StaffDAL.Instance.SetAccountStaff(((Staff)dtgvAccount.SelectedRows[0].Cells[2].Value).StaffID, "null");
                StaffDAL.Instance.SetAccountStaff(staff.StaffID, loginName);

                LoadStaff();
                LoadAccount();
                ClearAccountInputBox();

                if (loginAccount.AccountID == loginName)
                    loginAccount = new(loginName, pass, accType.TypeID, staff.StaffID);
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                ClearAccountInputBox();
                MessageBox.Show("Sửa thất bại");
            }
        }
        private void btnSearchAccount_Click(object sender, EventArgs e)
        {
            List<Account> listAccount = [];
            if

                (txtSearchLoginName.Text != String.Empty ||
                cbAccountType.SelectedItem != null)
            {
                listAccount = AccountDAL.Instance.SearchAccount(txtSearchLoginName.Text);
            }
            else
                listAccount = AccountDAL.Instance.GetListAccount();
            txtSearchLoginName.Text = String.Empty;

            LoadAccount(listAccount);
        }
        #endregion

        #region OTHER EVENT
        private void tsbStatistics_Click(object sender, EventArgs e)
        {
            frmStatistic frm = new();
            frm.ShowDialog();
        }
        private void tsbLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn đăng xuất khỏi hệ thống?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                pbProductImage.Image = null;
                ofdSelectProductImage.Dispose();
            }
            if (result != DialogResult.Yes)
                e.Cancel = true;
        }
        #endregion
        #endregion
    }
}
