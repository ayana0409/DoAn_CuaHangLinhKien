using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class OrderDetailDAL
    {
        private static OrderDetailDAL instance;

        internal static OrderDetailDAL Instance
        {
            get { if (instance == null) instance = new OrderDetailDAL(); return instance; }
            private set => instance = value;
        }
        private OrderDetailDAL() { }

        public bool InsertOrderDetail(int orderID, float price, int quantity)
        {
            string query = string.Format("Insert ChiTietDonHang ( MaDonHang, GiaBan, SoLuongBan ) values ({0},{1},{2})",
               orderID, quantity, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
