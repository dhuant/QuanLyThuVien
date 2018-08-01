using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV.DTO;
namespace QLTV.DAO
{
    public class nxbDAO
    {
        Data data = new Data();

        public DataTable getData()
        {
            return data.getData("select * from NXB");
        }

        public int addData(NXB ls)
        {
            string sql = "insert into NXB values('" + ls.Id + "',N'" + ls.Name + "',N'" + ls.Description + "')";
            return data.add(sql);
        }

        public bool CheckID(string id)
        {
            string sql = "select ID from NXB where ID ='" + id + "'";
            return data.checkID(sql);
        }

        public int edit(NXB ls)
        {
            string sql = "update NXB set Name=N'" + ls.Name + "',Description=N'" + ls.Description + "'  where ID='" + ls.Id + "'";
            if (data.Edit(sql) > 0)
                return 1;
            return 0;
        }

        public NXB getNXB()
        {
            NXB nxb = null;
            string sql = "select * from NXB";
            DataTable table = data.getData(sql);
            foreach (DataRow item in table.Rows)
            {
                nxb = new NXB(item);
                return nxb;
            }
            return nxb;
        }

        public NXB getNXBbyID(string id)
        {
            NXB nxb = null;
            string sql = "select * from NXB where ID = '" + id + "'";
            DataTable table = data.getData(sql);
            foreach (DataRow item in table.Rows)
            {
                nxb = new NXB(item);
                return nxb;
            }
            return nxb;
        }

        public NXB getIDbyName(string name)
        {
            NXB nxb = null;
            string sql = "select * from NXB where Name = N'" + name + "'";
            DataTable table = data.getData(sql);
            foreach (DataRow item in table.Rows)
            {
                nxb = new NXB(item);
                return nxb;
            }
            return nxb;
        }
    }
}
