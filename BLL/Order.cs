using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Order
    {
        public int ProductID { get; set; }
        public int StaffID { get; set; }
        public string CustomerNumberPhone { get; set; }
        public DateOnly Date { get; set; }
        public string Status { get; set; }
        public float Total { get; set; }

        public Order( int productID, int staffID, string customerNumberPhone, DateOnly date, string status, float total)
        {
            this.ProductID = productID;
            this.StaffID = staffID;
            this.CustomerNumberPhone = customerNumberPhone;
            this.Date = date;
            this.Status = status;
            this.Total = total;

        }
        public Order(DataRow row) 
        {
            this.ProductID = (int)row["MaSanPham"];
            this.StaffID = (int)row["MaNhanVien"];
            this.CustomerNumberPhone = (string)row["SDTKhachHang"];
            this.Date = (DateOnly)row["NgayNhap"];
            this.Status = (string)row["TrangThai"];
            this.Total = (float)row["TongGiaTien"];
        }
    }
}












































