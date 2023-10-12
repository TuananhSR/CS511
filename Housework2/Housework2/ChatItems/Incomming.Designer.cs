namespace Housework2.ChatItems
{
    partial class Incomming
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelKhung = new System.Windows.Forms.Panel();
            this.labelTextChat = new System.Windows.Forms.Label();
            this.panelUser2 = new System.Windows.Forms.Panel();
            this.panelKhung.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelKhung
            // 
            this.panelKhung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(207)))), ((int)(((byte)(209)))));
            this.panelKhung.Controls.Add(this.labelTextChat);
            this.panelKhung.Location = new System.Drawing.Point(49, 14);
            this.panelKhung.Name = "panelKhung";
            this.panelKhung.Size = new System.Drawing.Size(312, 51);
            this.panelKhung.TabIndex = 0;
            // 
            // labelTextChat
            // 
            this.labelTextChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextChat.ForeColor = System.Drawing.Color.White;
            this.labelTextChat.Location = new System.Drawing.Point(4, 4);
            this.labelTextChat.Name = "labelTextChat";
            this.labelTextChat.Size = new System.Drawing.Size(305, 36);
            this.labelTextChat.TabIndex = 0;
            this.labelTextChat.Text = "label1";
            // 
            // panelUser2
            // 
            this.panelUser2.BackgroundImage = global::Housework2.Properties.Resources.user_icon_2_;
            this.panelUser2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelUser2.Location = new System.Drawing.Point(3, 14);
            this.panelUser2.Name = "panelUser2";
            this.panelUser2.Size = new System.Drawing.Size(40, 40);
            this.panelUser2.TabIndex = 1;
            // 
            // Incomming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelUser2);
            this.Controls.Add(this.panelKhung);
            this.Name = "Incomming";
            this.Size = new System.Drawing.Size(372, 75);
            this.panelKhung.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelKhung;
        private System.Windows.Forms.Panel panelUser2;
        private System.Windows.Forms.Label labelTextChat;
    }
}
