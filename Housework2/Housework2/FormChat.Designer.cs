namespace Housework2
{
    partial class FormChat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelHeading = new System.Windows.Forms.Panel();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.panelKhungChat = new System.Windows.Forms.Panel();
            this.panelMessage = new System.Windows.Forms.Panel();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelSend = new System.Windows.Forms.Panel();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.panelBackChat = new System.Windows.Forms.Panel();
            this.panelHeading.SuspendLayout();
            this.panelMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeading
            // 
            this.panelHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(207)))), ((int)(((byte)(209)))));
            this.panelHeading.Controls.Add(this.labelAdmin);
            this.panelHeading.Controls.Add(this.panelAdmin);
            this.panelHeading.Controls.Add(this.panelBackChat);
            this.panelHeading.Location = new System.Drawing.Point(0, 0);
            this.panelHeading.Name = "panelHeading";
            this.panelHeading.Size = new System.Drawing.Size(433, 72);
            this.panelHeading.TabIndex = 0;
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.ForeColor = System.Drawing.Color.White;
            this.labelAdmin.Location = new System.Drawing.Point(128, 17);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(79, 25);
            this.labelAdmin.TabIndex = 2;
            this.labelAdmin.Text = "ADMIN";
            // 
            // panelKhungChat
            // 
            this.panelKhungChat.AutoScroll = true;
            this.panelKhungChat.Location = new System.Drawing.Point(0, 73);
            this.panelKhungChat.Name = "panelKhungChat";
            this.panelKhungChat.Size = new System.Drawing.Size(433, 471);
            this.panelKhungChat.TabIndex = 1;
            // 
            // panelMessage
            // 
            this.panelMessage.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panelMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMessage.Controls.Add(this.panelSend);
            this.panelMessage.Controls.Add(this.txtChat);
            this.panelMessage.Location = new System.Drawing.Point(0, 544);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.Size = new System.Drawing.Size(433, 68);
            this.panelMessage.TabIndex = 2;
            // 
            // txtChat
            // 
            this.txtChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChat.Location = new System.Drawing.Point(12, 8);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(336, 49);
            this.txtChat.TabIndex = 0;
            this.txtChat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtChat_KeyUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelSend
            // 
            this.panelSend.BackgroundImage = global::Housework2.Properties.Resources.IconSend;
            this.panelSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSend.Location = new System.Drawing.Point(370, 8);
            this.panelSend.Name = "panelSend";
            this.panelSend.Size = new System.Drawing.Size(49, 49);
            this.panelSend.TabIndex = 1;
            this.panelSend.Click += new System.EventHandler(this.panelSend_Click);
            this.panelSend.MouseEnter += new System.EventHandler(this.panelSend_MouseEnter);
            this.panelSend.MouseLeave += new System.EventHandler(this.panelSend_MouseLeave);
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackgroundImage = global::Housework2.Properties.Resources.user_icon_2_;
            this.panelAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAdmin.Location = new System.Drawing.Point(62, 7);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(60, 60);
            this.panelAdmin.TabIndex = 1;
            // 
            // panelBackChat
            // 
            this.panelBackChat.BackgroundImage = global::Housework2.Properties.Resources.back;
            this.panelBackChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBackChat.Location = new System.Drawing.Point(12, 17);
            this.panelBackChat.Name = "panelBackChat";
            this.panelBackChat.Size = new System.Drawing.Size(40, 40);
            this.panelBackChat.TabIndex = 0;
            this.panelBackChat.Click += new System.EventHandler(this.panelBackChat_Click);
            this.panelBackChat.MouseEnter += new System.EventHandler(this.panelBackChat_MouseEnter);
            this.panelBackChat.MouseLeave += new System.EventHandler(this.panelBackChat_MouseLeave);
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 611);
            this.Controls.Add(this.panelMessage);
            this.Controls.Add(this.panelKhungChat);
            this.Controls.Add(this.panelHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChat";
            this.Shown += new System.EventHandler(this.FormChat_Shown);
            this.panelHeading.ResumeLayout(false);
            this.panelHeading.PerformLayout();
            this.panelMessage.ResumeLayout(false);
            this.panelMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeading;
        private System.Windows.Forms.Panel panelKhungChat;
        private System.Windows.Forms.Panel panelMessage;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.Panel panelSend;
        private System.Windows.Forms.Panel panelBackChat;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Timer timer1;
    }
}