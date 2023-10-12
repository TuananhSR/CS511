namespace Housework2.ChatItems
{
    partial class Outgoing
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
            this.panelKhung.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelKhung
            // 
            this.panelKhung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelKhung.Controls.Add(this.labelTextChat);
            this.panelKhung.Location = new System.Drawing.Point(70, 3);
            this.panelKhung.Name = "panelKhung";
            this.panelKhung.Size = new System.Drawing.Size(312, 51);
            this.panelKhung.TabIndex = 0;
            // 
            // labelTextChat
            // 
            this.labelTextChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelTextChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextChat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(207)))), ((int)(((byte)(209)))));
            this.labelTextChat.Location = new System.Drawing.Point(4, 4);
            this.labelTextChat.Name = "labelTextChat";
            this.labelTextChat.Size = new System.Drawing.Size(305, 36);
            this.labelTextChat.TabIndex = 0;
            this.labelTextChat.Text = "label1";
            // 
            // Outgoing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelKhung);
            this.Name = "Outgoing";
            this.Size = new System.Drawing.Size(400, 75);
            this.panelKhung.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelKhung;
        private System.Windows.Forms.Label labelTextChat;
    }
}
