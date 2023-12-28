using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Role
    {
        public int RoleID { get; set; }
        public string RoleName   { get; set; }

        public Role( int roleID, string roleName)
        {
            this.RoleID = roleID;   
            this.RoleName = roleName;
        }
        public Role(DataRow row)
        {
            this.RoleID = (int)row["MaChucVu"];
            this.RoleName = (string)row["TenChucVu"];
        }
        public override string ToString()
        {
            return this.RoleName;
        }
    }
}
