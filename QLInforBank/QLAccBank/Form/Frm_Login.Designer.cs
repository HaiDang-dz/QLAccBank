namespace QLAccBank
{
    partial class Frm_Login
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            bt_exit = new Button();
            bt_login = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            txt_password = new TextBox();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            txt_username = new TextBox();
            panel5 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.926487F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.073513F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel6, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 720F));
            tableLayoutPanel1.Size = new Size(922, 720);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(bt_exit);
            panel1.Controls.Add(bt_login);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(564, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 716);
            panel1.TabIndex = 0;
            // 
            // bt_exit
            // 
            bt_exit.BackColor = Color.LightSeaGreen;
            bt_exit.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_exit.ForeColor = Color.White;
            bt_exit.Location = new Point(200, 466);
            bt_exit.Margin = new Padding(2);
            bt_exit.Name = "bt_exit";
            bt_exit.Size = new Size(135, 49);
            bt_exit.TabIndex = 8;
            bt_exit.Text = "Thoát";
            bt_exit.UseVisualStyleBackColor = false;
            bt_exit.Click += bt_exit_Click_1;
            // 
            // bt_login
            // 
            bt_login.BackColor = Color.LightSeaGreen;
            bt_login.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_login.ForeColor = Color.White;
            bt_login.Location = new Point(23, 466);
            bt_login.Margin = new Padding(2);
            bt_login.Name = "bt_login";
            bt_login.Size = new Size(135, 49);
            bt_login.TabIndex = 7;
            bt_login.Text = "Đăng Nhập";
            bt_login.UseVisualStyleBackColor = false;
            bt_login.Click += bt_login_Click_1;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(txt_password);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(21, 355);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(314, 42);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(4, 39);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(308, 1);
            panel4.TabIndex = 1;
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.WhiteSmoke;
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Location = new Point(36, 8);
            txt_password.Margin = new Padding(2);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(274, 20);
            txt_password.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.password;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(txt_username);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(21, 259);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(314, 48);
            panel2.TabIndex = 4;
            // 
            // txt_username
            // 
            txt_username.BackColor = Color.WhiteSmoke;
            txt_username.BorderStyle = BorderStyle.None;
            txt_username.ForeColor = SystemColors.WindowText;
            txt_username.Location = new Point(36, 16);
            txt_username.Margin = new Padding(2);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(274, 20);
            txt_username.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(2, 44);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(308, 1);
            panel5.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.account;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.people;
            pictureBox1.Location = new Point(126, 79);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightSeaGreen;
            panel6.Controls.Add(pictureBox4);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(label1);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 2);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(555, 716);
            panel6.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.qrcode_273473963_a9324a39fb640b3afb54072243cc7f29;
            pictureBox4.Location = new Point(140, 385);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(249, 201);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(79, 22);
            label3.Name = "label3";
            label3.Size = new Size(82, 32);
            label3.TabIndex = 1;
            label3.Text = "BANK";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 22);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 1;
            label2.Text = "HOCBA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(65, 261);
            label4.Name = "label4";
            label4.Size = new Size(403, 46);
            label4.TabIndex = 0;
            label4.Text = "Chào mừng các bạn đã đến với dự án mang tên \r\nquản lý tài khoản ngân hàng của nhóm Học Bá\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(65, 150);
            label1.Name = "label1";
            label1.Size = new Size(80, 59);
            label1.TabIndex = 0;
            label1.Text = "HI!";
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(922, 720);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "Frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button bt_exit;
        private Button bt_login;
        private Panel panel3;
        private TextBox txt_password;
        private Panel panel4;
        private PictureBox pictureBox3;
        private Panel panel2;
        private TextBox txt_username;
        private Panel panel5;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel6;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private PictureBox pictureBox4;
    }
}