using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderDetailDAL
    {
        private static OrderDetailDAL instance;

        public static OrderDetailDAL Instance
        {
            get { if (instance == null) instance = new OrderDetailDAL(); return instance; }
            private set => instance = value;
        }
        private OrderDetailDAL() { }

        public List<OrderDetail> GetListOrderDetailOrderID(int id)
        {
            List<OrderDetail> list = new();
            string query = "select * from ChiTietDonHang where MaDonHang = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                OrderDetail o = new(row);
                list.Add(o);
            }

            return list;
        }


        public bool InsertOrderDetail(int orderID, float price, int quantity)
        {
            string query = string.Format("Insert ChiTietDonHang ( MaDonHang, GiaBan, SoLuongBan ) values ({0},{1},{2})",
               orderID, quantity, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
