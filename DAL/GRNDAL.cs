using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    internal class GRNDAL
    {
        private static GRNDAL instance;

        internal static GRNDAL Instance
        {
            get { if (instance == null) instance = new GRNDAL(); return instance; }
            private set => instance = value;
        }
        private GRNDAL() { }

        public bool InsertGRN(int staffID, string unit, DateOnly date, string image)
        {
            string query = string.Format("Insert PhieuNhap ( MaNhanVien, DonViNhap, NgayNhapPhieu, HinhAnhPhieuNhap ) values ({0},N'{1}',N'{2}, N'{3})",
                staffID, unit, date, image);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateGRN(int GRNID, int staffID, string unit, DateOnly date, string image)
        {
            string query = string.Format("Update PhieuNhap set MaNhanVien = {0}, DonViNhap = N'{1}', NgayNhapPhieu = N'{2'}, HinhAnhPhieuNhap = N'{3'}) where MaPhieuNhap = N'{4}'",
                GRNID, staffID, unit, date, image);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
