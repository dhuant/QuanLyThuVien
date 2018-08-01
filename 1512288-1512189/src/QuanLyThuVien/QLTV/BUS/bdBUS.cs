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
    public class bdBUS
    {
        bdDAO bd = new bdDAO();

        public DataTable getData()
        {
            try
            {
                return bd.getData();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int addBD(BanDoc bandoc)
        {
            return bd.addnewBD(bandoc);
        }

        public int editBD(BanDoc bandoc)
        {
            return bd.edit(bandoc);
        }

        public BanDoc searchBD(string id)
        {
            return bd.searchBD(id);
        }

        public bool CheckID(string id)
        {
            return bd.CheckID(id);
        }

        public List<BanDoc> getlist()
        {
            List<BanDoc> list = new List<BanDoc>();
            DataTable data = bd.Data();
            foreach (DataRow item in data.Rows)
            {
                BanDoc nv = new BanDoc(item);
                list.Add(nv);
            }
            return list;
        }

    }
}
