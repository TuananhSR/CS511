namespace Housework2
{
    partial class FormDangNhap
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
            this.labelDangNhap = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.buttonDangNhap = new System.Windows.Forms.Button();
            this.labelQuenMK = new System.Windows.Forms.Label();
            this.checkBoxNhoMK = new System.Windows.Forms.CheckBox();
            this.labelChuaCoTK = new System.Windows.Forms.Label();
            this.labelDangKyTK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDangNhap
            // 
            this.labelDangNhap.AutoSize = true;
            this.labelDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(207)))), ((int)(((byte)(209)))));
            this.labelDangNhap.Location = new System.Drawing.Point(33, 30);
            this.labelDangNhap.Name = "labelDangNhap";
            this.labelDangNhap.Size = new System.Drawing.Size(184, 37);
            this.labelDangNhap.TabIndex = 0;
            this.labelDangNhap.Text = "Đăng nhập";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(207)))), ((int)(((byte)(209)))));
            this.txtTenDangNhap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTenDangNhap.Location = new System.Drawing.Point(37, 106);
            this.txtTenDangNhap.Multiline = true;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(403, 47);
            this.txtTenDangNhap.TabIndex = 1;
            this.txtTenDangNhap.Enter += new System.EventHandler(this.txtTenDangNhap_Enter);
            this.txtTenDangNhap.Leave += new System.EventHandler(this.txtTenDangNhap_Leave);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(207)))), ((int)(((byte)(209)))));
            this.txtMatKhau.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtMatKhau.Location = new System.Drawing.Point(37, 187);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(403, 47);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.Enter += new System.EventHandler(this.txtMatKhau_Enter);
            this.txtMatKhau.Leave += new System.EventHandler(this.txtMatKhau_Leave);
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(207)))), ((int)(((byte)(209)))));
            this.buttonDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDangNhap.ForeColor = System.Drawing.Color.White;
            this.buttonDangNhap.Location = new System.Drawing.Point(37, 273);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(403, 47);
            this.buttonDangNhap.TabIndex = 3;
            this.buttonDangNhap.Text = "Đăng Nhập";
            this.buttonDangNhap.UseVisualStyleBackColor = false;
            this.buttonDangNhap.Click += new System.EventHandler(this.buttonDangNhap_Click);
            this.buttonDangNhap.MouseEnter += new System.EventHandler(this.buttonDangNhap_MouseEnter);
            this.buttonDangNhap.MouseLeave += new System.EventHandler(this.buttonDangNhap_MouseLeave);
            // 
            // labelQuenMK
            // 
            this.labelQuenMK.AutoSize = true;
            this.labelQuenMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuenMK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(207)))), ((int)(((byte)(209)))));
            this.labelQuenMK.Location = new System.Drawing.Point(37, 337);
            this.labelQuenMK.Name = "labelQuenMK";
            this.labelQuenMK.Size = new System.Drawing.Size(109, 18);
            this.labelQuenMK.TabIndex = 4;
            this.labelQuenMK.Text = "Quên mật khẩu";
            this.labelQuenMK.MouseEnter += new System.EventHandler(this.labelQuenMK_MouseEnter);
            this.labelQuenMK.MouseLeave += new System.EventHandler(this.labelQuenMK_MouseLeave);
            // 
            // checkBoxNhoMK
            // 
            this.checkBoxNhoMK.AutoSize = true;
            this.checkBoxNhoMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNhoMK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(207)))), ((int)(((byte)(209)))));
            this.checkBoxNhoMK.Location = new System.Drawing.Point(320, 337);
            this.checkBoxNhoMK.Name = "checkBoxNhoMK";
            this.checkBoxNhoMK.Size = new System.Drawing.Size(120, 22);
            this.checkBoxNhoMK.TabIndex = 5;
            this.checkBoxNhoMK.Text = "Nhớ mật khẩu";
            this.checkBoxNhoMK.UseVisualStyleBackColor = true;
            // 
            // labelChuaCoTK
            // 
            this.labelChuaCoTK.AutoSize = true;
            this.labelChuaCoTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChuaCoTK.Location = new System.Drawing.Point(37, 407);
            this.labelChuaCoTK.Name = "labelChuaCoTK";
            this.labelChuaCoTK.Size = new System.Drawing.Size(167, 18);
            this.labelChuaCoTK.TabIndex = 6;
            this.labelChuaCoTK.Text = "Bạn chưa có tài khoản ?";
            // 
            // labelDangKyTK
            // 
            this.labelDangKyTK.AutoSize = true;
            this.labelDangKyTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDangKyTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(1)))), ((int)(((byte)(27)))));
            this.labelDangKyTK.Location = new System.Drawing.Point(210, 407);
            this.labelDangKyTK.Name = "labelDangKyTK";
            this.labelDangKyTK.Size = new System.Drawing.Size(74, 20);
            this.labelDangKyTK.TabIndex = 7;
            this.labelDangKyTK.Text = "Đăng ký";
            this.labelDangKyTK.Click += new System.EventHandler(this.labelDangKyTK_Click);
            this.labelDangKyTK.MouseEnter += new System.EventHandler(this.labelDangKyTK_MouseEnter);
            this.labelDangKyTK.MouseLeave += new System.EventHandler(this.labelDangKyTK_MouseLeave);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.labelDangKyTK);
            this.Controls.Add(this.labelChuaCoTK);
            this.Controls.Add(this.checkBoxNhoMK);
            this.Controls.Add(this.labelQuenMK);
            this.Controls.Add(this.buttonDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.labelDangNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangNhap";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDangNhap;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button buttonDangNhap;
        private System.Windows.Forms.Label labelQuenMK;
        private System.Windows.Forms.CheckBox checkBoxNhoMK;
        private System.Windows.Forms.Label labelChuaCoTK;
        private System.Windows.Forms.Label labelDangKyTK;
    }
}