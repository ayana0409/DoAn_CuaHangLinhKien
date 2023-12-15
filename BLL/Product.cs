using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public int ManufacturerID { get; set; }
        public string ProductName { get; set;}
        public string Information { get; set;}
        public int Quantity { get; set;}
        public double Price { get; set;} 
        public string Image { get; set;}

        public Product (int productID, int categoryID, int manufacturer, string productName, string information, int quantity, double price, string image ) 
        { 
            this.ProductID = productID;
            this.CategoryID = categoryID;
            this.ManufacturerID = manufacturer;
            this.ProductName = productName;
            this.Information = information;
            this.Quantity = quantity;
            this.Price = price;
            this.Image = image ;
        }
        public Product (DataRow row)
        {
            this.ProductID = (int)row["MaSanPham"];
            this.CategoryID = (int)row["MaDanhMuc"];
            this.ManufacturerID = (int)row["MaHangSX"];
            this.ProductName = (string)row["TenSanPham"];
            if (row["TTChiTiet"] != System.DBNull.Value)
                this.Information = (string)row["TTChiTiet"];
            this.Quantity = (int)row["SoLuong"];
            this.Price = (double)row["Gia"];
            if (row["HinhAnhSanPham"] != System.DBNull.Value)
                this.Image = (string)row["HinhAnhSanPham"];
        }

    }
}
