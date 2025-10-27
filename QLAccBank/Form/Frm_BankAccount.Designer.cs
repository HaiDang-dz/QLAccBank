namespace QLAccBank
{
    partial class Frm_BankAccount
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
            lbe_STK = new Label();
            lbe_MaKH = new Label();
            lbe_SoDu = new Label();
            lbe_LoaiTK = new Label();
            lbe_NgayMo = new Label();
            txt_STK = new TextBox();
            txt_MaKH = new TextBox();
            txt_SoDu = new TextBox();
            datetime = new DateTimePicker();
            combobox_LoaiTK = new ComboBox();
            dataGridView1 = new DataGridView();
            MaKH = new DataGridViewTextBoxColumn();
            TenKH = new DataGridViewTextBoxColumn();
            LoaiTaiKhoan = new DataGridViewTextBoxColumn();
            SoDu = new DataGridViewTextBoxColumn();
            NgayMo = new DataGridViewTextBoxColumn();
            TrangThaiHoatDong = new DataGridViewTextBoxColumn();
            lbe_TrangThai = new Label();
            cbox_TrangThai = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbe_STK
            // 
            lbe_STK.AutoSize = true;
            lbe_STK.Location = new Point(51, 35);
            lbe_STK.Name = "lbe_STK";
            lbe_STK.Size = new Size(95, 20);
            lbe_STK.TabIndex = 0;
            lbe_STK.Text = "Số tài khoản ";
            // 
            // lbe_MaKH
            // 
            lbe_MaKH.AutoSize = true;
            lbe_MaKH.Location = new Point(51, 87);
            lbe_MaKH.Name = "lbe_MaKH";
            lbe_MaKH.Size = new Size(109, 20);
            lbe_MaKH.TabIndex = 1;
            lbe_MaKH.Text = "Mã khách hàng";
            // 
            // lbe_SoDu
            // 
            lbe_SoDu.AutoSize = true;
            lbe_SoDu.Location = new Point(51, 193);
            lbe_SoDu.Name = "lbe_SoDu";
            lbe_SoDu.Size = new Size(48, 20);
            lbe_SoDu.TabIndex = 2;
            lbe_SoDu.Text = "Số dư";
            // 
            // lbe_LoaiTK
            // 
            lbe_LoaiTK.AutoSize = true;
            lbe_LoaiTK.Location = new Point(51, 144);
            lbe_LoaiTK.Name = "lbe_LoaiTK";
            lbe_LoaiTK.Size = new Size(106, 20);
            lbe_LoaiTK.TabIndex = 3;
            lbe_LoaiTK.Text = "Loại tài khoản ";
            // 
            // lbe_NgayMo
            // 
            lbe_NgayMo.AutoSize = true;
            lbe_NgayMo.Location = new Point(51, 242);
            lbe_NgayMo.Name = "lbe_NgayMo";
            lbe_NgayMo.Size = new Size(74, 20);
            lbe_NgayMo.TabIndex = 4;
            lbe_NgayMo.Text = "Ngày mở ";
            // 
            // txt_STK
            // 
            txt_STK.Location = new Point(306, 32);
            txt_STK.Name = "txt_STK";
            txt_STK.Size = new Size(282, 27);
            txt_STK.TabIndex = 5;
            // 
            // txt_MaKH
            // 
            txt_MaKH.Location = new Point(306, 84);
            txt_MaKH.Name = "txt_MaKH";
            txt_MaKH.Size = new Size(282, 27);
            txt_MaKH.TabIndex = 6;
            // 
            // txt_SoDu
            // 
            txt_SoDu.Location = new Point(306, 186);
            txt_SoDu.Name = "txt_SoDu";
            txt_SoDu.Size = new Size(282, 27);
            txt_SoDu.TabIndex = 7;
            // 
            // datetime
            // 
            datetime.Location = new Point(306, 242);
            datetime.Name = "datetime";
            datetime.Size = new Size(282, 27);
            datetime.TabIndex = 10;
            datetime.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // combobox_LoaiTK
            // 
            combobox_LoaiTK.FormattingEnabled = true;
            combobox_LoaiTK.Items.AddRange(new object[] { "Tiết kiệm ", "Thanh toán ", "Thẻ tín dụng ", "Đầu tư " });
            combobox_LoaiTK.Location = new Point(306, 136);
            combobox_LoaiTK.Name = "combobox_LoaiTK";
            combobox_LoaiTK.Size = new Size(282, 28);
            combobox_LoaiTK.TabIndex = 11;
            combobox_LoaiTK.Text = "Tiết kiệm ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaKH, TenKH, LoaiTaiKhoan, SoDu, NgayMo, TrangThaiHoatDong });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 353);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(945, 249);
            dataGridView1.TabIndex = 12;
            // 
            // MaKH
            // 
            MaKH.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaKH.HeaderText = "Mã khách hàng ";
            MaKH.MinimumWidth = 6;
            MaKH.Name = "MaKH";
            // 
            // TenKH
            // 
            TenKH.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenKH.HeaderText = "Tên khách hàng ";
            TenKH.MinimumWidth = 6;
            TenKH.Name = "TenKH";
            // 
            // LoaiTaiKhoan
            // 
            LoaiTaiKhoan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LoaiTaiKhoan.HeaderText = "Loại tài khoản ";
            LoaiTaiKhoan.MinimumWidth = 6;
            LoaiTaiKhoan.Name = "LoaiTaiKhoan";
            // 
            // SoDu
            // 
            SoDu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SoDu.HeaderText = "Số dư";
            SoDu.MinimumWidth = 6;
            SoDu.Name = "SoDu";
            // 
            // NgayMo
            // 
            NgayMo.HeaderText = "Ngày Mở";
            NgayMo.MinimumWidth = 6;
            NgayMo.Name = "NgayMo";
            NgayMo.Width = 125;
            // 
            // TrangThaiHoatDong
            // 
            TrangThaiHoatDong.HeaderText = "Trạng Thái Hoạt Động ";
            TrangThaiHoatDong.MinimumWidth = 6;
            TrangThaiHoatDong.Name = "TrangThaiHoatDong";
            TrangThaiHoatDong.Width = 125;
            // 
            // lbe_TrangThai
            // 
            lbe_TrangThai.AutoSize = true;
            lbe_TrangThai.Location = new Point(49, 295);
            lbe_TrangThai.Name = "lbe_TrangThai";
            lbe_TrangThai.Size = new Size(152, 20);
            lbe_TrangThai.TabIndex = 13;
            lbe_TrangThai.Text = "Trạng thái hoạt động ";
            // 
            // cbox_TrangThai
            // 
            cbox_TrangThai.FormattingEnabled = true;
            cbox_TrangThai.Items.AddRange(new object[] { "Có ", "Không" });
            cbox_TrangThai.Location = new Point(306, 292);
            cbox_TrangThai.Name = "cbox_TrangThai";
            cbox_TrangThai.Size = new Size(282, 28);
            cbox_TrangThai.TabIndex = 14;
            cbox_TrangThai.Text = "Có ";
            // 
            // Frm_BankAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 602);
            Controls.Add(cbox_TrangThai);
            Controls.Add(lbe_TrangThai);
            Controls.Add(dataGridView1);
            Controls.Add(combobox_LoaiTK);
            Controls.Add(datetime);
            Controls.Add(txt_SoDu);
            Controls.Add(txt_MaKH);
            Controls.Add(txt_STK);
            Controls.Add(lbe_NgayMo);
            Controls.Add(lbe_LoaiTK);
            Controls.Add(lbe_SoDu);
            Controls.Add(lbe_MaKH);
            Controls.Add(lbe_STK);
            Name = "Frm_BankAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BankAccount";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbe_STK;
        private Label lbe_MaKH;
        private Label lbe_SoDu;
        private Label lbe_LoaiTK;
        private Label lbe_NgayMo;
        private TextBox txt_STK;
        private TextBox txt_MaKH;
        private TextBox txt_SoDu;
        private DateTimePicker datetime;
        private ComboBox combobox_LoaiTK;
        private DataGridView dataGridView1;
        private Label lbe_TrangThai;
        private ComboBox cbox_TrangThai;
        private DataGridViewTextBoxColumn MaKH;
        private DataGridViewTextBoxColumn TenKH;
        private DataGridViewTextBoxColumn LoaiTaiKhoan;
        private DataGridViewTextBoxColumn SoDu;
        private DataGridViewTextBoxColumn NgayMo;
        private DataGridViewTextBoxColumn TrangThaiHoatDong;
    }
}