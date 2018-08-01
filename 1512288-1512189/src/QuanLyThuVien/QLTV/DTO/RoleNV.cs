using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DTO
{
    public class RoleNV
    {

        public RoleNV(string roleId, string roleName, string description)
        {
            this.RoleId = roleId;
            this.RoleName = roleName;
            this.Description = description;
        }
        public RoleNV(DataRow row)
        {
            this.RoleId = row["ID"].ToString();
            this.RoleName = row["roleName"].ToString();
            this.Description = row["Description"].ToString();
        }
        private string roleId;
        private string roleName;
        private string description;

        public string RoleId { get => roleId; set => roleId = value; }
        public string RoleName { get => roleName; set => roleName = value; }
        public string Description { get => description; set => description = value; }
    }
}
