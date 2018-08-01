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
    public partial class frmLoaiSach : Form
    {
        public void enable()
        {
            txtMaLS.Enabled = true;
            txtMoTa.Enabled = true;
            txtTenLS.Enabled = true;
        }

        public void disable()
        {
            //txtMaLS.Enabled = false;
            txtMoTa.Enabled = false;
            txtTenLS.Enabled = false;
        }

        public void clear()
        {
            txtMaLS.Clear();
            txtTenLS.Clear();
            txtMoTa.Clear();
        }
        public frmLoaiSach()
        {
            InitializeComponent();
            lsBUS ls = new lsBUS();
            disable();
            grvLoaiSach.DataSource = ls.getData();
            grvLoaiSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btnLuu.Enabled = false;
        }
        bool check = false;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            enable();
            clear();
            check = true;
            btnLuu.Enabled = true;
        }

        private void grvLoaiSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLS.Text = grvLoaiSach.CurrentRow.Cells[0].Value.ToString();
            txtTenLS.Text = grvLoaiSach.CurrentRow.Cells[1].Value.ToString();
            txtMoTa.Text = grvLoaiSach.CurrentRow.Cells[2].Value.ToString();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            enable();
            check = false;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            lsBUS lsB = new lsBUS();
            LoaiSach ls = new LoaiSach(txtMaLS.Text, txtTenLS.Text, txtMoTa.Text);

            if(check == true)
            {
                if (lsB.CheckID(txtMaLS.Text))
                {
                    MessageBox.Show(txtMaLS.Text + " đã tồn tại!!!");
                }
                else
                {
                    if (check == true)
                        lsB.addLS(ls);
                }
            }
            else
            {
                lsB.edit(ls);
            }
            grvLoaiSach.DataSource = lsB.getData();
        }
    }
}
