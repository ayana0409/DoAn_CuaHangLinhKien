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

        //SetStaff (StaffID)

        //DeleteStaff (StaffID = null)

        #region CRUD
        public bool InsertAccount(string accountID, int typeID, string password = "0", int? staffID = null)
        {
            string query = String.Format("Insert TaiKhoan (MaTaiKhoan, MatKhau, MaLoaiTK, MaNhanVien) " +
                "values ('{0}', '{1}', {3}, {4})", accountID, password, typeID, staffID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateAccount(string accountID, int typeID, string password = "0", int? staffID = null)
        {
            string query = String.Format("Update TaiKhoan set MatKhau = '{1}', MaLoaiTK = '{2}', MaNhanVien = {3} " +
                "where MaTaiKhoan = '{0}'", accountID, password, typeID, staffID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(string accountID)
        {
            Account account = GetAccountByID(accountID);
            if (account != null)
            {
                if (account.StaffID == null)
                {
                    string query = String.Format("Delete TaiKhoan where MaTaiKhoan = '{0}'", accountID);
                    int result = DataProvider.Instance.ExecuteNonQuery(query);
                    return result > 0;

                }
            }
            return false;
        }
        #endregion
    }
}
