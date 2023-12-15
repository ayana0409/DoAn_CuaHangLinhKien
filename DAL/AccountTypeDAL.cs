using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccountTypeDAL
    {
        private static AccountTypeDAL instance;
        public AccountTypeDAL() { }

        public static AccountTypeDAL Instance 
        {
            get { if (instance == null) instance = new AccountTypeDAL(); return instance; }
            private set => instance = value; 
        }

        public List<AccountType> GetListAccountType()
        {
            List<AccountType> list = new();
            string query = "select * form LoaiTaiKhoan";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                AccountType at = new(row);
                list.Add(at);
            }
            return list;
        }

        public AccountType GetAccountType(int id)
        {
            string query = String.Format("select * from LoaiTaiKhoan where MaLoaiTK = {0}", id);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            AccountType accountType = new(data.Rows[0]);

            return accountType;
        }

    }
}
