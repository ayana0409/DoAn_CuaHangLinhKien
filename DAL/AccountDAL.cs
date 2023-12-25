using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccountDAL
    {
        private static AccountDAL instance;

        public static AccountDAL Instance 
        {
            get { if (instance == null) instance = new AccountDAL(); return instance; } 
            private set => instance = value; 
        }
        public AccountDAL() { }

        public Account GetAccountByID(string accountID)
        {
            string query = "Select * from TaiKhoan where MaTaiKhoan = '" + accountID + "'";
            DataTable Data = DataProvider.Instance.ExecuteQuery(query);
            Account account = new(Data.Rows[0]);
            return account;
        }
        public bool Login(string username, string password)
        {
            string query = "proc_Login @accountID , @password";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {username, password});

            return result.Rows.Count > 0;
        }
        public List<Account> SearchAccount(string accountID)
        {
            List<Account> list = new();
            if (accountID != null)
            {
                string query = string.Format("select * from TaiKhoan where MaTaiKhoan  like '%{0}%'"
                    , accountID);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow row in data.Rows)
                {
                    Account ac = new(row);
                    list.Add(ac);
                }
            }
            return list;
        }
        public List<Account> GetListAccount()
        {
            List<Account> list = new List<Account>();
            string query = "select * from TaiKhoan";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Account account = new(row);
                list.Add(account);
            }

            return list;
        }

        public void DeleteAccountByStaffID(int staffID)
        {
            string query = String.Format("update TaiKhoan set MaNhanVien = null " +
                "where MaTaiKhoan in (select MaTaiKhoan from TaiKhoan where MaNhanVien = {0})",
                staffID);
            DataProvider.Instance.ExecuteQuery(query);
        }

        #region CRUD
        public bool InsertAccount(string accountID, string password, int typeID, int? staffID = null)
        {
            string query = String.Format("Insert TaiKhoan (MaTaiKhoan, MatKhau, MaLoaiTK, MaNhanVien) " +
                "values ('{0}', '{1}', '{2}', {3})", accountID, password, typeID, staffID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateAccount(string accountID, string password, int typeID, int? staffID = null)
        {
            string query = String.Format("Update TaiKhoan set MatKhau = '{1}', MaLoaiTK = '{2}', MaNhanVien = {3} " +
                "where MaTaiKhoan = '{0}'", accountID, password, typeID, staffID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateAccountID(string oldID ,string accountID, string password, int typeID, int? staffID = null)
        {
            string query = String.Format("Update TaiKhoan set MaTaiKhoan = '{0}', MatKhau = '{1}', MaLoaiTK = '{2}', MaNhanVien = {3} " +
                "where MaTaiKhoan = '{4}'", accountID, password, typeID, staffID, oldID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        #endregion
    }
}
