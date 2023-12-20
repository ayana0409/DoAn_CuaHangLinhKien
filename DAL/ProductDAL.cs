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

        public Product GetProduct(int id)
        {
            string query = "select * from SanPham where MaSanPham = " + id + "";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            Product product = new(data.Rows[0]);

            return product;
        }
        public List<Product> SearchProduct(string id = "", string name = "")
        {
            List<Product> list = new();
            if (id != null || name != null)
            {
                string query = String.Format("select * from SanPham where MaSanPham like '%{0}%' AND TenSanPham like N'%{1}%'", id, name);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow row in data.Rows)
                {
                    list.Add(new Product(row));
                }
            }
            return list;
        }

        public bool InsertProduct(string name, int categoryID, int manufacturerID, 
            string information = null, double price = 0, int quantity = 0,  string image = null)
        {
            string query = string.Format("Insert SanPham (TenSanPham, MaDanhMuc, MaHangSX, " +
                "TTChiTiet, Gia, SoLuong, HinhAnhSanPham) values (N'{0}',{1}, {2}, N'{3}',{4},{5},N'{6}')",
                name, categoryID, manufacturerID, information, price, quantity, image);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateProduct(int id, string name, int categoryID, int manufacturerID, string information = null, double price = 0, int quantity = 0, string image = null)
        {
            string query = "proc_UpdateProduct @maSanPham , @maDanhMuc , @maHangSX , @tenSanPham , @tTChiTiet , @soLuong , @gia , @hinhAnhSanPham ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {id,categoryID, manufacturerID, name, information, quantity, price, image});

            return result > 0;
        }
    }

}
