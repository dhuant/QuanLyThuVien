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
    public partial class frmNXB : Form
    {
        public void enable()
        {
            txtMoTa.Enabled = true;
            txtTenNXB.Enabled = true;
        }
        public void disable()
        {
            txtMoTa.Enabled = false;
            txtTenNXB.Enabled = false;
        }
        public void clear()
        {
            txtTenNXB.Clear();
            txtMaNXB.Clear();
            txtMoTa.Clear();
        }
        public frmNXB()
        {
            InitializeComponent();
            nxbBUS nxbB = new nxbBUS();
            grvNXB.DataSource = nxbB.getData();
            grvNXB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            disable();
            btnLuu.Enabled = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grvNXB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNXB.Text = grvNXB.CurrentRow.Cells[0].Value.ToString();
            txtTenNXB.Text = grvNXB.CurrentRow.Cells[1].Value.ToString();
            txtMoTa.Text = grvNXB.CurrentRow.Cells[2].Value.ToString();
        }
        bool check = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            enable();
            clear();
            check = true;
            btnLuu.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enable();
            check = false;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            disable();
            NXB nxb = new NXB(txtMaNXB.Text,txtTenNXB.Text,txtMoTa.Text);
            nxbBUS nxbB = new nxbBUS();
            if (check)
            {
                if (nxbB.CheckID(txtMaNXB.Text))
                {
                    MessageBox.Show(txtMaNXB.Text + " đã tồn tại!!!");
                }
                else
                {
                    nxbB.addNXB(nxb);
                }
            }
            else
            {
                nxbB.edit(nxb);
            }
            grvNXB.DataSource = nxbB.getData();
        }
    }
}
