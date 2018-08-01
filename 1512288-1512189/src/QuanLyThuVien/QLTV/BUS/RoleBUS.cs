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
    public class RoleBUS
    {
        roleDAO role = new roleDAO();

        public DataTable getData()
        {
            try
            {
                return role.getData();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int addData(RoleNV r)
        {
            return role.addData(r);
        }
        public int edit(RoleNV r)
        {
            if (role.edit(r) == 1)
                return 1;
            return 0;
        }

        public bool CheckID(string id)
        {
            return role.CheckID(id);
        }

        public List<RoleNV> Getlist()
        {
            List<RoleNV> list = new List<RoleNV>();
            DataTable data = role.getData();
            foreach (DataRow item in data.Rows)
            {
                RoleNV nv = new RoleNV(item);
                list.Add(nv);
            }
            return list;
        }

        public RoleNV getRole(string id)
        {
            return role.getRoleNVByID(id);
        }

        public RoleNV getRoleID(string roleName)
        {
            return role.getIDbyRoleName(roleName);
        }

    }
}
