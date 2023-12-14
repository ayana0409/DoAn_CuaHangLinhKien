using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Staff
    {
        public int StaffID { get; set; }
        public int AccountID { get; set; }
        public int RoleID { get; set; }
        public string StaffName { get; set; }
        public DateOnly Date { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public string Status { get; set; }

        public Staff(int staffID,int AccountID,int RoleID, string staffName, DateOnly date, string sex, string address, int phoneNumber, string status)
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
            this.AccountID = (int)row["MaTaiKhoan"];
            this.RoleID = (int)row["MaChucVu"];
            this.StaffName = (string)row["TenNhanVien"];
            this.Date = (DateOnly)row["NgaySinh"];
            this.Sex = (string)row["GioiTinh"];
            this.Address = (string)row["DiaChi"];
            this.PhoneNumber = (int)row["SDT"];
            this.Status = (string)row["TrangThai"];
        } 
    }
}
