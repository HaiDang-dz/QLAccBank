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

namespace QLAccBank
{
    public partial class Frm_BankAccount : Form
    {
        private List<BankAccount> BankAccountList = new List<BankAccount>();
        public Frm_BankAccount()
        {
            InitializeComponent();
            dgv_BankAccount.AutoGenerateColumns = false;

            dgv_BankAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_BankAccount.MultiSelect = false;

            // --- BẮT BUỘC: map DataPropertyName cho từng column (tên phải khớp với DataTable column keys)
            // Giả sử m đã tạo các column trong Designer và đặt Name tương ứng:
            // colAccountNumber, colCustomerID, colCustomerName, colAccountType, colBalance, colOpenDate, colIsActive

            AccountNumber.DataPropertyName = "AccountNumber";
            CustomerID.DataPropertyName = "CustomerID";
            CustomerName.DataPropertyName = "CustomerName";
            AccountType.DataPropertyName = "AccountType";
            Balance.DataPropertyName = "Balance";
            OpenDate.DataPropertyName = "OpenDate";
            IsActive.DataPropertyName = "IsActive";
        }

        private void dgv_BankAccount_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgv_BankAccount.Rows[e.RowIndex];
            if (row == null) return;

            // Lấy dữ liệu từ các cột
            txt_STK.Text = row.Cells["AccountNumber"].Value?.ToString() ?? "";
            txt_MaKH.Text = row.Cells["CustomerID"].Value?.ToString() ?? "";

            // Loại tài khoản - ComboBox
            txt_loaiTK.Text = row.Cells["AccountType"].Value?.ToString() ?? "";

            // Số dư
            txt_SoDu.Text = row.Cells["Balance"].Value?.ToString() ?? "";

            // Ngày mở - DateTimePicker
            if (DateTime.TryParse(row.Cells["OpenDate"].Value?.ToString(), out DateTime openDate))
                datetime.Value = openDate;
            else
                datetime.Value = DateTime.Now;

            // Trạng thái hoạt động - ComboBox
            txt_tthd.Text = row.Cells["IsActive"].Value?.ToString() ?? "";
        }

        private void Frm_BankAccount_Load(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            List<Customer> customers = cus.GetListFormCSV(); // 🔹 Lấy danh sách khách hàng

            BankAccount acc = new BankAccount();
            BankAccountList = acc.GetBankAccListFromCSV();   // 🔹 Lấy danh sách tài khoản

            DataTable dt = acc.ToDataTable(BankAccountList, customers); // 🔹 Ghép 2 danh sách

            dgv_BankAccount.DataSource = dt;
        }

        private void dgv_BankAccount_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_BankAccount.Columns[e.ColumnIndex].Name == "Balance" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal val))
                {
                    e.Value = val.ToString("#,##0", new System.Globalization.CultureInfo("vi-VN")) + " VNĐ";
                    e.FormattingApplied = true;
                }
            }
        }

        private void txt_tim_TextChanged(object sender, EventArgs e)
        {
            string filterText = txt_tim.Text.Trim().ToLower();

            // Nếu chưa có danh sách, thoát sớm
            if (BankAccountList == null || BankAccountList.Count == 0)
                return;

            // Lấy lại danh sách khách hàng để join tên (vì trong acc chỉ có ID)
            Customer cus = new Customer();
            List<Customer> customers = cus.GetListFormCSV();

            List<BankAccount> filtered;

            if (string.IsNullOrEmpty(filterText))
            {
                // Hiển thị lại toàn bộ
                filtered = BankAccountList;
            }
            else
            {
                // Lọc theo số tài khoản, mã KH, tên KH
                filtered = BankAccountList.Where(a =>
                {
                    // tìm khách hàng tương ứng
                    var customer = customers.FirstOrDefault(c => c.CustomerID == a.CustomerID);
                    string fullName = customer != null ? $"{customer.LastName} {customer.FirstName}".ToLower() : "";

                    return a.AccountNumber.ToLower().Contains(filterText)
                        || a.CustomerID.ToLower().Contains(filterText)
                        || fullName.Contains(filterText);
                }).ToList();
            }

            // Tạo lại DataTable để hiển thị
            BankAccount acc = new BankAccount();
            DataTable dt = acc.ToDataTable(filtered, customers);
            dgv_BankAccount.DataSource = dt;
        }
    }
}
