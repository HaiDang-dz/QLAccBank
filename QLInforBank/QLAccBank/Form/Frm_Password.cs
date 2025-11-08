using QLAccBank.Class;

namespace QLAccBank
{
    public partial class Frm_Password : Form
    {
        private Dictionary<string, string> members = GlobalData.Members;
        private string username;

        public Frm_Password(Dictionary<string, string> membersDict, string user)
        {
            InitializeComponent();
            members = membersDict;
            username = user;
        }

        private void btt_DoiMatKhau2_Click(object sender, EventArgs e)
        {
            string oldPass = txt_MatKhauCu.Text.Trim();
            string newPass = txt_MatKhauMoi.Text.Trim();
            string confirmPass = txt_NhapLaiMatKhau.Text.Trim();

            if (oldPass == "" || newPass == "" || confirmPass == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!members.ContainsKey(username) || members[username] != oldPass)
            {
                MessageBox.Show("Mật khẩu cũ không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ✅ Cập nhật tạm thời mật khẩu trong Dictionary
            members[username] = newPass;

            MessageBox.Show("Đổi mật khẩu thành công!",
                            "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btt_Huy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn hủy không?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 🧹 Xóa toàn bộ nội dung trong textbox
                txt_MatKhauCu.Clear();
                txt_MatKhauMoi.Clear();
                txt_NhapLaiMatKhau.Clear();

                // Đưa con trỏ về ô nhập đầu tiên (nếu muốn)
                txt_MatKhauCu.Focus();
            }
            // Nếu chọn No thì không làm gì cả
        }

        private void Frm_Password_Load(object sender, EventArgs e)
        {

        }
    }
}
