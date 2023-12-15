using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class RoleDAL
    {
        private static RoleDAL instance;

        internal static RoleDAL Instance
        {
            get { if (instance == null) instance = new RoleDAL(); return instance; }
            private set => instance = value;
        }
        private RoleDAL() { }






        public bool InsertRole(string name)
        {
            string query = string.Format("Insert ChucVu (TenChucVu) values (N'{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
