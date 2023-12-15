using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class ManufacturerDAL
    {
        private static ManufacturerDAL instance;

        internal static ManufacturerDAL Instance
        {
            get { if (instance == null) instance = new ManufacturerDAL(); return instance; }
            private set => instance = value;
        }
        private ManufacturerDAL() { }




        public bool InsertManufacturer(string name)
        {
            string query = string.Format("Insert HangSX (TenHangSX) values (N'{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateManufacturer(int id, string name)
        {
            string query = string.Format("Update HangSX set TenHangSX = N'{0}' where MaHangSX = {1}", name, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
