using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV.DAO;
using QLTV.DTO;
using QLTV.BUS;

namespace QLTV
{
    public partial class frmMuonSach : Form
    {
        pmBUS pmB = new pmBUS();
        nvBUS nvB = new nvBUS();
        bdBUS bdB = new bdBUS();
        sachBUS sachB = new sachBUS();
        string curSach = "";
        string newSach = "";
        public void load()
        {
            grvPhieuMuon.DataSource = pmB.getData();
            grvPhieuMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void enable()
        {
            txtMaPM.Enabled = true;
            cbbSach.Enabled = true;
            txtNgayMuon.Enabled = true;
            cbbTenBD.Enabled = true;

        }
        public void disable()
        {
            //txtMaPM.Enabled = false;
            cbbSach.Enabled = false;
            txtNgayMuon.Enabled = false;
            cbbTenBD.Enabled = false;
        }
        public void clear()
        {
            txtMaPM.Clear();
            txtNgayMuon.Clear();
            cbbSach.Text = "";
            cbbTenBD.Text = "";
        }

        public void loadCBB()
        {
            cbbTenBD.DataSource = bdB.getlist();
            cbbTenBD.ValueMember = "ID";
            cbbTenBD.DisplayMember = "Name";

            cbbSach.DataSource = sachB.getList();
            cbbSach.ValueMember = "ID";
            cbbSach.DisplayMember = "Name";
        }
        public frmMuonSach()
        {
            InitializeComponent();
            txtNV.Text = nvB.getFullNamebyUsername(Form1.username).TenNV;
            load();
            txtNV.Enabled = false;
            disable();
            btnLuu.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grvPhieuMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPM.Text = grvPhieuMuon.CurrentRow.Cells[0].Value.ToString();
            cbbTenBD.Text = grvPhieuMuon.CurrentRow.Cells[2].Value.ToString();
            txtNV.Text = grvPhieuMuon.CurrentRow.Cells[4].Value.ToString();
            cbbSach.Text = grvPhieuMuon.CurrentRow.Cells[6].Value.ToString();
            txtNgayMuon.Text = grvPhieuMuon.CurrentRow.Cells[7].Value.ToString();
        }
        bool isThem = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            clear();
            loadCBB();
            enable();
            isThem = true;
            txtNV.Text = nvB.getFullNamebyUsername(Form1.username).TenNV;
            txtNgayMuon.Text = DateTime.Now.ToString().Trim();
            btnLuu.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enable();
            txtMaPM.Enabled = false;
            cbbTenBD.Enabled = false;
            loadCBB();
            isThem = false;
            txtNV.Text = nvB.getFullNamebyUsername(Form1.username).TenNV;
            cbbTenBD.Text = bdB.searchBD(pmB.getPMbyID(txtMaPM.Text).IdBD).Name;
            cbbSach.Text = sachB.getSachbyID(pmB.getPMbyID(txtMaPM.Text).IdSach).Name;
            curSach = pmB.getPMbyID(txtMaPM.Text).IdSach;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            PhieuMuon pm = new PhieuMuon(txtMaPM.Text, cbbTenBD.SelectedValue.ToString(), cbbSach.SelectedValue.ToString(), nvB.getIDbyUsername(Form1.username).IdNV, txtNgayMuon.Text, "Chưa Trả");
            if (isThem == true)
            {
                pmB.addData(pm);
                sachB.updateTru(cbbSach.SelectedValue.ToString());
            }
            else
            {
                pmB.edit(pm);
                newSach = cbbSach.SelectedValue.ToString();
                sachB.updateCong(curSach);
                sachB.updateTru(newSach);
            }
            load();
            disable();
            clear();
            newSach = "";
            curSach = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                pmB.deleteData(txtMaPM.Text);
            }
            load();
            clear();
        }
    }
}
