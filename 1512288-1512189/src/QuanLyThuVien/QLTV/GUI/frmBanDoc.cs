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
    public partial class frmBanDoc : Form
    {
        public void disable()
        {
            //txtMaSo.Enabled = false;
            txtTenBD.Enabled = false;
            txtDiaChi.Enabled = false;
            txtCMND.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtEmail.Enabled = false;
            txtNgayLap.Enabled = false;
        }
        public void enable()
        {
            //txtMaSo.Enabled = false;
            txtTenBD.Enabled = true;
            txtDiaChi.Enabled = true;
            txtCMND.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtEmail.Enabled = true;
            txtNgayLap.Enabled = true;
        }

        public void clear()
        {
            txtMaSo.Clear();
            txtTenBD.Clear();
            txtDiaChi.Clear();
            txtCMND.Clear();
            txtNgaySinh.Clear();
            txtEmail.Clear();
            txtNgayLap.Clear();
        }
        public frmBanDoc()
        {
            InitializeComponent();
            txtNguoiLap.Enabled = false;
            bdBUS bd = new bdBUS();
            grvBanDoc.DataSource = bd.getData();
            grvBanDoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            disable();
            btnLuu.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grvBanDoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSo.Text = grvBanDoc.CurrentRow.Cells[0].Value.ToString();
            txtTenBD.Text = grvBanDoc.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = grvBanDoc.CurrentRow.Cells[2].Value.ToString();
            txtCMND.Text = grvBanDoc.CurrentRow.Cells[3].Value.ToString();
            txtNgaySinh.Text = grvBanDoc.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = grvBanDoc.CurrentRow.Cells[5].Value.ToString();
            txtNgayLap.Text = grvBanDoc.CurrentRow.Cells[6].Value.ToString();
            txtNguoiLap.Text = grvBanDoc.CurrentRow.Cells[8].Value.ToString();
        }
        bool check = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            enable();
            clear();
            nvBUS nvB = new nvBUS();
            txtNguoiLap.Text = (nvB.getFullNamebyUsername(Form1.username).TenNV);
            check = true;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            nvBUS nvB = new nvBUS();
            bdBUS bdB = new bdBUS();
            string IdNguoiLap = nvB.getIDbyUsername(Form1.username).IdNV;

            BanDoc bd = new BanDoc(txtMaSo.Text, txtTenBD.Text, txtDiaChi.Text, txtCMND.Text, txtNgaySinh.Text, txtEmail.Text, txtNgayLap.Text, IdNguoiLap);
            if (check == true)
            {
                bdB.addBD(bd);
            }
            else
            {
                bdB.editBD(bd);
                disable();
            }
            grvBanDoc.DataSource = bdB.getData();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enable();
            check = false;
            nvBUS nvB = new nvBUS();
            txtNguoiLap.Text = nvB.getFullNamebyUsername(Form1.username).TenNV;
            btnLuu.Enabled = true;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            bdBUS bdB = new bdBUS();
            nvBUS nvB = new nvBUS();
            BanDoc bd = bdB.searchBD(txtMaSo.Text);
            txtMaSo.Text = bd.Id;
            txtTenBD.Text = bd.Name;
            txtDiaChi.Text = bd.Address;
            txtCMND.Text = bd.Cmnd;
            txtNgaySinh.Text = bd.Ngaysinh;
            txtEmail.Text = bd.Email;
            txtNgayLap.Text = bd.Ngaylap;
            txtNguoiLap.Text = nvB.getFullNamebyID(bd.Nguoilap).TenNV;
        }
    }
}
