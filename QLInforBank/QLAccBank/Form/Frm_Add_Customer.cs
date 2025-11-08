 using QLAccBank.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QLAccBank
{
    public partial class Frm_Add_Customer : Form
    {
        public Customer returnCustomer { get; private set; } // Public property to hold the return value

        public Frm_Add_Customer()
        {
            InitializeComponent();
            txtHoTen.Enabled = true;
            cboGioiTinh.Text = "Chọn giới tính";
            btnXacNhan.Text = "Thêm mới";
            this.Text = "THÊM MỚI KHÁCH HÀNG";
        }


        public Frm_Add_Customer(Customer customer)
        {
            InitializeComponent();
            if (customer != null)
            {
                txtHoTen.Enabled = false;
                btnXacNhan.Text = "Cập nhật";
                this.Text = "CẬP NHẬT KHÁCH HÀNG";

                txtMaKhachHang.Text = customer.CustomerID;
                txtHoTen.Text = $"{customer.LastName} {customer.FirstName}";
                dateTimePickerDOB.Value = customer.DOB;
                cboGioiTinh.SelectedIndex = Convert.ToInt32(customer.Gender);
                txtSoDienThoai.Text = customer.PhoneNumber;
                txtSoCanCuoc.Text = customer.IDCard;
            }
        }

        private void TaoSoTaiKhoan()
        {
            if (combobox_loaithe.SelectedIndex == -1) return; // Chưa chọn loại thẻ
            string prefix = "232";
            if (combobox_loaithe.Text == "thanh toán")
                prefix += "01";
            else if (combobox_loaithe.Text == "tính dụng")
                prefix += "02";
            else if (combobox_loaithe.Text == "tiết kiệm")
                prefix += "03";

            Random rand = new Random();
            string randomNumber = rand.Next(0, 100000000).ToString("D8"); // 8 số
            txt_sotaikhoan.Text = prefix + randomNumber;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            returnCustomer = new Customer();
            returnCustomer.Email = txtEmail.Text;
            bool isEmail = returnCustomer.IsEmail();
            if (isEmail)
            {
                var (ho, ten) = myString.TachHoTen(txtHoTen.Text);
                returnCustomer.LastName = ho;
                returnCustomer.FirstName = ten;
                returnCustomer.DOB = dateTimePickerDOB.Value.Date;
                returnCustomer.PhoneNumber = txtSoDienThoai.Text;
                returnCustomer.Gender = cboGioiTinh.Text;
                returnCustomer.Address = txtDiaChi.Text;
                returnCustomer.IDCard = txtSoCanCuoc.Text;
                // Gán CustomerID từ textbox (đã tự động điền)
                returnCustomer.CustomerID = txtMaKhachHang.Text;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                returnCustomer = null;
                MessageBox.Show("Email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Tạo tài khoản ngân hàng mới
            // Tạo đối tượng BankAccount mới
            BankAccount newAccount = new BankAccount();
            newAccount.AccountNumber = txt_sotaikhoan.Text;       // Số tài khoản random
            newAccount.AccountType = combobox_loaithe.Text;           // Loại tài khoản
            newAccount.CustomerID = returnCustomer.CustomerID;  // Liên kết với Customer
            newAccount.HoDem = returnCustomer.LastName;        // Họ đệm từ Customer
            newAccount.Ten = returnCustomer.FirstName;         // Tên từ Customer
            newAccount.Balance = 0;                             // Số dư mặc định
            newAccount.OpenDate = DateTime.Now;                // Ngày mở tài khoản là hiện tại
            newAccount.IsActive = true;                        // Mặc định tài khoản hoạt động

            // Lưu vào Frm_BankAccount
            Frm_AccountBank frmBank = Application.OpenForms.OfType<Frm_AccountBank>().FirstOrDefault();
            if (frmBank != null)
            {
                frmBank.BankAccountList.Add(newAccount);
                frmBank.UpdateDataGridView(); // Hàm refresh dgv_accountbank
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void combobox_loaithe_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaoSoTaiKhoan();
        }
    }
}
