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
    public class pmBUS
    {
        pmDAO pm = new pmDAO();

        public DataTable getData()
        {
            try
            {
                return pm.getData();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable getPM()
        {
            try
            {
                return pm.getPM();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int addData(PhieuMuon r)
        {
            return pm.addData(r);
        }
        public int edit(PhieuMuon r)
        {
            if (pm.edit(r) == 1)
                return 1;
            return 0;
        }
        public int deleteData(string r)
        {
            if (pm.deleteData(r) == 1)
                return 1;
            return 0;
        }
        public int update(string id, string nvTra, string ngaytra)
        {
            if (pm.update(id,nvTra,ngaytra) == 1)
                return 1;
            return 0;
        }

        public PhieuMuon getPMbyID(string id)
        {
            return pm.getPMbyID(id);
        }

        public bool CheckID(string id)
        {
            return pm.CheckID(id);
        }
    }
}
