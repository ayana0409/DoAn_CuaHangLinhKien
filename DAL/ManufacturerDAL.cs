using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ManufacturerDAL
    {
        private static ManufacturerDAL instance;

        public static ManufacturerDAL Instance
        {
            get { if (instance == null) instance = new ManufacturerDAL(); return instance; }
            private set => instance = value;
        }
        private ManufacturerDAL() { }


        public List<Manufacturer> GetListManufacturer()
        {
            List<Manufacturer> list = new();
            string query = "select * from HangSX";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Manufacturer mnu = new(row);
                list.Add(mnu);
            }
            return list;
        }
        public List<Manufacturer> SearchManufacturer(string id = " ", string name = " ")
        {
            List<Manufacturer> list = new();
            if (id != null || name != null)
            {
                string query = string.Format("select * from HangSX where MaHangSX  like  '%{0}%' and TenHangSX like '%{1}%'", id, name);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow row in data.Rows)
                {
                    Manufacturer ct = new(row);
                    list.Add(ct);
                }
            }
            return list;
        }
        public Manufacturer GetManufacturer(int id)
        {
            string query = "select * from HangSX where MaHangSX = " + id + "";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            Manufacturer manufacturer = new(data.Rows[0]);

            return manufacturer;
        }

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
