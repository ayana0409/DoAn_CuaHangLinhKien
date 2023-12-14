using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Customer
    {
        public string CustomerNumberPhone { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }

        public Customer(string customerNumberPhone, string customerName, string customerAddress)
        {
            this.CustomerNumberPhone = customerNumberPhone;
            this.CustomerName = customerName;
            this.CustomerAddress = customerAddress;
        }

        public Customer(DataRow row) 
        {
            this.CustomerNumberPhone = (string)row["SDTKhachHang"];
            this.CustomerName = (string)row["HoVaTenKhachHang"];
            this.CustomerAddress = (string)row["DiaChi"];
        }


    }
}
