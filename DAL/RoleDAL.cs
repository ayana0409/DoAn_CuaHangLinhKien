using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RoleDAL
    {
        private static RoleDAL instance;

        public static RoleDAL Instance
        {
            get { if (instance == null) instance = new RoleDAL(); return instance; }
            private set => instance = value;
        }
        private RoleDAL() { }

        public List<Role> GetListRole()
        {
            List<Role> list = new();
            string query = "select * from ChucVu";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Role pd = new(row);
                list.Add(pd);
            }
            return list;
        }
        public Role GetRole(int id)
        {
            string query = "select * from ChucVu where MaChucVu = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return new Role(data.Rows[0]);
        }

        public bool InsertRole(string name)
        {
            string query = string.Format("Insert ChucVu (TenChucVu) values (N'{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
