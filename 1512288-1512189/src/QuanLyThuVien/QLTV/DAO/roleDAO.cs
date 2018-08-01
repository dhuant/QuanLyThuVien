using QLTV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace QLTV.DAO
{
    public class roleDAO
    {
        Data data = new Data();
        
        public DataTable getData()
        {
            return data.getData("select * from RoleNV");
        }
        public RoleNV getRoleNVByID(string id)
        {
            RoleNV role = null;
            string sql = "select * from RoleNV where ID ='" + id + "'";
            DataTable table = data.getData(sql);
            foreach(DataRow item in table.Rows)
            {
                role = new RoleNV(item);
                return role;
            }
            return role;
        }
        public RoleNV getIDbyRoleName(string roleName)
        {
            RoleNV role = null;
            string sql = "select * from RoleNV where roleName = '" + roleName + "'";
            DataTable table = data.getData(sql);
            foreach (DataRow item in table.Rows)
            {
                role = new RoleNV(item);
                return role;
            }
            return role;
        }

        public int addData(RoleNV role)
        {
            string sql = "insert into RoleNV values('" + role.RoleId + "',N'" + role.RoleName + "',N'" + role.Description + "')";
            return data.add(sql);
        }

        public int edit(RoleNV role)
        {
            string sql = "update RoleNV set roleName=N'" + role.RoleName + "',Description=N'" + role.Description + "'  where ID='" + role.RoleId + "'";
            if (data.Edit(sql) > 0)
                return 1;
            return 0;
        }
        public bool CheckID(string id)
        {
            string sql = "select ID from RoleNV where ID ='" + id + "'";
            return data.checkID(sql);
        }

       
       

    }
}
