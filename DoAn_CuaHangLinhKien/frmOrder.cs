using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmOrder : Form
    {
        private Order order = new();
        private Customer customer;
        private List<OrderDetail> listDetail = [];

        private bool _isReading = false;

        /*
        public frmDonHang()
        {
            InitializeComponent();
        }
        */
        public frmOrder(Order? readOder = null)
        {
            InitializeComponent();
            if (readOder != null)
            {
                order = readOder;
                _isReading = true;
                customer = CustomerDAL.Instance.GetCustomer(readOder.CustomerNumberPhone);
                listDetail = OrderDetailDAL.Instance.GetListOrderDetailOrderID(order.OrderID);
            }
        }

        private void frmDonHang_Load(object sender, EventArgs e)
        {
            LoadOrder(order);
            LoadDetailList();
            CheckReading();
        }

        private bool CheckCustomer(string phone)
        {
            int result;
            result = CustomerDAL.Instance.GetCustomerIndex(phone);
            if (result != -1)
            {
                customer = CustomerDAL.Instance.GetCustomer(phone);
                return true;
            }
            else { return false; }
        }
        private bool CheckContainProduct(int id)
        {
            foreach (OrderDetail i in listDetail)
                if (i.ProductID == id)
                    return true;
            return false;
        }

        private void CheckReading()
        {
            if (_isReading)
            {
                txtCustomerName.Enabled = false;
                txtPhone.Enabled = false;
                rtbCustomerAdress.Enabled = false;
            }
        }

        private void CheckTotal()
        {
            double total = 0;
            foreach (OrderDetail i in listDetail)
                total += i.Quantity * i.Price;

            txtTotal.Text = total.ToString();
        }

        private void LoadOrder(Order o)
        {
            if (_isReading)
            {
                txtPhone.Text = o.CustomerNumberPhone;
                txtCustomerName.Text = customer.CustomerName;
                rtbCustomerAdress.Text = customer.CustomerAddress;
                txtOrderID.Text = o.OrderID.ToString();
                cbStatus.Text = o.Status;
                dtpkDate.Text = o.Date.ToString("dd/MM/yyyy");
                txtTotal.Text = o.Total.ToString();
            }
            else
            {
                dtpkDate.Text = DateTime.Now.ToShortDateString();
                cbStatus.Text = "Chưa thanh toán";
                txtTotal.Text = "0";
            }
        }
        private void RemoveOldProduct(int id)
        {
            foreach (OrderDetail i in listDetail)
                if (i.ProductID == id)
                {
                    listDetail.Remove(i);
                    break;
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
        private void LoadDetailList()
        {
            dtgvDetail.Rows.Clear();
            foreach (OrderDetail s in listDetail)
            {
                DataGridViewRow row = (DataGridViewRow)dtgvDetail.Rows[0].Clone(); ;
                row.Cells[0].Value = s.ProductID;
                row.Cells[1].Value = ProductDAL.Instance.GetProduct(s.ProductID).ProductName;
                row.Cells[2].Value = s.Quantity;
                row.Cells[3].Value = s.Price;
                dtgvDetail.Rows.Add(row);
            }

            CheckTotal();
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (CheckNumberPhone(txtPhone.Text))
            {
                if (CheckCustomer(txtPhone.Text))
                {
                    txtCustomerName.Text = customer.CustomerName;
                    rtbCustomerAdress.Text = customer.CustomerAddress;

                    txtCustomerName.Enabled = false;
                    rtbCustomerAdress.Enabled = false;

                    lbNewCustomer.Visible = false;
                }
                else
                {
                    lbNewCustomer.Visible = true;
                    lbNewCustomer.Text = "Khách hàng mới sẽ được tự động lưu vào hệ thống";

                    txtCustomerName.Enabled = true;
                    rtbCustomerAdress.Enabled = true;
                    txtCustomerName.Text = String.Empty;
                    rtbCustomerAdress.Text = String.Empty;
                }
            }
            else
            {
                lbNewCustomer.Visible = true;
                lbNewCustomer.Text = "Sai định dạng SĐT";

                txtCustomerName.Enabled = true;
                rtbCustomerAdress.Enabled = true;
                txtCustomerName.Text = String.Empty;
                rtbCustomerAdress.Text = String.Empty;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            frmInfomation frm = new(true);
            frm.ShowDialog();

            if (frm.selectedProduct != null)
            {
                if (CheckContainProduct(frm.selectedProduct.ProductID))
                {
                    RemoveOldProduct(frm.selectedProduct.ProductID);
                }

                listDetail.Add(new OrderDetail(frm.selectedProduct.ProductID, OrderDAL.Instance.GetHighestOrder().OrderID, frm.price, frm.quantity));
            }

            frm.Close();

            LoadDetailList();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dtgvDetail.SelectedCells.Count != 0)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc muốn xóa sản phẩm [" + dtgvDetail.SelectedCells[1].Value + "]?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
                if (result == DialogResult.Yes)
                    RemoveOldProduct(System.Convert.ToInt32(dtgvDetail.SelectedCells[0].Value));
            }
            LoadDetailList();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                   "Bạn có chắc muốn hủy đơn?",
                   "Xác nhận",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question
                   );
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
