using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace DAL
{
    public class StaffDAL
    {
        private static StaffDAL? instance;

        public static StaffDAL Instance
        {
            get { if (instance == null) instance = new StaffDAL(); return instance; }
            private set => instance = value;
        }
        private StaffDAL() { }

        public List<Staff> GetListStaff()
        {
            List<Staff> list = new();
            string query = "select * from NhanVien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Staff pd = new(row);
                list.Add(pd);
            }
            return list;
        }

        public List<Staff> SearchStaff(string id = "", string name = "")
        {
            string query = System.String.Format("select * from NhanVien where MaNhanVien like '%{0}%' " +
                "and HoVaTen like N'%{1}%'", id, name);
            List<Staff> list = new();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow row in data.Rows)
            {
                list.Add(new Staff(row));
            }

            return list;
        }

        public Staff GetStaff(int id)
        {
            string query = "select * from NhanVien where MaNhanVien = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return new Staff(data.Rows[0]);
        }

        //SetAccount
        //query = "Update TaiKhoan Set StaffID = @id where MaTaiKhoan = @ma"


        //DeleteAccount (AccountID = null)

        public bool InsertStaff(int roleID, string name, string date, string sex, 
            string address, string numberphone, string status)
        {
            string query = string.Format("Insert NhanVien ( MaChucVu, HoVaTen, NgaySinh, GioiTinh, " +
                "DiaChi, SDT, TrangThai ) values ({0}, N'{1}', '{2}',N'{3}',N'{4}', '{5}',N'{6}')",
                roleID, name, date, sex, address, numberphone, status);
               
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateStaff(int roleID, string name, string date, string sex, 
            string address, string numberphone, string status, int staffID)
        {
            string query = string.Format("Update NhanVien set MaChucVu = {0}, HoVaTen = N'{1}', " +
                "NgaySinh = N'{2}', GioiTinh = N'{3}', DiaChi = N'{4}', SDT = N'{5}', " +
                "TrangThai = N'{6}' where MaNhanVien = {7}",
                roleID, name, date, sex, address, numberphone, status, staffID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool SetAccountStaff(int staffID, string accountID = "")
        {
            string query = string.Format("proc_UpdateStaffAccount @manv , @matk ");
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { staffID, accountID});

            return result > 0;
        }
    }
}
