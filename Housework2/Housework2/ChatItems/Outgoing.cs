﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Housework2.ChatItems
{
    public partial class Outgoing : UserControl
    {
        public Outgoing()
        {
            InitializeComponent();
        }

        public string Message
        {
            get
            {

                return labelTextChat.Text;
            }

            set
            {
                labelTextChat.Text = value;
            }
        }


        void AdjustHeight()
        {
            labelTextChat.Height = Utils.GetTextHeight(labelTextChat) + 10;

            panelKhung.Height = labelTextChat.Top + panelKhung.Top + labelTextChat.Height;
            this.Height = panelKhung.Bottom + 10;
        }

        private void Incomming_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
        }
    }
}
