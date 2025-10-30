using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLAccBank.Class
{
    public class HistoryTransation
    {
        public string AccountNumber { get; set; }      // Số tài khoản
        public DateTime TransactionDate { get; set; }  // Ngày giao dịch
        public string TransactionType { get; set; }    // Loại giao dịch (nạp tiền, rút tiền, chuyển khoản, v.v.)
        public decimal Amount { get; set; }            // Số tiền giao dịch
        public decimal BalanceAfterTransaction { get; set; } // Số dư sau giao dịch
        public string Description { get; set; }        // Mô tả giao dịch (nếu có)

        public HistoryTransation()
        {
            AccountNumber = TransactionType = Description = string.Empty;
            TransactionDate = DateTime.Now;
            Amount = 0.0m;
            BalanceAfterTransaction = 0.0m;
        }

        public List<HistoryTransation> Transactions { get; set; } = new List<HistoryTransation>();

        public HistoryTransation(string csvLine)
        {
            string[] values = csvLine.Split(',');
            AccountNumber = values[0];
            TransactionDate = DateTime.Parse(values[1]);
            TransactionType = values[2];
            Amount = decimal.Parse(values[3]);
            BalanceAfterTransaction = decimal.Parse(values[4]);
            Description = values[5];
        }
    }
}
