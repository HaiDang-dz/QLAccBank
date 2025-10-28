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
        public string LastName { get; set; }           // Họ đệm
        public string FirstName { get; set; }          // Tên
        public string CustomerID { get; set; }         // Mã khách hàng (liên kết với Customer)
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
        public List<BankAccount> GetListFromCSV(string fileName = "")
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
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    list.Add(new BankAccount(line));
                }
            }
            return list;
        }

        // 🟢 Thêm hàm mới: lọc tài khoản theo Mã KH
        public List<BankAccount> GetListByCustomerID(string customerID, string fileName = "")
        {
            var allAccounts = GetListFromCSV(fileName);
            return allAccounts.Where(acc => acc.CustomerID == customerID).ToList();
        }
        // 🟢 Chuyển danh sách tài khoản sang DataTable để hiển thị
        public DataTable ToDataTable(List<BankAccount> accounts)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Mã khách hàng", typeof(string));
            dt.Columns.Add("Họ đệm", typeof(string));
            dt.Columns.Add("Tên", typeof(string));
            dt.Columns.Add("Loại tài khoản", typeof(string));
            dt.Columns.Add("Số dư", typeof(decimal));
            dt.Columns.Add("Ngày mở", typeof(DateTime));
            dt.Columns.Add("Trạng thái hoạt động", typeof(string));

            foreach (var acc in accounts)
            {
                dt.Rows.Add(
                    acc.CustomerID,     // mã khách hàng
                    acc.LastName,      // họ đệm
                    acc.FirstName,     // tên
                    acc.AccountType,    // loại tài khoản
                    acc.Balance,        // số dư
                    acc.OpenDate,       // ngày mở
                    acc.IsActive ? "Có" : "Không" // trạng thái hoạt động
                );
            }

            return dt;
        }


    }
}
