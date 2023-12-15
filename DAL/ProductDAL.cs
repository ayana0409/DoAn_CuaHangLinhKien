using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    internal class ProductDAL
    {
        private static ProductDAL instance;

        internal static ProductDAL Instance
        {
            get { if (instance == null) instance = new ProductDAL(); return instance; }
            private set => instance = value;
        }

        private ProductDAL() { }


        public bool InsertProduc(string name, string information = null, float price = 0, int quantity = 0,  string image = null)
        {
            string query = string.Format("Insert SanPham (TenSanPham, TTChiTiet, Gia, SoLuong, HinhAnhSanPham) values (N'{0}',N'{1}',{2},{3},N'{4}')",
                name, information, price, quantity, image);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateProduct(int id, string name, string information = null, float price = 0, int quantity = 0, string image = null)
        {
            string query = string.Format("Update SanPham set TenSanPham = N'{0}', TTChiTiet = N'{1}', Gia = {2}, SoLuong = {3}, HinhAnhSanPham = N'{4} where MaSanPham = {5}",
                name, information, price, quantity, image, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }

}
