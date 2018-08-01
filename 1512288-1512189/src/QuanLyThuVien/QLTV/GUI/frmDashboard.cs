using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            if (Form1.isAdmin == false)
            {
                QLNVTool.Enabled = false ;
            }
            
        }

        private void logoutTool_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoiMKtool_Click(object sender, EventArgs e)
        {
            frmChangePassword f = new frmChangePassword();
            f.ShowDialog();
        }

        private void SachTool_Click(object sender, EventArgs e)
        {
            frmSach f = new frmSach();
            f.ShowDialog();
        }

        private void NXBTool_Click(object sender, EventArgs e)
        {
            frmNXB f = new frmNXB();
            f.ShowDialog();
        }

        private void LoaiSachTool_Click(object sender, EventArgs e)
        {
            frmLoaiSach f = new frmLoaiSach();
            f.ShowDialog();
        }

        private void TraSachTool_Click(object sender, EventArgs e)
        {
            frmTraSach f = new frmTraSach();
            f.ShowDialog();
        }

        private void MuonSachTool_Click(object sender, EventArgs e)
        {
            frmMuonSach f = new frmMuonSach();
            f.ShowDialog();
        }

        private void roleTool_Click(object sender, EventArgs e)
        {
            frmRoleNV f = new frmRoleNV();
            if (!Form1.isAdmin)
            {
                f.Enabled = false;
                MessageBox.Show("Bạn chưa được cấp quyền truy cập vào mục này!!!");
            }
            else
            {
                f.ShowDialog();
            }
        }

        private void DSNVTool_Click(object sender, EventArgs e)
        {
            frmNV f = new frmNV();
            if (!Form1.isAdmin)
            {
                f.Enabled = false;
                MessageBox.Show("Bạn chưa được cấp quyền truy cập vào mục này!!!");
            }
            else
            {
                f.ShowDialog();
            }
        }

        private void QLBDTool_Click(object sender, EventArgs e)
        {
            frmBanDoc f = new frmBanDoc();
            f.ShowDialog();
        }

        private void QLNVTool_Click(object sender, EventArgs e)
        {
            
        }

        private void frmDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.isAdmin = true;
        }
    }
}
