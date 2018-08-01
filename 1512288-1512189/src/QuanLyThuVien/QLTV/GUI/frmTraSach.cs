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
    public partial class frmTraSach : Form
    {
        pmBUS pmB = new pmBUS();
        nvBUS nvB = new nvBUS();
        bdBUS bdB = new bdBUS();
        sachBUS sachB = new sachBUS();
        public void disable()
        {
            txtTenBD.Enabled = false;
            txtNM.Enabled = false;
            txtNT.Enabled = false;
            txtNV.Enabled = false;
            txtSach.Enabled = false;
        }
        public void load()
        {
            grvPhieuTra.DataSource = pmB.getPM();
            grvPhieuTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public frmTraSach()
        {
            InitializeComponent();
            load();
            txtNT.Text = DateTime.Now.ToString().Trim();
            txtNV.Text = nvB.getFullNamebyUsername(Form1.username).TenNV;
            disable();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grvPhieuTra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPM.Text = grvPhieuTra.CurrentRow.Cells[0].Value.ToString();
            txtTenBD.Text = bdB.searchBD(pmB.getPMbyID(txtMaPM.Text).IdBD).Name;
            txtNM.Text = grvPhieuTra.CurrentRow.Cells[4].Value.ToString();
            txtSach.Text = sachB.getSachbyID(pmB.getPMbyID(txtMaPM.Text).IdSach).Name;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (pmB.CheckID(txtMaPM.Text))
            {
               txtTenBD.Text = bdB.searchBD(pmB.getPMbyID(txtMaPM.Text).IdBD).Name;
               txtSach.Text = sachB.getSachbyID(pmB.getPMbyID(txtMaPM.Text).IdSach).Name;
                txtNM.Text = pmB.getPMbyID(txtMaPM.Text).Ngaymuon;
                txtNT.Text = pmB.getPMbyID(txtMaPM.Text).Ngaytra;
                NhanVien nv = nvB.getFullNamebyID(pmB.getPMbyID(txtMaPM.Text).IdNVTra);
                if(nv == null)
                    txtNV.Text = "";
                else
                    txtNV.Text = nv.TenNV;
            }
            else
            {
                MessageBox.Show(txtMaPM.Text + "Khong ton tai!!!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            pmB.update(txtMaPM.Text, nvB.getIDbyUsername(Form1.username).IdNV, DateTime.Now.ToString().Trim());
            sachB.updateCong(pmB.getPMbyID(txtMaPM.Text).IdSach);
            load();
        }
    }
}
