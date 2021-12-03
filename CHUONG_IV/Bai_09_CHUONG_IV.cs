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
/*Name:Nguyenn_Le_Nhut_Quyen
 *Date:19/11/2021
 */
namespace CHUONG_IV
{
    class Bai_09_CHUONG_IV
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Khai Báo Biến
            float x = 0;//Giá trị x do người nhập
            float y = 0;//Giá trị y do người nhập
            char kt;//ký tự người nhập lựa chọn
            string a;//điệu kiện chia

            //input
            Console.WriteLine("Nhập vào số thực x:");
            x = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào số thực y:");
            y = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào ký tự (+; -; *; /):");
            ktNhapLai:  kt = Convert.ToChar(Console.ReadLine());

            //tính
            switch (kt)
            {
                case '+':
                    Console.WriteLine($"{x} + {y} = {x + y}");
                    break;
                case '-':
                    Console.WriteLine($"{x} - {y} = {x - y}");
                    break;
                case '*':
                    Console.WriteLine($"{x} x {y} = {x * y}");
                    break;
                case '/':
                    a = (y == 0) ? $"{x} không chia được cho {y}" : $"{x} / {y} = {x / y}";
                    Console.WriteLine($"{a}");
                    break;
                default:
                    Console.WriteLine("Nhập không đúng. Vui lòng nhập lại");
                    goto ktNhapLai;
                    break;
            }
        }
    }
}
