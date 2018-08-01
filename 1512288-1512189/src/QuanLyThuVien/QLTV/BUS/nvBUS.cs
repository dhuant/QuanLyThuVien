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
    public class nvBUS
    {
        nvDAO nv = new nvDAO();

        public DataTable getData()
        {
            try
            {
                return nv.getData();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int addData(NhanVien nhanvien)
        {
            return nv.addnewNV(nhanvien);
        }
        public int edit(NhanVien nhanvien)
        {
            if (nv.edit(nhanvien) == 1)
                return 1;
            return 0;
        }
         public showNV displayFrmNV(string id)
        {
            return nv.displayFrmNV(id);
        }

        public Account login(string username, string password)
        {
            return nv.login(username, password);
        }

        public bool CheckUsername(string username)
        {
            return nv.CheckUsername(username);
        }

        public int changePassword(string username, string newPass)
        {
            if (nv.changePassword(username, newPass) == 1)
                return 1;
            return 0;
        }

        public List<NhanVien> getList1()
        {
            List<NhanVien> list = new List<NhanVien>();
            DataTable data = nv.getList();
            foreach (DataRow item in data.Rows)
            {
                NhanVien nv1 = new NhanVien(item);
                list.Add(nv1);
            }
            return list;
        }

        public NhanVien getFullNamebyUsername(string username)
        {
            return nv.getFullNamebyUsername(username);
        }

        public NhanVien getIDbyUsername(string id)
        {
            return nv.getIDbyUsername(id);
        }

        public NhanVien getFullNamebyID(string id)
        {
            return nv.getFullNamebyID(id);
        }
    }
}
