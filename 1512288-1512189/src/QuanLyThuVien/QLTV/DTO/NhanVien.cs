using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DTO
{
    public class NhanVien
    {
        public NhanVien(string roleId, string Id, string username, string pass, string ten, string cmnd, string ngaysinh, string diachi, string email, string calamviec)
        {
            this.RoleId = roleId;
            this.IdNV = Id;
            this.Username = username;
            this.Password = pass;
            this.TenNV = ten;
            this.Cmnd = cmnd;
            this.Ngaysinh = ngaysinh;
            this.Diachi = diachi;
            this.Email = email;
            this.Calamviec = calamviec;
        }
        public NhanVien(DataRow row)
        {
            this.IdNV = row["ID"].ToString();
            this.Username = row["Username"].ToString();
            this.Password = row["Password"].ToString();
            this.TenNV = row["FullName"].ToString();
            this.Cmnd = row["CMND"].ToString();
            this.Ngaysinh = row["DataOfBirth"].ToString();
            this.Diachi = row["Address"].ToString();
            this.Email = row["Email"].ToString();
            this.Calamviec = row["CaLamViec"].ToString();
            this.RoleId = row["RoleID"].ToString();
        }
        private string roleId;
        private string idNV;
        private string username;
        private string password;
        private string tenNV;
        private string cmnd;
        private string ngaysinh;
        private string diachi;
        private string email;
        private string calamviec;

        public string RoleId { get => roleId; set => roleId = value; }
        public string IdNV { get => idNV; set => idNV = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Email { get => email; set => email = value; }
        public string Calamviec { get => calamviec; set => calamviec = value; }
    }
}
