namespace QLAccBank
{
    partial class Frm_Customer
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
            tlp_qlttkh = new TableLayoutPanel();
            panel1 = new Panel();
            btt_QLTK = new Button();
            comboBox_gioitinh = new ComboBox();
            dtp_ngaysinh = new DateTimePicker();
            txt_cancuoc = new TextBox();
            txt_diachi = new TextBox();
            txt_email = new TextBox();
            txt_sdt = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txt_ten = new TextBox();
            label5 = new Label();
            txt_hodem = new TextBox();
            label4 = new Label();
            txt_tim = new TextBox();
            label3 = new Label();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            bt_them = new Button();
            lb_tim = new Label();
            dgv_customer = new DataGridView();
            CustomerID = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            DOB = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            IDCard = new DataGridViewTextBoxColumn();
            Action = new DataGridViewTextBoxColumn();
            tlp_qlttkh.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_customer).BeginInit();
            SuspendLayout();
            // 
            // tlp_qlttkh
            // 
            tlp_qlttkh.ColumnCount = 2;
            tlp_qlttkh.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 99.4012F));
            tlp_qlttkh.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.5988024F));
            tlp_qlttkh.Controls.Add(panel1, 0, 0);
            tlp_qlttkh.Controls.Add(dgv_customer, 0, 1);
            tlp_qlttkh.Dock = DockStyle.Fill;
            tlp_qlttkh.Location = new Point(0, 0);
            tlp_qlttkh.Margin = new Padding(2);
            tlp_qlttkh.Name = "tlp_qlttkh";
            tlp_qlttkh.RowCount = 3;
            tlp_qlttkh.RowStyles.Add(new RowStyle(SizeType.Percent, 58.1259155F));
            tlp_qlttkh.RowStyles.Add(new RowStyle(SizeType.Percent, 41.8740845F));
            tlp_qlttkh.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tlp_qlttkh.Size = new Size(1328, 692);
            tlp_qlttkh.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btt_QLTK);
            panel1.Controls.Add(comboBox_gioitinh);
            panel1.Controls.Add(dtp_ngaysinh);
            panel1.Controls.Add(txt_cancuoc);
            panel1.Controls.Add(txt_diachi);
            panel1.Controls.Add(txt_email);
            panel1.Controls.Add(txt_sdt);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txt_ten);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txt_hodem);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_tim);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(bt_them);
            panel1.Controls.Add(lb_tim);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1316, 393);
            panel1.TabIndex = 1;
            // 
            // btt_QLTK
            // 
            btt_QLTK.Location = new Point(1002, 331);
            btt_QLTK.Margin = new Padding(2);
            btt_QLTK.Name = "btt_QLTK";
            btt_QLTK.Size = new Size(230, 42);
            btt_QLTK.TabIndex = 8;
            btt_QLTK.Text = "Quản Lí Tài khoản ";
            btt_QLTK.UseVisualStyleBackColor = true;
            btt_QLTK.Click += btt_QLTK_Click;
            // 
            // comboBox_gioitinh
            // 
            comboBox_gioitinh.Enabled = false;
            comboBox_gioitinh.FormattingEnabled = true;
            comboBox_gioitinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            comboBox_gioitinh.Location = new Point(259, 215);
            comboBox_gioitinh.Margin = new Padding(2);
            comboBox_gioitinh.Name = "comboBox_gioitinh";
            comboBox_gioitinh.Size = new Size(302, 33);
            comboBox_gioitinh.TabIndex = 7;
            // 
            // dtp_ngaysinh
            // 
            dtp_ngaysinh.Enabled = false;
            dtp_ngaysinh.Location = new Point(259, 159);
            dtp_ngaysinh.Margin = new Padding(2);
            dtp_ngaysinh.Name = "dtp_ngaysinh";
            dtp_ngaysinh.Size = new Size(302, 31);
            dtp_ngaysinh.TabIndex = 6;
            // 
            // txt_cancuoc
            // 
            txt_cancuoc.Enabled = false;
            txt_cancuoc.Location = new Point(821, 212);
            txt_cancuoc.Margin = new Padding(2);
            txt_cancuoc.Name = "txt_cancuoc";
            txt_cancuoc.Size = new Size(302, 31);
            txt_cancuoc.TabIndex = 5;
            txt_cancuoc.TextChanged += txt_tim_TextChanged_1;
            // 
            // txt_diachi
            // 
            txt_diachi.Enabled = false;
            txt_diachi.Location = new Point(821, 156);
            txt_diachi.Margin = new Padding(2);
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(302, 31);
            txt_diachi.TabIndex = 5;
            txt_diachi.TextChanged += txt_tim_TextChanged_1;
            // 
            // txt_email
            // 
            txt_email.Enabled = false;
            txt_email.Location = new Point(821, 101);
            txt_email.Margin = new Padding(2);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(302, 31);
            txt_email.TabIndex = 5;
            txt_email.TextChanged += txt_tim_TextChanged_1;
            // 
            // txt_sdt
            // 
            txt_sdt.Enabled = false;
            txt_sdt.Location = new Point(821, 48);
            txt_sdt.Margin = new Padding(2);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(302, 31);
            txt_sdt.TabIndex = 5;
            txt_sdt.TextChanged += txt_tim_TextChanged_1;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(668, 215);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(85, 25);
            label8.TabIndex = 2;
            label8.Text = "Căn cước";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(668, 159);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(65, 25);
            label7.TabIndex = 2;
            label7.Text = "Địa chỉ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(668, 104);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 2;
            label6.Text = "Email";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_ten
            // 
            txt_ten.Enabled = false;
            txt_ten.Location = new Point(259, 98);
            txt_ten.Margin = new Padding(2);
            txt_ten.Name = "txt_ten";
            txt_ten.Size = new Size(302, 31);
            txt_ten.TabIndex = 5;
            txt_ten.TextChanged += txt_tim_TextChanged_1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(668, 51);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(117, 25);
            label5.TabIndex = 2;
            label5.Text = "Số điện thoại";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_hodem
            // 
            txt_hodem.Enabled = false;
            txt_hodem.Location = new Point(259, 45);
            txt_hodem.Margin = new Padding(2);
            txt_hodem.Name = "txt_hodem";
            txt_hodem.Size = new Size(302, 31);
            txt_hodem.TabIndex = 5;
            txt_hodem.TextChanged += txt_tim_TextChanged_1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(106, 218);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 2;
            label4.Text = "Giới tính";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_tim
            // 
            txt_tim.Location = new Point(254, 338);
            txt_tim.Margin = new Padding(2);
            txt_tim.Name = "txt_tim";
            txt_tim.Size = new Size(302, 31);
            txt_tim.TabIndex = 5;
            txt_tim.TextChanged += txt_tim_TextChanged_1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(106, 159);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(786, 331);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(138, 42);
            button1.TabIndex = 4;
            button1.Text = "Làm mới";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(106, 101);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 25);
            label2.TabIndex = 2;
            label2.Text = "Tên";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(106, 48);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 2;
            label1.Text = "Họ đệm";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bt_them
            // 
            bt_them.Location = new Point(579, 331);
            bt_them.Margin = new Padding(2);
            bt_them.Name = "bt_them";
            bt_them.Size = new Size(146, 42);
            bt_them.TabIndex = 4;
            bt_them.Text = "Thêm";
            bt_them.UseVisualStyleBackColor = true;
            bt_them.Click += bt_them_Click_1;
            // 
            // lb_tim
            // 
            lb_tim.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lb_tim.AutoSize = true;
            lb_tim.Location = new Point(101, 340);
            lb_tim.Margin = new Padding(2, 0, 2, 0);
            lb_tim.Name = "lb_tim";
            lb_tim.Size = new Size(84, 25);
            lb_tim.TabIndex = 2;
            lb_tim.Text = "Tìm kiếm";
            lb_tim.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgv_customer
            // 
            dgv_customer.AllowUserToAddRows = false;
            dgv_customer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_customer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_customer.Columns.AddRange(new DataGridViewColumn[] { CustomerID, LastName, FirstName, Gender, DOB, PhoneNumber, Email, Address, IDCard, Action });
            dgv_customer.Location = new Point(2, 399);
            dgv_customer.Margin = new Padding(2);
            dgv_customer.Name = "dgv_customer";
            dgv_customer.ReadOnly = true;
            dgv_customer.RowHeadersWidth = 62;
            dgv_customer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_customer.Size = new Size(1316, 282);
            dgv_customer.TabIndex = 0;
            dgv_customer.CellClick += dgv_customer_CellClick;
            dgv_customer.CellEnter += dgv_customer_CellEnter;
            dgv_customer.CellPainting += dgv_customer_CellPainting;
            // 
            // CustomerID
            // 
            CustomerID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CustomerID.DataPropertyName = "CustomerID";
            CustomerID.FillWeight = 14F;
            CustomerID.HeaderText = "Mã KH";
            CustomerID.MinimumWidth = 8;
            CustomerID.Name = "CustomerID";
            CustomerID.ReadOnly = true;
            // 
            // LastName
            // 
            LastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LastName.DataPropertyName = "LastName";
            LastName.FillWeight = 20F;
            LastName.HeaderText = "Họ đệm";
            LastName.MinimumWidth = 8;
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            // 
            // FirstName
            // 
            FirstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FirstName.DataPropertyName = "FirstName";
            FirstName.FillWeight = 10F;
            FirstName.HeaderText = "Tên";
            FirstName.MinimumWidth = 8;
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            // 
            // Gender
            // 
            Gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Gender.DataPropertyName = "Gender";
            Gender.FillWeight = 14.9F;
            Gender.HeaderText = "Giới tính";
            Gender.MinimumWidth = 8;
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            // 
            // DOB
            // 
            DOB.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DOB.DataPropertyName = "DOB";
            DOB.FillWeight = 21.23967F;
            DOB.HeaderText = "Ngày sinh";
            DOB.MinimumWidth = 8;
            DOB.Name = "DOB";
            DOB.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            PhoneNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PhoneNumber.DataPropertyName = "PhoneNumber";
            PhoneNumber.FillWeight = 18F;
            PhoneNumber.HeaderText = "SĐT";
            PhoneNumber.MinimumWidth = 8;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.DataPropertyName = "Email";
            Email.FillWeight = 21.23967F;
            Email.HeaderText = "Email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Address
            // 
            Address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Address.DataPropertyName = "Address";
            Address.FillWeight = 21.23967F;
            Address.HeaderText = "Địa chỉ";
            Address.MinimumWidth = 8;
            Address.Name = "Address";
            Address.ReadOnly = true;
            // 
            // IDCard
            // 
            IDCard.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IDCard.DataPropertyName = "IDCard";
            IDCard.FillWeight = 21.23967F;
            IDCard.HeaderText = "Căn cước";
            IDCard.MinimumWidth = 8;
            IDCard.Name = "IDCard";
            IDCard.ReadOnly = true;
            // 
            // Action
            // 
            Action.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Action.FillWeight = 13F;
            Action.HeaderText = "";
            Action.Name = "Action";
            Action.ReadOnly = true;
            // 
            // Frm_Customer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1328, 692);
            Controls.Add(tlp_qlttkh);
            Margin = new Padding(2);
            Name = "Frm_Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông Tin Khách Hàng";
            Load += Frm_Customer_Load;
            tlp_qlttkh.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_customer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp_qlttkh;
        private DataGridView dgv_customer;
        private Panel panel1;
        private Button bt_them;
        private Label lb_tim;
        private TextBox txt_tim;
        private TextBox txt_cancuoc;
        private TextBox txt_diachi;
        private TextBox txt_email;
        private TextBox txt_sdt;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txt_ten;
        private Label label5;
        private TextBox txt_hodem;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private ComboBox comboBox_gioitinh;
        private DateTimePicker dtp_ngaysinh;
        private Button btt_QLTK;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn DOB;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn IDCard;
        private DataGridViewTextBoxColumn Action;
    }
}