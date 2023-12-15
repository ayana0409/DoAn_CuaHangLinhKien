﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class CategoryDAL
    {
        private static CategoryDAL instance;

        internal static CategoryDAL Instance 
        {
            get { if (instance == null) instance = new CategoryDAL(); return instance; }
            private set => instance = value; 
        }
        private CategoryDAL() { }






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