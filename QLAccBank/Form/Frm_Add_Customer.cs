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
                this.Text = "CẬP";

                txtMaKhachHang.Text = customer.CustomerID;
                txtHoTen.Text = $"{customer.LastName} {customer.FirstName}";
                dateTimePickerDOB.Value = customer.DOB;
                cboGioiTinh.SelectedIndex = Convert.ToInt32(customer.Gender);
                txtSoDienThoai.Text = customer.PhoneNumber;
                txtSoCanCuoc.Text = customer.IDCard;
            }
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
                returnCustomer.Gender = cboGioiTinh.SelectedIndex.ToString();
                returnCustomer.IDCard = txtSoCanCuoc.Text;

                DialogResult = DialogResult.OK;  // 🔹 báo cho form cha biết là “OK”
                this.Close();
            }
            else
            {
                returnCustomer = null;
                MessageBox.Show("Email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
