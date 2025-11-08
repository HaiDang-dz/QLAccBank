using QLAccBank.Class;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QLAccBank
{
    public partial class Frm_Login : Form
    {
        private Dictionary<string, string> members = GlobalData.Members;

        public Frm_Login()
        {
            InitializeComponent();
        }

        public void ResetLoginInfo()
        {
            txt_username.Text = "";
            txt_password.Text = "";
            txt_username.Focus(); // đưa con trỏ về ô username
        }
        private void bt_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text.Trim();
            string password = txt_password.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập!",
                                "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem username có trong danh sách thành viên không
            if (GlobalData.Members.ContainsKey(username))
            {
                if (GlobalData.Members[username] == password)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Members currentMember = null;

                    // Nếu người dùng có trong danh sách thông tin (cũ hoặc mới)
                    if (GlobalData.MemberInfo.ContainsKey(username))
                    {
                        currentMember = GlobalData.MemberInfo[username];
                    }
                    else
                    {
                        // Không có thông tin chi tiết -> dùng mặc định
                        currentMember = new Members(
                            "Người dùng không xác định",
                            "Không có",
                            "Không có",
                            "Không có",
                            DateTime.Now,
                            "default_avatar"
                        );
                    }

                    //Mở form Members, truyền dữ liệu
                    Frm_Members frm = new Frm_Members(currentMember, GlobalData.Members, username, this);
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập không tồn tại!",
                                "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void bt_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}