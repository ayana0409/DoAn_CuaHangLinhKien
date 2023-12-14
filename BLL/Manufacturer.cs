using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Manufacturer
    {
        public int ManufacturerID { get; set; }
        public string ManufacturerName { get; set; }

        public Manufacturer(int manufacturerID, string manufacturerName)
        {
            this.ManufacturerID = manufacturerID;
            this.ManufacturerName = manufacturerName;
        }
        public Manufacturer(DataRow row)
        {
            this.ManufacturerID = (int)row["MaHangSX"];
            this.ManufacturerName = (string)row["TenHangSX"];
        }
    }
}
