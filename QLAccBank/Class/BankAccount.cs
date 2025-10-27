using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLAccBank.Class
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }      // Số tài khoản
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
    }
}
