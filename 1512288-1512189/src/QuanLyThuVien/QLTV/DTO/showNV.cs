using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DTO
{
    public class showNV
    {

        public showNV(string roleId, string roleName, string id, string username, string password, string fullname, string cmnd, string dateofbirth, string diachi, string email, string calamviec)
        {
            this.roleId = roleId;
            this.roleName = roleName;
            this.id = id;
            this.username = username;
            this.password = password;
            this.fullname = fullname;
            this.cmnd = cmnd;
            this.dateofbirth = dateofbirth;
            this.diachi = diachi;
            this.email = email;
            this.calamviec = calamviec;
        }

        public showNV(DataRow row)
        {
            this.roleId = row["RoleID"].ToString();
            this.roleName = row["roleName"].ToString();
            this.id = row["ID"].ToString();
            this.username = row["Username"].ToString();
            this.password = row["Password"].ToString();
            this.fullname = row["FullName"].ToString();
            this.cmnd = row["CMND"].ToString();
            this.dateofbirth = row["DataOfBirth"].ToString();
            this.diachi = row["Address"].ToString();
            this.email = row["Email"].ToString();
            this.calamviec = row["CaLamViec"].ToString();
        }
        private string roleId;
        private string roleName;
        private string id;
        private string username;
        private string password;
        private string fullname;
        private string cmnd;
        private string dateofbirth;
        private string diachi;
        private string email;
        private string calamviec;

        public string RoleId { get => roleId; set => roleId = value; }
        public string RoleName { get => roleName; set => roleName = value; }
        public string Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Dateofbirth { get => dateofbirth; set => dateofbirth = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Email { get => email; set => email = value; }
        public string Calamviec { get => calamviec; set => calamviec = value; }
    }
}
