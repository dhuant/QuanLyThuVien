using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DTO
{
    public class Sach
    {

        public Sach(string id, string name, string isLS, string idNXB, string namXB, string tacgia, string gia, string sl, string ngaynhap)
        {
            this.Id = id;
            this.Name = name;
            this.IdLS = isLS;
            this.IdNXB = idNXB;
            this.NamXB = namXB;
            this.Tacgia = tacgia;
            this.Gia = gia;
            this.Soluong = sl;
            this.Ngaynhap = ngaynhap;
        }
        public Sach(DataRow row)
        {
            this.Id = row["ID"].ToString();
            this.Name = row["Name"].ToString();
            this.IdLS = row["IDLoaiSach"].ToString();
            this.IdNXB = row["IDNXB"].ToString();
            this.NamXB = row["NamXB"].ToString();
            this.Tacgia = row["TacGia"].ToString();
            this.Gia = row["Gia"].ToString();
            this.Soluong = row["SoLuong"].ToString();
            this.Ngaynhap = row["NgayNhap"].ToString();

        }
        private string id;
        private string name;
        private string idLS;
        private string idNXB;
        private string namXB;
        private string tacgia;
        private string gia;
        private string soluong;
        private string ngaynhap;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string IdLS { get => idLS; set => idLS = value; }
        public string IdNXB { get => idNXB; set => idNXB = value; }
        public string NamXB { get => namXB; set => namXB = value; }
        public string Tacgia { get => tacgia; set => tacgia = value; }
        public string Gia { get => gia; set => gia = value; }
        public string Soluong { get => soluong; set => soluong = value; }
        public string Ngaynhap { get => ngaynhap; set => ngaynhap = value; }
    }
}
