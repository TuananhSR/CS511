using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Housework2
{
    public partial class FormDangKi : Form
    {
        public FormDangKi()
        {
            InitializeComponent();
        }

        private void txtHoDK_Enter(object sender, EventArgs e)
        {
            if (txtHoDK.Text == "Họ")
            {
                txtHoDK.Text = "";
                txtHoDK.ForeColor = Color.Black;
            }
        }

        private void txtHoDK_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoDK.Text))
            {
                txtHoDK.Text = "Họ";
                txtHoDK.ForeColor = Color.Gray;
            }
        }

        private void txtTenDK_Enter(object sender, EventArgs e)
        {
            if (txtTenDK.Text == "Tên")
            {
                txtTenDK.Text = "";
                txtTenDK.ForeColor = Color.Black; 
            }
        }

        private void txtTenDK_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDK.Text))
            {
                txtTenDK.Text = "Tên";
                txtTenDK.ForeColor = Color.Gray;
            }
        }

        private void FormDangKi_Load(object sender, EventArgs e)
        {

            txtHoDK.Text = "Họ";
            txtHoDK.ForeColor = Color.Gray;

            txtTenDK.Text = "Tên";
            txtTenDK.ForeColor = Color.Gray;

            txtEmailDK.Text = "Email";
            txtEmailDK.ForeColor = Color.Gray;

            txtSdtDK.Text = "Số điện thoại";
            txtSdtDK.ForeColor = Color.Gray;

            txtNhapMkDK.Text = "Nhập mật khẩu mới";
            txtNhapMkDK.ForeColor = Color.Gray;

            txtNhapLaiMK.Text = "Nhập lại mật khẩu";
            txtNhapLaiMK.ForeColor = Color.Gray;
        }

        private void txtEmailDK_Enter(object sender, EventArgs e)
        {
            if (txtEmailDK.Text == "Email")
            {
                txtEmailDK.Text = "";
                txtEmailDK.ForeColor = Color.Black;
            }
        }

        private void txtEmailDK_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmailDK.Text))
            {
                txtEmailDK.Text = "Email";
                txtEmailDK.ForeColor = Color.Gray;
            }
        }

        private void txtSdtDK_Enter(object sender, EventArgs e)
        {
            if (txtSdtDK.Text == "Số điện thoại")
            {
                txtSdtDK.Text = "";
                txtSdtDK.ForeColor = Color.Black;
            }
        }

        private void txtSdtDK_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSdtDK.Text))
            {
                txtSdtDK.Text = "Số điện thoại";
                txtSdtDK.ForeColor = Color.Gray;
            }
        }

        private void txtNhapMkDK_Enter(object sender, EventArgs e)
        {
            if (txtNhapMkDK.Text == "Nhập mật khẩu mới")
            {
                txtNhapMkDK.PasswordChar = '*';
                txtNhapMkDK.Text = "";
                txtNhapMkDK.ForeColor = Color.Black;
            }
        }

        private void txtNhapMkDK_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNhapMkDK.Text))
            {
                txtNhapMkDK.PasswordChar = '\0';
                txtNhapMkDK.Text = "Nhập mật khẩu mới";
                txtNhapMkDK.ForeColor = Color.Gray;
            }
        }

        private void txtNhapLaiMK_Enter(object sender, EventArgs e)
        {
            if (txtNhapLaiMK.Text == "Nhập lại mật khẩu")
            {
                txtNhapLaiMK.PasswordChar = '*';
                txtNhapLaiMK.Text = "";
                txtNhapLaiMK.ForeColor = Color.Black;
            }
        }

        private void txtNhapLaiMK_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNhapLaiMK.Text))
            {
                txtNhapLaiMK.PasswordChar = '\0';
                txtNhapLaiMK.Text = "Nhập lại mật khẩu";
                txtNhapLaiMK.ForeColor = Color.Gray;
            }
        }

        private void buttonDangKi_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                FormDangNhap sistema = new FormDangNhap();
                sistema.ShowDialog();
                this.Close();
            }
        }

        private void buttonDangKi_MouseEnter(object sender, EventArgs e)
        {
            buttonDangKi.BackColor = Color.FromArgb(29, 190, 210);
        }

        private void buttonDangKi_MouseLeave(object sender, EventArgs e)
        {
            buttonDangKi.BackColor = Color.FromArgb(29, 207, 209);
        }
    }
}
