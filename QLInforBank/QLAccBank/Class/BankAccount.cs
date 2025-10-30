using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLAccBank.Class
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }      // Số tài khoản
        public string CustomerID { get; set; }         // Mã khách hàng (liên kết với Customer)
        public string HoDem { get; set; }
        public string Ten { get; set; }
        public string AccountType { get; set; }        // Loại tài khoản (tiết kiệm, thanh toán, v.v.)
        public decimal Balance { get; set; }           // Số dư
        public DateTime OpenDate { get; set; }         // Ngày mở tài khoản
        public bool IsActive { get; set; }             // Trạng thái hoạt động

        public BankAccount()
        {
            AccountNumber = CustomerID = AccountType = string.Empty;
            Balance = 0.0m;
            OpenDate = DateTime.Now;
            IsActive = true;
        }

        public BankAccount(string csvLine)
        {
            string[] values = csvLine.Split(',');
            AccountNumber = values[0];
            CustomerID = values[1];
            AccountType = values[2];
            Balance = decimal.Parse(values[3]);
            OpenDate = DateTime.Parse(values[4]);
            IsActive = bool.Parse(values[5]);
        }
        public List<BankAccount> GetBankAccListFromCSV(string fileName = "")
        {
            List<BankAccount> list = new List<BankAccount>();
            fileName = fileName == "" ? GlobalSettings.BankAccountFile : fileName;

            if (!File.Exists(fileName))
                return list;

            using (StreamReader reader = new StreamReader(fileName))
            {
                if (!reader.EndOfStream) reader.ReadLine(); // bỏ dòng tiêu đề

                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Trim();
                    if (string.IsNullOrEmpty(line) || line.Split(',').Length < 6)
                        continue;
                    list.Add(new BankAccount(line));
                }
            }
            return list;
        }

        // 🟢 Thêm hàm mới: lọc tài khoản theo Mã KH
        public List<BankAccount> GetListByCustomerID(string customerID, string fileName = "")
        {
            var allAccounts = GetBankAccListFromCSV(fileName);
            return allAccounts.Where(acc => acc.CustomerID == customerID).ToList();
        }
        // 🟢 Chuyển danh sách tài khoản sang DataTable để hiển thị
        // BankAccount.cs - ToDataTable (sửa tên DataColumn thành English keys)
        public DataTable ToDataTable(List<BankAccount> accounts, List<Customer> customers)
        {
            DataTable dt = new DataTable();

            // dùng tên key dễ map (tiếng Anh)
            dt.Columns.Add("AccountNumber", typeof(string));
            dt.Columns.Add("CustomerID", typeof(string));
            dt.Columns.Add("CustomerName", typeof(string));
            dt.Columns.Add("AccountType", typeof(string));
            dt.Columns.Add("Balance", typeof(decimal));
            dt.Columns.Add("OpenDate", typeof(DateTime));
            dt.Columns.Add("IsActive", typeof(string));

            foreach (var acc in accounts)
            {
                Customer customer = null;
                foreach (var c in customers)
                {
                    if (c.CustomerID == acc.CustomerID)
                    {
                        customer = c;
                        break;
                    }
                }

                string tenKH = customer != null ? $"{customer.LastName} {customer.FirstName}" : "";

                dt.Rows.Add(
                    acc.AccountNumber,
                    acc.CustomerID,
                    tenKH,
                    acc.AccountType,
                    acc.Balance,
                    acc.OpenDate,
                    acc.IsActive ? "Đang hoạt động" : "Ngừng hoạt động"
                );
            }

            return dt;
        }


    }
}
