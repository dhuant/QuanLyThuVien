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
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnDes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            nvBUS nvB = new nvBUS();
            if(txtNewPass.Text != txtNewPass1.Text || txtCurPass.Text != Form1.password)
            {
                MessageBox.Show("Fail!");
            }
            else if(nvB.changePassword(Form1.username, txtNewPass.Text) == 1)
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
                this.Close();
            }
        }
    }
}
