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
        public Order order = new();
        private Customer customer = new();
        public List<OrderDetail> listDetail = [];
        public bool _isAdd = false;
        private bool _isReading = false;
        
        public frmOrder(Order? readOder = null, bool isRead = true)
        {
            InitializeComponent();
            if (readOder != null)
            {
                order = readOder;
                _isReading = isRead;
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
                txtPhone.Text = customer.CustomerNumberPhone.Trim();
                txtCustomerName.Text = customer.CustomerName;
                rtbCustomerAdress.Text = customer.CustomerAddress;

                txtCustomerName.Enabled = false;
                rtbCustomerAdress.Enabled = false;

                lbNewCustomer.Visible = false;
                return true;
            }
            else 
            {
                lbNewCustomer.Visible = true;
                lbNewCustomer.Text = "Khách hàng mới sẽ được tự động lưu vào hệ thống";

                txtCustomerName.Enabled = true;
                rtbCustomerAdress.Enabled = true;
                return false; 
            }
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

                btnAddProduct.Enabled = false;
                btnCancel.Enabled = false;
                btnDeleteProduct.Enabled = false;
                btnPayment.Enabled = false;
                lbNewCustomer.Text = "Cảm ơn quý khách đã mua hàng";

                dtgvDetail.Enabled = false;
                dtgvDetail.ClearSelection();
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
                if (o.CustomerNumberPhone != String.Empty)
                    txtPhone.Text = o.CustomerNumberPhone.Trim();
                customer = CustomerDAL.Instance.GetCustomer(txtPhone.Text);
                dtpkDate.Text = DateTime.Now.ToShortDateString();
                cbStatus.Text = "Chưa thanh toán";
                txtTotal.Text = "0";
                CheckCustomer(txtPhone.Text);
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
                    default: result = false; break;
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
        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (CheckNumberPhone(txtPhone.Text))
            {
                CheckCustomer(txtPhone.Text);
            }
            else
            {
                lbNewCustomer.Visible = true;
                lbNewCustomer.Text = "Sai định dạng SĐT";

                txtCustomerName.Enabled = true;
                rtbCustomerAdress.Enabled = true;
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
            if (listDetail.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 sản phẩm");
                return;
            }

            if (txtPhone.Text == String.Empty ||
                txtCustomerName.Text == String.Empty ||
                rtbCustomerAdress.Text == String.Empty)
            { 
                MessageBox.Show("Vui lòng nhập thông tin khách hàng");
                return; 
            }

            if (!CheckNumberPhone(txtPhone.Text))
            {
                MessageBox.Show("Sai định dạng SDT");
                return;
            }


            DialogResult result = MessageBox.Show(
                "Bạn có muốn thanh toán và in hóa đơn?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            order.Date = dtpkDate.Value;
            order.CustomerNumberPhone = txtPhone.Text;
            order.Status = "Đã thanh toán";
            order.Total = System.Convert.ToDouble(txtTotal.Text);

            if (!CheckCustomer(txtPhone.Text))
            {
                CustomerDAL.Instance.InsertCustomer(txtPhone.Text, txtCustomerName.Text, rtbCustomerAdress.Text);
            }

            _isAdd = true;

            this.Hide();    
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
                _isAdd = false;
                this.Close();
            }
        }
    }
}
