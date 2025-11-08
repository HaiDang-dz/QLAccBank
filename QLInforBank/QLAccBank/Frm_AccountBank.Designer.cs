namespace QLAccBank
{
    partial class Frm_AccountBank
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgv_HistoryBank = new DataGridView();
            TransactionID = new DataGridViewTextBoxColumn();
            CustomerID1 = new DataGridViewTextBoxColumn();
            AccountNumber1 = new DataGridViewTextBoxColumn();
            TransactionType = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Note = new DataGridViewTextBoxColumn();
            txt_Tim = new TextBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgv_BankAccount = new DataGridView();
            AccountNumber = new DataGridViewTextBoxColumn();
            CustomerID = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            AccountType = new DataGridViewTextBoxColumn();
            Balance = new DataGridViewTextBoxColumn();
            OpenDate = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewTextBoxColumn();
            panelSinhVien = new Panel();
            lblFullName = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_HistoryBank).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_BankAccount).BeginInit();
            panelSinhVien.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_HistoryBank
            // 
            dgv_HistoryBank.AllowUserToAddRows = false;
            dgv_HistoryBank.AllowUserToDeleteRows = false;
            dgv_HistoryBank.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_HistoryBank.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_HistoryBank.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HistoryBank.Columns.AddRange(new DataGridViewColumn[] { TransactionID, CustomerID1, AccountNumber1, TransactionType, Amount, Date, Note });
            dgv_HistoryBank.Dock = DockStyle.Fill;
            dgv_HistoryBank.EnableHeadersVisualStyles = false;
            dgv_HistoryBank.GridColor = Color.Silver;
            dgv_HistoryBank.Location = new Point(1008, 89);
            dgv_HistoryBank.Margin = new Padding(4, 5, 4, 5);
            dgv_HistoryBank.Name = "dgv_HistoryBank";
            dgv_HistoryBank.ReadOnly = true;
            dgv_HistoryBank.RowHeadersWidth = 20;
            dgv_HistoryBank.Size = new Size(912, 725);
            dgv_HistoryBank.TabIndex = 5;
            // 
            // TransactionID
            // 
            TransactionID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            TransactionID.DataPropertyName = "TransactionID";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            TransactionID.DefaultCellStyle = dataGridViewCellStyle2;
            TransactionID.HeaderText = "Mã giao dịch";
            TransactionID.MinimumWidth = 6;
            TransactionID.Name = "TransactionID";
            TransactionID.ReadOnly = true;
            TransactionID.Width = 120;
            // 
            // CustomerID1
            // 
            CustomerID1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CustomerID1.DataPropertyName = "CustomerID";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            CustomerID1.DefaultCellStyle = dataGridViewCellStyle3;
            CustomerID1.HeaderText = "Mã KH";
            CustomerID1.MinimumWidth = 6;
            CustomerID1.Name = "CustomerID1";
            CustomerID1.ReadOnly = true;
            CustomerID1.Width = 76;
            // 
            // AccountNumber1
            // 
            AccountNumber1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AccountNumber1.DataPropertyName = "AccountNumber";
            AccountNumber1.HeaderText = "Số tài khoản";
            AccountNumber1.MinimumWidth = 6;
            AccountNumber1.Name = "AccountNumber1";
            AccountNumber1.ReadOnly = true;
            AccountNumber1.Width = 144;
            // 
            // TransactionType
            // 
            TransactionType.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            TransactionType.DataPropertyName = "TransactionType";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopCenter;
            TransactionType.DefaultCellStyle = dataGridViewCellStyle4;
            TransactionType.HeaderText = "Kiểu chuyển khoản";
            TransactionType.MinimumWidth = 6;
            TransactionType.Name = "TransactionType";
            TransactionType.ReadOnly = true;
            TransactionType.Width = 135;
            // 
            // Amount
            // 
            Amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "Biến động";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // Date
            // 
            Date.DataPropertyName = "Date";
            Date.HeaderText = "Ngày biến động";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // Note
            // 
            Note.DataPropertyName = "Description";
            Note.HeaderText = "Ghi chú";
            Note.MinimumWidth = 6;
            Note.Name = "Note";
            Note.ReadOnly = true;
            // 
            // txt_Tim
            // 
            txt_Tim.Location = new Point(372, 29);
            txt_Tim.Margin = new Padding(4, 4, 4, 4);
            txt_Tim.Name = "txt_Tim";
            txt_Tim.Size = new Size(539, 31);
            txt_Tim.TabIndex = 0;
            txt_Tim.TextChanged += txt_Tim_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(201, 25);
            label1.TabIndex = 1;
            label1.Text = "Tìm thông tin tài khoản:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.1829529F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.8170471F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.Controls.Add(dgv_BankAccount, 0, 1);
            tableLayoutPanel1.Controls.Add(panelSinhVien, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgv_HistoryBank, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1924, 819);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // dgv_BankAccount
            // 
            dgv_BankAccount.AllowUserToAddRows = false;
            dgv_BankAccount.AllowUserToDeleteRows = false;
            dgv_BankAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_BankAccount.Columns.AddRange(new DataGridViewColumn[] { AccountNumber, CustomerID, CustomerName, AccountType, Balance, OpenDate, IsActive });
            dgv_BankAccount.Dock = DockStyle.Fill;
            dgv_BankAccount.Location = new Point(4, 88);
            dgv_BankAccount.Margin = new Padding(4, 4, 4, 4);
            dgv_BankAccount.Name = "dgv_BankAccount";
            dgv_BankAccount.ReadOnly = true;
            dgv_BankAccount.RowHeadersWidth = 51;
            dgv_BankAccount.Size = new Size(996, 727);
            dgv_BankAccount.TabIndex = 13;
            dgv_BankAccount.CellClick += dgv_BankAccount_CellClick;
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
            CustomerName.DataPropertyName = "CustomerName";
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
            // panelSinhVien
            // 
            panelSinhVien.Controls.Add(lblFullName);
            panelSinhVien.Dock = DockStyle.Fill;
            panelSinhVien.Location = new Point(1008, 5);
            panelSinhVien.Margin = new Padding(4, 5, 4, 5);
            panelSinhVien.Name = "panelSinhVien";
            panelSinhVien.Size = new Size(912, 74);
            panelSinhVien.TabIndex = 2;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.ForeColor = Color.FromArgb(192, 0, 0);
            lblFullName.Location = new Point(4, 36);
            lblFullName.Margin = new Padding(4, 0, 4, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(148, 25);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Lịch sử giao dịch:";
            lblFullName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_Tim);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(4, 4);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(996, 76);
            panel1.TabIndex = 3;
            // 
            // Frm_AccountBank
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 819);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Frm_AccountBank";
            Text = "Thông tin tài khoản";
            WindowState = FormWindowState.Maximized;
            Load += Frm_AccountBank_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_HistoryBank).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_BankAccount).EndInit();
            panelSinhVien.ResumeLayout(false);
            panelSinhVien.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgv_HistoryBank;
        private TextBox txt_Tim;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelSinhVien;
        private Label lblFullName;
        private Panel panel1;
        private DataGridView dgv_BankAccount;
        private DataGridViewTextBoxColumn AccountNumber;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn AccountType;
        private DataGridViewTextBoxColumn Balance;
        private DataGridViewTextBoxColumn OpenDate;
        private DataGridViewTextBoxColumn IsActive;
        private DataGridViewTextBoxColumn TransactionID;
        private DataGridViewTextBoxColumn CustomerID1;
        private DataGridViewTextBoxColumn AccountNumber1;
        private DataGridViewTextBoxColumn TransactionType;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Note;
    }
}