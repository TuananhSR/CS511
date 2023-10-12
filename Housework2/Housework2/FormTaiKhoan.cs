using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Housework2
{
    public partial class FormTaiKhoan : Form
    {
        public FormTaiKhoan()
        {
            InitializeComponent();
        }

        private void panelImgHomeTK_MouseClick(object sender, MouseEventArgs e)
        {
            {
                this.Hide();
                FormHome sistema = new FormHome();
                sistema.ShowDialog();
                this.Close();
            }
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                FormDangNhap sistema = new FormDangNhap();
                sistema.ShowDialog();
                this.Close();
            }
        }

        private void panelImgHomeTK_MouseEnter(object sender, EventArgs e)
        {
            panelImgHomeTK.BackColor = Color.FromArgb(29, 190, 210);
        }

        private void panelImgHomeTK_MouseLeave(object sender, EventArgs e)
        {
            panelImgHomeTK.BackColor = Color.FromArgb(29, 207, 209);
        }

        private void buttonDangXuat_MouseEnter(object sender, EventArgs e)
        {
            buttonDangXuat.BackColor = Color.FromArgb(29, 190, 210);
            buttonDangXuat.ForeColor = Color.White;
        }

        private void buttonDangXuat_MouseLeave(object sender, EventArgs e)
        {
            buttonDangXuat.BackColor = Color.FromArgb(29, 207, 209);
            buttonDangXuat.ForeColor= Color.Black;
        }
    }
}
