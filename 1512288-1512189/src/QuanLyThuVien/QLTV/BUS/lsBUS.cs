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
    public class lsBUS
    {
        lsDAO ls = new lsDAO();

        public DataTable getData()
        {
            try
            {
                return ls.getData();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int addLS(LoaiSach l)
        {
            return ls.addData(l);
        }

        public bool CheckID(string id)
        {
            return ls.CheckID(id);
        }

        public int edit(LoaiSach r)
        {
            if (ls.edit(r) == 1)
                return 1;
            return 0;
        }

        public List<LoaiSach> getLS()
        {
            List<LoaiSach> list = new List<LoaiSach>();
            DataTable data = ls.getData();
            foreach (DataRow item in data.Rows)
            {
                LoaiSach ls1 = new LoaiSach(item);
                list.Add(ls1);
            }
            return list;
        }

        public LoaiSach getLSbyID(string id)
        {
            return ls.getLSbyID(id);
        }

        public LoaiSach getIDbyName(string name)
        {
            return ls.getIDbyName(name);
        }
    }
}
