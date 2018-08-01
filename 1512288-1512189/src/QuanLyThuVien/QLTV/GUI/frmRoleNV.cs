using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV.BUS;
using QLTV.DAO;
using QLTV.DTO;


namespace QLTV
{
    public partial class frmRoleNV : Form
    {
        public void clear()
        {
            txtRoleID.Clear();
            txtTenRole.Clear();
            txtMoTa.Clear();
        }
        public void btnEnable()
        {
            btnSua.Enabled = true;
            btnThem.Enabled = true;
        }
        public void btnDisable()
        {
            btnSua.Enabled = false;
            btnThem.Enabled = false;
        }
        public frmRoleNV()
        {
            InitializeComponent();
            RoleBUS role = new RoleBUS();
            grvRole.DataSource = role.getData();
            grvRole.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if(txtTenRole.Text == "" && txtRoleID.Text == "")
            {
                btnDisable();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            RoleBUS role = new RoleBUS();
            RoleNV rolenv = new RoleNV(txtRoleID.Text, txtTenRole.Text, txtMoTa.Text);
            
            if (role.CheckID(txtRoleID.Text) == true)
            {
                MessageBox.Show("Mã Role đã tồn tại!");
            }
            else
            {
                role.addData(rolenv);
                grvRole.DataSource = role.getData();
            }
            clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            RoleBUS role = new RoleBUS();
            RoleNV rolenv = new RoleNV(txtRoleID.Text, txtTenRole.Text, txtMoTa.Text);
            if(role.edit(rolenv) == 1)
            {
                MessageBox.Show("Sua thanh cong!");
                grvRole.DataSource = role.getData();
            }
            clear();
        }

        private void grvRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRoleID.Text = grvRole.CurrentRow.Cells[0].Value.ToString();
            txtTenRole.Text = grvRole.CurrentRow.Cells[1].Value.ToString();
            txtMoTa.Text = grvRole.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            RoleBUS roleBus = new RoleBUS();
            RoleNV roleNV = roleBus.getRole(txtRoleID.Text);
            if(roleNV == null)
            {
                MessageBox.Show(txtRoleID.Text + " không tồn tại!!!");
            }
            else
            {
                txtRoleID.Text = roleNV.RoleId;
                txtTenRole.Text = roleNV.RoleName;
                txtMoTa.Text = roleNV.Description;
            }
        }
        bool checkID = false;
        bool checkName = false;
        private void txtRoleID_TextChanged(object sender, EventArgs e)
        {
            if (txtRoleID.Text != "")
                checkID = true;
            else
                checkID = false;
            if(checkID && checkName)
                btnEnable();
            else
                btnDisable();
        }

        private void txtTenRole_TextChanged(object sender, EventArgs e)
        {
            if (txtTenRole.Text != "")
                checkName = true;
            else
                checkName = false;
            if (checkID && checkName)
                btnEnable();
            else
                btnDisable();
        }
    }
}
