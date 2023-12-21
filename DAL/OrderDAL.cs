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

        public bool InsertOrder(int staffid, int numberphone, DateOnly date, string status, float total)
        {
            string query = string.Format("Insert DonHang (MaNhanVien, SDTKhachHang, NgayNhap, TrangThai, TongGiaTri) values ({0},{1},{2},N'{3}',{4})",
                staffid, numberphone, date, status, total);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateOrder(int staffid, string numberphone, DateOnly date, string status, float total, int id)
        {
            string query = string.Format("Update DonHang set MaNhanVien = {0}, SDTKhachHang = N'{1}',NgayNhap = {2}, TrangThai = N'{3}', TongGiaTri = {4} where MaDonHang = {5}",
                staffid, numberphone, date, status, total, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteOrder (int idOrder)
        {
            //

            string query = string.Format("DeleteOrder where id = {0}", idOrder);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

        return result > 0;
        }
    }
}

