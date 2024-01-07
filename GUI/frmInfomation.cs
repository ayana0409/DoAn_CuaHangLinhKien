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
    public partial class frmInfomation : Form
    {
        public Product selectedProduct = null;
        public int quantity = 0;
        public double price = 0;

        private bool _isOrder = false;

        private List<Product> listProduct = new();
        public frmInfomation(bool isOrder = false)
        {
            InitializeComponent();
            _isOrder = isOrder;
        }

        private void frmInfomationGRN_Load(object sender, EventArgs e)
        {
            listProduct = ProductDAL.Instance.GetListProduct();
            LoadProduct();
        }

        private void LoadProduct()
        {
            flpProduct.Controls.Clear();
            foreach (Product p in listProduct)
            {
                SPViewer ctrViewer = new(p);
                ctrViewer.WasClicked += FlowLayOutPanel_Controls_WasClicked;
                flpProduct.Controls.Add(ctrViewer);
            }
        }
        private bool CheckNumber(string phone)
        {
            bool result = false;
            char[] chars = phone.ToCharArray();
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
            txtID.Text = v.Product.ProductID.ToString();
            txtName.Text = v.Product.ProductName;
            txtPrice.Text = v.Product.Price.ToString();
            rtbDetail.Text = v.Product.Information;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchProductID.Text != String.Empty || txtSearchProductName.Text != String.Empty)
                listProduct = ProductDAL.Instance.SearchProduct(txtSearchProductID.Text, txtSearchProductName.Text);
            else
                listProduct = ProductDAL.Instance.GetListProduct();
            txtSearchProductID.Text = String.Empty;
            txtSearchProductName.Text = String.Empty;
            LoadProduct();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text == String.Empty || txtPrice.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }

            if (!CheckNumber(txtPrice.Text) || !CheckNumber(txtQuantity.Text))
            {
                MessageBox.Show("Sai định dạng số lượng");
                return;
            }

            selectedProduct = ProductDAL.Instance.GetProduct(System.Convert.ToInt32(txtID.Text));
            quantity = System.Convert.ToInt32(txtQuantity.Text);
            price = System.Convert.ToDouble(txtPrice.Text);

            if (_isOrder)
            {
                if (quantity > selectedProduct.Quantity)
                {
                    MessageBox.Show("Số lượng thêm vào vượt quá giới hạn");
                    return;
                }
            }

            this.Hide();
        }
    }
}
