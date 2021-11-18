using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
   9.Viết chương trình nhập vào 2 số thực x, y và menu cho phép người dùng lựa chọn một trong trong bốn toán tử +, -, *, /. 
     Nếu chọn sai yêu cầu chọn lại.
     Nếu là + thì in ra kết quả x + y, 
     Nếu là – thì in ra x – y, 
     Nếu là * thì in ra x * y, 
     Nếu là / thì in ra x / y (nếu y = 0 thì thông báo không chia được) và kết thúc chương trình.
 */
namespace CHUONG_IV
{
    class Bai_09_CHUONG_IV
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số thực x:");
            float x = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào số thực y:");
            float y = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào ký tự (+; -; *; /):");
            string kt = Console.ReadLine();
            switch (kt)
            {
                case "+":
                    Console.WriteLine($"{x} + {y} = {x + y}");
                    break;
                case "-":
                    Console.WriteLine($"{x} - {y} = {x - y}");
                    break;
                case "*":
                    Console.WriteLine($"{x} x {y} = {x * y}");
                    break;
                case "/":
                    string a;
                    a = (y == 0) ? $"{x} không chia được cho {y}" : $"{x} / {y} = {x / y}";
                    Console.WriteLine($"{a}");
                    break;
                default:
                    Console.WriteLine("Vui lòng nhập lại");
                    break;
            }
        }
    }
}
