using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class CustomerDAL
    {
        private static CustomerDAL instance;

        internal static CustomerDAL Instance
        {
            get { if (instance == null) instance = new CustomerDAL(); return instance; }
            private set => instance = value;
        }
        private CustomerDAL() { }
        // GetListCustomer


        #region CRUD
        public bool InsertCustomer(string numberphone, string name, string address)
        {
            string query = string.Format("Insert KhachHang ( SDTKhachHang, HoVaTenKhachHang, DiaChi ) values (N'{0}',N'{1}',N'{2}')",
               numberphone, name,address);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateCustomer(string numberphone, string name, string address)
        {
            string query = string.Format("Update KhachHang set HoVaTenKhachHang = N'{0}', DiaChi = N'{1}') where SDTKhachHang = N'{2}'",
               numberphone, name, address);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        #endregion
    }
}
