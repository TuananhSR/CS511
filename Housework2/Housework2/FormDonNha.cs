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
    public partial class FormDonNha : Form
    {
        public FormDonNha()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelMenuDN.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelMenuDN.Visible)
                panelMenuDN.Visible = false;
        }


        private void showSubMenu(Panel DV)
        {
            if (DV.Visible == false)
            {
                hideSubMenu();
                DV.Visible = true;
            }
            else
                DV.Visible = false;
        }

        private void panelImgHomeDN_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                FormHome sistema = new FormHome();
                sistema.ShowDialog();
                this.Close();
            }
        }

        private void panelImgHomeDN_MouseEnter(object sender, EventArgs e)
        {
            panelImgHomeDN.BackColor = Color.FromArgb(29, 190, 210);
        }

        private void panelImgHomeDN_MouseLeave(object sender, EventArgs e)
        {
            panelImgHomeDN.BackColor = Color.FromArgb(29, 207, 209);
        }

        private void picMenuDN_MouseEnter(object sender, EventArgs e)
        {
            picMenuDN.BackColor = Color.FromArgb(29, 190, 210);
        }

        private void picMenuDN_MouseLeave(object sender, EventArgs e)
        {
            picMenuDN.BackColor = Color.FromArgb(29, 207, 209);
        }

        private void picMenuDN_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenuDN);
        }

        private void buttonNauComDN_MouseEnter(object sender, EventArgs e)
        {
            buttonNauComDN.BackColor = Color.FromArgb(29, 207, 209);
            buttonNauComDN.ForeColor = Color.White;
        }

        private void buttonNauComDN_MouseLeave(object sender, EventArgs e)
        {
            buttonNauComDN.BackColor = Color.White;
            buttonNauComDN.ForeColor = Color.FromArgb(29, 207, 209);
        }

        private void buttonGiatUiDN_MouseEnter(object sender, EventArgs e)
        {
            buttonGiatUiDN.BackColor = Color.FromArgb(29, 207, 209);
            buttonGiatUiDN.ForeColor = Color.White;
        }

        private void buttonGiatUiDN_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                FormGiatUi sistema = new FormGiatUi();
                sistema.ShowDialog();
                this.Close();
            }
        }

        private void buttonNauComDN_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                FormNauCom sistema = new FormNauCom();
                sistema.ShowDialog();
                this.Close();
            }
        }

        private void panelChungCu_MouseEnter(object sender, EventArgs e)
        {
            panelChungCu.BackColor = Color.FromArgb(110, 185, 166);
        }

        private void panelChungCu_MouseLeave(object sender, EventArgs e)
        {
            panelChungCu.BackColor = Color.Teal;
        }

        private void panelNhaDat_MouseEnter(object sender, EventArgs e)
        {
            panelNhaDat.BackColor = Color.FromArgb(110, 185, 166);
        }

        private void panelNhaDat_MouseLeave(object sender, EventArgs e)
        {
            panelNhaDat.BackColor= Color.Teal;
        }

        private void panelBietThu_MouseEnter(object sender, EventArgs e)
        {
            panelBietThu.BackColor = Color.FromArgb(110, 185, 166);
        }

        private void panelBietThu_MouseLeave(object sender, EventArgs e)
        {
            panelBietThu.BackColor = Color.Teal;
        }
    }
}
