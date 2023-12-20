﻿using System;
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
        public Account loginAccount = new();

        private List<Product> listProduct = [];
        private List<Category> listCategory = [];
        private List<Manufacturer> listManufacturer = [];
        private List<Staff> listStaff = [];
        private List<Role> listRole = [];
        private List<GRN> listGRN = [];
        private List<Customer> listCustomer = [];

        public List<string> listDeleteProductImage = [];

        string? _tempImageName = null;

        private readonly string productImagePath = Application.StartupPath.Split("\\DoAn_CuaHangLinhKien", 
            StringSplitOptions.None)[0] + @"\DoAn_CuaHangLinhKien\BLL\product-images\";

        public frmManage()
        {
            InitializeComponent();
        }
        #region METHOD
        #region OTHER METHOD
        private void frmManage_Load(object sender, EventArgs e)
        {
            CheckRole();
            listCategory = CategoryDAL.Instance.GetListCategory();
            listManufacturer = ManufacturerDAL.Instance.GetListManufacturer();
            listProduct = ProductDAL.Instance.GetListProduct();
            listStaff = StaffDAL.Instance.GetListStaff();
            listRole = RoleDAL.Instance.GetListRole();
            listGRN = GRNDAL.Instance.GetListGRN();
            listCustomer = CustomerDAL.Instance.GetListCustomer();
            listCategory = CategoryDAL.Instance.GetListCategory();

            LoadProduct();
            LoadStaff();
            LoadListRole();
            LoadGRN();
            LoadCustomer();
            LoadManufacturer();
            LoadCategory();

            SetSearchDate();

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
        private bool CheckNumberPhone(string phone)
        {
            bool result = false;
            char[] chars = phone.ToCharArray();
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
                        result = true; break;
                }
            }
            return result;
        }
        #endregion

        #region PRODUCT MANAGE METHOD
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
            ClearProductInputBox();
            CheckImageButton();
        }
        private void ClearProductInputBox()
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
        private void CheckImageButton()
        {
            if (btnSaveProduct.Enabled)
            {
                btnSelectProductImage.Enabled = true;
                if (pbProductImage.Image == null)
                    btnDeleteProductImage.Enabled = false;
                else
                    btnDeleteProductImage.Enabled = true;
            }
            else
            {
                btnSelectProductImage.Enabled = false;
                btnDeleteProductImage.Enabled = false;
            }
        }
        #endregion

        #region STAFF METHOD
        private void LoadStaff()
        {
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
            cbStaffRole.DataSource = listRole;
        }
        #endregion

        #region GRN MANAGE METHOD
        private void LoadGRN()
        {
            dtgvGRN.Rows.Clear();
            foreach (GRN s in listGRN)
            {
                DataGridViewRow row = (DataGridViewRow)dtgvGRN.Rows[0].Clone(); ;
                row.Cells[0].Value = s.GRNID.ToString();
                row.Cells[1].Value = s.Unit.ToString();
                row.Cells[2].Value = StaffDAL.Instance.GetStaff(s.StaffID).StaffName;
                row.Cells[3].Value = s.Date.ToString("dd/MM/yyyy");
                row.Cells[4].Value = s.Total;
                dtgvGRN.Rows.Add(row);
            }
            cbGRNStaff.DataSource = listStaff;
        }
        private void SetSearchDate()
        {
            dtpkSearchGRNFrom.Value = DateTime.Parse(String.Format(
                "{0}/{1}/{2}",
                1,
                DateTime.Now.Month,
                DateTime.Now.Year
                ));
            dtpkSearchGRNTo.Value = DateTime.Parse(String.Format(
                "{0}/{1}/{2}",
                DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month),
                DateTime.Now.Month,
                DateTime.Now.Year
                ));
        }
        #endregion

        #region CUSTOMER METHOD
        private void LoadCustomer()
        {
            dtgvCustomer.Rows.Clear();
            foreach (Customer c in listCustomer)
            {
                DataGridViewRow row = (DataGridViewRow)dtgvCustomer.Rows[0].Clone();
                row.Cells[0].Value = c.CustomerNumberPhone.ToString();
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
        private void LoadManufacturer()
        {
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
        private void LoadCategory()
        {
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
            txtCateID.Text = String.Empty;
            txtCateName.Text = String.Empty;
        }
#endregion

#endregion

// EVENT
#region EVENT
        #region PRODUCT MANAGE EVENT
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
                    txtProductPrice.Text = v.Product.Price.ToString();
                    rtbProductInfomation.Text = v.Product.Information;
                    nmudQuantity.Value = v.Product.Quantity;
                    cbProductCategory.Text = CategoryDAL.Instance.GetCategory(v.Product.CategoryID).CategoryName;
                    cbProductManufacturer.Text = ManufacturerDAL.Instance.GetManufacturer(v.Product.ManufacturerID).ManufacturerName;

                    if (v.Product.Image != "Unknown")
                    {
                        try
                        {
                            pbProductImage.Image = Image.FromFile(productImagePath + v.Product.Image);
                            _tempImageName = productImagePath + v.Product.Image;
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
                        pbProductImage.Image = Image.FromFile(fileName);
                    }
                    catch
                    {
                        pbProductImage.Image = null;
                    }
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
                    }
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
                        if (result == DialogResult.Yes)
                        {
                            ClearProductInputBox();
                            btnUpdateProduct.Enabled = true;
                            btnSaveProduct.Enabled = false;
                            CheckImageButton();
                            return;
                        }
                    }
                    else
                    {
                        btnAddProduct.Enabled = true;
                        btnUpdateProduct.Enabled = false;
                        btnSaveProduct.Enabled = true;

                        CheckImageButton();
                        ClearProductInputBox();
                    }
                }
                private void btnSaveProduct_Click(object sender, EventArgs e)
                {

                    if (btnAddProduct.Enabled)
                    {
                        if (txtProductName.Text == String.Empty ||
                            txtProductPrice.Text == String.Empty ||
                            cbProductCategory.SelectedItem == null ||
                            cbProductManufacturer.SelectedItem == null ||
                            _tempImageName == null)
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
                        if (fileName != null)
                            File.Copy(fileName, productImagePath + newFileName);
                        Category productCategory = (Category)cbProductCategory.SelectedItem;
                        Manufacturer productManufacturer = (Manufacturer)cbProductManufacturer.SelectedItem;

                        if (ProductDAL.Instance.InsertProduct(name, productCategory.CategoryID, productManufacturer.ManufacturerID, info, price, quantity, newFileName))
                        {
                            MessageBox.Show("Thêm thành công");
                            listProduct = ProductDAL.Instance.GetListProduct();
                            LoadProduct();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi rồi");
                        }
                    }
                    else if (btnUpdateProduct.Enabled)
                    {
                        if (txtProductName.Text == String.Empty ||
                            txtProductPrice.Text == String.Empty ||
                            cbProductCategory.SelectedItem == null ||
                            cbProductManufacturer.SelectedItem == null ||
                            _tempImageName == String.Empty)
                        {
                            MessageBox.Show("Vui lòng nhập đủ thông tin!");
                            return;
                        }
                        int id = System.Convert.ToInt32(txtProductID.Text);
                        string name = txtProductName.Text;
                        string info = rtbProductInfomation.Text;
                        double price = Double.Parse(txtProductPrice.Text);
                        int quantity = (int)nmudQuantity.Value;

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
                            listProduct = ProductDAL.Instance.GetListProduct();
                            LoadProduct();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi rồi");
                        }
                    }
                }
                private void btnUpdateProduct_Click(object sender, EventArgs e)
                {
                    if (btnSaveProduct.Enabled)
                    {
                        DialogResult result = MessageBox.Show(
                            "Bạn có muốn hủy thao tác?",
                            "Xác nhận",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                            );
                        if (result == DialogResult.Yes)
                        {
                            ClearProductInputBox();
                            btnAddProduct.Enabled = true;
                            btnSaveProduct.Enabled = false;
                            CheckImageButton();
                            return;
                        }
                    }
                    else
                    {
                        btnAddProduct.Enabled = false;
                        btnUpdateProduct.Enabled = true;
                        btnSaveProduct.Enabled = true;

                        CheckImageButton();
                        ClearProductInputBox();
                    }
                }
                private void btnSearchProduct_Click(object sender, EventArgs e)
                {
                    if (txtSearchProductID.Text != String.Empty || txtSearchProductName.Text != String.Empty)
                        listProduct = ProductDAL.Instance.SearchProduct(txtSearchProductID.Text, txtSearchProductName.Text);
                    else
                        listProduct = ProductDAL.Instance.GetListProduct();
                    txtSearchProductID.Text = String.Empty;
                    txtSearchProductName.Text = String.Empty;
                    LoadProduct();
                }
                #endregion

        #region STAFF MANAGE EVENT
        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            if (btnSaveStaff.Enabled)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có muốn hủy thao tác?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    btnSaveStaff.Enabled = false;
                    btnAddStaff.Enabled = true;
                    ClearStaffInputBox();
                }
            }
            else
            {
                btnSaveStaff.Enabled = true;
                btnAddStaff.Enabled = false;
                ClearStaffInputBox();
            }
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if (btnSaveStaff.Enabled)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có muốn hủy thao tác?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    btnSaveStaff.Enabled = false;
                    btnUpdateStaff.Enabled = true;
                    ClearStaffInputBox();
                }
            }
            else
            {
                btnSaveStaff.Enabled = true;
                btnUpdateStaff.Enabled = false;
                ClearStaffInputBox();
            }
        }
        private void btnSaveStaff_Click(object sender, EventArgs e)
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

            if (!CheckNumberPhone(phone))
            {
                MessageBox.Show("Sai định dạng số điện thoại!");
                return;
            }

            if (btnAddStaff.Enabled)
            {
                if (StaffDAL.Instance.InsertStaff(role.RoleID, name, bornDate, gender, adress, phone, status))
                {
                    MessageBox.Show("Thêm thành công");
                    listStaff = StaffDAL.Instance.GetListStaff();
                    LoadStaff();
                    ClearStaffInputBox();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    ClearStaffInputBox();
                }
            }
            else if (btnUpdateStaff.Enabled)
            {
                int id = System.Convert.ToInt32(txtStaffID.Text);
                if (StaffDAL.Instance.UpdateStaff(role.RoleID, name, bornDate, gender, adress, phone, status, id))
                {
                    MessageBox.Show("Sửa thành công");
                    listStaff = StaffDAL.Instance.GetListStaff();
                    LoadStaff();
                    ClearStaffInputBox();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                    ClearStaffInputBox();
                }
            }
        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            if (txtSearchStaffID.Text != String.Empty || txtSearchStaffName.Text != String.Empty)
                listStaff = StaffDAL.Instance.SearchStaff(txtSearchStaffID.Text, txtSearchStaffName.Text);
            else
                listStaff = StaffDAL.Instance.GetListStaff();

            txtSearchStaffID.Text = String.Empty;
            txtSearchStaffName.Text = String.Empty;
            LoadStaff();
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

        #region GRN MANAGE EVENT (Good Received Note)
        private void btnAddGRN_Click(object sender, EventArgs e)
        {
            if (cbGRNStaff.SelectedItem == null)
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
                return;
            }
            frmGRN frm = new();
            frm.ShowDialog();
            GRN gRN = new();
            gRN = frm.GRN;
            if (loginAccount.StaffID != null)
                gRN.StaffID = (int)loginAccount.StaffID;
            else
                gRN.StaffID = ((Staff)cbGRNStaff.SelectedItem).StaffID;
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
            listGRN = GRNDAL.Instance.GetListGRN();
            listProduct = ProductDAL.Instance.GetListProduct();

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
                cbGRNStaff.Text = row.Cells[2].Value.ToString();
                dtpkGRNDate.Text = row.Cells[3].Value.ToString();
                txtGRNTotal.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnDetailAndUpdateGRN_Click(object sender, EventArgs e)
        {
            if (dtgvGRN.SelectedCells[0].Value != null)
            {
                DataGridViewRow row = dtgvGRN.SelectedRows[0];
                GRN gRN = GRNDAL.Instance.GetGRN(System.Convert.ToInt32(row.Cells[0].Value));
                frmGRN frm = new(gRN);

                frm.ShowDialog();

            }
        }

        private void btnSearchGRN_Click(object sender, EventArgs e)
        {
            listGRN = GRNDAL.Instance.SearchGRN(
                dtpkSearchGRNFrom.Value.ToString("yyyy/MM/dd"),
                dtpkSearchGRNTo.Value.ToString("yyyy/MM/dd"),
                txtSearchGRNID.Text);
            txtSearchGRNID.Text = String.Empty;
            LoadGRN();
        }

        private void btnSearchGRNCancel_Click(object sender, EventArgs e)
        {
            SetSearchDate();
            txtSearchGRNID.Text = String.Empty;
            listGRN = GRNDAL.Instance.GetListGRN();
            LoadGRN();
        }

        #endregion

        #region MANEGE CUSTOMER
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (btnSaveCustomer.Enabled)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có muốn hủy thao tác?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
                if (result == DialogResult.Yes)
                {
                    ClearCustomer();
                    btnUpdateCustomer.Enabled = true;
                    btnSaveCustomer.Enabled = false;
                    return;
                }
            }
            else
            {
                btnAddCustomer.Enabled = true;
                btnUpdateCustomer.Enabled = false;
                btnSaveCustomer.Enabled = true;

                ClearCustomer();
            }
        }



        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            if (
               txtNumberPhone.Text == String.Empty ||
               txtName.Text == String.Empty ||
               rtbAddress.Text == String.Empty
               )
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !");
                return;
            }
            string phone = txtNumberPhone.Text;
            string name = txtName.Text;
            string address = rtbAddress.Text;

            if (btnAddCustomer.Enabled)
            {
                if (CustomerDAL.Instance.InsertCustomer(phone, name, address))
                {
                    MessageBox.Show("Thêm thành công");
                    listCustomer = CustomerDAL.Instance.GetListCustomer();
                    LoadCustomer();
                    ClearCustomer();
                }

                else
                {
                    MessageBox.Show("Thêm thất bại");
                    ClearCustomer();
                }
            }
            else if (btnUpdateCustomer.Enabled)
            {
                if (CustomerDAL.Instance.UpdateCustomer(phone, name, address))
                {
                    MessageBox.Show("Sửa thành công");
                    listCustomer = CustomerDAL.Instance.GetListCustomer();
                    LoadCustomer();
                    ClearCustomer();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                    ClearCustomer();
                }

            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            if (txtSearchNumberPhone.Text != String.Empty || txtSearchName.Text != String.Empty)
                listCustomer = CustomerDAL.Instance.SearchCustomer(txtSearchNumberPhone.Text, txtSearchName.Text);
            else
                listCustomer = CustomerDAL.Instance.GetListCustomer();
            txtSearchNumberPhone.Text = String.Empty;
            txtSearchName.Text = String.Empty;
            LoadCustomer();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (btnSaveCustomer.Enabled)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có muốn hủy thao tác?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
                if (result == DialogResult.Yes)
                {

                    btnSaveCustomer.Enabled = false;
                    btnAddCustomer.Enabled = true;
                    ClearCustomer();
                }
            }
            else
            {
                btnSaveCustomer.Enabled = true;
                btnAddCustomer.Enabled = false;
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
        #endregion

        #region MANEGE MANUFACTURER
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
            if (btnSaveManufacturer.Enabled)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có muốn hủy thao tác?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
                if (result == DialogResult.Yes)
                {
                    ClearManufacturerInputBox();
                    btnUpdateManufacturer.Enabled = true;
                    btnSaveManufacturer.Enabled = false;
                    return;
                }
            }
            else
            {
                btnAddManufacturer.Enabled = true;
                btnUpdateManufacturer.Enabled = false;
                btnSaveManufacturer.Enabled = true;

                ClearManufacturerInputBox();
            }
        }

        private void btnSaveManufacturer_Click(object sender, EventArgs e)
        {
            if (
               txtManufacturerName.Text == String.Empty
               )
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !");
                return;
            }
            string name = txtManufacturerName.Text;

            if (btnAddManufacturer.Enabled)
            {
                if (ManufacturerDAL.Instance.InsertManufacturer(name))
                {
                    MessageBox.Show("Thêm thành công");
                    listManufacturer = ManufacturerDAL.Instance.GetListManufacturer();
                    LoadManufacturer();
                    ClearManufacturerInputBox();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    ClearManufacturerInputBox();
                }
            }
            else if (btnUpdateManufacturer.Enabled)
            {
                if (txtManufacturerID.Text == String.Empty)
                {
                    MessageBox.Show("Chọn hãng SX dùm cái");
                    return;
                }
                int id = System.Convert.ToInt32(txtManufacturerID.Text);
                if (ManufacturerDAL.Instance.UpdateManufacturer(id, name))
                {
                    MessageBox.Show("Sửa thành công");
                    listManufacturer = ManufacturerDAL.Instance.GetListManufacturer();
                    LoadManufacturer();
                    ClearManufacturerInputBox();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                    ClearManufacturerInputBox();
                }

            }
        }

        private void btnSearchManufactuer_Click(object sender, EventArgs e)
        {
            if (txtSearchManuID.Text != String.Empty || txtSearchManuName.Text != String.Empty)
                listManufacturer = ManufacturerDAL.Instance.SearchManufacturer(txtSearchManuID.Text, txtSearchManuName.Text);
            else
                listManufacturer = ManufacturerDAL.Instance.GetListManufacturer();
            txtSearchManuID.Text = String.Empty;
            txtSearchManuName.Text = String.Empty;
            LoadManufacturer();
        }
        private void btnUpdateManufacturer_Click(object sender, EventArgs e)
        {
            if (btnSaveManufacturer.Enabled)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có muốn hủy thao tác?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
                if (result == DialogResult.Yes)
                {

                    btnSaveManufacturer.Enabled = false;
                    btnAddManufacturer.Enabled = true;
                    ClearManufacturerInputBox();
                }
            }
            else
            {
                btnSaveManufacturer.Enabled = true;
                btnAddManufacturer.Enabled = false;
            }
        }
        #endregion

        #region MANEGE CATEGORY 
        private void dtgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvCategory.SelectedCells[0].Value != null)
            {
                DataGridViewRow row = dtgvCategory.SelectedRows[0];
                txtCateID.Text = row.Cells[0].Value.ToString();
                txtCateName.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnAddCate_Click(object sender, EventArgs e)
        {
            if (btnSaveCate.Enabled)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có muốn hủy thao tác?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
                if (result == DialogResult.Yes)
                {
                    ClearCategoryInputBox();
                    btnUpdateCate.Enabled = true;
                    btnSaveCate.Enabled = false;
                    return;
                }
            }
            else
            {
                btnAddCate.Enabled = true;
                btnUpdateCate.Enabled = false;
                btnSaveCate.Enabled = true;
                ClearCategoryInputBox();
            }
        }
        private void btnSaveCate_Click(object sender, EventArgs e)
        {
            if (
               txtCateName.Text == String.Empty
               )
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !");
                return;
            }
            string name = txtCateName.Text;

            if (btnAddCate.Enabled)
            {
                if (CategoryDAL.Instance.InsertCategory(name))
                {
                    MessageBox.Show("Thêm thành công");
                    listCategory = CategoryDAL.Instance.GetListCategory();
                    LoadCategory();
                    ClearCategoryInputBox();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    ClearCategoryInputBox();
                }
            }
            else if (btnUpdateCate.Enabled)
            {
                if (txtCateID.Text == String.Empty )
                {
                    MessageBox.Show("Chọn danh mục dùm cái");
                    return;
                }
                int id = System.Convert.ToInt32(txtCateID.Text);
                if (CategoryDAL.Instance.UpdateCategory(id, name))
                {
                    MessageBox.Show("Sửa thành công");
                    listCategory = CategoryDAL.Instance.GetListCategory();
                    LoadCategory();
                    ClearCategoryInputBox();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                    ClearCategoryInputBox();
                }

            }
        }
        private void btnSearchCate_Click(object sender, EventArgs e)
        {
            if (txtSearchCateID.Text != String.Empty || txtSearchCateName.Text != String.Empty)
                listCategory = CategoryDAL.Instance.SearchCategory(txtSearchCateID.Text, txtSearchCateName.Text);
            else
                listCategory = CategoryDAL.Instance.GetListCategory();
            txtSearchCateID.Text = String.Empty;
            txtSearchCateName.Text = String.Empty;
            LoadCategory();
        }

        private void btnUpdateCate_Click(object sender, EventArgs e)
        {
            if (btnSaveCate.Enabled)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có muốn hủy thao tác?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
                if (result == DialogResult.Yes)
                {

                    btnSaveCate.Enabled = false;
                    btnAddCate.Enabled = true;
                    ClearCategoryInputBox();
                }
            }
            else
            {
                btnSaveCate.Enabled = true;
                btnAddCate.Enabled = false;
            }
        }
        #endregion

        #endregion
    }
}
