namespace QLAccBank
{
    partial class Frm_Add_Customer
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
            label1 = new Label();
            txtMaKhachHang = new TextBox();
            groupBox1 = new GroupBox();
            btnHuy = new Button();
            btnXacNhan = new Button();
            txtSoCanCuoc = new TextBox();
            label9 = new Label();
            txt_sotaikhoan = new TextBox();
            combobox_loaithe = new ComboBox();
            cboGioiTinh = new ComboBox();
            label11 = new Label();
            label2 = new Label();
            dateTimePickerDOB = new DateTimePicker();
            label5 = new Label();
            txtDiaChi = new TextBox();
            txtEmail = new TextBox();
            txt_ten = new TextBox();
            txtSoDienThoai = new TextBox();
            txtHoTen = new TextBox();
            label8 = new Label();
            label4 = new Label();
            label7 = new Label();
            label10 = new Label();
            label6 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(339, 53);
            label1.Name = "label1";
            label1.Size = new Size(139, 23);
            label1.TabIndex = 0;
            label1.Text = "Mã Khách hàng";
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.Location = new Point(335, 82);
            txtMaKhachHang.Margin = new Padding(3, 4, 3, 4);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.Size = new Size(201, 31);
            txtMaKhachHang.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnXacNhan);
            groupBox1.Controls.Add(txtSoCanCuoc);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_sotaikhoan);
            groupBox1.Controls.Add(combobox_loaithe);
            groupBox1.Controls.Add(cboGioiTinh);
            groupBox1.Controls.Add(txtMaKhachHang);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dateTimePickerDOB);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txt_ten);
            groupBox1.Controls.Add(txtSoDienThoai);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(32, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(807, 476);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng ";
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.LightSeaGreen;
            btnHuy.Font = new Font("Times New Roman", 15F);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(448, 403);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(148, 50);
            btnHuy.TabIndex = 8;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.LightSeaGreen;
            btnXacNhan.Font = new Font("Times New Roman", 15F);
            btnXacNhan.ForeColor = Color.White;
            btnXacNhan.Location = new Point(222, 403);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(148, 50);
            btnXacNhan.TabIndex = 8;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // txtSoCanCuoc
            // 
            txtSoCanCuoc.Location = new Point(337, 254);
            txtSoCanCuoc.Name = "txtSoCanCuoc";
            txtSoCanCuoc.Size = new Size(203, 31);
            txtSoCanCuoc.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(341, 141);
            label9.Name = "label9";
            label9.Size = new Size(118, 23);
            label9.TabIndex = 0;
            label9.Text = "Số tài Khoản";
            // 
            // txt_sotaikhoan
            // 
            txt_sotaikhoan.Enabled = false;
            txt_sotaikhoan.Location = new Point(337, 170);
            txt_sotaikhoan.Margin = new Padding(3, 4, 3, 4);
            txt_sotaikhoan.Name = "txt_sotaikhoan";
            txt_sotaikhoan.Size = new Size(199, 31);
            txt_sotaikhoan.TabIndex = 1;
            // 
            // combobox_loaithe
            // 
            combobox_loaithe.FormattingEnabled = true;
            combobox_loaithe.Items.AddRange(new object[] { "thanh toán", "tín dụng", "tiết kiệm" });
            combobox_loaithe.Location = new Point(599, 170);
            combobox_loaithe.Margin = new Padding(3, 4, 3, 4);
            combobox_loaithe.Name = "combobox_loaithe";
            combobox_loaithe.Size = new Size(182, 30);
            combobox_loaithe.TabIndex = 3;
            combobox_loaithe.SelectedIndexChanged += combobox_loaithe_SelectedIndexChanged;
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cboGioiTinh.Location = new Point(599, 254);
            cboGioiTinh.Margin = new Padding(3, 4, 3, 4);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(182, 30);
            cboGioiTinh.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(219, 55);
            label11.Name = "label11";
            label11.Size = new Size(41, 23);
            label11.TabIndex = 0;
            label11.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 53);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 0;
            label2.Text = "Họ đệm";
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.CustomFormat = "dd/MM/yyyy";
            dateTimePickerDOB.Format = DateTimePickerFormat.Custom;
            dateTimePickerDOB.Location = new Point(601, 81);
            dateTimePickerDOB.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerDOB.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(180, 31);
            dateTimePickerDOB.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(339, 225);
            label5.Name = "label5";
            label5.Size = new Size(110, 23);
            label5.TabIndex = 0;
            label5.Text = "Số căn cước";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(156, 339);
            txtDiaChi.Margin = new Padding(3, 4, 3, 4);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(537, 31);
            txtDiaChi.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(20, 254);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(264, 31);
            txtEmail.TabIndex = 7;
            // 
            // txt_ten
            // 
            txt_ten.Location = new Point(219, 82);
            txt_ten.Margin = new Padding(3, 4, 3, 4);
            txt_ten.Name = "txt_ten";
            txt_ten.Size = new Size(65, 31);
            txt_ten.TabIndex = 2;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(20, 169);
            txtSoDienThoai.Margin = new Padding(3, 4, 3, 4);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(264, 31);
            txtSoDienThoai.TabIndex = 5;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(20, 82);
            txtHoTen.Margin = new Padding(3, 4, 3, 4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(193, 31);
            txtHoTen.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(158, 316);
            label8.Name = "label8";
            label8.Size = new Size(70, 23);
            label8.TabIndex = 0;
            label8.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(601, 53);
            label4.Name = "label4";
            label4.Size = new Size(92, 23);
            label4.TabIndex = 0;
            label4.Text = "Ngày sinh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 227);
            label7.Name = "label7";
            label7.Size = new Size(60, 23);
            label7.TabIndex = 0;
            label7.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(601, 141);
            label10.Name = "label10";
            label10.Size = new Size(78, 23);
            label10.TabIndex = 0;
            label10.Text = "Loại thẻ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(601, 225);
            label6.Name = "label6";
            label6.Size = new Size(85, 23);
            label6.TabIndex = 0;
            label6.Text = "Giới tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 141);
            label3.Name = "label3";
            label3.Size = new Size(97, 23);
            label3.TabIndex = 0;
            label3.Text = "Điện thoại";
            // 
            // Frm_Add_Customer
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(863, 495);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Frm_Add_Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm Khách Hàng";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cboGioiTinh;
        private Label label2;
        private DateTimePicker dateTimePickerDOB;
        private TextBox txtEmail;
        private TextBox txtSoDienThoai;
        private TextBox txtHoTen;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label5;
        private TextBox txtSoCanCuoc;
        private Button btnHuy;
        private Button btnXacNhan;
        public TextBox txtMaKhachHang;
        private TextBox txtDiaChi;
        private Label label8;
        private Label label9;
        public TextBox txt_sotaikhoan;
        private ComboBox combobox_loaithe;
        private Label label10;
        private Label label11;
        private TextBox txt_ten;
    }
}