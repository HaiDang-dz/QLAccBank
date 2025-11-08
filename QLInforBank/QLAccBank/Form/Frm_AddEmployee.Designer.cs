namespace QLAccBank
{
    partial class Frm_AddEmployee
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
            datetime_NgayVao = new DateTimePicker();
            txt_ChucVu = new TextBox();
            txt_SDT = new TextBox();
            txt_Email = new TextBox();
            txt_HoVaTen = new TextBox();
            lbe_NgayVao = new Label();
            lbe_ChucVu = new Label();
            lbe_SDT = new Label();
            lbe_Email = new Label();
            lbe_HoVaTen = new Label();
            lbe_ThongTinNhanVien = new Label();
            pic_Avatar = new PictureBox();
            lbe_TenDangNhap = new Label();
            lbe_MatKhau = new Label();
            txt_TenDangNhap = new TextBox();
            txt_MatKhau = new TextBox();
            btt_Luu = new Button();
            btt_Huy = new Button();
            btt_ChonHinhAnh = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_Avatar).BeginInit();
            SuspendLayout();
            // 
            // datetime_NgayVao
            // 
            datetime_NgayVao.Location = new Point(133, 407);
            datetime_NgayVao.Name = "datetime_NgayVao";
            datetime_NgayVao.Size = new Size(293, 27);
            datetime_NgayVao.TabIndex = 29;
            // 
            // txt_ChucVu
            // 
            txt_ChucVu.Location = new Point(133, 355);
            txt_ChucVu.Name = "txt_ChucVu";
            txt_ChucVu.Size = new Size(293, 27);
            txt_ChucVu.TabIndex = 28;
            // 
            // txt_SDT
            // 
            txt_SDT.Location = new Point(133, 303);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(293, 27);
            txt_SDT.TabIndex = 27;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(133, 245);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(293, 27);
            txt_Email.TabIndex = 26;
            // 
            // txt_HoVaTen
            // 
            txt_HoVaTen.Location = new Point(133, 193);
            txt_HoVaTen.Name = "txt_HoVaTen";
            txt_HoVaTen.Size = new Size(293, 27);
            txt_HoVaTen.TabIndex = 25;
            // 
            // lbe_NgayVao
            // 
            lbe_NgayVao.AutoSize = true;
            lbe_NgayVao.Location = new Point(21, 414);
            lbe_NgayVao.Name = "lbe_NgayVao";
            lbe_NgayVao.Size = new Size(79, 20);
            lbe_NgayVao.TabIndex = 24;
            lbe_NgayVao.Text = "Ngày vào: ";
            // 
            // lbe_ChucVu
            // 
            lbe_ChucVu.AutoSize = true;
            lbe_ChucVu.Location = new Point(21, 355);
            lbe_ChucVu.Name = "lbe_ChucVu";
            lbe_ChucVu.Size = new Size(64, 20);
            lbe_ChucVu.TabIndex = 23;
            lbe_ChucVu.Text = "Chức vụ:";
            // 
            // lbe_SDT
            // 
            lbe_SDT.AutoSize = true;
            lbe_SDT.Location = new Point(21, 303);
            lbe_SDT.Name = "lbe_SDT";
            lbe_SDT.Size = new Size(104, 20);
            lbe_SDT.TabIndex = 22;
            lbe_SDT.Text = "Số điện thoại: ";
            // 
            // lbe_Email
            // 
            lbe_Email.AutoSize = true;
            lbe_Email.Location = new Point(21, 248);
            lbe_Email.Name = "lbe_Email";
            lbe_Email.Size = new Size(53, 20);
            lbe_Email.TabIndex = 21;
            lbe_Email.Text = "Email: ";
            // 
            // lbe_HoVaTen
            // 
            lbe_HoVaTen.AutoSize = true;
            lbe_HoVaTen.Location = new Point(21, 196);
            lbe_HoVaTen.Name = "lbe_HoVaTen";
            lbe_HoVaTen.Size = new Size(82, 20);
            lbe_HoVaTen.TabIndex = 20;
            lbe_HoVaTen.Text = "Họ và Tên: ";
            // 
            // lbe_ThongTinNhanVien
            // 
            lbe_ThongTinNhanVien.AutoSize = true;
            lbe_ThongTinNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbe_ThongTinNhanVien.Location = new Point(213, 9);
            lbe_ThongTinNhanVien.Name = "lbe_ThongTinNhanVien";
            lbe_ThongTinNhanVien.Size = new Size(311, 28);
            lbe_ThongTinNhanVien.TabIndex = 19;
            lbe_ThongTinNhanVien.Text = "ĐĂNG KÝ TÀI KHOẢN NHÂN VIÊN";
            // 
            // pic_Avatar
            // 
            pic_Avatar.Image = Properties.Resources.default_avatar;
            pic_Avatar.Location = new Point(487, 101);
            pic_Avatar.Name = "pic_Avatar";
            pic_Avatar.Size = new Size(201, 229);
            pic_Avatar.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Avatar.TabIndex = 18;
            pic_Avatar.TabStop = false;
            // 
            // lbe_TenDangNhap
            // 
            lbe_TenDangNhap.AutoSize = true;
            lbe_TenDangNhap.Location = new Point(21, 100);
            lbe_TenDangNhap.Name = "lbe_TenDangNhap";
            lbe_TenDangNhap.Size = new Size(114, 20);
            lbe_TenDangNhap.TabIndex = 30;
            lbe_TenDangNhap.Text = "Tên đăng nhập: ";
            // 
            // lbe_MatKhau
            // 
            lbe_MatKhau.AutoSize = true;
            lbe_MatKhau.Location = new Point(21, 145);
            lbe_MatKhau.Name = "lbe_MatKhau";
            lbe_MatKhau.Size = new Size(73, 20);
            lbe_MatKhau.TabIndex = 31;
            lbe_MatKhau.Text = "Mật khẩu:";
            // 
            // txt_TenDangNhap
            // 
            txt_TenDangNhap.Location = new Point(133, 97);
            txt_TenDangNhap.Name = "txt_TenDangNhap";
            txt_TenDangNhap.Size = new Size(293, 27);
            txt_TenDangNhap.TabIndex = 32;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Location = new Point(133, 142);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.Size = new Size(293, 27);
            txt_MatKhau.TabIndex = 33;
            // 
            // btt_Luu
            // 
            btt_Luu.Location = new Point(235, 475);
            btt_Luu.Name = "btt_Luu";
            btt_Luu.Size = new Size(109, 44);
            btt_Luu.TabIndex = 34;
            btt_Luu.Text = "Lưu";
            btt_Luu.UseVisualStyleBackColor = true;
            btt_Luu.Click += btt_Luu_Click;
            // 
            // btt_Huy
            // 
            btt_Huy.Location = new Point(383, 475);
            btt_Huy.Name = "btt_Huy";
            btt_Huy.Size = new Size(109, 44);
            btt_Huy.TabIndex = 35;
            btt_Huy.Text = "Hủy";
            btt_Huy.UseVisualStyleBackColor = true;
            btt_Huy.Click += btt_Huy_Click;
            // 
            // btt_ChonHinhAnh
            // 
            btt_ChonHinhAnh.Location = new Point(487, 374);
            btt_ChonHinhAnh.Name = "btt_ChonHinhAnh";
            btt_ChonHinhAnh.Size = new Size(201, 44);
            btt_ChonHinhAnh.TabIndex = 36;
            btt_ChonHinhAnh.Text = "Chọn hình ảnh";
            btt_ChonHinhAnh.UseVisualStyleBackColor = true;
            btt_ChonHinhAnh.Click += btt_ChonHinhAnh_Click;
            // 
            // Frm_AddEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 548);
            Controls.Add(btt_ChonHinhAnh);
            Controls.Add(btt_Huy);
            Controls.Add(btt_Luu);
            Controls.Add(txt_MatKhau);
            Controls.Add(txt_TenDangNhap);
            Controls.Add(lbe_MatKhau);
            Controls.Add(lbe_TenDangNhap);
            Controls.Add(datetime_NgayVao);
            Controls.Add(txt_ChucVu);
            Controls.Add(txt_SDT);
            Controls.Add(txt_Email);
            Controls.Add(txt_HoVaTen);
            Controls.Add(lbe_NgayVao);
            Controls.Add(lbe_ChucVu);
            Controls.Add(lbe_SDT);
            Controls.Add(lbe_Email);
            Controls.Add(lbe_HoVaTen);
            Controls.Add(lbe_ThongTinNhanVien);
            Controls.Add(pic_Avatar);
            Name = "Frm_AddEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_AddEmployee";
            Load += Frm_AddEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)pic_Avatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker datetime_NgayVao;
        private TextBox txt_ChucVu;
        private TextBox txt_SDT;
        private TextBox txt_Email;
        private TextBox txt_HoVaTen;
        private Label lbe_NgayVao;
        private Label lbe_ChucVu;
        private Label lbe_SDT;
        private Label lbe_Email;
        private Label lbe_HoVaTen;
        private Label lbe_ThongTinNhanVien;
        private PictureBox pic_Avatar;
        private Label lbe_TenDangNhap;
        private Label lbe_MatKhau;
        private TextBox txt_TenDangNhap;
        private TextBox txt_MatKhau;
        private Button btt_Luu;
        private Button btt_Huy;
        private Button btt_ChonHinhAnh;
    }
}