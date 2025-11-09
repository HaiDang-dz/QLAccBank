namespace QLAccBank
{
    partial class Frm_Members
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
            pic_Avatar = new PictureBox();
            lbe_ThongTinNhanVien = new Label();
            lbe_HoVaTen = new Label();
            lbe_Gmail = new Label();
            lbe_SDT = new Label();
            lbe_ChucVu = new Label();
            lbe_NgayVao = new Label();
            txt_HoVaTen = new TextBox();
            txt_Email = new TextBox();
            txt_SDT = new TextBox();
            txt_ChucVu = new TextBox();
            datetime_NgayVao = new DateTimePicker();
            btt_CapNhat = new Button();
            btt_DoiMatKhau = new Button();
            btt_ThemNguoiDung = new Button();
            btt_DangXuat = new Button();
            btt_Sua = new Button();
            btt_QuanLyKhachHang = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_Avatar).BeginInit();
            SuspendLayout();
            // 
            // pic_Avatar
            // 
            pic_Avatar.Location = new Point(16, 71);
            pic_Avatar.Name = "pic_Avatar";
            pic_Avatar.Size = new Size(201, 246);
            pic_Avatar.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Avatar.TabIndex = 0;
            pic_Avatar.TabStop = false;
            // 
            // lbe_ThongTinNhanVien
            // 
            lbe_ThongTinNhanVien.AutoSize = true;
            lbe_ThongTinNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbe_ThongTinNhanVien.Location = new Point(201, 9);
            lbe_ThongTinNhanVien.Name = "lbe_ThongTinNhanVien";
            lbe_ThongTinNhanVien.Size = new Size(273, 32);
            lbe_ThongTinNhanVien.TabIndex = 1;
            lbe_ThongTinNhanVien.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // lbe_HoVaTen
            // 
            lbe_HoVaTen.AutoSize = true;
            lbe_HoVaTen.Location = new Point(246, 71);
            lbe_HoVaTen.Name = "lbe_HoVaTen";
            lbe_HoVaTen.Size = new Size(99, 25);
            lbe_HoVaTen.TabIndex = 2;
            lbe_HoVaTen.Text = "Họ và Tên: ";
            // 
            // lbe_Gmail
            // 
            lbe_Gmail.AutoSize = true;
            lbe_Gmail.Location = new Point(246, 123);
            lbe_Gmail.Name = "lbe_Gmail";
            lbe_Gmail.Size = new Size(63, 25);
            lbe_Gmail.TabIndex = 3;
            lbe_Gmail.Text = "Email: ";
            // 
            // lbe_SDT
            // 
            lbe_SDT.AutoSize = true;
            lbe_SDT.Location = new Point(246, 178);
            lbe_SDT.Name = "lbe_SDT";
            lbe_SDT.Size = new Size(126, 25);
            lbe_SDT.TabIndex = 4;
            lbe_SDT.Text = "Số điện thoại: ";
            // 
            // lbe_ChucVu
            // 
            lbe_ChucVu.AutoSize = true;
            lbe_ChucVu.Location = new Point(246, 230);
            lbe_ChucVu.Name = "lbe_ChucVu";
            lbe_ChucVu.Size = new Size(80, 25);
            lbe_ChucVu.TabIndex = 5;
            lbe_ChucVu.Text = "Chức vụ:";
            // 
            // lbe_NgayVao
            // 
            lbe_NgayVao.AutoSize = true;
            lbe_NgayVao.Location = new Point(246, 289);
            lbe_NgayVao.Name = "lbe_NgayVao";
            lbe_NgayVao.Size = new Size(97, 25);
            lbe_NgayVao.TabIndex = 6;
            lbe_NgayVao.Text = "Ngày vào: ";
            // 
            // txt_HoVaTen
            // 
            txt_HoVaTen.Location = new Point(358, 68);
            txt_HoVaTen.Name = "txt_HoVaTen";
            txt_HoVaTen.Size = new Size(293, 31);
            txt_HoVaTen.TabIndex = 7;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(358, 120);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(293, 31);
            txt_Email.TabIndex = 8;
            // 
            // txt_SDT
            // 
            txt_SDT.Location = new Point(358, 178);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(293, 31);
            txt_SDT.TabIndex = 9;
            // 
            // txt_ChucVu
            // 
            txt_ChucVu.Location = new Point(358, 230);
            txt_ChucVu.Name = "txt_ChucVu";
            txt_ChucVu.Size = new Size(293, 31);
            txt_ChucVu.TabIndex = 10;
            // 
            // datetime_NgayVao
            // 
            datetime_NgayVao.Location = new Point(358, 282);
            datetime_NgayVao.Name = "datetime_NgayVao";
            datetime_NgayVao.Size = new Size(293, 31);
            datetime_NgayVao.TabIndex = 11;
            // 
            // btt_CapNhat
            // 
            btt_CapNhat.Location = new Point(16, 393);
            btt_CapNhat.Name = "btt_CapNhat";
            btt_CapNhat.Size = new Size(155, 43);
            btt_CapNhat.TabIndex = 12;
            btt_CapNhat.Text = "Cập nhật ";
            btt_CapNhat.UseVisualStyleBackColor = true;
            btt_CapNhat.Click += btt_CapNhat_Click;
            // 
            // btt_DoiMatKhau
            // 
            btt_DoiMatKhau.Location = new Point(246, 393);
            btt_DoiMatKhau.Name = "btt_DoiMatKhau";
            btt_DoiMatKhau.Size = new Size(155, 43);
            btt_DoiMatKhau.TabIndex = 13;
            btt_DoiMatKhau.Text = "Đổi mật khẩu";
            btt_DoiMatKhau.UseVisualStyleBackColor = true;
            btt_DoiMatKhau.Click += btt_DoiMatKhau_Click;
            // 
            // btt_ThemNguoiDung
            // 
            btt_ThemNguoiDung.Location = new Point(457, 393);
            btt_ThemNguoiDung.Name = "btt_ThemNguoiDung";
            btt_ThemNguoiDung.Size = new Size(182, 43);
            btt_ThemNguoiDung.TabIndex = 14;
            btt_ThemNguoiDung.Text = "Thêm người dùng";
            btt_ThemNguoiDung.UseVisualStyleBackColor = true;
            btt_ThemNguoiDung.Click += btt_ThemNguoiDung_Click;
            // 
            // btt_DangXuat
            // 
            btt_DangXuat.Location = new Point(246, 452);
            btt_DangXuat.Name = "btt_DangXuat";
            btt_DangXuat.Size = new Size(155, 43);
            btt_DangXuat.TabIndex = 17;
            btt_DangXuat.Text = "Đăng xuất";
            btt_DangXuat.UseVisualStyleBackColor = true;
            btt_DangXuat.Click += btt_DangXuat_Click;
            // 
            // btt_Sua
            // 
            btt_Sua.Location = new Point(16, 452);
            btt_Sua.Name = "btt_Sua";
            btt_Sua.Size = new Size(155, 43);
            btt_Sua.TabIndex = 15;
            btt_Sua.Text = "Sửa";
            btt_Sua.UseVisualStyleBackColor = true;
            btt_Sua.Click += btt_Sua_Click;
            // 
            // btt_QuanLyKhachHang
            // 
            btt_QuanLyKhachHang.Location = new Point(457, 452);
            btt_QuanLyKhachHang.Name = "btt_QuanLyKhachHang";
            btt_QuanLyKhachHang.Size = new Size(181, 43);
            btt_QuanLyKhachHang.TabIndex = 16;
            btt_QuanLyKhachHang.Text = "Quản lý khách hàng";
            btt_QuanLyKhachHang.UseVisualStyleBackColor = true;
            btt_QuanLyKhachHang.Click += btt_QuanLyKhachHang_Click;
            // 
            // Frm_Members
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 507);
            Controls.Add(btt_QuanLyKhachHang);
            Controls.Add(btt_Sua);
            Controls.Add(btt_DangXuat);
            Controls.Add(btt_ThemNguoiDung);
            Controls.Add(btt_DoiMatKhau);
            Controls.Add(btt_CapNhat);
            Controls.Add(datetime_NgayVao);
            Controls.Add(txt_ChucVu);
            Controls.Add(txt_SDT);
            Controls.Add(txt_Email);
            Controls.Add(txt_HoVaTen);
            Controls.Add(lbe_NgayVao);
            Controls.Add(lbe_ChucVu);
            Controls.Add(lbe_SDT);
            Controls.Add(lbe_Gmail);
            Controls.Add(lbe_HoVaTen);
            Controls.Add(lbe_ThongTinNhanVien);
            Controls.Add(pic_Avatar);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            MaximizeBox = false;
            Name = "Frm_Members";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang Nhân Viên";
            Load += Frm_Members_Load;
            ((System.ComponentModel.ISupportInitialize)pic_Avatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_Avatar;
        private Label lbe_ThongTinNhanVien;
        private Label lbe_HoVaTen;
        private Label lbe_Gmail;
        private Label lbe_SDT;
        private Label lbe_ChucVu;
        private Label lbe_NgayVao;
        private TextBox txt_HoVaTen;
        private TextBox txt_Email;
        private TextBox txt_SDT;
        private TextBox txt_ChucVu;
        private DateTimePicker datetime_NgayVao;
        private Button btt_CapNhat;
        private Button btt_DoiMatKhau;
        private Button btt_ThemNguoiDung;
        private Button btt_DangXuat;
        private Button btt_Sua;
        private Button btt_QuanLyKhachHang;
    }
}