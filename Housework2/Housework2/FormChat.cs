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
    public partial class FormChat : Form
    {
        public FormChat()
        {
            InitializeComponent();
        }



        void Send()
        {
            if (txtChat.Text.Trim().Length == 0) return;
            AddOutGoing(txtChat.Text);
            txtChat.Text = string.Empty;

            timer1.Start();
        }
        void AddInComing(string message)
        {
            var bubble = new ChatItems.Incomming();
            panelKhungChat.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.Message = message;
        }

        void AddOutGoing(string message)
        {
            var bubble = new ChatItems.Outgoing();
            panelKhungChat.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.Message = message;
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            AddInComing("Xin Lỗi, Hiện đang bận.");
        }

        private void panelSend_Click(object sender, EventArgs e)
        {
            Send();
        }

        private void txtChat_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Send();
            }
        }

        private void FormChat_Shown(object sender, EventArgs e)
        {
            AddInComing("Tôi có thể giúp gì ?");
        }

        private void panelBackChat_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                FormHome sistema = new FormHome();
                sistema.ShowDialog();
                this.Close();
            }
        }

        private void panelSend_MouseEnter(object sender, EventArgs e)
        {
            panelSend.BackColor = Color.FromArgb(29, 207, 209);
        }

        private void panelSend_MouseLeave(object sender, EventArgs e)
        {
            panelSend.BackColor = Color.LightGoldenrodYellow;
        }

        private void panelBackChat_MouseEnter(object sender, EventArgs e)
        {
            panelBackChat.BackColor = Color.LightGoldenrodYellow;
        }

        private void panelBackChat_MouseLeave(object sender, EventArgs e)
        {
            panelBackChat.BackColor = Color.FromArgb(29, 207, 209);
        }
    }
}
