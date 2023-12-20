﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    public class CustomerDAL
    {
        private static CustomerDAL instance;

        public static CustomerDAL Instance
        {
            get { if (instance == null) instance = new CustomerDAL(); return instance; }
            private set => instance = value;
        }
        private CustomerDAL() { }


        public List<Customer> GetListCustomer()
        {
            List<Customer> list = new ();
            string query = "select * from KhachHang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Customer ct = new (row);
                list.Add(ct);
            }
            return list;
        }
       
        public List<Customer> SearchCustomer(string numberphone = "", string name = "")
        {
            List<Customer> list = new ();
            if (numberphone != null || name != null)
            {
                string query = string.Format("select * from KhachHang where SDTKhachHang  like  '%{0}%' and HoVaTenKhachHang like '%{1}%'", numberphone, name);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow row in data.Rows)
                {
                    Customer ct = new (row);
                    list.Add(ct);
                }
            }
            return list;
        }

        #region CRUD
        public bool InsertCustomer(string numberphone, string name, string address = null)
        {
            string query = string.Format("Insert KhachHang ( SDTKhachHang, HoVaTenKhachHang, DiaChi ) values (N'{0}',N'{1}',N'{2}')",
               numberphone, name,address);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateCustomer(string numberphone, string name, string address = null)
        {
            string query = string.Format("Update KhachHang set HoVaTenKhachHang = N'{0}', DiaChi = N'{1}' where SDTKhachHang = N'{2}'",
               name, address, numberphone);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        #endregion
    }
}
