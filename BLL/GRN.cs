using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GRN //good received note: phiếu nhập 
    {
        public int GRNID { get; set; }
        public int StaffID { get; set; }
        public string Unit { get; set; }
        public DateOnly Date { get; set; }
        public string Image { get; set; }
        public float Total { get; set; }

        public GRN(int gRNID, int staffID, string unit, DateOnly date, string image, float total)
        {
            this.GRNID = gRNID;
            this.StaffID = staffID;
            this.Unit = unit;
            this.Date = date;
            this.Image = image;
            this.Total = total;

        }
        public GRN(DataRow row) 
        {
            this.StaffID = (int)row["MaNhanVien"];
            this.GRNID = (int)row["MaPhieuNhap"];
            this.Unit = (string)row["DonViNhap"];
            this.Date = (DateOnly)row["NgayNhapPhieu"];
            this.Image = (string)row["HinhAnhPhieuNhap"];
            this.Total = (float)row["TongGiaTri"];
        }
    }
}