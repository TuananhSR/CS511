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
    public partial class FormGiatUi : Form
    {
        public FormGiatUi()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelMenuGU.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelMenuGU.Visible)
                panelMenuGU.Visible = false;
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

        private void panelImgGiatUi_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                FormHome sistema = new FormHome();
                sistema.ShowDialog();
                this.Close();
            }
        }

        private void panelImgGiatUi_MouseEnter(object sender, EventArgs e)
        {
            panelImgGiatUi.BackColor = Color.FromArgb(29, 190, 210);
        }

        private void panelImgGiatUi_MouseLeave(object sender, EventArgs e)
        {
            panelImgGiatUi.BackColor = Color.FromArgb(29, 207, 209);
        }

        private void picMenuGU_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenuGU);
        }

        private void picMenuGU_MouseEnter(object sender, EventArgs e)
        {
            picMenuGU.BackColor = Color.FromArgb(29, 190, 210);
        }

        private void picMenuGU_MouseLeave(object sender, EventArgs e)
        {
            picMenuGU.BackColor = Color.FromArgb(29, 207, 209);
        }

        private void buttonDonNhaGU_MouseEnter(object sender, EventArgs e)
        {
            buttonDonNhaGU.BackColor = Color.FromArgb(29, 207, 209);
            buttonDonNhaGU.ForeColor = Color.White;
        }

        private void buttonDonNhaGU_MouseLeave(object sender, EventArgs e)
        {
            buttonDonNhaGU.BackColor = Color.White;
            buttonDonNhaGU.ForeColor = Color.FromArgb(29, 207, 209);
        }

        private void buttonNauComGU_MouseEnter(object sender, EventArgs e)
        {
            buttonNauComGU.BackColor = Color.FromArgb(29, 207, 209);
            buttonNauComGU.ForeColor = Color.White;
        }

        private void buttonNauComGU_MouseLeave(object sender, EventArgs e)
        {
            buttonNauComGU.BackColor = Color.White;
            buttonNauComGU.ForeColor = Color.FromArgb(29, 207, 209);
        }

        private void buttonDonNhaGU_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                FormDonNha sistema = new FormDonNha();
                sistema.ShowDialog();
                this.Close();
            }
        }

        private void buttonNauComGU_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                FormNauCom sistema = new FormNauCom();
                sistema.ShowDialog();
                this.Close();
            }
        }

        private void panelSayNhanh_MouseEnter(object sender, EventArgs e)
        {
            panelSayNhanh.BackColor = Color.FromArgb(110, 185, 166);
        }

        private void panelSayNhanh_MouseLeave(object sender, EventArgs e)
        {
            panelSayNhanh.BackColor = Color.Teal;
        }

        private void panelGiatHap_MouseEnter(object sender, EventArgs e)
        {
            panelGiatHap.BackColor = Color.FromArgb(110, 185, 166);
        }

        private void panelGiatHap_MouseLeave(object sender, EventArgs e)
        {
            panelGiatHap.BackColor = Color.Teal;
        }
    }
}
