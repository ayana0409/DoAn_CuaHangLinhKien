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
        public int OrderID { get; set; }
        public int StaffID { get; set; }
        public string CustomerNumberPhone { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public double Total { get; set; }
        public Order()
        {
            OrderID = -1;
            StaffID = 0;
            this.CustomerNumberPhone = string.Empty;
            this.Date = DateTime.Now;
            this.Status = "Chưa thanh toán";
            this.Total = 0;
        }


        public Order( int orderID, int staffID, string customerNumberPhone, DateTime date, string status, double total)
        {
            this.OrderID = orderID;
            this.StaffID = staffID;
            this.CustomerNumberPhone = customerNumberPhone;
            this.Date = date;
            this.Status = status;
            this.Total = total;

        }
        public Order(DataRow row) 
        {
            this.OrderID = (int)row["MaDonHang"];
            this.StaffID = (int)row["MaNhanVien"];
            this.CustomerNumberPhone = (string)row["SDTKhachHang"];
            this.Date = (DateTime)row["NgayNhap"];
            this.Status = (string)row["TrangThai"];
            this.Total = (double)row["TongGiaTien"];
        }
    }
}












































