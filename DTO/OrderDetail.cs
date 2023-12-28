using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderDetail
    {
        public int ProductID { get; set; }
        public int OrderID { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public OrderDetail(int productID, int orderID, double price, int quantity)
        {
            this.ProductID = productID;
            this. OrderID = orderID;
            this.Price = price;
            this.Quantity = quantity;
        }
        public OrderDetail(DataRow row )
        {
            this.ProductID = (int)row["MaSanPham"];
            this.OrderID = (int)row["MaDonHang"];
            this.Price = (double)row["GiaBan"];
            this.Quantity = (int)row["SoLuongBan"];
        }
    }
    
}
