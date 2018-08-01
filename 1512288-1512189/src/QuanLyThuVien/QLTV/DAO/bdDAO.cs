using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV.DTO;
namespace QLTV.DAO
{
    public class bdDAO
    {
        Data data = new Data();
        public DataTable getData()
        {
            return data.getData("select bd.ID as ID, bd.Name as Ten, bd.Address as Diachi, bd.CMND, bd.DateOfBirth as Ngaysinh, bd.Email, bd.DateCreated as Ngaylap, bd.Creator as IDNguoilap, nv.FullName as Nguoilap from NhanVien nv, BanDoc bd where nv.ID = bd.Creator");
        }
        public DataTable Data()
        {
            return data.getData("select * from BanDoc");
        }
        public int addnewBD(BanDoc bd)
        {
            DateTime ngaysinh = Convert.ToDateTime(bd.Ngaysinh);
            DateTime ngaylap = Convert.ToDateTime(bd.Ngaylap);
            string sql = "insert into BanDoc values('" + bd.Id + "',N'" + bd.Name + "','" + bd.Address + "',N'" + bd.Cmnd + "','" + ngaysinh.ToString("MM-dd-yyyy") + "','" + bd.Email + "',N'" + ngaylap.ToString("MM-dd-yyyy") + "','" + bd.Nguoilap + "')";
            return data.add(sql);
        }

        public int edit(BanDoc bd)
        {
            DateTime ngaysinh = Convert.ToDateTime(bd.Ngaysinh);
            DateTime ngaylap = Convert.ToDateTime(bd.Ngaylap);
            string sql = "update BanDoc set Name=N'" + bd.Name + "',Address='" + bd.Address + "',CMND='" + bd.Cmnd + "',DateOfBirth='" + ngaysinh.ToString("MM-dd-yyyy") + "',Email='" + bd.Email + "',DateCreated='" + ngaylap.ToString("MM-dd-yyyy") + "',Creator='" + bd.Nguoilap + "'  where ID ='" + bd.Id + "'";
            if (data.Edit(sql) > 0)
                return 1;
            return 0;
        }


        public BanDoc searchBD(string id)
        {
            BanDoc sNV = null;
            string sql = "select * from BanDoc nv where nv.ID = '" + id + "'";
            DataTable table = data.getData(sql);
            foreach (DataRow item in table.Rows)
            {
                sNV = new BanDoc(item);
                return sNV;
            }
            return sNV;
        }

        public bool CheckID(string id)
        {
            string sql = "select ID from BanDoc where ID ='" + id + "'";
            return data.checkID(sql);
        }
    }
}
