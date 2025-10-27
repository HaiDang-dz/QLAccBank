using System;
using System.IO;

namespace QLAccBank
{
    public static class GlobalSettings
    {
        public static string BasePath = AppDomain.CurrentDomain.BaseDirectory;

        public static string CustomerFile => Path.Combine(BasePath, "Data", "customer.csv");
        public static string BankAccountFile => Path.Combine(BasePath, "Data", "bankaccount.csv");
        public static string HistoryTransactionFile => Path.Combine(BasePath, "Data", "historytransaction.csv");
    }
}
