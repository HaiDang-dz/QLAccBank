using QLAccBank.Class;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QLAccBank
{
    public partial class Frm_Members : Form
    {
        private Members currentMember;
        private Dictionary<string, string> members = GlobalData.Members;
        private string username;
        private Frm_Login loginForm; // Giữ form Login để quay lại

        public Frm_Members(Members member, Dictionary<string, string> membersDict, string user, Frm_Login login)
        {
            InitializeComponent();
            currentMember = member;
            members = membersDict;
            username = user;
            loginForm = login;
        }

        // Khi form load

        // Bật/Tắt chế độ chỉnh sửa
        private void SetEditMode(bool isEditing)
        {
            txt_HoVaTen.ReadOnly = !isEditing;
            txt_Email.ReadOnly = !isEditing;
            txt_SDT.ReadOnly = !isEditing;
            txt_ChucVu.ReadOnly = !isEditing;
            datetime_NgayVao.Enabled = isEditing;

            btt_Sua.Enabled = !isEditing;
            btt_CapNhat.Enabled = isEditing;
        }

        // Nút Sửa
        private void btt_Sua_Click(object sender, EventArgs e)
        {
            SetEditMode(true);
            txt_HoVaTen.Enabled = true;
            txt_Email.Enabled = true;
            txt_SDT.Enabled = true;
            txt_ChucVu.Enabled = true;
            datetime_NgayVao.Enabled = true;
            btt_Sua.Enabled = true;
        }

        // Nút Cập nhật
        private void btt_CapNhat_Click(object sender, EventArgs e)
        {
            currentMember.FullName = txt_HoVaTen.Text.Trim();
            currentMember.Email = txt_Email.Text.Trim();
            currentMember.Phone = txt_SDT.Text.Trim();
            currentMember.Position = txt_ChucVu.Text.Trim();
            currentMember.JoinDate = datetime_NgayVao.Value;

            MessageBox.Show("Cập nhật thông tin thành công!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SetEditMode(false);
            txt_HoVaTen.Enabled = false;
            txt_Email.Enabled = false;
            txt_SDT.Enabled = false;
            txt_ChucVu.Enabled = false;
            datetime_NgayVao.Enabled = false;
        }

        // Nút Trang chủ
        private void btt_QuanLyKhachHang_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn muốn qua trang quản lý khách hàng?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Frm_Customer frmCustomer = new Frm_Customer();
                frmCustomer.ShowDialog();
                this.Show();
            }
        }

        // Nút Đăng xuất
        private void btt_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất không?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Frm_Login newlogin = new Frm_Login();
                newlogin.ShowDialog();
                this.Close();
                newlogin.ResetLoginInfo();
            }
        }

        // Nút Đổi mật khẩu
        private void btt_DoiMatKhau_Click(object sender, EventArgs e)
        {
            Frm_Password frm = new Frm_Password(members, username);
            frm.ShowDialog();
        }

        private void Frm_Members_Load(object sender, EventArgs e)
        {
            // Khóa các textbox khi vừa mở
            txt_HoVaTen.Text = currentMember.FullName;
            txt_HoVaTen.Enabled = false;

            txt_Email.Text = currentMember.Email;
            txt_Email.Enabled = false;

            txt_SDT.Text = currentMember.Phone;
            txt_SDT.Enabled = false;

            txt_ChucVu.Text = currentMember.Position;
            txt_ChucVu.Enabled = false;

            datetime_NgayVao.Value = currentMember.JoinDate;
            datetime_NgayVao.Enabled = false;

            btt_CapNhat.Enabled = false;

            // Hiển thị ảnh đại diện
            Image avatarImage = null;

            // Trường hợp dùng ảnh có sẵn trong Resources
            switch (currentMember.AvatarPath)
            {
                case "dang":
                    avatarImage = Properties.Resources.dang;
                    break;
                case "doan":
                    avatarImage = Properties.Resources.doan;
                    break;
                case "huy":
                    avatarImage = Properties.Resources.huy;
                    break;
                case "default_avatar":
                    avatarImage = Properties.Resources.default_avatar;
                    break;
            }

            // Trường hợp người dùng mới thêm và chọn ảnh từ file
            if (avatarImage == null && !string.IsNullOrEmpty(currentMember.AvatarPath))
            {
                try
                {
                    if (File.Exists(currentMember.AvatarPath))
                        avatarImage = Image.FromFile(currentMember.AvatarPath);
                }
                catch (Exception)
                {
                    avatarImage = Properties.Resources.default_avatar; // fallback an toàn
                }
            }

            //  Gán ảnh vào PictureBox (nếu vẫn null thì dùng ảnh mặc định)
            pic_Avatar.Image = avatarImage ?? Properties.Resources.default_avatar;
            pic_Avatar.SizeMode = PictureBoxSizeMode.Zoom;
        }


        private void btt_ThemNguoiDung_Click(object sender, EventArgs e)
        {
            Frm_Add_Employee frmAdd = new Frm_Add_Employee(members);
            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Người dùng mới đã được thêm! Hãy đăng xuất và đăng nhập lại để sử dụng tài khoản này.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
