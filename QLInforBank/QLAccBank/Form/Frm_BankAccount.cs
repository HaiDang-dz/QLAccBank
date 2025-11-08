using QLAccBank.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace QLAccBank
{
    public partial class Frm_BankAccount : Form
    {
        private List<BankAccount> BankAccountList = new List<BankAccount>();
        private List<Customer> CustomerList = new List<Customer>();
<<<<<<< HEAD

        public Frm_BankAccount()
        {
            InitializeComponent();

            // DataGridView tài khoản
            dgv_BankAccount.AutoGenerateColumns = false;
            dgv_BankAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_BankAccount.MultiSelect = false;

            // DataGridView lịch sử giao dịch
            dgv_HistoryBankAccount.AutoGenerateColumns = true;
            dgv_HistoryBankAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_HistoryBankAccount.MultiSelect = false;

            // Map cột cho dgv_BankAccount
            AccountNumber1.DataPropertyName = "AccountNumber";
            CustomerID.DataPropertyName = "CustomerID";
            AccountType.DataPropertyName = "AccountType";
            Balance.DataPropertyName = "Balance";
            OpenDate.DataPropertyName = "OpenDate";
            IsActive.DataPropertyName = "IsActive";
        }

        private void Frm_BankAccount_Load(object sender, EventArgs e)
        {
            // Load khách hàng
            Customer cus = new Customer();
            CustomerList = cus.GetListFormCSV();

            // Load tài khoản
            BankAccount acc = new BankAccount();
            BankAccountList = acc.GetBankAccListFromCSV();

            // Hiển thị danh sách tài khoản
            DataTable dt = acc.ToDataTable(BankAccountList, CustomerList);
            dgv_BankAccount.DataSource = dt;
        }

        private void txt_Tim_TextChanged(object sender, EventArgs e)
        {
            string filterText = txt_Tim.Text.Trim().ToLower();
            if (BankAccountList == null || BankAccountList.Count == 0) return;

            List<BankAccount> filtered = string.IsNullOrEmpty(filterText)
                ? BankAccountList
                : BankAccountList.Where(a =>
                {
                    var customer = CustomerList.FirstOrDefault(c => c.CustomerID == a.CustomerID);
                    string fullName = customer != null ? $"{customer.LastName} {customer.FirstName}".ToLower() : "";
                    return a.AccountNumber.ToLower().Contains(filterText)
                        || a.CustomerID.ToLower().Contains(filterText)
                        || fullName.Contains(filterText);
                }).ToList();

            DataTable dt = new BankAccount().ToDataTable(filtered, CustomerList);
            dgv_BankAccount.DataSource = dt;
        }

        private void dgv_BankAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                // Lấy số tài khoản từ cột AccountNumber
                string accountNumber = dgv_BankAccount.Rows[e.RowIndex].Cells["AccountNumber1"].Value.ToString();

                // Load giao dịch
                HistoryTransaction ht = new HistoryTransaction();
                var historyList = ht.GetList("Data/HistoryTransactionFile.csv", accountNumber);

                // Gán dữ liệu trực tiếp vào dgv_HistoryBankAccount
                dgv_HistoryBankAccount.DataSource = null;
                dgv_HistoryBankAccount.DataSource = historyList;

                // Format tiền và ngày tháng
                if (dgv_HistoryBankAccount.Columns.Contains("Amount"))
                    dgv_HistoryBankAccount.Columns["Amount"].DefaultCellStyle.Format = "#,##0 VNĐ";

                if (dgv_HistoryBankAccount.Columns.Contains("TransactionDate"))
                    dgv_HistoryBankAccount.Columns["TransactionDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lịch sử giao dịch: " + ex.Message);
            }
        }

        private void dgv_BankAccount_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_BankAccount.Columns[e.ColumnIndex].Name == "Balance" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal val))
                {
                    e.Value = val.ToString("#,##0", new CultureInfo("vi-VN")) + " VNĐ";
                    e.FormattingApplied = true;
                }
            }
        }
=======
        public Frm_BankAccount()
        {
            InitializeComponent();
            dgv_Customer.AutoGenerateColumns = false;
            dgv_Customer.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_Customer.RowsDefaultCellStyle.BackColor = Color.White;
            dgv_Customer.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

            dgv_BankAccount.AutoGenerateColumns = false;
            dgv_BankAccount.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_BankAccount.RowsDefaultCellStyle.BackColor = Color.White;
            dgv_BankAccount.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
        }

        //bjjkf
>>>>>>> 080b375ea39245a9806295cf8d977a026742910e
    }
}