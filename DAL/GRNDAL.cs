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
    public class GRNDAL
    {
        private static GRNDAL? instance;

        public static GRNDAL Instance
        {
            get { if (instance == null) instance = new GRNDAL(); return instance; }
            private set => instance = value;
        }
        private GRNDAL() { }

        public List<GRN> GetListGRN()
        {
            List<GRN> list = new();
            string query = "select * from PhieuNhap";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                GRN mnu = new(row);
                list.Add(mnu);
            }

            return list;
        } 

        public GRN GetGRN(int id)
        {
            string query = "select * from PhieuNhap where MaPhieuNhap = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
                return new GRN(data.Rows[0]);
            else
                return new GRN();
        }

        public GRN GetHighestGRN()
        {
            string query = "select top 1 * from PhieuNhap order by MaPhieuNhap DESC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
                return new GRN(data.Rows[0]);
            else
                return new GRN();
        }

        public List<GRN> SearchGRN(string from, string to,string id = "")
        {
            string query = String.Format("select * from PhieuNhap where MaPhieuNhap like '%{0}%' and NgayNhapPhieu between '{1}' and '{2}'", id, from, to); 
            List<GRN> list = new();

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                GRN mnu = new(row);
                list.Add(mnu);
            }

            return list;
        }

        public bool InsertGRN(int staffID, string unit, string date, double total, string image = "Unknown")
        {
            string query = string.Format("Insert PhieuNhap ( MaNhanVien, DonViNhap, NgayNhapPhieu, HinhAnhPhieuNhap, TongGiaTri ) values ({0},N'{1}',N'{2}', N'{3}', {4})",
                staffID, unit, date, image, total);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateGRN(int GRNID, int staffID, string unit, string date, string image)
        {
            string query = string.Format("Update PhieuNhap set MaNhanVien = {0}, DonViNhap = N'{1}', NgayNhapPhieu = N'{2}', HinhAnhPhieuNhap = N'{3}') where MaPhieuNhap = N'{4}'",
                GRNID, staffID, unit, date, image);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
