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
    public partial class FormNauCom : Form
    {
        public FormNauCom()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelMenuNC.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelMenuNC.Visible)
                panelMenuNC.Visible = false;
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

        private void panelImgHomeNC_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                FormHome sistema = new FormHome();
                sistema.ShowDialog();
                this.Close();
            }
        }

        private void panelImgHomeNC_MouseEnter(object sender, EventArgs e)
        {
            panelImgHomeNC.BackColor = Color.FromArgb(29, 190, 210);
        }

        private void panelImgHomeNC_MouseLeave(object sender, EventArgs e)
        {
            panelImgHomeNC.BackColor = Color.FromArgb(29, 207, 209);
        }

        private void picMenuNC_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenuNC);
        }

        private void buttonDonNhaNC_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                FormDonNha sistema = new FormDonNha();
                sistema.ShowDialog();
                this.Close();
            }
        }

        private void buttonGiatUiNC_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                FormGiatUi sistema = new FormGiatUi();
                sistema.ShowDialog();
                this.Close();
            }
        }



        private void picMenuNC_MouseEnter(object sender, EventArgs e)
        {
            picMenuNC.BackColor = Color.FromArgb(29, 190, 210);
        }

        private void picMenuNC_MouseLeave(object sender, EventArgs e)
        {
            picMenuNC.BackColor = Color.FromArgb(29, 207, 209);
        }

        private void buttonDonNhaNC_MouseEnter(object sender, EventArgs e)
        {
            buttonDonNhaNC.BackColor = Color.FromArgb(29, 207, 209);
            buttonDonNhaNC.ForeColor = Color.White;
        }

        private void buttonDonNhaNC_MouseLeave(object sender, EventArgs e)
        {
            buttonDonNhaNC.BackColor = Color.White;
            buttonDonNhaNC.ForeColor = Color.FromArgb(29, 207, 209);
        }

        private void buttonGiatUiNC_MouseEnter(object sender, EventArgs e)
        {
            buttonGiatUiNC.BackColor = Color.FromArgb(29, 207, 209);
            buttonGiatUiNC.ForeColor = Color.White;
        }

        private void buttonGiatUiNC_MouseLeave(object sender, EventArgs e)
        {
            buttonGiatUiNC.BackColor = Color.White;
            buttonGiatUiNC.ForeColor = Color.FromArgb(29, 207, 209);
        }

        private void panelDatTiecBan_MouseEnter(object sender, EventArgs e)
        {
            panelDatTiecBan.BackColor = Color.FromArgb(110, 185, 166);
        }

        private void panelDatTiecBan_MouseLeave(object sender, EventArgs e)
        {
            panelDatTiecBan.BackColor = Color.Teal;
        }

        private void panelDatTiecBBQ_MouseEnter(object sender, EventArgs e)
        {
            panelDatTiecBBQ.BackColor = Color.FromArgb(110, 185, 166);
        }

        private void panelDatTiecBBQ_MouseLeave(object sender, EventArgs e)
        {
            panelDatTiecBBQ.BackColor = Color.Teal;
        }

        private void panelDatTiecBuffet_MouseEnter(object sender, EventArgs e)
        {
            panelDatTiecBuffet.BackColor = Color.FromArgb(110, 185, 166);
        }

        private void panelDatTiecBuffet_MouseLeave(object sender, EventArgs e)
        {
            panelDatTiecBuffet.BackColor = Color.Teal;
        }
    }
}
