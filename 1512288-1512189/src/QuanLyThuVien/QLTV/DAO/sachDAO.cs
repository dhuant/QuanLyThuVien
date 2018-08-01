using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV.DTO;

namespace QLTV.DAO
{
    public class sachDAO
    {
        Data data = new Data();
        public DataTable getData()
        {
            return data.getData("select * from QuyenSach");
        }

        public DataTable getData1()
        {
            return data.getData("select * from QuyenSach qs where qs.SoLuong > 0");
        }
        public int add(Sach sach)
        {
            DateTime date = Convert.ToDateTime(sach.Ngaynhap);
            string sql = "insert into QuyenSach values('" + sach.Id + "',N'" + sach.Name + "','" + sach.IdLS + "','" + sach.IdNXB + "','" + sach.NamXB + "',N'" + sach.Tacgia + "','" + sach.Gia + "','" + sach.Soluong + "','" + date.ToString("MM-dd-yyyy") + "')";
            return data.add(sql);
        }

        public int edit(Sach s)
        {
            DateTime date = Convert.ToDateTime(s.Ngaynhap);
            string sql = "update QuyenSach set Name=N'" + s.Name + "',IDLoaiSach='" + s.IdLS + "',IDNXB='" + s.IdNXB + "',NamXB='" + s.NamXB + "',TacGia=N'" + s.Tacgia + "',Gia='" + s.Gia + "',SoLuong='" + s.Soluong + "',NgayNhap='" + date.ToString("MM-dd-yyyy") + "'  where ID='" + s.Id + "'";
            if (data.Edit(sql) > 0)
                return 1;
            return 0;
        }
        public int updateTru(string id)
        {
            string sql = "update QuyenSach set SoLuong -= 1 where ID = '" + id + "'";
            return data.Edit(sql);
        }

        public int updateCong(string id)
        {
            string sql = "update QuyenSach set SoLuong += 1 where ID = '" + id + "'";
            return data.Edit(sql);
        }
        public Sach getSachbyID(string id)
        {
            Sach sach = null;
            string sql = "select * from QuyenSach where ID = '" + id + "'";
            DataTable table = data.getData(sql);
            foreach (DataRow item in table.Rows)
            {
                sach = new Sach(item);
                return sach;
            }
            return sach;
        }
        public bool CheckID(string id)
        {
            string sql = "select ID from QuyenSach where ID ='" + id + "'";
            return data.checkID(sql);
        }
    }
}
