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
            cboGioiTinh = new ComboBox();
            label2 = new Label();
            dateTimePickerDOB = new DateTimePicker();
            label5 = new Label();
            txtEmail = new TextBox();
            txtSoDienThoai = new TextBox();
            txtHoTen = new TextBox();
            label4 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 58);
            label1.Name = "label1";
            label1.Size = new Size(113, 19);
            label1.TabIndex = 0;
            label1.Text = "Mã Khách hàng";
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.Location = new Point(34, 87);
            txtMaKhachHang.Margin = new Padding(3, 4, 3, 4);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.Size = new Size(114, 27);
            txtMaKhachHang.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnXacNhan);
            groupBox1.Controls.Add(txtSoCanCuoc);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cboGioiTinh);
            groupBox1.Controls.Add(txtMaKhachHang);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dateTimePickerDOB);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtSoDienThoai);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(32, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(725, 402);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng ";
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(361, 266);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 8;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(487, 266);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 29);
            btnXacNhan.TabIndex = 8;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // txtSoCanCuoc
            // 
            txtSoCanCuoc.Location = new Point(485, 184);
            txtSoCanCuoc.Name = "txtSoCanCuoc";
            txtSoCanCuoc.Size = new Size(203, 27);
            txtSoCanCuoc.TabIndex = 6;
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cboGioiTinh.Location = new Point(485, 87);
            cboGioiTinh.Margin = new Padding(3, 4, 3, 4);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(118, 27);
            cboGioiTinh.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 58);
            label2.Name = "label2";
            label2.Size = new Size(73, 19);
            label2.TabIndex = 0;
            label2.Text = "Họ và tên";
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.CustomFormat = "dd/MM/yyyy";
            dateTimePickerDOB.Format = DateTimePickerFormat.Custom;
            dateTimePickerDOB.Location = new Point(34, 184);
            dateTimePickerDOB.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerDOB.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(121, 27);
            dateTimePickerDOB.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(487, 158);
            label5.Name = "label5";
            label5.Size = new Size(92, 19);
            label5.TabIndex = 0;
            label5.Text = "Số căn cước";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(34, 268);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(271, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(200, 184);
            txtSoDienThoai.Margin = new Padding(3, 4, 3, 4);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(243, 27);
            txtSoDienThoai.TabIndex = 5;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(200, 87);
            txtHoTen.Margin = new Padding(3, 4, 3, 4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(243, 27);
            txtHoTen.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 156);
            label4.Name = "label4";
            label4.Size = new Size(76, 19);
            label4.TabIndex = 0;
            label4.Text = "Ngày sinh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 240);
            label7.Name = "label7";
            label7.Size = new Size(49, 19);
            label7.TabIndex = 0;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(487, 58);
            label6.Name = "label6";
            label6.Size = new Size(70, 19);
            label6.TabIndex = 0;
            label6.Text = "Giới tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 156);
            label3.Name = "label3";
            label3.Size = new Size(80, 19);
            label3.TabIndex = 0;
            label3.Text = "Điện thoại";
            // 
            // Frm_Add_Customer
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 428);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Frm_Add_Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCustomer";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private TextBox txtMaKhachHang;
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
    }
}