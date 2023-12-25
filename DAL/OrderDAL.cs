using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using DTO;
using System.Data;
using System.Numerics;

namespace DAL
{
    public class OrderDAL
    {
        private static OrderDAL instance;

        public static OrderDAL Instance
        {
            get { if (instance == null) instance = new OrderDAL(); return instance; }
            private set => instance = value;
        }
        private OrderDAL() { }

        public List<Order> GetListOrder()
        {
            List<Order> list = new();
            string query = "select * from DonHang";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Order o = new(row);
                list.Add(o);
            }

            return list;
        }


        public Order GetHighestOrder()
        {
            string query = "select top 1 * from DonHang order by MaDonHang DESC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
                return new Order(data.Rows[0]);
            else
                return new Order();
        }

        public Order GetOrder(int id)
        {
            string query = "select * from DonHang where MaDonHang = '" + id + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return new Order(data.Rows[0]);
        }

        public List<Order> SearchOrder(string from, string to, string id = "") 
        {
            string query = String.Format("select * from DonHang where MaDonHang like '%{0}%' and NgayNhap between '{1}' and '{2}'", id, from, to);
            List<Order> list = new();

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Order mnu = new(row);
                list.Add(mnu);
            }

            return list;
        }

        public bool InsertOrder(int staffid, string numberphone, string date, string status, double total)
        {
            string query = string.Format("Insert DonHang (MaNhanVien, SDTKhachHang, NgayNhap, TrangThai, TongGiaTien) values ({0},'{1}','{2}',N'{3}',{4})",
                staffid, numberphone, date, status, total);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}

