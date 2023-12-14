using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class InformationGRN
    {
        public int GRNID { get; set; }
        public int ProductID { get; set;}
        public int Quantity { get; set; }
        public float Price { get; set; }

        public InformationGRN(int gRNID, int productID, int quantity, float price) 
        {
            this.GRNID = gRNID;
            this.ProductID = productID;
            this.Quantity = quantity;
            this.Price = price;
        }
        public InformationGRN(DataRow row)
        {
            this.GRNID = (int)row["MaPhieuNhap"];
            this.ProductID = (int)row["MaSanPham"];
            this.Quantity = (int)row["SoLuongNhap"];
            this.Price = (int)row["GiaNhap"];

        }

    }
    
}
