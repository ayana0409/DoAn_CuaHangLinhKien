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
    public partial class SPViewer : UserControl
    {
        private Product product;
        private bool isSelected;

        public event EventHandler WasClicked;

        public SPViewer(Product product)
        {
            InitializeComponent();
            Directory.CreateDirectory("C:\\CuaHangLinhKien\\HinhAnhSanPham\\");
            this.Product = product;
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

        public Product Product
        {
            get => product;
            set
            {
                product = value;
                lbID.Text = "MSP: " + product.ProductID.ToString();
                lbName.Text = product.ProductName;
                lbQuantity.Text = "Kho: " + product.Quantity.ToString();
                lbPrice.Text = product.Price.ToString("#,###") + " VNĐ";
                lbInfomation.Text = product.Information;
                string path = "C:\\CuaHangLinhKien\\HinhAnhSanPham\\";
                if (product.Image == "Unknown" || product.Image == String.Empty)
                    pbImage.ImageLocation = path + "default-product.png";
                else
                    pbImage.ImageLocation = path + product.Image;
            }
        }
        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;
                this.BackColor = IsSelected ? Color.FromArgb(255, 242, 212) : Color.Azure;
            }
        }
        private void SPViewer_Click(object sender, EventArgs e)
        {
            WasClicked?.Invoke(this, e);
            IsSelected = true;
        }
    }
}
