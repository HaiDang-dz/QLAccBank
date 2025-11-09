namespace QLAccBank
{
    partial class Frm_Add_Employee
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
            datetime_NgayVao.Location = new Point(166, 509);
            datetime_NgayVao.Margin = new Padding(4);
            datetime_NgayVao.Name = "datetime_NgayVao";
            datetime_NgayVao.Size = new Size(365, 31);
            datetime_NgayVao.TabIndex = 7;
            // 
            // txt_ChucVu
            // 
            txt_ChucVu.Location = new Point(166, 444);
            txt_ChucVu.Margin = new Padding(4);
            txt_ChucVu.Name = "txt_ChucVu";
            txt_ChucVu.Size = new Size(365, 31);
            txt_ChucVu.TabIndex = 6;
            // 
            // txt_SDT
            // 
            txt_SDT.Location = new Point(166, 379);
            txt_SDT.Margin = new Padding(4);
            txt_SDT.MaxLength = 10;
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(365, 31);
            txt_SDT.TabIndex = 5;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(166, 306);
            txt_Email.Margin = new Padding(4);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(365, 31);
            txt_Email.TabIndex = 4;
            // 
            // txt_HoVaTen
            // 
            txt_HoVaTen.Location = new Point(166, 241);
            txt_HoVaTen.Margin = new Padding(4);
            txt_HoVaTen.Name = "txt_HoVaTen";
            txt_HoVaTen.Size = new Size(365, 31);
            txt_HoVaTen.TabIndex = 3;
            // 
            // lbe_NgayVao
            // 
            lbe_NgayVao.AutoSize = true;
            lbe_NgayVao.Location = new Point(26, 518);
            lbe_NgayVao.Margin = new Padding(4, 0, 4, 0);
            lbe_NgayVao.Name = "lbe_NgayVao";
            lbe_NgayVao.Size = new Size(97, 25);
            lbe_NgayVao.TabIndex = 24;
            lbe_NgayVao.Text = "Ngày vào: ";
            // 
            // lbe_ChucVu
            // 
            lbe_ChucVu.AutoSize = true;
            lbe_ChucVu.Location = new Point(26, 444);
            lbe_ChucVu.Margin = new Padding(4, 0, 4, 0);
            lbe_ChucVu.Name = "lbe_ChucVu";
            lbe_ChucVu.Size = new Size(80, 25);
            lbe_ChucVu.TabIndex = 23;
            lbe_ChucVu.Text = "Chức vụ:";
            // 
            // lbe_SDT
            // 
            lbe_SDT.AutoSize = true;
            lbe_SDT.Location = new Point(26, 379);
            lbe_SDT.Margin = new Padding(4, 0, 4, 0);
            lbe_SDT.Name = "lbe_SDT";
            lbe_SDT.Size = new Size(126, 25);
            lbe_SDT.TabIndex = 22;
            lbe_SDT.Text = "Số điện thoại: ";
            // 
            // lbe_Email
            // 
            lbe_Email.AutoSize = true;
            lbe_Email.Location = new Point(26, 310);
            lbe_Email.Margin = new Padding(4, 0, 4, 0);
            lbe_Email.Name = "lbe_Email";
            lbe_Email.Size = new Size(63, 25);
            lbe_Email.TabIndex = 21;
            lbe_Email.Text = "Email: ";
            // 
            // lbe_HoVaTen
            // 
            lbe_HoVaTen.AutoSize = true;
            lbe_HoVaTen.Location = new Point(26, 245);
            lbe_HoVaTen.Margin = new Padding(4, 0, 4, 0);
            lbe_HoVaTen.Name = "lbe_HoVaTen";
            lbe_HoVaTen.Size = new Size(99, 25);
            lbe_HoVaTen.TabIndex = 20;
            lbe_HoVaTen.Text = "Họ và Tên: ";
            // 
            // lbe_ThongTinNhanVien
            // 
            lbe_ThongTinNhanVien.AutoSize = true;
            lbe_ThongTinNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbe_ThongTinNhanVien.ForeColor = Color.LightSeaGreen;
            lbe_ThongTinNhanVien.Location = new Point(266, 35);
            lbe_ThongTinNhanVien.Margin = new Padding(4, 0, 4, 0);
            lbe_ThongTinNhanVien.Name = "lbe_ThongTinNhanVien";
            lbe_ThongTinNhanVien.Size = new Size(406, 32);
            lbe_ThongTinNhanVien.TabIndex = 19;
            lbe_ThongTinNhanVien.Text = "ĐĂNG KÝ TÀI KHOẢN NHÂN VIÊN";
            // 
            // pic_Avatar
            // 
            pic_Avatar.Image = Properties.Resources.default_avatar;
            pic_Avatar.Location = new Point(609, 126);
            pic_Avatar.Margin = new Padding(4);
            pic_Avatar.Name = "pic_Avatar";
            pic_Avatar.Size = new Size(251, 286);
            pic_Avatar.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Avatar.TabIndex = 18;
            pic_Avatar.TabStop = false;
            // 
            // lbe_TenDangNhap
            // 
            lbe_TenDangNhap.AutoSize = true;
            lbe_TenDangNhap.Location = new Point(26, 125);
            lbe_TenDangNhap.Margin = new Padding(4, 0, 4, 0);
            lbe_TenDangNhap.Name = "lbe_TenDangNhap";
            lbe_TenDangNhap.Size = new Size(138, 25);
            lbe_TenDangNhap.TabIndex = 30;
            lbe_TenDangNhap.Text = "Tên đăng nhập: ";
            // 
            // lbe_MatKhau
            // 
            lbe_MatKhau.AutoSize = true;
            lbe_MatKhau.Location = new Point(26, 181);
            lbe_MatKhau.Margin = new Padding(4, 0, 4, 0);
            lbe_MatKhau.Name = "lbe_MatKhau";
            lbe_MatKhau.Size = new Size(90, 25);
            lbe_MatKhau.TabIndex = 31;
            lbe_MatKhau.Text = "Mật khẩu:";
            // 
            // txt_TenDangNhap
            // 
            txt_TenDangNhap.Location = new Point(166, 121);
            txt_TenDangNhap.Margin = new Padding(4);
            txt_TenDangNhap.Name = "txt_TenDangNhap";
            txt_TenDangNhap.Size = new Size(365, 31);
            txt_TenDangNhap.TabIndex = 1;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Location = new Point(166, 178);
            txt_MatKhau.Margin = new Padding(4);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.Size = new Size(365, 31);
            txt_MatKhau.TabIndex = 2;
            // 
            // btt_Luu
            // 
            btt_Luu.BackColor = Color.LightSeaGreen;
            btt_Luu.ForeColor = Color.White;
            btt_Luu.Location = new Point(294, 594);
            btt_Luu.Margin = new Padding(4);
            btt_Luu.Name = "btt_Luu";
            btt_Luu.Size = new Size(136, 55);
            btt_Luu.TabIndex = 9;
            btt_Luu.Text = "Lưu";
            btt_Luu.UseVisualStyleBackColor = false;
            btt_Luu.Click += btt_Luu_Click;
            // 
            // btt_Huy
            // 
            btt_Huy.BackColor = Color.LightSeaGreen;
            btt_Huy.ForeColor = Color.White;
            btt_Huy.Location = new Point(479, 594);
            btt_Huy.Margin = new Padding(4);
            btt_Huy.Name = "btt_Huy";
            btt_Huy.Size = new Size(136, 55);
            btt_Huy.TabIndex = 10;
            btt_Huy.Text = "Hủy";
            btt_Huy.UseVisualStyleBackColor = false;
            btt_Huy.Click += btt_Huy_Click;
            // 
            // btt_ChonHinhAnh
            // 
            btt_ChonHinhAnh.BackColor = Color.LightSeaGreen;
            btt_ChonHinhAnh.ForeColor = Color.White;
            btt_ChonHinhAnh.Location = new Point(609, 468);
            btt_ChonHinhAnh.Margin = new Padding(4);
            btt_ChonHinhAnh.Name = "btt_ChonHinhAnh";
            btt_ChonHinhAnh.Size = new Size(251, 55);
            btt_ChonHinhAnh.TabIndex = 8;
            btt_ChonHinhAnh.Text = "Chọn hình ảnh";
            btt_ChonHinhAnh.UseVisualStyleBackColor = false;
            btt_ChonHinhAnh.Click += btt_ChonHinhAnh_Click;
            // 
            // Frm_AddEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(892, 685);
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
            Margin = new Padding(4);
            Name = "Frm_AddEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Ký Tài Khoản";
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