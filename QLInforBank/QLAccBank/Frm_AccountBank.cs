    using QLAccBank.Class;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    namespace QLAccBank
    {
        public partial class Frm_AccountBank : Form
        {
            private List<BankAccount> BankAccountList = new List<BankAccount>();
            public Frm_AccountBank()
            {
                InitializeComponent();

                // dgv tài khoản
                dgv_BankAccount.AutoGenerateColumns = false;
                dgv_BankAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv_BankAccount.MultiSelect = false;

                dgv_HistoryBank.AutoGenerateColumns = false;
                dgv_HistoryBank.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv_HistoryBank.MultiSelect = false;

                // Map cột cho dgv_BankAccount
                AccountNumber.DataPropertyName = "AccountNumber";
                CustomerID.DataPropertyName = "CustomerID";
                CustomerName.DataPropertyName ="CustomerName";
                AccountType.DataPropertyName = "AccountType";
                Balance.DataPropertyName = "Balance";
                OpenDate.DataPropertyName = "OpenDate";
                IsActive.DataPropertyName = "IsActive";
            }

            private void Frm_AccountBank_Load(object sender, EventArgs e)
            {
                Customer cus = new Customer();
                List<Customer> customers = cus.GetListFormCSV(); // 🔹 Lấy danh sách khách hàng

                BankAccount acc = new BankAccount();
                BankAccountList = acc.GetBankAccListFromCSV();   // 🔹 Lấy danh sách tài khoản

                DataTable dt = acc.ToDataTable(BankAccountList, customers); // 🔹 Ghép 2 danh sách

                dgv_BankAccount.DataSource = dt;
            }

            private void txt_Tim_TextChanged(object sender, EventArgs e)
            {
                string filterText = txt_Tim.Text.Trim().ToLower();

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

            private void dgv_BankAccount_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex < 0) return;

                try
                {
                    string accountNumber = dgv_BankAccount.Rows[e.RowIndex].Cells["AccountNumber"].Value.ToString();

                    string path = Path.Combine(Application.StartupPath, "Data", "HistoryTransactionFile.csv");
                    HistoryTransaction ht = new HistoryTransaction();
                    var historyList = ht.GetList(path, accountNumber);

                    dgv_HistoryBank.DataSource = null;
                    dgv_HistoryBank.DataSource = historyList;

                    // Format tiền
                    if (dgv_HistoryBank.Columns.Contains("Amount"))
                        dgv_HistoryBank.Columns["Amount"].DefaultCellStyle.Format = "#,##0 VNĐ";

                    // Format ngày
                    if (dgv_HistoryBank.Columns.Contains("TransactionDate"))
                        dgv_HistoryBank.Columns["TransactionDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    else if (dgv_HistoryBank.Columns.Contains("Date"))
                        dgv_HistoryBank.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
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
        }
    }
