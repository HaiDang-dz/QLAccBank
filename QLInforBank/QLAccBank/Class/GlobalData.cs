using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLAccBank.Class
{
    public static class GlobalData
    {
        // Danh sách tài khoản (username - password)
        public static Dictionary<string, string> Members = new Dictionary<string, string>()
        {
            { "nguyenhaidang", "2003" },
            { "nguyendamkhanhdoan", "2005" },
            { "ledoanbaohuy", "2005" }
        };

        // Danh sách thông tin chi tiết của từng thành viên
        public static Dictionary<string, Members> MemberInfo = new Dictionary<string, Members>()
        {
            {
                "nguyenhaidang",
                new Members("Nguyễn Hải Đăng", "nguyenhaidang@gmail.com", "0905123456",
                            "Nhân viên giao dịch", DateTime.Now.AddYears(-2), "dang")
            },
            {
                "nguyendamkhanhdoan",
                new Members("Nguyễn Đàm Khánh Đoan", "nguyendamkhanhdoan@gmail.com", "0988777666",
                            "Nhân viên hỗ trợ", DateTime.Now.AddYears(-1), "doan")
            },
            {
                "ledoanbaohuy",
                new Members("Lê Đoàn Bảo Huy", "ledoanbaohuy@gmail.com", "0912345678",
                            "Quản lý khách hàng", DateTime.Now.AddMonths(-6), "huy")
            }
        };
    }
}
