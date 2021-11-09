using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
        7.	Viết chương trình nhập vào số giây từ 0 đến 86399, 
            đổi số giây nhập vào thành dạng "gio:phut:giay",
            mỗi thành phần là một số nguyên có 2 chữ số.
 */
namespace CHUONG_III
{
    class Class1
    {
      static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Nhập vào số giây:");
            uint a = uint.Parse(Console.ReadLine());
            uint b,c,d;
            if (a < 60)
            {
                Console.WriteLine($"Giờ được chuyển đổi là: 0:0:{a}");
            }
            else if (a >= 60 && a < 3600)
            {
                b = a / 60;
                c = a % 60;
                Console.WriteLine($"Giờ được chuyển đổi là: 0:{b}:{c}");
            }
            else if (a >= 3600)
            {
                b = a / 3600;
                c = (a - b*3600) / 60;
                d = a - (b*3600 + c*60);
                Console.WriteLine($"Giờ được chuyển đổi là:{b}:{c}:{d}");
            }
        }
    }
}
