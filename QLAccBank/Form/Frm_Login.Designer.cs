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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            txt_username = new TextBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            txt_password = new TextBox();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            bt_login = new Button();
            bt_exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.people;
            pictureBox1.Location = new Point(96, 48);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_username);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(12, 137);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 25);
            panel1.TabIndex = 0;
            // 
            // txt_username
            // 
            txt_username.BackColor = SystemColors.ButtonFace;
            txt_username.BorderStyle = BorderStyle.None;
            txt_username.Location = new Point(24, -1);
            txt_username.Margin = new Padding(2);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(222, 20);
            txt_username.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(2, 19);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(246, 1);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.account;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 18);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(txt_password);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(12, 174);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(251, 25);
            panel3.TabIndex = 1;
            // 
            // txt_password
            // 
            txt_password.BackColor = SystemColors.ButtonFace;
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Location = new Point(24, -1);
            txt_password.Margin = new Padding(2);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(222, 20);
            txt_password.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(2, 19);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(246, 1);
            panel4.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.password;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 18);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // bt_login
            // 
            bt_login.BackColor = SystemColors.ButtonShadow;
            bt_login.Location = new Point(10, 222);
            bt_login.Margin = new Padding(2);
            bt_login.Name = "bt_login";
            bt_login.Size = new Size(254, 39);
            bt_login.TabIndex = 2;
            bt_login.Text = "Login";
            bt_login.UseVisualStyleBackColor = false;
            bt_login.Click += bt_login_Click;
            // 
            // bt_exit
            // 
            bt_exit.BackColor = SystemColors.ButtonShadow;
            bt_exit.Location = new Point(12, 273);
            bt_exit.Margin = new Padding(2);
            bt_exit.Name = "bt_exit";
            bt_exit.Size = new Size(251, 39);
            bt_exit.TabIndex = 3;
            bt_exit.Text = "Exit";
            bt_exit.UseVisualStyleBackColor = false;
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 363);
            Controls.Add(bt_exit);
            Controls.Add(bt_login);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "Frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox txt_username;
        private Panel panel3;
        private TextBox txt_password;
        private Panel panel4;
        private PictureBox pictureBox3;
        private Button bt_login;
        private Button bt_exit;
    }
}