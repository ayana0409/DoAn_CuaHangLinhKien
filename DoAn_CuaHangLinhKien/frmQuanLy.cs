using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
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
        List<Customer> listCustomer;


        string? _tempImageName = null;
        public frmManage()
        {
            InitializeComponent();
        }

        private void frmManage_Load(object sender, EventArgs e)
        {
            listCategory = CategoryDAL.Instance.GetListCategory();
            listManufacturer = ManufacturerDAL.Instance.GetListManufacturer();
            listCustomer = CustomerDAL.Instance.GetListCustomer();
            LoadCustomer();
            LoadManufacturer();
            LoadCategory();
        }

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
                row = dtgvCustomer.Rows[e.RowIndex];
                txtNumberPhone.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                rtbAddress.Text = row.Cells[2].Value.ToString();
            }
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

        #region MANEGE MANUFACTURER
        private void dtgvManufacturer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvManufacturer.SelectedCells[0].Value != null)
            {
                DataGridViewRow row = dtgvManufacturer.SelectedRows[0];
                row = dtgvManufacturer.Rows[e.RowIndex];
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
               txtManufacturerID.Text == String.Empty ||
               txtManufacturerName.Text == String.Empty
               )
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !");
                return;
            }
            int id = System.Convert.ToInt32(txtManufacturerID.Text);
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
               txtCateID.Text == String.Empty ||
               txtCateName.Text == String.Empty
               )
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !");
                return;
            }
            int id = System.Convert.ToInt32(txtCateID.Text);
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
    }
}
#endregion






