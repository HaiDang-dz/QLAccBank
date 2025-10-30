using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLAccBank
{
    public partial class Frm_Login : Form
    {
        Dictionary<string, string> members = new Dictionary<string, string>()
        {
            { "nguyenhaidang", "2003" },
            { "nguyendamkhanhdoan", "2005" },
            { "ledoanbaohuy", "2005" }
        };
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text.Trim();
            string password = txt_password.Text.Trim();

            if (members.ContainsKey(username))
            {
                if (members[username] == password)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Ẩn form đăng nhập, mở form chính
                    Frm_Customer main = new Frm_Customer();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu!", "Vui lòng nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập không tồn tại!", "Vui lòng nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
