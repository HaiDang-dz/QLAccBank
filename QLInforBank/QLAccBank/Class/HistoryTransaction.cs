using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.IO;
=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> 080b375ea39245a9806295cf8d977a026742910e

namespace QLAccBank.Class
{
    public class HistoryTransaction
    {
<<<<<<< HEAD
        public string TransactionID { get; set; }   // Mã giao dịch
        public string CustomerID { get; set; }      // Mã khách hàng
        public string AccountNumber { get; set; }   // Số tài khoản
        public string TransactionType { get; set; } // Loại giao dịch
        public decimal Amount { get; set; }         // Số tiền giao dịch
        public DateTime Date { get; set; } // Ngày giao dịch
        public string Description { get; set; }     // Mô tả (nếu có)

        public HistoryTransaction()
        {
            TransactionID = CustomerID = AccountNumber = TransactionType = Description = string.Empty;
            Amount = 0;
            Date = DateTime.Now;
        }

        public HistoryTransaction(string csvLine)
        {
            try
            {
                string[] values = csvLine.Split(',');

                if (values.Length < 6)
                {
                    TransactionID = CustomerID = AccountNumber = TransactionType = Description = string.Empty;
                    Amount = 0;
                    Date = DateTime.Now;
                    return;
                }

                TransactionID = values[0];
                CustomerID = values[1];
                AccountNumber = values[2];
                TransactionType = values[3];
                Amount = decimal.TryParse(values[4], out decimal amt) ? amt : 0;
                Date = DateTime.TryParse(values[5], out DateTime dt) ? dt : DateTime.Now;
                Description = values.Length > 6 ? values[6] : string.Empty;
            }
            catch
            {
                TransactionID = CustomerID = AccountNumber = TransactionType = Description = string.Empty;
                Amount = 0;
                Date = DateTime.Now;
            }
        }

        public List<HistoryTransaction> GetList(string filePath, string accountNumber)
        {
            var list = new List<HistoryTransaction>();

            if (!File.Exists(filePath))
                return list;

            try
            {
                var lines = File.ReadAllLines(filePath);

                for (int i = 1; i < lines.Length; i++)
                {
                    string line = lines[i].Trim();
                    if (string.IsNullOrEmpty(line))
                        continue;

                    var ht = new HistoryTransaction(line);

                    if (!string.IsNullOrEmpty(ht.AccountNumber) &&
                        ht.AccountNumber.Equals(accountNumber, StringComparison.OrdinalIgnoreCase))
                    {
                        list.Add(ht);
                    }
                }
            }
            catch
            {
                // Nếu file lỗi, trả về list rỗng
            }

            return list;
=======
        public string AccountNumber { get; set; }      // Số tài khoản
        public DateTime TransactionDate { get; set; }  // Ngày giao dịch
        public string TransactionType { get; set; }    // Loại giao dịch (nạp tiền, rút tiền, chuyển khoản, v.v.)
        public decimal Amount { get; set; }            // Số tiền giao dịch
        public decimal BalanceAfterTransaction { get; set; } // Số dư sau giao dịch
        public string Description { get; set; }        // Mô tả giao dịch (nếu có)

        public HistoryTransaction()
        {
            AccountNumber = TransactionType = Description = string.Empty;
            TransactionDate = DateTime.Now;
            Amount = 0.0m;
            BalanceAfterTransaction = 0.0m;
        }

        public List<HistoryTransaction> Transactions { get; set; } = new List<HistoryTransaction>();
        
        public HistoryTransaction(string csvLine)
        {
            string[] values = csvLine.Split(',');
            AccountNumber = values[0];
            TransactionDate = DateTime.Parse(values[1]);
            TransactionType = values[2];
            Amount = decimal.Parse(values[3]);
            BalanceAfterTransaction = decimal.Parse(values[4]);
            Description = values[5];
>>>>>>> 080b375ea39245a9806295cf8d977a026742910e
        }
    }
}
