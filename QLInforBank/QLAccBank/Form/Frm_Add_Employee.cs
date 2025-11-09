using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLAccBank.Class;

namespace QLAccBank
{
    public partial class Frm_Add_Employee : Form
    {
        private Dictionary<string, string> members = GlobalData.Members;
        public Members NewMember { get; private set; } // trả về thông tin nhân viên mới

        public Frm_Add_Employee(Dictionary<string, string> membersDict)
        {
            InitializeComponent();
            members = membersDict;
        }

        private void Frm_AddEmployee_Load(object sender, EventArgs e)
        {
            datetime_NgayVao.Format = DateTimePickerFormat.Custom;
            datetime_NgayVao.CustomFormat = "dd/MM/yyyy";
        }

        private void btt_ChonHinhAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pic_Avatar.Image = Image.FromFile(ofd.FileName);
                    pic_Avatar.Tag = ofd.FileName; // lưu đường dẫn ảnh
                }
            }
        }

        private void btt_Luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TenDangNhap.Text) ||
                string.IsNullOrWhiteSpace(txt_MatKhau.Text) ||
                string.IsNullOrWhiteSpace(txt_HoVaTen.Text) ||
                string.IsNullOrWhiteSpace(txt_ChucVu.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!",
                                "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = txt_TenDangNhap.Text.Trim();
            string password = txt_MatKhau.Text.Trim();

            // Kiểm tra trùng tên đăng nhập
            if (GlobalData.Members.ContainsKey(username))
            {
                MessageBox.Show("Tên đăng nhập này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ✅ Lưu vào danh sách tạm
            GlobalData.Members.Add(username, password);

            // ✅ Lưu thông tin nhân viên chi tiết
            GlobalData.MemberInfo[username] = new Members(
                txt_HoVaTen.Text.Trim(),
                txt_Email.Text.Trim(),
                txt_SDT.Text.Trim(),
                txt_ChucVu.Text.Trim(),
                datetime_NgayVao.Value,
                pic_Avatar.Tag?.ToString() ?? "default_avatar" // có thể là đường dẫn ảnh
            );

            MessageBox.Show("Thêm người dùng thành công!\n(Tài khoản này sẽ bị mất khi tắt chương trình.)",
                            "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btt_Huy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn hủy thao tác này không?",
                "Xác nhận hủy",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
