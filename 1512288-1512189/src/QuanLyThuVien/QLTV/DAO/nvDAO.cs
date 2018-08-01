using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV.DTO;

namespace QLTV.DAO
{
    public class nvDAO
    {
        Data data = new Data();
        public DataTable getData()
        {
            return data.getData("select nv.RoleID, role.roleName,nv.ID,nv.Username,nv.Password, nv.FullName,nv.CMND, nv.DataOfBirth, nv.Address, nv.Email, nv.CaLamViec from RoleNV role, NhanVien nv where role.ID = nv.RoleID");
        }

        public DataTable getList()
        {
            return data.getData("select * from NhanVien");
        }
        public int addnewNV(NhanVien nv)
        {
            DateTime date = Convert.ToDateTime(nv.Ngaysinh);
            string sql = "insert into NhanVien values('" + nv.IdNV + "',N'" + nv.Username + "','" + nv.Password + "',N'" + nv.TenNV + "','" + nv.Cmnd + "','" + date.ToString("MM-dd-yyyy") + "',N'" + nv.Diachi + "','" + nv.Email + "',N'" + nv.Calamviec + "','" + nv.RoleId + "')";
            return data.add(sql);
        }

        public int edit(NhanVien nv)
        {
            DateTime date = Convert.ToDateTime(nv.Ngaysinh);
            string sql = "update NhanVien set RoleID='" + nv.RoleId + "', Username='" + nv.Username + "',Password='" + nv.Password + "',FullName=N'" + nv.TenNV + "',CMND='" + nv.Cmnd + "',DataOfBirth='" + date.ToString("MM-dd-yyyy") + "',Address=N'" + nv.Diachi + "',Email='" + nv.Email + "',CaLamViec=N'" + nv.Calamviec + "'  where ID ='" + nv.IdNV+ "'";
            if (data.Edit(sql) > 0)
                return 1;
            return 0;
        }

        public showNV displayFrmNV(string id)
        {
            showNV sNV = null;
            string sql = "select nv.RoleID, role.roleName,nv.ID,nv.Username,nv.Password, nv.FullName,nv.CMND, nv.DataOfBirth, nv.Address, nv.Email, nv.CaLamViec from RoleNV role, NhanVien nv where role.ID = nv.RoleID and nv.ID = '" + id + "'";
            DataTable table = data.getData(sql);
            foreach (DataRow item in table.Rows)
            {
                sNV = new showNV(item);
                return sNV;
            }
            return sNV;
        }

        public Account login(string username, string password)
        {
            Account acc = null;
            string sql = "select nv.RoleID,nv.Username,nv.Password from RoleNV role, NhanVien nv where role.ID = nv.RoleID and nv.Username = '" + username + "' and nv.Password = '" + password + "'";
            DataTable table = data.getData(sql);
            foreach (DataRow item in table.Rows)
            {
                acc = new Account(item);
                return acc;
            }
            return acc;
        }

        public NhanVien getFullNamebyUsername(string username)
        {
            NhanVien nv1 = null;
            string sql = "select * from NhanVien nv where nv.Username = '" + username + "'";
            DataTable table = data.getData(sql);
            foreach (DataRow item in table.Rows)
            {
                nv1 = new NhanVien(item);
                return nv1;
            }
            return nv1;
        }

        public NhanVien getIDbyUsername(string id)
        {
            NhanVien nv1 = null;
            string sql = "select * from NhanVien nv where nv.Username = '" + id + "'";
            DataTable table = data.getData(sql);
            foreach (DataRow item in table.Rows)
            {
                nv1 = new NhanVien(item);
                return nv1;
            }
            return nv1;
        }

        public NhanVien getFullNamebyID(string id)
        {
            NhanVien nv1 = null;
            string sql = "select * from NhanVien nv where nv.ID = '" + id + "'";
            DataTable table = data.getData(sql);
            foreach (DataRow item in table.Rows)
            {
                nv1 = new NhanVien(item);
                return nv1;
            }
            return nv1;
        }
        public bool CheckUsername(string username)
        {
            string sql = "select Username from NhanVien where Username ='" + username + "'";
            return data.checkID(sql);
        }

        public int changePassword(string username, string newPass)
        {
            string sql = "update NhanVien set Password='" + newPass + "'  where Username ='" + username + "'";
            if (data.Edit(sql) > 0)
                return 1;
            return 0;
        }
    }
}
