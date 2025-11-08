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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BankAccount));
            IDCard = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            DOB = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            CustomerID = new DataGridViewTextBoxColumn();
            dgv_Customer = new DataGridView();
            Address = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewTextBoxColumn();
            OpenDate = new DataGridViewTextBoxColumn();
            Balance = new DataGridViewTextBoxColumn();
            CustomerID1 = new DataGridViewTextBoxColumn();
            AccountNumber = new DataGridViewTextBoxColumn();
            dgv_BankAccount = new DataGridView();
            AccountType = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelSinhVien = new Panel();
            lblCusInformation = new Label();
            panel1 = new Panel();
            btnThemMoi = new Button();
            txt_Tim = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Customer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_BankAccount).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panelSinhVien.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // IDCard
            // 
            IDCard.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IDCard.DataPropertyName = "IDCard";
            IDCard.FillWeight = 18.20646F;
            IDCard.HeaderText = "Căn cước";
            IDCard.MinimumWidth = 8;
            IDCard.Name = "IDCard";
            IDCard.ReadOnly = true;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.DataPropertyName = "Email";
            Email.FillWeight = 17.6822853F;
            Email.HeaderText = "Email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            PhoneNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PhoneNumber.DataPropertyName = "PhoneNumber";
            PhoneNumber.FillWeight = 14.9852228F;
            PhoneNumber.HeaderText = "SĐT";
            PhoneNumber.MinimumWidth = 8;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            // 
            // DOB
            // 
            DOB.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DOB.DataPropertyName = "DOB";
            DOB.FillWeight = 17.6822853F;
            DOB.HeaderText = "Ngày sinh";
            DOB.MinimumWidth = 8;
            DOB.Name = "DOB";
            DOB.ReadOnly = true;
            // 
            // Gender
            // 
            Gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Gender.DataPropertyName = "Gender";
            Gender.FillWeight = 12.4044333F;
            Gender.HeaderText = "Giới tính";
            Gender.MinimumWidth = 8;
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            // 
            // FullName
            // 
            FullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FullName.DataPropertyName = "FullName";
            FullName.FillWeight = 31.96174F;
            FullName.HeaderText = "Họ Tên KH";
            FullName.MinimumWidth = 8;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // CustomerID
            // 
            CustomerID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CustomerID.DataPropertyName = "CustomerID";
            CustomerID.FillWeight = 11.6551733F;
            CustomerID.HeaderText = "Mã KH";
            CustomerID.MinimumWidth = 8;
            CustomerID.Name = "CustomerID";
            CustomerID.ReadOnly = true;
            // 
            // dgv_Customer
            // 
            dgv_Customer.AllowUserToAddRows = false;
            dgv_Customer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_Customer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Customer.Columns.AddRange(new DataGridViewColumn[] { CustomerID, FullName, Gender, DOB, PhoneNumber, Email, Address, IDCard });
            dgv_Customer.Location = new Point(2, 69);
            dgv_Customer.Margin = new Padding(2);
            dgv_Customer.Name = "dgv_Customer";
            dgv_Customer.ReadOnly = true;
            dgv_Customer.RowHeadersWidth = 62;
            dgv_Customer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Customer.Size = new Size(1036, 794);
            dgv_Customer.TabIndex = 6;
            // 
            // Address
            // 
            Address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Address.DataPropertyName = "Address";
            Address.FillWeight = 17.2810574F;
            Address.HeaderText = "Địa chỉ";
            Address.MinimumWidth = 8;
            Address.Name = "Address";
            Address.ReadOnly = true;
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
            // OpenDate
            // 
            OpenDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OpenDate.FillWeight = 70F;
            OpenDate.HeaderText = "Ngày Mở";
            OpenDate.MinimumWidth = 6;
            OpenDate.Name = "OpenDate";
            OpenDate.ReadOnly = true;
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
            // CustomerID1
            // 
            CustomerID1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CustomerID1.FillWeight = 60F;
            CustomerID1.HeaderText = "Mã KH";
            CustomerID1.MinimumWidth = 6;
            CustomerID1.Name = "CustomerID1";
            CustomerID1.ReadOnly = true;
            // 
            // AccountNumber
            // 
            AccountNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AccountNumber.FillWeight = 80F;
            AccountNumber.HeaderText = "Số TK";
            AccountNumber.MinimumWidth = 8;
            AccountNumber.Name = "AccountNumber";
            AccountNumber.ReadOnly = true;
            // 
            // dgv_BankAccount
            // 
            dgv_BankAccount.AllowUserToAddRows = false;
            dgv_BankAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_BankAccount.Columns.AddRange(new DataGridViewColumn[] { AccountNumber, CustomerID1, AccountType, Balance, OpenDate, IsActive });
            dgv_BankAccount.Dock = DockStyle.Fill;
            dgv_BankAccount.Location = new Point(1043, 70);
            dgv_BankAccount.Name = "dgv_BankAccount";
            dgv_BankAccount.ReadOnly = true;
            dgv_BankAccount.RowHeadersWidth = 51;
            dgv_BankAccount.Size = new Size(677, 792);
            dgv_BankAccount.TabIndex = 13;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.39501F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.60499F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(dgv_BankAccount, 1, 1);
            tableLayoutPanel1.Controls.Add(panelSinhVien, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgv_Customer, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1723, 865);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panelSinhVien
            // 
            panelSinhVien.Controls.Add(lblCusInformation);
            panelSinhVien.Dock = DockStyle.Fill;
            panelSinhVien.Location = new Point(1043, 4);
            panelSinhVien.Margin = new Padding(3, 4, 3, 4);
            panelSinhVien.Name = "panelSinhVien";
            panelSinhVien.Size = new Size(677, 59);
            panelSinhVien.TabIndex = 2;
            // 
            // lblCusInformation
            // 
            lblCusInformation.AutoSize = true;
            lblCusInformation.ForeColor = Color.Blue;
            lblCusInformation.Location = new Point(3, 29);
            lblCusInformation.Name = "lblCusInformation";
            lblCusInformation.Size = new Size(154, 20);
            lblCusInformation.TabIndex = 0;
            lblCusInformation.Text = "Thông tin khách hàng:";
            lblCusInformation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThemMoi);
            panel1.Controls.Add(txt_Tim);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1034, 61);
            panel1.TabIndex = 3;
            // 
            // btnThemMoi
            // 
            btnThemMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemMoi.DialogResult = DialogResult.OK;
            btnThemMoi.Image = (Image)resources.GetObject("btnThemMoi.Image");
            btnThemMoi.ImageAlign = ContentAlignment.MiddleRight;
            btnThemMoi.Location = new Point(2684, 19);
            btnThemMoi.Margin = new Padding(3, 4, 3, 4);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(118, 37);
            btnThemMoi.TabIndex = 8;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThemMoi.UseVisualStyleBackColor = true;
            // 
            // txt_Tim
            // 
            txt_Tim.Location = new Point(262, 19);
            txt_Tim.Name = "txt_Tim";
            txt_Tim.Size = new Size(423, 27);
            txt_Tim.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 27);
            label1.Name = "label1";
            label1.Size = new Size(180, 20);
            label1.TabIndex = 1;
            label1.Text = "Tìm thông tin khách hàng:";
            // 
            // Frm_BankAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1723, 865);
            Controls.Add(tableLayoutPanel1);
            Name = "Frm_BankAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông Tin Tài Khoản";
            ((System.ComponentModel.ISupportInitialize)dgv_Customer).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_BankAccount).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panelSinhVien.ResumeLayout(false);
            panelSinhVien.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btt_QLTK;
        private Button button1;
        private Button bt_update;
        private Button bt_xoa;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn IDCard;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn DOB;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridView dgv_Customer;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn IsActive;
        private DataGridViewTextBoxColumn OpenDate;
        private DataGridViewTextBoxColumn Balance;
        private DataGridViewTextBoxColumn CustomerID1;
        private DataGridViewTextBoxColumn AccountNumber;
        private DataGridView dgv_BankAccount;
        private DataGridViewTextBoxColumn AccountType;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelSinhVien;
        private Label lblCusInformation;
        private Panel panel1;
        private Button btnThemMoi;
        private TextBox txt_Tim;
        private Label label1;
    }
}