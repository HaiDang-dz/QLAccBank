using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QLAccBank.Class
{
    public class Customer
    {
        public string CustomerID { get; set; }         // Mã khách hàng
        public string LastName { get; set; }   // Họ đệm
        public string FirstName { get; set; }  // Tên
        public string Gender { get; set; }             // Giới tính
        public DateTime DOB { get; set; }      // Ngày sinh
        public string PhoneNumber { get; set; }        // Số điện thoại
        public string Email { get; set; }              // Email
        public string Address { get; set; }            // Địa chỉ
        public string IDCard { get; set; }     // CMND/CCCD

        public Customer()
        {
            CustomerID = LastName = FirstName = Gender = Address = PhoneNumber = Email = IDCard = string.Empty;
        }

        public Customer(string csvLine)
        {
            string[] values = csvLine.Split(',');
            CustomerID = values[0];
            LastName = values[1];
            FirstName = values[2];
            Gender = values[3];
            DOB = DateTime.Parse(values[4]);
            PhoneNumber = values[5];
            Email = values[6];
            Address = values[7];
            IDCard = values[8];
        }
        public bool IsEmail()
        {
            if (string.IsNullOrWhiteSpace(Email))
                return false;

            // Mẫu regex kiểm tra email hợp lệ
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(Email, pattern, RegexOptions.IgnoreCase);
        }

        public List<Customer> GetListFormCSV(string fileName = "")
        {
            List<Customer> cusList = new List<Customer>();
            fileName = fileName == "" ? GlobalSettings.CustomerFile : fileName;

            using (StreamReader reader = new StreamReader(fileName))
            {
                // Bỏ qua dòng tiêu đề
                if (!reader.EndOfStream) reader.ReadLine();

                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue; // bỏ qua dòng trống
                    cusList.Add(new Customer(line));
                }
            }
            return cusList;
        }
        public string FullName => LastName + " " + FirstName;
        public DataTable ToDataTable(List<Customer> Customers)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã KH", typeof(string));
            dt.Columns.Add("Họ đệm", typeof(string));
            dt.Columns.Add("Tên", typeof(string));
            dt.Columns.Add("Giới tính", typeof(string));
            dt.Columns.Add("Ngày sinh", typeof(DateTime));
            dt.Columns.Add("Số điện thoại", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Địa chỉ", typeof(string));
            dt.Columns.Add("Căn cước", typeof(string));
            foreach (var cus in Customers)
            {
                dt.Rows.Add(cus.CustomerID, cus.LastName, cus.FirstName, cus.Gender, cus.DOB, cus.PhoneNumber, cus.Email, cus.Address, cus.IDCard);
            }
            return dt;
        }
    }
}
   