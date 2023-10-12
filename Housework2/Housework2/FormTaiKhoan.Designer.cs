namespace Housework2
{
    partial class FormTaiKhoan
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
            this.panelThanhDuoiTK = new System.Windows.Forms.Panel();
            this.panelImgHomeTK = new System.Windows.Forms.Panel();
            this.panelThanhGiuaTK = new System.Windows.Forms.Panel();
            this.buttonDangXuat = new System.Windows.Forms.Button();
            this.groupAvatar = new System.Windows.Forms.GroupBox();
            this.panelAvatar = new System.Windows.Forms.Panel();
            this.labelAvatar = new System.Windows.Forms.Label();
            this.labelHoSo = new System.Windows.Forms.Label();
            this.groupBoxThongTin = new System.Windows.Forms.GroupBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelGioiTinh = new System.Windows.Forms.Label();
            this.labelSDT = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTen = new System.Windows.Forms.Label();
            this.labelTenDangNhap = new System.Windows.Forms.Label();
            this.panelThanhTrenTK = new System.Windows.Forms.Panel();
            this.panelThanhDuoiTK.SuspendLayout();
            this.panelThanhGiuaTK.SuspendLayout();
            this.groupAvatar.SuspendLayout();
            this.groupBoxThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelThanhDuoiTK
            // 
            this.panelThanhDuoiTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(207)))), ((int)(((byte)(209)))));
            this.panelThanhDuoiTK.Controls.Add(this.panelImgHomeTK);
            this.panelThanhDuoiTK.Location = new System.Drawing.Point(1, 606);
            this.panelThanhDuoiTK.Name = "panelThanhDuoiTK";
            this.panelThanhDuoiTK.Size = new System.Drawing.Size(1082, 55);
            this.panelThanhDuoiTK.TabIndex = 0;
            // 
            // panelImgHomeTK
            // 
            this.panelImgHomeTK.BackgroundImage = global::Housework2.Properties.Resources.Home;
            this.panelImgHomeTK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImgHomeTK.Location = new System.Drawing.Point(11, 0);
            this.panelImgHomeTK.Name = "panelImgHomeTK";
            this.panelImgHomeTK.Size = new System.Drawing.Size(60, 52);
            this.panelImgHomeTK.TabIndex = 0;
            this.panelImgHomeTK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelImgHomeTK_MouseClick);
            this.panelImgHomeTK.MouseEnter += new System.EventHandler(this.panelImgHomeTK_MouseEnter);
            this.panelImgHomeTK.MouseLeave += new System.EventHandler(this.panelImgHomeTK_MouseLeave);
            // 
            // panelThanhGiuaTK
            // 
            this.panelThanhGiuaTK.BackColor = System.Drawing.Color.White;
            this.panelThanhGiuaTK.Controls.Add(this.buttonDangXuat);
            this.panelThanhGiuaTK.Controls.Add(this.groupAvatar);
            this.panelThanhGiuaTK.Controls.Add(this.labelHoSo);
            this.panelThanhGiuaTK.Controls.Add(this.groupBoxThongTin);
            this.panelThanhGiuaTK.Location = new System.Drawing.Point(1, 34);
            this.panelThanhGiuaTK.Name = "panelThanhGiuaTK";
            this.panelThanhGiuaTK.Size = new System.Drawing.Size(1082, 571);
            this.panelThanhGiuaTK.TabIndex = 1;
            // 
            // buttonDangXuat
            // 
            this.buttonDangXuat.BackColor = System.Drawing.Color.Turquoise;
            this.buttonDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDangXuat.Location = new System.Drawing.Point(868, 21);
            this.buttonDangXuat.Name = "buttonDangXuat";
            this.buttonDangXuat.Size = new System.Drawing.Size(170, 45);
            this.buttonDangXuat.TabIndex = 3;
            this.buttonDangXuat.Text = "Đăng Xuất";
            this.buttonDangXuat.UseVisualStyleBackColor = false;
            this.buttonDangXuat.Click += new System.EventHandler(this.buttonDangXuat_Click);
            this.buttonDangXuat.MouseEnter += new System.EventHandler(this.buttonDangXuat_MouseEnter);
            this.buttonDangXuat.MouseLeave += new System.EventHandler(this.buttonDangXuat_MouseLeave);
            // 
            // groupAvatar
            // 
            this.groupAvatar.Controls.Add(this.panelAvatar);
            this.groupAvatar.Controls.Add(this.labelAvatar);
            this.groupAvatar.Location = new System.Drawing.Point(694, 121);
            this.groupAvatar.Name = "groupAvatar";
            this.groupAvatar.Size = new System.Drawing.Size(344, 377);
            this.groupAvatar.TabIndex = 2;
            this.groupAvatar.TabStop = false;
            // 
            // panelAvatar
            // 
            this.panelAvatar.BackgroundImage = global::Housework2.Properties.Resources.avatar;
            this.panelAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAvatar.Location = new System.Drawing.Point(41, 37);
            this.panelAvatar.Name = "panelAvatar";
            this.panelAvatar.Size = new System.Drawing.Size(260, 260);
            this.panelAvatar.TabIndex = 1;
            // 
            // labelAvatar
            // 
            this.labelAvatar.AutoSize = true;
            this.labelAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvatar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(207)))), ((int)(((byte)(209)))));
            this.labelAvatar.Location = new System.Drawing.Point(80, 316);
            this.labelAvatar.Name = "labelAvatar";
            this.labelAvatar.Size = new System.Drawing.Size(176, 33);
            this.labelAvatar.TabIndex = 0;
            this.labelAvatar.Text = "Ảnh đại diện";
            // 
            // labelHoSo
            // 
            this.labelHoSo.AutoSize = true;
            this.labelHoSo.BackColor = System.Drawing.Color.White;
            this.labelHoSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoSo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(207)))), ((int)(((byte)(209)))));
            this.labelHoSo.Location = new System.Drawing.Point(80, 56);
            this.labelHoSo.Name = "labelHoSo";
            this.labelHoSo.Size = new System.Drawing.Size(218, 37);
            this.labelHoSo.TabIndex = 1;
            this.labelHoSo.Text = "Hồ sơ của tôi";
            // 
            // groupBoxThongTin
            // 
            this.groupBoxThongTin.Controls.Add(this.radNu);
            this.groupBoxThongTin.Controls.Add(this.radNam);
            this.groupBoxThongTin.Controls.Add(this.txtNgaySinh);
            this.groupBoxThongTin.Controls.Add(this.txtSDT);
            this.groupBoxThongTin.Controls.Add(this.txtEmail);
            this.groupBoxThongTin.Controls.Add(this.txtTen);
            this.groupBoxThongTin.Controls.Add(this.txtTenDangNhap);
            this.groupBoxThongTin.Controls.Add(this.labelDate);
            this.groupBoxThongTin.Controls.Add(this.labelGioiTinh);
            this.groupBoxThongTin.Controls.Add(this.labelSDT);
            this.groupBoxThongTin.Controls.Add(this.labelEmail);
            this.groupBoxThongTin.Controls.Add(this.labelTen);
            this.groupBoxThongTin.Controls.Add(this.labelTenDangNhap);
            this.groupBoxThongTin.Location = new System.Drawing.Point(83, 121);
            this.groupBoxThongTin.Name = "groupBoxThongTin";
            this.groupBoxThongTin.Size = new System.Drawing.Size(575, 377);
            this.groupBoxThongTin.TabIndex = 0;
            this.groupBoxThongTin.TabStop = false;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radNu.Location = new System.Drawing.Point(353, 262);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(47, 24);
            this.radNu.TabIndex = 13;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radNam.Location = new System.Drawing.Point(241, 262);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(60, 24);
            this.radNam.TabIndex = 12;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.BackColor = System.Drawing.Color.White;
            this.txtNgaySinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNgaySinh.Enabled = false;
            this.txtNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaySinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNgaySinh.Location = new System.Drawing.Point(241, 319);
            this.txtNgaySinh.Multiline = true;
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.ReadOnly = true;
            this.txtNgaySinh.Size = new System.Drawing.Size(242, 24);
            this.txtNgaySinh.TabIndex = 11;
            this.txtNgaySinh.Text = "01/01/2023";
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.White;
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSDT.Enabled = false;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSDT.Location = new System.Drawing.Point(241, 208);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(242, 24);
            this.txtSDT.TabIndex = 9;
            this.txtSDT.Text = "0123.456.789";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.Location = new System.Drawing.Point(241, 152);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(242, 24);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Text = "Abc@gmail.com";
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.Color.White;
            this.txtTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTen.Enabled = false;
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTen.Location = new System.Drawing.Point(241, 96);
            this.txtTen.Multiline = true;
            this.txtTen.Name = "txtTen";
            this.txtTen.ReadOnly = true;
            this.txtTen.Size = new System.Drawing.Size(242, 24);
            this.txtTen.TabIndex = 7;
            this.txtTen.Text = "Nguyễn Văn A";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BackColor = System.Drawing.Color.White;
            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenDangNhap.Enabled = false;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenDangNhap.Location = new System.Drawing.Point(241, 40);
            this.txtTenDangNhap.Multiline = true;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.ReadOnly = true;
            this.txtTenDangNhap.Size = new System.Drawing.Size(242, 24);
            this.txtTenDangNhap.TabIndex = 6;
            this.txtTenDangNhap.Text = "abc";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(207)))), ((int)(((byte)(209)))));
            this.labelDate.Location = new System.Drawing.Point(96, 316);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(102, 24);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "Ngày Sinh:";
            // 
            // labelGioiTinh
            // 
            this.labelGioiTinh.AutoSize = true;
            this.labelGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(207)))), ((int)(((byte)(209)))));
            this.labelGioiTinh.Location = new System.Drawing.Point(107, 261);
            this.labelGioiTinh.Name = "labelGioiTinh";
            this.labelGioiTinh.Size = new System.Drawing.Size(91, 24);
            this.labelGioiTinh.TabIndex = 4;
            this.labelGioiTinh.Text = "Giới Tính:";
            // 
            // labelSDT
            // 
            this.labelSDT.AutoSize = true;
            this.labelSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(207)))), ((int)(((byte)(209)))));
            this.labelSDT.Location = new System.Drawing.Point(68, 205);
            this.labelSDT.Name = "labelSDT";
            this.labelSDT.Size = new System.Drawing.Size(130, 24);
            this.labelSDT.TabIndex = 3;
            this.labelSDT.Text = "Số Điện Thoại";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(207)))), ((int)(((byte)(209)))));
            this.labelEmail.Location = new System.Drawing.Point(136, 149);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(62, 24);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email:";
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(207)))), ((int)(((byte)(209)))));
            this.labelTen.Location = new System.Drawing.Point(149, 93);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(49, 24);
            this.labelTen.TabIndex = 1;
            this.labelTen.Text = "Tên:";
            // 
            // labelTenDangNhap
            // 
            this.labelTenDangNhap.AutoSize = true;
            this.labelTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(207)))), ((int)(((byte)(209)))));
            this.labelTenDangNhap.Location = new System.Drawing.Point(43, 37);
            this.labelTenDangNhap.Name = "labelTenDangNhap";
            this.labelTenDangNhap.Size = new System.Drawing.Size(155, 24);
            this.labelTenDangNhap.TabIndex = 0;
            this.labelTenDangNhap.Text = "Tên Đăng Nhập: ";
            // 
            // panelThanhTrenTK
            // 
            this.panelThanhTrenTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(207)))), ((int)(((byte)(209)))));
            this.panelThanhTrenTK.Location = new System.Drawing.Point(1, 0);
            this.panelThanhTrenTK.Name = "panelThanhTrenTK";
            this.panelThanhTrenTK.Size = new System.Drawing.Size(1082, 36);
            this.panelThanhTrenTK.TabIndex = 2;
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.panelThanhTrenTK);
            this.Controls.Add(this.panelThanhGiuaTK);
            this.Controls.Add(this.panelThanhDuoiTK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTaiKhoan";
            this.panelThanhDuoiTK.ResumeLayout(false);
            this.panelThanhGiuaTK.ResumeLayout(false);
            this.panelThanhGiuaTK.PerformLayout();
            this.groupAvatar.ResumeLayout(false);
            this.groupAvatar.PerformLayout();
            this.groupBoxThongTin.ResumeLayout(false);
            this.groupBoxThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThanhDuoiTK;
        private System.Windows.Forms.Panel panelThanhGiuaTK;
        private System.Windows.Forms.Panel panelThanhTrenTK;
        private System.Windows.Forms.Panel panelImgHomeTK;
        private System.Windows.Forms.Label labelHoSo;
        private System.Windows.Forms.GroupBox groupBoxThongTin;
        private System.Windows.Forms.Label labelGioiTinh;
        private System.Windows.Forms.Label labelSDT;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTen;
        private System.Windows.Forms.Label labelTenDangNhap;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.GroupBox groupAvatar;
        private System.Windows.Forms.Label labelAvatar;
        private System.Windows.Forms.Panel panelAvatar;
        private System.Windows.Forms.Button buttonDangXuat;
    }
}