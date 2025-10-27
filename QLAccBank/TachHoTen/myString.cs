using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QLAccBank.Class
{
    public class myString
    {
        // 5. Xóa khoảng trắng dư thừa trong chuỗi
        static public string Standard(string s)
        {
            try
            {
                // Xóa khoảng trắng đầu và cuối chuỗi
                s = s.Trim();
                string s1 = " ";    // 1 khoảng trắng
                string s2 = "  ";   // 2 khoảng trắng
                                    // Tìm chuỗi s2 trong s
                int index = s.IndexOf(s2);
                while (index != -1)
                {
                    s = s.Replace(s2, s1);
                    index = s.IndexOf(s2);
                }
                return s;
            }
            catch
            {
                return string.Empty;
            }
        }

        // 6. Trả về n kí tự bên trái của chuỗi
        static public string Left(string s, int n)
        {
            try
            {
                return s.Substring(0, n);
            }
            catch
            {
                return string.Empty;
            }

        }

        // 7. Trả về n kí tự bên phải của chuỗi Pham Dinh Sac
        static public string Right(string s, int n)
        {
            try
            {
                return s.Substring(s.Length - n, n);
            }
            catch
            {
                return string.Empty;
            }

        }

        // 8. Trả về n kí tự bên phải của chuỗi
        static public string Mid(string s, int index, int n)
        {
            try
            {
                return s.Substring(index, n);
            }
            catch
            {
                return string.Empty;
            }

        }

        // 9. Proper(s) Chuỗi có kí tự đầu HOA, các kí tự còn lại thường
        static public string Proper(string s)
        {
            try
            {
                // Xóa khoảng trắng dư thừa và chuyển chuỗi --> chữ thường
                s = Standard(s); s = s.ToLower();

                // Đổi kiểu chuỗi (string) --> mảng kí tự (char array)
                char[] charArr = s.ToCharArray();
                // Xử lý ký tự đầu tiên
                if (char.IsLetter(charArr[0]))
                    charArr[0] = char.ToUpper(charArr[0]);

                // Upper kí tự sau khoảng trắng
                for (int i = charArr.Length - 1; i > 0; i--)
                {
                    if (charArr[i - 1] == ' ' && char.IsLetter(charArr[i]))
                        charArr[i] = char.ToUpper(charArr[i]);
                }
                //chuyển đổi kiểu mảng kí tự (char array) --> chuỗi (string)
                s = new string(charArr);
                return s;
            }
            catch
            {
                return string.Empty;
            }
        }
        // 9. FirstCapitalLetter(s) Chuỗi có kí tự đầu HOA, các kí tự còn lại thường
        public static string FirstCapitalLetter(string s)
        {
            try
            {
                // Xóa khoảng trắng dư thừa và chuyển chuỗi --> chữ thường
                s = Standard(s); s = s.ToLower();

                //Chuyển chuỗi thành mảng chuỗi dựa vào kí tự khoảng trắng ' '
                string[] Words = s.Split(' ');
                s = "";
                foreach (string st in Words)
                {
                    if (st.Length > 1)
                        s += st.Substring(0, 1).ToUpper() + st.Substring(1) + " ";
                    else
                        s += st.ToUpper() + " ";
                }
                // Xóa khoảng trắng đầu và cuối chuỗi
                return s.Trim();
            }
            catch
            {
                return string.Empty;
            }
        }


        // Ten in Vietnamese: Ho Ten
        public static (string, string) TachHoTen(string hoTen)
        {
            if (string.IsNullOrWhiteSpace(hoTen))
                return ("", "");

            string[] parts = hoTen.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length == 1)
                return ("", parts[0]); // chỉ có tên, không có họ

            string ho = string.Join(" ", parts.Take(parts.Length - 1));
            string ten = parts.Last();

            return (ho, ten);
        }



        // Name in English: FirstName LastName
        public static (string FirstName, string LastName) SplitFullName(string s)
        {
            try
            {
                s = FirstCapitalLetter(s);
                int index = s.IndexOf(' '); // vị trí khoảng trắng đầu tiên

                string firstName = Left(s, index).Trim();
                string lastName = Right(s, s.Length - index).Trim();

                return (firstName, lastName);
            }
            catch
            {
                return (string.Empty, string.Empty);
            }
        }
    }

}
