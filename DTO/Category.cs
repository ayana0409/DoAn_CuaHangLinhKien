using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public Category (int categoryID, string categoryName)
        {
            this.CategoryID = categoryID;
            this.CategoryName = categoryName;
        }
        public Category(DataRow row)
        {
            this.CategoryID = (int)row["MaDanhMuc"];
            this.CategoryName = (string)row["TenDanhMuc"];
        }

        public override string ToString()
        {
            return this.CategoryName;
        }
    }
}
