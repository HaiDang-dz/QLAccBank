namespace QLAccBank
{
    partial class Frm_Password
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_MatKhauCu = new TextBox();
            txt_MatKhauMoi = new TextBox();
            txt_NhapLaiMatKhau = new TextBox();
            btt_DoiMatKhau2 = new Button();
            btt_Huy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(121, 9);
            label1.Name = "label1";
            label1.Size = new Size(173, 31);
            label1.TabIndex = 0;
            label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 78);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu cũ: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 136);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu mới: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 201);
            label4.Name = "label4";
            label4.Size = new Size(137, 20);
            label4.TabIndex = 3;
            label4.Text = "Nhập lại mật khẩu: ";
            // 
            // txt_MatKhauCu
            // 
            txt_MatKhauCu.Location = new Point(151, 71);
            txt_MatKhauCu.Name = "txt_MatKhauCu";
            txt_MatKhauCu.Size = new Size(242, 27);
            txt_MatKhauCu.TabIndex = 4;
            // 
            // txt_MatKhauMoi
            // 
            txt_MatKhauMoi.Location = new Point(151, 129);
            txt_MatKhauMoi.Name = "txt_MatKhauMoi";
            txt_MatKhauMoi.Size = new Size(242, 27);
            txt_MatKhauMoi.TabIndex = 5;
            // 
            // txt_NhapLaiMatKhau
            // 
            txt_NhapLaiMatKhau.Location = new Point(151, 198);
            txt_NhapLaiMatKhau.Name = "txt_NhapLaiMatKhau";
            txt_NhapLaiMatKhau.Size = new Size(242, 27);
            txt_NhapLaiMatKhau.TabIndex = 6;
            // 
            // btt_DoiMatKhau2
            // 
            btt_DoiMatKhau2.Location = new Point(37, 289);
            btt_DoiMatKhau2.Name = "btt_DoiMatKhau2";
            btt_DoiMatKhau2.Size = new Size(166, 44);
            btt_DoiMatKhau2.TabIndex = 7;
            btt_DoiMatKhau2.Text = "Đổi mật khẩu ";
            btt_DoiMatKhau2.UseVisualStyleBackColor = true;
            btt_DoiMatKhau2.Click += btt_DoiMatKhau2_Click;
            // 
            // btt_Huy
            // 
            btt_Huy.Location = new Point(209, 289);
            btt_Huy.Name = "btt_Huy";
            btt_Huy.Size = new Size(166, 44);
            btt_Huy.TabIndex = 8;
            btt_Huy.Text = "Hủy ";
            btt_Huy.UseVisualStyleBackColor = true;
            btt_Huy.Click += btt_Huy_Click;
            // 
            // Frm_Password
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 431);
            Controls.Add(btt_Huy);
            Controls.Add(btt_DoiMatKhau2);
            Controls.Add(txt_NhapLaiMatKhau);
            Controls.Add(txt_MatKhauMoi);
            Controls.Add(txt_MatKhauCu);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Frm_Password";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Password";
            Load += Frm_Password_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_MatKhauCu;
        private TextBox txt_MatKhauMoi;
        private TextBox txt_NhapLaiMatKhau;
        private Button btt_DoiMatKhau2;
        private Button btt_Huy;
    }
}