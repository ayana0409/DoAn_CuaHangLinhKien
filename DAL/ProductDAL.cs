using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    public class ProductDAL
    {
        private static ProductDAL instance;

        public static ProductDAL Instance
        {
            get { if (instance == null) instance = new ProductDAL(); return instance; }
            private set => instance = value;
        }

        private ProductDAL() { }

        public List<Product> GetListProduct()
        {
            List<Product> list = new();
            string query = "select * from SanPham";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Product pd = new(row);
                list.Add(pd);
            }
            return list;
        }

        public bool InsertProduct(string name, int categoryID, int manufacturerID, string information = null, double price = 0, int quantity = 0,  string image = null)
        {
            string query = string.Format("Insert SanPham (TenSanPham, MaDanhMuc, MaHangSX, TTChiTiet, Gia, SoLuong, HinhAnhSanPham) values (N'{0}',{1}, {2}, N'{3}',{4},{5},N'{6}')",
                name, categoryID, manufacturerID, information, price, quantity, image);
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
