using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV.DTO;
namespace QLTV.DAO
{
    public class lsDAO
    {
        Data data = new Data();

        public DataTable getData()
        {
            return data.getData("select * from LoaiSach");
        }
        public LoaiSach getLS()
        {
            LoaiSach ls = null;
            string sql = "select * from LoaiSach";
            DataTable table = data.getData(sql);
            foreach (DataRow item in table.Rows)
            {
                ls = new LoaiSach(item);
                return ls;
            }
            return ls;
        }
        public int addData(LoaiSach ls)
        {
            string sql = "insert into LoaiSach values('" + ls.Id + "',N'" + ls.Name + "',N'" + ls.Description + "')";
            return data.add(sql);
        }

        public bool CheckID(string id)
        {
            string sql = "select ID from LoaiSach where ID ='" + id + "'";
            return data.checkID(sql);
        }

        public int edit(LoaiSach ls)
        {
            string sql = "update LoaiSach set Name=N'" + ls.Name + "',Description=N'" + ls.Description + "'  where ID='" + ls.Id + "'";
            if (data.Edit(sql) > 0)
                return 1;
            return 0;
        }

        public LoaiSach getLSbyID(string id)
        {
            LoaiSach ls1 = null;
            string sql = "select * from LoaiSach ls where ls.ID = '" + id + "'";
            DataTable table = data.getData(sql);
            foreach (DataRow item in table.Rows)
            {
                ls1 = new LoaiSach(item);
                return ls1;
            }
            return ls1;
        }

        public LoaiSach getIDbyName(string name)
        {
            LoaiSach ls1 = null;
            string sql = "select * from LoaiSach ls where ls.Name = N'" + name + "'";
            DataTable table = data.getData(sql);
            foreach (DataRow item in table.Rows)
            {
                ls1 = new LoaiSach(item);
                return ls1;
            }
            return ls1;
        }
    }
}
