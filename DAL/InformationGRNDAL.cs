using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InformationGRNDAL
    {
        private static InformationGRNDAL instance;

        public static InformationGRNDAL Instance
        {
            get { if (instance == null) instance = new InformationGRNDAL(); return instance; }
            private set => instance = value;
        }
        private InformationGRNDAL() { }

        public List<InformationGRN> GetListInfoGRNByID(int id)
        {
            List<InformationGRN> list = new();
            string query = "select * from ThongTinPhieuNhap where MaPhieuNhap = " +id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                InformationGRN mnu = new(row);
                list.Add(mnu);
            }

            return list;
        }
        public bool InsertInformation(int GRNID, int productID, int quantity, double price)
        {
            string query = string.Format("Insert ThongTinPhieuNhap (MaPhieuNhap, MaSanPham, SoLuongNhap, GiaNhap ) values ({0}, {1}, {2}, {3})",
               GRNID, productID, quantity, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

    }
}
