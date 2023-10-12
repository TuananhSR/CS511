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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void txtTenDangNhap_Enter(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "Email/Số điện thoại/Tên đăng nhập")
            {
                txtTenDangNhap.Text = "";
                txtTenDangNhap.ForeColor = Color.Black;
            }    
        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                txtTenDangNhap.Text = "Email/Số điện thoại/Tên đăng nhập";
                txtTenDangNhap.ForeColor = Color.Gray;
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

            txtMatKhau.Text = "Mật khẩu";
            txtMatKhau.ForeColor = Color.Gray;

            txtTenDangNhap.Text = "Email/Số điện thoại/Tên đăng nhập";
            txtTenDangNhap.ForeColor = Color.Gray;
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Mật khẩu")
            {
                txtMatKhau.PasswordChar = '*';
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black;
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                txtMatKhau.PasswordChar = '\0';
                txtMatKhau.Text = "Mật khẩu";
                txtMatKhau.ForeColor = Color.Gray;
            }
        }


        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                FormHome sistema = new FormHome();
                sistema.ShowDialog();
                this.Close();
            }
        }

        private void labelDangKyTK_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                FormDangKi sistema = new FormDangKi();
                sistema.ShowDialog();
                this.Close();
            }
        }

        private void buttonDangNhap_MouseEnter(object sender, EventArgs e)
        {
            buttonDangNhap.BackColor = Color.FromArgb(29, 190, 210);
        }

        private void buttonDangNhap_MouseLeave(object sender, EventArgs e)
        {
            buttonDangNhap.BackColor = Color.FromArgb(29, 207, 209);
        }

        private void labelDangKyTK_MouseEnter(object sender, EventArgs e)
        {
            labelDangKyTK.ForeColor = Color.FromArgb(29, 207, 209);
        }

        private void labelDangKyTK_MouseLeave(object sender, EventArgs e)
        {
            labelDangKyTK.ForeColor = Color.FromArgb(208, 1, 27);
        }

        private void labelQuenMK_MouseEnter(object sender, EventArgs e)
        {
            labelQuenMK.ForeColor = Color.Gray;
        }

        private void labelQuenMK_MouseLeave(object sender, EventArgs e)
        {
            labelQuenMK.ForeColor = Color.FromArgb(29, 207, 209);
        }
    }
}
