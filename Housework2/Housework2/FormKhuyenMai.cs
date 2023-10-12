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
    public partial class FormKhuyenMai : Form
    {
        public FormKhuyenMai()
        {
            InitializeComponent();
        }

        private void panelImgHomeKM_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                FormHome sistema = new FormHome();
                sistema.ShowDialog();
                this.Close();
            }
        }

        private void panelImgHomeKM_MouseEnter(object sender, EventArgs e)
        {
            panelImgHomeKM.BackColor = Color.FromArgb(29, 190, 210);
        }

        private void panelImgHomeKM_MouseLeave(object sender, EventArgs e)
        {
            panelImgHomeKM.BackColor = Color.FromArgb(29, 207, 209);
        }

        private void panelBlackFriday_MouseEnter(object sender, EventArgs e)
        {
            panelBlackFriday.BackColor = Color.Linen;
        }

        private void panelBlackFriday_MouseLeave(object sender, EventArgs e)
        {
            panelBlackFriday.BackColor = Color.Bisque;
        }

        private void panelCombo_MouseEnter(object sender, EventArgs e)
        {
            panelCombo.BackColor = Color.RosyBrown;
        }

        private void panelCombo_MouseLeave(object sender, EventArgs e)
        {
            panelCombo.BackColor= Color.LightCoral;
        }

        private void panelTVM_MouseEnter(object sender, EventArgs e)
        {
            panelTVM.BackColor = Color.Aquamarine;
        }

        private void panelTVM_MouseLeave(object sender, EventArgs e)
        {
            panelTVM.BackColor= Color.Turquoise;
        }
    }
}
