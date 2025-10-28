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
            dgv_BankAccount = new DataGridView();
            lbe_TrangThai = new Label();
            cbox_TrangThai = new ComboBox();
            txt_tim = new TextBox();
            lb_tim = new Label();
            CustomerID = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            AccountType = new DataGridViewTextBoxColumn();
            Balance = new DataGridViewTextBoxColumn();
            OpenDate = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_BankAccount).BeginInit();
            SuspendLayout();
            // 
            // lbe_STK
            // 
            lbe_STK.AutoSize = true;
            lbe_STK.Location = new Point(52, 60);
            lbe_STK.Name = "lbe_STK";
            lbe_STK.Size = new Size(95, 20);
            lbe_STK.TabIndex = 0;
            lbe_STK.Text = "Số tài khoản ";
            // 
            // lbe_MaKH
            // 
            lbe_MaKH.AutoSize = true;
            lbe_MaKH.Location = new Point(52, 106);
            lbe_MaKH.Name = "lbe_MaKH";
            lbe_MaKH.Size = new Size(109, 20);
            lbe_MaKH.TabIndex = 1;
            lbe_MaKH.Text = "Mã khách hàng";
            // 
            // lbe_SoDu
            // 
            lbe_SoDu.AutoSize = true;
            lbe_SoDu.Location = new Point(52, 160);
            lbe_SoDu.Name = "lbe_SoDu";
            lbe_SoDu.Size = new Size(48, 20);
            lbe_SoDu.TabIndex = 2;
            lbe_SoDu.Text = "Số dư";
            // 
            // lbe_LoaiTK
            // 
            lbe_LoaiTK.AutoSize = true;
            lbe_LoaiTK.Location = new Point(505, 60);
            lbe_LoaiTK.Name = "lbe_LoaiTK";
            lbe_LoaiTK.Size = new Size(106, 20);
            lbe_LoaiTK.TabIndex = 3;
            lbe_LoaiTK.Text = "Loại tài khoản ";
            // 
            // lbe_NgayMo
            // 
            lbe_NgayMo.AutoSize = true;
            lbe_NgayMo.Location = new Point(505, 106);
            lbe_NgayMo.Name = "lbe_NgayMo";
            lbe_NgayMo.Size = new Size(74, 20);
            lbe_NgayMo.TabIndex = 4;
            lbe_NgayMo.Text = "Ngày mở ";
            // 
            // txt_STK
            // 
            txt_STK.Location = new Point(178, 57);
            txt_STK.Name = "txt_STK";
            txt_STK.Size = new Size(299, 27);
            txt_STK.TabIndex = 5;
            // 
            // txt_MaKH
            // 
            txt_MaKH.Location = new Point(178, 99);
            txt_MaKH.Name = "txt_MaKH";
            txt_MaKH.Size = new Size(299, 27);
            txt_MaKH.TabIndex = 6;
            // 
            // txt_SoDu
            // 
            txt_SoDu.Location = new Point(178, 157);
            txt_SoDu.Name = "txt_SoDu";
            txt_SoDu.Size = new Size(299, 27);
            txt_SoDu.TabIndex = 7;
            // 
            // datetime
            // 
            datetime.Location = new Point(666, 101);
            datetime.Name = "datetime";
            datetime.Size = new Size(299, 27);
            datetime.TabIndex = 10;
            datetime.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // combobox_LoaiTK
            // 
            combobox_LoaiTK.FormattingEnabled = true;
            combobox_LoaiTK.Items.AddRange(new object[] { "Tiết kiệm ", "Thanh toán ", "Thẻ tín dụng ", "Đầu tư " });
            combobox_LoaiTK.Location = new Point(666, 52);
            combobox_LoaiTK.Name = "combobox_LoaiTK";
            combobox_LoaiTK.Size = new Size(299, 28);
            combobox_LoaiTK.TabIndex = 11;
            combobox_LoaiTK.Text = "Chọn loại tài khoản";
            // 
            // dgv_BankAccount
            // 
            dgv_BankAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_BankAccount.Columns.AddRange(new DataGridViewColumn[] { CustomerID, LastName, FirstName, AccountType, Balance, OpenDate, IsActive });
            dgv_BankAccount.Dock = DockStyle.Bottom;
            dgv_BankAccount.Location = new Point(0, 324);
            dgv_BankAccount.Name = "dgv_BankAccount";
            dgv_BankAccount.RowHeadersWidth = 51;
            dgv_BankAccount.Size = new Size(1044, 293);
            dgv_BankAccount.TabIndex = 12;
            // 
            // lbe_TrangThai
            // 
            lbe_TrangThai.AutoSize = true;
            lbe_TrangThai.Location = new Point(505, 155);
            lbe_TrangThai.Name = "lbe_TrangThai";
            lbe_TrangThai.Size = new Size(152, 20);
            lbe_TrangThai.TabIndex = 13;
            lbe_TrangThai.Text = "Trạng thái hoạt động ";
            // 
            // cbox_TrangThai
            // 
            cbox_TrangThai.FormattingEnabled = true;
            cbox_TrangThai.Items.AddRange(new object[] { "Có ", "Không" });
            cbox_TrangThai.Location = new Point(666, 149);
            cbox_TrangThai.Name = "cbox_TrangThai";
            cbox_TrangThai.Size = new Size(299, 28);
            cbox_TrangThai.TabIndex = 14;
            cbox_TrangThai.Text = "Chọn trạng thái hoạt động";
            // 
            // txt_tim
            // 
            txt_tim.Location = new Point(178, 251);
            txt_tim.Margin = new Padding(2);
            txt_tim.Name = "txt_tim";
            txt_tim.Size = new Size(301, 27);
            txt_tim.TabIndex = 20;
            // 
            // lb_tim
            // 
            lb_tim.AutoSize = true;
            lb_tim.Location = new Point(52, 255);
            lb_tim.Margin = new Padding(2, 0, 2, 0);
            lb_tim.Name = "lb_tim";
            lb_tim.Size = new Size(70, 20);
            lb_tim.TabIndex = 15;
            lb_tim.Text = "Tìm kiếm";
            lb_tim.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CustomerID
            // 
            CustomerID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CustomerID.HeaderText = "Mã khách hàng ";
            CustomerID.MinimumWidth = 6;
            CustomerID.Name = "CustomerID";
            // 
            // LastName
            // 
            LastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LastName.HeaderText = "Họ đệm";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            // 
            // FirstName
            // 
            FirstName.HeaderText = "Tên";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            FirstName.Width = 125;
            // 
            // AccountType
            // 
            AccountType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AccountType.HeaderText = "Loại tài khoản ";
            AccountType.MinimumWidth = 6;
            AccountType.Name = "AccountType";
            // 
            // Balance
            // 
            Balance.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Balance.HeaderText = "Số dư";
            Balance.MinimumWidth = 6;
            Balance.Name = "Balance";
            // 
            // OpenDate
            // 
            OpenDate.HeaderText = "Ngày Mở";
            OpenDate.MinimumWidth = 6;
            OpenDate.Name = "OpenDate";
            OpenDate.Width = 125;
            // 
            // IsActive
            // 
            IsActive.HeaderText = "Trạng Thái Hoạt Động ";
            IsActive.MinimumWidth = 6;
            IsActive.Name = "IsActive";
            IsActive.Width = 125;
            // 
            // Frm_BankAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 617);
            Controls.Add(txt_tim);
            Controls.Add(lb_tim);
            Controls.Add(cbox_TrangThai);
            Controls.Add(lbe_TrangThai);
            Controls.Add(dgv_BankAccount);
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
            ((System.ComponentModel.ISupportInitialize)dgv_BankAccount).EndInit();
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
        private DataGridView dgv_BankAccount;
        private Label lbe_TrangThai;
        private ComboBox cbox_TrangThai;
        private Button btt_QLTK;
        private TextBox txt_tim;
        private Button button1;
        private Button bt_update;
        private Button bt_xoa;
        private Label lb_tim;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn AccountType;
        private DataGridViewTextBoxColumn Balance;
        private DataGridViewTextBoxColumn OpenDate;
        private DataGridViewTextBoxColumn IsActive;
    }
}