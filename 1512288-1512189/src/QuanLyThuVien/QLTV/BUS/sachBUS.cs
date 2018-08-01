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
    class sachBUS
    {
        sachDAO sach = new sachDAO();

        public DataTable getData()
        {
            try
            {
                return sach.getData();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int add(Sach r)
        {
            return sach.add(r);
        }
        public int edit(Sach r)
        {
            if (sach.edit(r) == 1)
                return 1;
            return 0;
        }
        public int updateTru(string id)
        {
            if (sach.updateTru(id) == 1)
                return 1;
            return 0;
        }
        public int updateCong(string id)
        {
            if (sach.updateCong(id) == 1)
                return 1;
            return 0;
        }
        public Sach getSachbyID(string id)
        {
            return sach.getSachbyID(id);
        }

        public bool CheckID(string id)
        {
            return sach.CheckID(id);
        }

        public List<Sach> getList()
        {
            List<Sach> list = new List<Sach>();
            DataTable data = sach.getData1();
            foreach (DataRow item in data.Rows)
            {
                Sach nv = new Sach(item);
                list.Add(nv);
            }
            return list;
        }
    }
}
