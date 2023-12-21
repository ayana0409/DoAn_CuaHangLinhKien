using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmGRN : Form
    {
        private bool _isRead = false;
        public GRN GRN { get; set; }
        public List<InformationGRN> listInsertProduct = new();

        public bool _isAdd = false;

        string _tempImageName = "Unknown";

        private string GRNImagePath = Application.StartupPath.Split("\\DoAn_CuaHangLinhKien", 
            StringSplitOptions.None)[0] + @"\DoAn_CuaHangLinhKien\BLL\GRN-images\";

        public frmGRN(GRN? gRN = null)
        {
            InitializeComponent();
            if (gRN == null)
            {
                GRN = new();
            }
            else
            {
                GRN = gRN;
                _isRead = true;
            }
        }

        private void frmGRN_Load(object sender, EventArgs e)
        {
            listInsertProduct = InformationGRNDAL.Instance.GetListInfoGRNByID(GRN.GRNID);

            LoadGRN(GRN);
            CheckImageButton();
            LoadInstalProductList();
            CheckReadOnly();
        }
        #region METHOD

        private void CheckReadOnly()
        {
            if (_isRead)
            {
                btnAddGRNImage.Enabled = false;
                btnDeleteGRNImage.Enabled = false;
                btnAddProduct.Enabled = false;
                btnDeleteProduct.Enabled = false;
                btnInsertProduct.Enabled = false;

                dtpkGRNDate.Enabled = false;
                txtGRNID.Enabled = false;
                txtGRNUnit.Enabled = false;
                dtgvListInsertProduct.Enabled = false;
                cbCommit.Enabled = false;
            }
            else
            {
                btnAddProduct.Enabled = true;
                btnDeleteProduct.Enabled = false;
            }
        }

        private void LoadGRN(GRN gRN)
        {
            if (gRN == null)
                return;

            txtGRNID.Text = gRN.GRNID.ToString();
            txtGRNUnit.Text = gRN.Unit;
            dtpkGRNDate.Text = gRN.Date.ToString();
            if (gRN.Image != "Unknown")
                pbGRNImage.ImageLocation = GRNImagePath + gRN.Image;
            CheckToTal();
        }

        private void CheckImageButton()
        {
            if (pbGRNImage.Image == null)
                btnDeleteGRNImage.Enabled = false;
            else
                btnDeleteGRNImage.Enabled = true;
        }

        private bool CheckContainProduct(int id)
        {
            foreach (InformationGRN i in listInsertProduct)
                if (i.ProductID == id)
                    return true;
            return false;
        }

        private void RemoveOldProduct(int id)
        {
            foreach (InformationGRN i in listInsertProduct)
                if (i.ProductID == id)
                {
                    listInsertProduct.Remove(i);
                    break;
                }
        }

        private void CheckToTal()
        {
            GRN.Total = 0;
            if (listInsertProduct.Count == 0)
                GRN.Total = 0;
            else
                foreach (InformationGRN i in listInsertProduct)
                    GRN.Total += i.Price * i.Quantity;

            txtTotal.Text = GRN.Total.ToString();
        }

        private void LoadInstalProductList()
        {
            dtgvListInsertProduct.Rows.Clear();
            foreach (InformationGRN s in listInsertProduct)
            {
                DataGridViewRow row = (DataGridViewRow)dtgvListInsertProduct.Rows[0].Clone(); ;
                row.Cells[0].Value = s.ProductID.ToString();
                row.Cells[1].Value = ProductDAL.Instance.GetProduct(s.ProductID).ProductName;
                row.Cells[2].Value = s.Quantity;
                row.Cells[3].Value = s.Price;
                dtgvListInsertProduct.Rows.Add(row);
            }
            CheckToTal();
        }
        #endregion
        #region EVENT
        private void btnAddGRNImage_Click(object sender, EventArgs e)
        {
            ofdSelectImage.ShowDialog();
            string fileName = ofdSelectImage.FileName;

            _tempImageName = fileName;
            try
            {
                pbGRNImage.Image = Image.FromFile(fileName);
                _tempImageName = fileName;
            }
            catch
            {
                pbGRNImage.Image = null;
            }

            CheckImageButton();
        }

        private void btnDeleteGRNImage_Click(object sender, EventArgs e)
        {
            pbGRNImage.Image = null;
            CheckImageButton();
        }

        private void dtgvListInsertProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvListInsertProduct.SelectedCells[0].Value != null)
            {
                btnDeleteProduct.Enabled = true;
            }
            else
            {
                btnDeleteProduct.Enabled = false;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmInfomation frm = new();
            frm.ShowDialog();

            if (frm.selectedProduct != null)
            {
                if (CheckContainProduct(frm.selectedProduct.ProductID))
                {
                    RemoveOldProduct(frm.selectedProduct.ProductID);
                }

                listInsertProduct.Add(new InformationGRN(GRNDAL.Instance.GetHighestGRN().GRNID + 1,frm.selectedProduct.ProductID, frm.quantity, frm.price));
            }

            frm.Close();

            LoadInstalProductList();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dtgvListInsertProduct.SelectedCells.Count != 0)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc muốn xóa sản phẩm [" + dtgvListInsertProduct.SelectedCells[1].Value + "]?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
                if (result == DialogResult.Yes)
                    RemoveOldProduct(System.Convert.ToInt32(dtgvListInsertProduct.SelectedCells[0].Value));
            }
            LoadInstalProductList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                    "Bạn có chắc muốn hủy thao tác?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void btnInsertProduct_Click(object sender, EventArgs e)
        {
            if (!cbCommit.Checked)
            {
                MessageBox.Show(
                    "Bạn phải xác nhận trước khi nhập hàng \n Bạn phải chịu trách nhiệm cho hành động của mình",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc muốn nhập phiếu hàng này?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
                if (result == DialogResult.Yes)
                {
                    GRN.Unit = txtGRNUnit.Text;
                    GRN.Date = dtpkGRNDate.Value;
                    GRN.Total = System.Convert.ToDouble(txtTotal.Text);

                    string fileName = _tempImageName;
                    string newFileName = Guid.NewGuid().ToString() + Path.GetExtension(fileName);

                    GRN.Image = newFileName;

                    if (fileName != null)
                        File.Copy(fileName, GRNImagePath + newFileName);
                    _isAdd = true;
                    this.Hide();
                }
            }
        }

        private void cbCommit_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(
                    "Bạn không thể sửa sau khi nhập hàng",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
        }
        #endregion
    }
}
