using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class InformationGRNDAL
    {
        private static InformationGRNDAL instance;

        internal static InformationGRNDAL Instance
        {
            get { if (instance == null) instance = new InformationGRNDAL(); return instance; }
            private set => instance = value;
        }
        private InformationGRNDAL() { }




        public bool InsertInformation(int productID, int quantity, float price)
        {
            string query = string.Format("Insert ChiTietPhieuNhap ( MaSanPham, SoLuongNhap, GiaNhap ) values ({0},{1},{2})",
               productID, quantity, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

    }
}
