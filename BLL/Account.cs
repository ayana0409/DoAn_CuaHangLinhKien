using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class Account
    {
        public string AccountID { get; set; }
        public int? StaffID { get; set; }
        public string Password { get; set; }
        public int TypeID { get; set; }

        public Account(string accountID, string password, int typeID, int? staffID = null)
        {
            this.AccountID = accountID;
            this.Password = password;
            this.TypeID = typeID;
            this.StaffID = staffID;
        }
        public Account(DataRow row)
        {
            this.AccountID = (string)row["MaTaiKhoan"];
            this.Password = (string)row["MatKhau"];
            this.TypeID = (int)row["MaLoaiTK "];
            // Có thể lỗi
            this.StaffID = (int)row["MaNhanVien"];
        }
    }
}
