using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DTO
{
    public class Account
    {

        public Account(string Id, string Username, string Password)
        {
            this.Id = Id;
            this.Username = Username;
            this.Password = Password;
        }
        public Account(DataRow row)
        {
            this.Id = row["RoleID"].ToString();
            this.Username = row["Username"].ToString();
            this.Password = row["Password"].ToString();
        }
        private string id;
        private string username;
        private string password;

        public string Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
