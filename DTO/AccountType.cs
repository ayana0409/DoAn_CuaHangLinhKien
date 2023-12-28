using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountType
    {
        public AccountType(int typeID, string typeName)
        {
            this.TypeID = typeID;
            this.TypeName = typeName;
        }

        public AccountType(DataRow row)
        {
            this.TypeID = (int)row["MaLoaiTK"];
            this.TypeName = (string)row["TenLoaiTK"];
        }

        public int TypeID { get; set; }
        public string TypeName { get; set; }

        public override string ToString()
        {
            return this.TypeName;
        }
    }
}
