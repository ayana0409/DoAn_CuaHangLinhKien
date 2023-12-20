using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace DTO
{
    public class Staff
    {
        public int StaffID { get; set; }
        public string? AccountID { get; set; }
        public int RoleID { get; set; }
        public string StaffName { get; set; }
        public DateTime Date { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Status { get; set; }

        public Staff(int staffID,string AccountID,int roleID, string staffName, DateTime date, string sex, string address, string phoneNumber, string status)
        {
            this.StaffID = staffID;
            this.AccountID = AccountID;
            this.RoleID = RoleID;
            this.StaffName = staffName;
            this.Date = date;
            this.Sex = sex;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Status = status;
        }

        public Staff(DataRow row)
        {
            this.StaffID = (int)row["MaNhanVien"];
            if (row["MaTaiKhoan"] != System.DBNull.Value)
                this.AccountID = (string)row["MaTaiKhoan"];
            else
                this.AccountID = null;
            this.RoleID = (int)row["MaChucVu"];
            this.StaffName = (string)row["HoVaTen"];
            this.Date = (DateTime)row["NgaySinh"];
            this.Sex = (string)row["GioiTinh"];
            this.Address = (string)row["DiaChi"];
            this.PhoneNumber = (string)row["SDT"];
            this.Status = (string)row["TrangThai"];
        } 

        public override string ToString()
        {
            return this.StaffName;
        }
    }
}
