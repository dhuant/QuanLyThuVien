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
    public partial class frmNV : Form
    {
        public void disnable()
        {
            txtUser.Enabled = false;
            txtPass.Enabled = false;
            txtTenNV.Enabled = false;
            txtCMND.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;
            txtCaLamViec.Enabled = false;
            cbbVaiTro.Enabled = false;
        }
        public void clear()
        {
            txtUser.Clear();
            txtPass.Clear();
            txtTenNV.Clear();
            txtCMND.Clear();
            txtNgaySinh.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtCaLamViec.Clear();
            txtMaNV.Clear();
        }
        public void enable()
        {
            txtUser.Enabled = true;
            txtPass.Enabled = true;
            txtTenNV.Enabled = true;
            txtCMND.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtDiaChi.Enabled = true;
            txtEmail.Enabled = true;
            txtCaLamViec.Enabled = true;
            cbbVaiTro.Enabled = true;
        }
        public frmNV()
        {
            InitializeComponent();
            nvBUS role = new nvBUS();
            grvNV.DataSource = role.getData();
            grvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btnLuu.Enabled = false;
            disnable();
            
        }
       
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool check = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            enable();
            clear();
            RoleBUS role = new RoleBUS();
            cbbVaiTro.DataSource = role.Getlist();
            cbbVaiTro.DisplayMember = "roleName";
            check = true;
            btnLuu.Enabled = true;
        }

        private void grvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = grvNV.CurrentRow.Cells[2].Value.ToString();
            txtUser.Text = grvNV.CurrentRow.Cells[3].Value.ToString();
            txtPass.Text = grvNV.CurrentRow.Cells[4].Value.ToString();
            txtTenNV.Text = grvNV.CurrentRow.Cells[5].Value.ToString();
            txtCMND.Text = grvNV.CurrentRow.Cells[6].Value.ToString();
            txtNgaySinh.Text = grvNV.CurrentRow.Cells[7].Value.ToString();
            txtDiaChi.Text = grvNV.CurrentRow.Cells[8].Value.ToString();
            txtEmail.Text = grvNV.CurrentRow.Cells[9].Value.ToString();
            txtCaLamViec.Text = grvNV.CurrentRow.Cells[10].Value.ToString();
            cbbVaiTro.Text = grvNV.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            RoleBUS role = new RoleBUS();
            RoleNV roleID = role.getRoleID(cbbVaiTro.Text);
            // MessageBox.Show(roleID);

            nvBUS nvBus = new nvBUS();
            NhanVien nv = new NhanVien(roleID.RoleId, txtMaNV.Text, txtUser.Text, txtPass.Text, txtTenNV.Text, txtCMND.Text, txtNgaySinh.Text, txtDiaChi.Text, txtEmail.Text, txtCaLamViec.Text);
            if (check == true)
            {
                if (nvBus.CheckUsername(txtUser.Text))
                {
                    MessageBox.Show(txtUser.Text + " đã tồn tại!!!");
                }
                else
                {
                    nvBus.addData(nv);
                    disnable();
                    clear();
                    check = false;
                }
                
            }
            else
            {
                nvBus.edit(nv);
                disnable();
                clear();
                check = false;
            }
            grvNV.DataSource = nvBus.getData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enable();
            RoleBUS role = new RoleBUS();
            cbbVaiTro.DataSource = role.Getlist();
            cbbVaiTro.DisplayMember = "roleName";
            check = false;
            btnLuu.Enabled = true;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            nvBUS nvB = new nvBUS();
            showNV sNV = nvB.displayFrmNV(txtMaNV.Text);
            if(txtMaNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên!");
            }
            else if (sNV == null)
            {
                MessageBox.Show("Mã nhân viên " + txtMaNV.Text + " không tồn tại!");
            }
            else
            {
                txtMaNV.Text = sNV.Id;
                txtUser.Text = sNV.Username;
                txtPass.Text = sNV.Password;
                txtTenNV.Text = sNV.Fullname;
                txtCMND.Text = sNV.Cmnd;
                txtNgaySinh.Text = sNV.Dateofbirth;
                txtDiaChi.Text = sNV.Diachi;
                txtEmail.Text = sNV.Email;
                txtCaLamViec.Text = sNV.Calamviec;
                cbbVaiTro.Text = sNV.RoleName;
            }
        }
        
    }
}
