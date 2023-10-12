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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            
        }

        // Bấm vô menu là menu hiện lên các nút khác
        private void customizeDesing()
        {
            panelDV.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelDV.Visible) 
                panelDV.Visible = false;
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

        private void buttonDV_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDV);
        }

        private void buttonDonNha_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            {
                this.Hide();
                FormDonNha sistema = new FormDonNha();
                sistema.ShowDialog();
                this.Close();
            }
        }

        private void buttonNauAn_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            {
                this.Hide();
                FormNauCom sistema = new FormNauCom();
                sistema.ShowDialog();
                this.Close();
            }
        }

        private void buttonGiatUi_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            {
                this.Hide();
                FormGiatUi sistema = new FormGiatUi();
                sistema.ShowDialog();
                this.Close();
            }
        } 

        private void buttonTaiKhoan_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                FormTaiKhoan sistema = new FormTaiKhoan();
                sistema.ShowDialog();
                this.Close();
            }
        }

        private void buttonKhuyenMai_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                FormKhuyenMai sistema = new FormKhuyenMai();
                sistema.ShowDialog();
                this.Close();
            }
        }

        private void buttonHome_MouseEnter(object sender, EventArgs e)
        {
            buttonHome.BackColor = Color.FromArgb(29, 190, 210);
        }

        private void buttonHome_MouseLeave(object sender, EventArgs e)
        {
            buttonHome.BackColor = Color.FromArgb(29, 207, 209);
        }

        private void buttonDV_MouseEnter(object sender, EventArgs e)
        {
            buttonDV.BackColor = Color.FromArgb(29, 207, 209);
            buttonDV.ForeColor = Color.White;
        }

        private void buttonDV_MouseLeave(object sender, EventArgs e)
        {
            buttonDV.BackColor = Color.White;
            buttonDV.ForeColor = Color.FromArgb(29, 207, 209);
        }

        private void buttonKhuyenMai_MouseEnter(object sender, EventArgs e)
        {
            buttonKhuyenMai.BackColor = Color.FromArgb(29, 207, 209);
            buttonKhuyenMai.ForeColor = Color.White;
        }

        private void buttonKhuyenMai_MouseLeave(object sender, EventArgs e)
        {
            buttonKhuyenMai.BackColor = Color.White;
            buttonKhuyenMai.ForeColor = Color.FromArgb(29, 207, 209);
        }

        private void buttonTaiKhoan_MouseEnter(object sender, EventArgs e)
        {
            buttonTaiKhoan.BackColor = Color.FromArgb(29, 207, 209);
            buttonTaiKhoan.ForeColor = Color.White;
        }

        private void buttonTaiKhoan_MouseLeave(object sender, EventArgs e)
        {
            buttonTaiKhoan.BackColor = Color.White;
            buttonTaiKhoan.ForeColor = Color.FromArgb(29, 207, 209);
        }

        private void buttonLienHe_MouseEnter(object sender, EventArgs e)
        {
            buttonLienHe.BackColor = Color.FromArgb(29, 207, 209);
            buttonLienHe.ForeColor = Color.White;
        }

        private void buttonLienHe_MouseLeave(object sender, EventArgs e)
        {
            buttonLienHe.BackColor = Color.White;
            buttonLienHe.ForeColor = Color.FromArgb(29, 207, 209);
        }

        private void buttonDonNha_MouseEnter(object sender, EventArgs e)
        {
            buttonDonNha.BackColor = Color.FromArgb(29, 207, 209);
            buttonDonNha.ForeColor = Color.White;
        }

        private void buttonDonNha_MouseLeave(object sender, EventArgs e)
        {
            buttonDonNha.BackColor = Color.White;
            buttonDonNha.ForeColor = Color.FromArgb(29, 207, 209);
        }

        private void buttonNauAn_MouseEnter(object sender, EventArgs e)
        {
            buttonNauAn.BackColor = Color.FromArgb(29, 207, 209);
            buttonNauAn.ForeColor = Color.White;
        }

        private void buttonNauAn_MouseLeave(object sender, EventArgs e)
        {
            buttonNauAn.BackColor = Color.White;
            buttonNauAn.ForeColor = Color.FromArgb(29, 207, 209);
        }

        private void buttonGiatUi_MouseEnter(object sender, EventArgs e)
        {
            buttonGiatUi.BackColor = Color.FromArgb(29, 207, 209);
            buttonGiatUi.ForeColor = Color.White;
        }

        private void buttonGiatUi_MouseLeave(object sender, EventArgs e)
        {
            buttonGiatUi.BackColor = Color.White;
            buttonGiatUi.ForeColor = Color.FromArgb(29, 207, 209);
        }

        private void buttonHotlineDuoi_MouseEnter(object sender, EventArgs e)
        {
            buttonHotlineDuoi.BackColor = Color.FromArgb(29, 207, 209);
        }

        private void buttonHotlineDuoi_MouseLeave(object sender, EventArgs e)
        {
            buttonHotlineDuoi.BackColor = Color.FromArgb(36, 186, 152);
        }

        private void buttonLienHe_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                FormChat sistema = new FormChat();
                sistema.ShowDialog();
                this.Close();
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Red;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor= Color.Tomato;
        }
    }
}
