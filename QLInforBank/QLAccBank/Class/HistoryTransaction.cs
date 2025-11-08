using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace QLAccBank.Class
{
    public class HistoryTransaction
    {
        public string TransactionID { get; set; }
        public string CustomerID { get; set; }
        public string AccountNumber { get; set; }
        public string TransactionType { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public HistoryTransaction() { }

        public HistoryTransaction(string csvLine)
        {
            string[] values = csvLine.Split(',');
            TransactionID = values[0];
            CustomerID = values[1];
            AccountNumber = values[2];
            TransactionType = values[3];
            Amount = decimal.Parse(values[4]);
            Date = DateTime.Parse(values[5], CultureInfo.InvariantCulture);
            Description = values[6];
        }

        public List<HistoryTransaction> GetList(string filePath, string accountNumber)
        {
            var list = new List<HistoryTransaction>();
            if (!File.Exists(filePath))
            {
                // Thêm thông báo nếu file không tồn tại (có thể log hoặc throw exception)
                throw new FileNotFoundException($"File không tồn tại: {filePath}");
            }

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line) || line.StartsWith("TransactionID", StringComparison.OrdinalIgnoreCase)) continue; // Bỏ header và dòng trống

                var parts = line.Split(',');
                if (parts.Length < 7) continue; // Bỏ dòng thiếu cột

                // Kiểm tra AccountNumber khớp
                if (parts[2].Trim() != accountNumber.Trim()) continue;

                try
                {
                    // Parse an toàn với try-catch
                    list.Add(new HistoryTransaction
                    {
                        TransactionID = parts[0].Trim(),
                        CustomerID = parts[1].Trim(),
                        AccountNumber = parts[2].Trim(),
                        TransactionType = parts[3].Trim(),
                        Amount = decimal.Parse(parts[4].Trim(), CultureInfo.InvariantCulture),
                        Date = DateTime.Parse(parts[5].Trim(), CultureInfo.InvariantCulture),
                        Description = parts[6].Trim()
                    });
                }
                catch (Exception ex)
                {
                    // Log lỗi parse (có thể bỏ qua dòng lỗi hoặc throw)
                    Console.WriteLine($"Lỗi parse dòng: {line}. Chi tiết: {ex.Message}");
                    // Hoặc throw để dừng nếu cần
                }
            }
            return list;
        }
    }
}