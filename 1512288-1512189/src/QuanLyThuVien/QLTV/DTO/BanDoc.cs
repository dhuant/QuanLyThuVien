using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DTO
{
    public class BanDoc
    {

        public BanDoc (string id, string name, string address, string cmnd, string ngaysinh, string email, string ngaylap, string nguoilap)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Cmnd = cmnd;
            this.Ngaysinh = ngaysinh;
            this.Email = email;
            this.Ngaylap = ngaylap;
            this.Nguoilap = nguoilap;
        }
        public BanDoc(DataRow row)
        {
            this.Id = row["ID"].ToString();
            this.Name = row["Name"].ToString();
            this.Address = row["Address"].ToString();
            this.Cmnd = row["CMND"].ToString();
            this.Ngaysinh = row["DateOfBirth"].ToString();
            this.Email = row["Email"].ToString();
            this.Ngaylap = row["DateCreated"].ToString();
            this.Nguoilap = row["Creator"].ToString();
        }
        private string id;
        private string name;
        private string address;
        private string cmnd;
        private string ngaysinh;
        private string email;
        private string ngaylap;
        private string nguoilap;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Email { get => email; set => email = value; }
        public string Ngaylap { get => ngaylap; set => ngaylap = value; }
        public string Nguoilap { get => nguoilap; set => nguoilap = value; }
    }
}
