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
    public partial class frmSach : Form
    {
        sachBUS sachB = new sachBUS();
        lsBUS lsB = new lsBUS();
        nxbBUS nxbB = new nxbBUS();
        public void enable()
        {
            txtMaSach.Enabled = true;
            txtTenSach.Enabled = true;
            txtTacGia.Enabled = true;
            txtSL.Enabled = true;
            txtGia.Enabled = true;
            cbbLS.Enabled = true;
            cbbNXB.Enabled = true;
            txtNgayNhap.Enabled = true;
            txtNamXB.Enabled = true;
        }
        public void disable()
        {
           // txtMaSach.Enabled = true;
            txtTenSach.Enabled = false;
            txtTacGia.Enabled = false;
            txtSL.Enabled = false;
            txtGia.Enabled = false;
            cbbLS.Enabled = false;
            cbbNXB.Enabled = false;
            txtNgayNhap.Enabled = false;
            txtNamXB.Enabled = false;

        }

        public void clear()
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtTacGia.Clear();
            txtGia.Clear();
            txtSL.Clear();
            txtNgayNhap.Clear();
            cbbLS.Text = "";
            cbbNXB.Text = "";
            txtNamXB.Clear();
        }
        public void load()
        {
            grvSach.DataSource = sachB.getData();
            grvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public frmSach()
        {
            InitializeComponent();
            load();
            disable();
            btnLuu.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool check = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            clear();
            cbbLS.DataSource = lsB.getLS();
            cbbLS.DisplayMember = "Name";
            cbbNXB.DataSource = nxbB.getNXB();
            cbbNXB.DisplayMember = "Name";
            check = true;
            enable();
            btnLuu.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enable();
            cbbLS.DataSource = lsB.getLS();
            cbbLS.DisplayMember = "Name";
            cbbNXB.DataSource = nxbB.getNXB();
            cbbNXB.DisplayMember = "Name";
            cbbLS.Text = lsB.getLSbyID(sachB.getSachbyID(txtMaSach.Text).IdLS).Name;
            cbbNXB.Text = nxbB.getNXBbyID(sachB.getSachbyID(txtMaSach.Text).IdNXB).Name;
            check = false;
            txtMaSach.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach(txtMaSach.Text, txtTenSach.Text, lsB.getIDbyName(cbbLS.Text).Id, nxbB.getIDbyName(cbbNXB.Text).Id, txtNamXB.Text, txtTacGia.Text, txtGia.Text, txtSL.Text, txtNgayNhap.Text);
            if(check)
            {
                if (sachB.CheckID(txtMaSach.Text))
                {
                    MessageBox.Show(txtMaSach.Text + " đã tồn tại!!!");
                }
                else
                {
                    sachB.add(sach);
                    disable();
                    clear();
                }
            }
            else
            {
                sachB.edit(sach);
                disable();
                clear();
            }
            load();
            txtMaSach.Enabled = true;
        }

        private void grvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSach.Text = grvSach.CurrentRow.Cells[0].Value.ToString();
            txtTenSach.Text = grvSach.CurrentRow.Cells[1].Value.ToString();
            txtTacGia.Text = grvSach.CurrentRow.Cells[5].Value.ToString();
            cbbNXB.Text = nxbB.getNXBbyID(grvSach.CurrentRow.Cells[3].Value.ToString()).Name;
            txtNamXB.Text = grvSach.CurrentRow.Cells[4].Value.ToString();
            cbbLS.Text = lsB.getLSbyID(grvSach.CurrentRow.Cells[2].Value.ToString()).Name;
            txtGia.Text = grvSach.CurrentRow.Cells[6].Value.ToString();
            txtSL.Text = grvSach.CurrentRow.Cells[7].Value.ToString();
            txtNgayNhap.Text = grvSach.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if(txtMaSach.Text == "")
            {
                MessageBox.Show("nhập vào đã chớ!!");
            }
            else if (!sachB.CheckID(txtMaSach.Text))
            {
                MessageBox.Show(txtMaSach.Text + " khong ton tai!!!");
            }
            else
            {
                Sach sach = sachB.getSachbyID(txtMaSach.Text);

                txtMaSach.Text = sach.Id;
                txtTenSach.Text = sach.Name;
                txtTacGia.Text = sach.Tacgia;
                cbbNXB.Text = nxbB.getNXBbyID(sach.IdNXB).Name;
                txtNamXB.Text = sach.NamXB;
                cbbLS.Text = lsB.getLSbyID(sach.IdLS).Name;
                txtGia.Text = sach.Gia;
                txtSL.Text = sach.Soluong;
                txtNgayNhap.Text = sach.Ngaynhap;
            }
        }
    }
}
