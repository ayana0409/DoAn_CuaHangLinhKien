using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class StaffDAL
    {
        private static StaffDAL instance;

        internal static StaffDAL Instance
        {
            get { if (instance == null) instance = new StaffDAL(); return instance; }
            private set => instance = value;
        }
        private StaffDAL() { }





        public bool InsertStaff(int accountID, int roleID, string name, DateOnly date, string sex, string address, string numberphone, string status)
        {
            string query = string.Format("Insert NhanVien ( MaTaiKhoan, MaChucVu, HoVaTen, NgaySinh, GioiTinh,DiaChi, SDT, TrangThai ) values ({0},{1},N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}')",
               accountID, roleID,name, date, sex, address, numberphone, status);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateStaff(int accountID, int roleID, string name, DateOnly date, string sex, string address, string numberphone, string status, int staffID)
        {
            string query = string.Format("Update NhanVien set MaTaiKhoan = {0}, MaChucVu = {1}, HoVaTen = N'{2}', NgaySinh = N'{3}', GioiTinh = N'{4}, DiaChi = N'{5}', SDT = N'{6}', TrangThai = N'{7}' where staffID = {8}",
              accountID, roleID, name, date, sex, address, numberphone, status, staffID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
