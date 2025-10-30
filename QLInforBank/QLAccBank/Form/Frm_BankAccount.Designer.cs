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
            dgv_BankAccount = new DataGridView();
            AccountNumber = new DataGridViewTextBoxColumn();
            CustomerID = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            AccountType = new DataGridViewTextBoxColumn();
            Balance = new DataGridViewTextBoxColumn();
            OpenDate = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewTextBoxColumn();
            lbe_TrangThai = new Label();
            txt_tim = new TextBox();
            lb_tim = new Label();
            txt_loaiTK = new TextBox();
            txt_tthd = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_BankAccount).BeginInit();
            SuspendLayout();
            // 
            // lbe_STK
            // 
            lbe_STK.AutoSize = true;
            lbe_STK.Location = new Point(65, 75);
            lbe_STK.Margin = new Padding(4, 0, 4, 0);
            lbe_STK.Name = "lbe_STK";
            lbe_STK.Size = new Size(116, 25);
            lbe_STK.TabIndex = 0;
            lbe_STK.Text = "Số tài khoản ";
            // 
            // lbe_MaKH
            // 
            lbe_MaKH.AutoSize = true;
            lbe_MaKH.Location = new Point(65, 132);
            lbe_MaKH.Margin = new Padding(4, 0, 4, 0);
            lbe_MaKH.Name = "lbe_MaKH";
            lbe_MaKH.Size = new Size(133, 25);
            lbe_MaKH.TabIndex = 1;
            lbe_MaKH.Text = "Mã khách hàng";
            // 
            // lbe_SoDu
            // 
            lbe_SoDu.AutoSize = true;
            lbe_SoDu.Location = new Point(65, 200);
            lbe_SoDu.Margin = new Padding(4, 0, 4, 0);
            lbe_SoDu.Name = "lbe_SoDu";
            lbe_SoDu.Size = new Size(60, 25);
            lbe_SoDu.TabIndex = 2;
            lbe_SoDu.Text = "Số dư";
            // 
            // lbe_LoaiTK
            // 
            lbe_LoaiTK.AutoSize = true;
            lbe_LoaiTK.Location = new Point(631, 75);
            lbe_LoaiTK.Margin = new Padding(4, 0, 4, 0);
            lbe_LoaiTK.Name = "lbe_LoaiTK";
            lbe_LoaiTK.Size = new Size(127, 25);
            lbe_LoaiTK.TabIndex = 3;
            lbe_LoaiTK.Text = "Loại tài khoản ";
            // 
            // lbe_NgayMo
            // 
            lbe_NgayMo.AutoSize = true;
            lbe_NgayMo.Location = new Point(631, 132);
            lbe_NgayMo.Margin = new Padding(4, 0, 4, 0);
            lbe_NgayMo.Name = "lbe_NgayMo";
            lbe_NgayMo.Size = new Size(91, 25);
            lbe_NgayMo.TabIndex = 4;
            lbe_NgayMo.Text = "Ngày mở ";
            // 
            // txt_STK
            // 
            txt_STK.Enabled = false;
            txt_STK.Location = new Point(222, 71);
            txt_STK.Margin = new Padding(4);
            txt_STK.Name = "txt_STK";
            txt_STK.Size = new Size(373, 31);
            txt_STK.TabIndex = 5;
            // 
            // txt_MaKH
            // 
            txt_MaKH.Enabled = false;
            txt_MaKH.Location = new Point(222, 124);
            txt_MaKH.Margin = new Padding(4);
            txt_MaKH.Name = "txt_MaKH";
            txt_MaKH.Size = new Size(373, 31);
            txt_MaKH.TabIndex = 6;
            // 
            // txt_SoDu
            // 
            txt_SoDu.Enabled = false;
            txt_SoDu.Location = new Point(222, 196);
            txt_SoDu.Margin = new Padding(4);
            txt_SoDu.Name = "txt_SoDu";
            txt_SoDu.Size = new Size(373, 31);
            txt_SoDu.TabIndex = 7;
            // 
            // datetime
            // 
            datetime.Enabled = false;
            datetime.Location = new Point(832, 126);
            datetime.Margin = new Padding(4);
            datetime.Name = "datetime";
            datetime.Size = new Size(373, 31);
            datetime.TabIndex = 10;
            // 
            // dgv_BankAccount
            // 
            dgv_BankAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_BankAccount.Columns.AddRange(new DataGridViewColumn[] { AccountNumber, CustomerID, CustomerName, AccountType, Balance, OpenDate, IsActive });
            dgv_BankAccount.Dock = DockStyle.Bottom;
            dgv_BankAccount.Location = new Point(0, 405);
            dgv_BankAccount.Margin = new Padding(4);
            dgv_BankAccount.Name = "dgv_BankAccount";
            dgv_BankAccount.ReadOnly = true;
            dgv_BankAccount.RowHeadersWidth = 51;
            dgv_BankAccount.Size = new Size(1305, 366);
            dgv_BankAccount.TabIndex = 12;
            dgv_BankAccount.CellEnter += dgv_BankAccount_CellEnter;
            dgv_BankAccount.CellFormatting += dgv_BankAccount_CellFormatting;
            // 
            // AccountNumber
            // 
            AccountNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AccountNumber.FillWeight = 80F;
            AccountNumber.HeaderText = "Số tài khoản";
            AccountNumber.MinimumWidth = 8;
            AccountNumber.Name = "AccountNumber";
            AccountNumber.ReadOnly = true;
            // 
            // CustomerID
            // 
            CustomerID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CustomerID.FillWeight = 60F;
            CustomerID.HeaderText = "Mã khách hàng ";
            CustomerID.MinimumWidth = 6;
            CustomerID.Name = "CustomerID";
            CustomerID.ReadOnly = true;
            // 
            // CustomerName
            // 
            CustomerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CustomerName.FillWeight = 120F;
            CustomerName.HeaderText = "Tên khách hàng";
            CustomerName.MinimumWidth = 8;
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            // 
            // AccountType
            // 
            AccountType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AccountType.FillWeight = 80F;
            AccountType.HeaderText = "Loại tài khoản ";
            AccountType.MinimumWidth = 6;
            AccountType.Name = "AccountType";
            AccountType.ReadOnly = true;
            // 
            // Balance
            // 
            Balance.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Balance.FillWeight = 80F;
            Balance.HeaderText = "Số dư";
            Balance.MinimumWidth = 6;
            Balance.Name = "Balance";
            Balance.ReadOnly = true;
            // 
            // OpenDate
            // 
            OpenDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OpenDate.FillWeight = 70F;
            OpenDate.HeaderText = "Ngày Mở";
            OpenDate.MinimumWidth = 6;
            OpenDate.Name = "OpenDate";
            OpenDate.ReadOnly = true;
            // 
            // IsActive
            // 
            IsActive.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IsActive.FillWeight = 80F;
            IsActive.HeaderText = "Trạng Thái Hoạt Động ";
            IsActive.MinimumWidth = 6;
            IsActive.Name = "IsActive";
            IsActive.ReadOnly = true;
            // 
            // lbe_TrangThai
            // 
            lbe_TrangThai.AutoSize = true;
            lbe_TrangThai.Location = new Point(631, 194);
            lbe_TrangThai.Margin = new Padding(4, 0, 4, 0);
            lbe_TrangThai.Name = "lbe_TrangThai";
            lbe_TrangThai.Size = new Size(183, 25);
            lbe_TrangThai.TabIndex = 13;
            lbe_TrangThai.Text = "Trạng thái hoạt động ";
            // 
            // txt_tim
            // 
            txt_tim.Location = new Point(222, 314);
            txt_tim.Margin = new Padding(2);
            txt_tim.Name = "txt_tim";
            txt_tim.Size = new Size(375, 31);
            txt_tim.TabIndex = 20;
            txt_tim.TextChanged += txt_tim_TextChanged;
            // 
            // lb_tim
            // 
            lb_tim.AutoSize = true;
            lb_tim.Location = new Point(65, 319);
            lb_tim.Margin = new Padding(2, 0, 2, 0);
            lb_tim.Name = "lb_tim";
            lb_tim.Size = new Size(84, 25);
            lb_tim.TabIndex = 15;
            lb_tim.Text = "Tìm kiếm";
            lb_tim.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_loaiTK
            // 
            txt_loaiTK.Enabled = false;
            txt_loaiTK.Location = new Point(832, 69);
            txt_loaiTK.Margin = new Padding(4);
            txt_loaiTK.Name = "txt_loaiTK";
            txt_loaiTK.Size = new Size(373, 31);
            txt_loaiTK.TabIndex = 6;
            // 
            // txt_tthd
            // 
            txt_tthd.Enabled = false;
            txt_tthd.Location = new Point(832, 191);
            txt_tthd.Margin = new Padding(4);
            txt_tthd.Name = "txt_tthd";
            txt_tthd.Size = new Size(373, 31);
            txt_tthd.TabIndex = 6;
            // 
            // Frm_BankAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1305, 771);
            Controls.Add(txt_tim);
            Controls.Add(lb_tim);
            Controls.Add(lbe_TrangThai);
            Controls.Add(dgv_BankAccount);
            Controls.Add(datetime);
            Controls.Add(txt_SoDu);
            Controls.Add(txt_tthd);
            Controls.Add(txt_loaiTK);
            Controls.Add(txt_MaKH);
            Controls.Add(txt_STK);
            Controls.Add(lbe_NgayMo);
            Controls.Add(lbe_LoaiTK);
            Controls.Add(lbe_SoDu);
            Controls.Add(lbe_MaKH);
            Controls.Add(lbe_STK);
            Margin = new Padding(4);
            Name = "Frm_BankAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông Tin Tài Khoản";
            Load += Frm_BankAccount_Load;
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
        private DataGridView dgv_BankAccount;
        private Label lbe_TrangThai;
        private Button btt_QLTK;
        private TextBox txt_tim;
        private Button button1;
        private Button bt_update;
        private Button bt_xoa;
        private Label lb_tim;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn AccountNumber;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn AccountType;
        private DataGridViewTextBoxColumn Balance;
        private DataGridViewTextBoxColumn OpenDate;
        private DataGridViewTextBoxColumn IsActive;
        private TextBox txt_loaiTK;
        private TextBox txt_tthd;
    }
}