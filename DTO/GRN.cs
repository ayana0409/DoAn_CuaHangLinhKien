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
        public DateTime Date { get; set; }
        public string Image { get; set; }
        public double Total { get; set; }
        public GRN()
        {
            GRNID = -1;
            StaffID = 0;
            Unit = "Unknown";
            Date = DateTime.Now;
            Image = "Unknown";
            Total = 0;
        }
        public GRN(int gRNID, int staffID, string unit, DateTime date, string image, double total)
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
            this.Date = (DateTime)row["NgayNhapPhieu"];
            if (row["HinhAnhPhieuNhap"] != System.DBNull.Value)
                this.Image = (string)row["HinhAnhPhieuNhap"];
            else
                this.Image = "Unknown";
            this.Total = (double)row["TongGiaTri"];
        }
    }
}