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
    public partial class Form1 : Form
    {
        public static bool isAdmin = true;
        public static string username = "";
        public static string password = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            frmDashboard f = new frmDashboard();
            nvBUS nvB = new nvBUS();
            Account acc = nvB.login(txtUser.Text, txtPass.Text);
            
            if(acc == null)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!!!");
            }
            else
            {
                if (acc.Id == "ad")
                {
                    isAdmin = true;
                   // MessageBox.Show("true");
                }
                else isAdmin = false;
                username = txtUser.Text;
                password = txtPass.Text;
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
