using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV.DAO;
using QLTV.DTO;
namespace QLTV.BUS
{
    public class nxbBUS
    {
        nxbDAO nxb = new nxbDAO();

        public DataTable getData()
        {
            try
            {
                return nxb.getData();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
        public int addNXB(NXB l)
        {
            return nxb.addData(l);
        }

        public bool CheckID(string id)
        {
            return nxb.CheckID(id);
        }

        public int edit(NXB r)
        {
            if (nxb.edit(r) == 1)
                return 1;
            return 0;
        }

        public List<NXB> getNXB()
        {
            List<NXB> list = new List<NXB>();
            DataTable data = nxb.getData();
            foreach (DataRow item in data.Rows)
            {
                NXB nxb1 = new NXB(item);
                list.Add(nxb1);
            }
            return list;
        }

        public NXB getNXBbyID(string id)
        {
            return nxb.getNXBbyID(id);
        }

        public NXB getIDbyName(string name)
        {
            return nxb.getIDbyName(name);
        }
    }
}
