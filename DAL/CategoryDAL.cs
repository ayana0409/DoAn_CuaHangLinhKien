using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryDAL
    {
        private static CategoryDAL instance;

        public static CategoryDAL Instance 
        {
            get { if (instance == null) instance = new CategoryDAL(); return instance; }
            private set => instance = value; 
        }
        private CategoryDAL() { }



        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();
            string query = "select * from DanhMucSanPham";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow row in data.Rows) 
            {
                Category category = new(row);
                list.Add(category);
            }

            return list;
        }

        public List<Category>SearchCategory(string id = " ", string name = " ")
        {
            List<Category> list = new();
            if (id != null || name != null)
            {
                string query = string.Format("select * from DanhMucSanPham where MaDanhMuc  like  '%{0}%' and TenDanhMuc like '%{1}%'", id, name);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow row in data.Rows)
                {
                    Category ct = new(row);
                    list.Add(ct);
                }
            }
            return list;
        }


        public bool InsertCategory(string name)
        {
            string query = string.Format("Insert DanhMucSanPham (TenDanhMuc) values (N'{0}')", name);  
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateCategory(int id, string name)
        {
            string query = string.Format("Update DanhMucSanPham set TenDanhMuc = N'{0}' where MaDanhMuc = {1}", name, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        } 
    }
}
