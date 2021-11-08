using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//10.Viết chương trình giải phương trình bậc 2: ax2 + bx + c = 0, với a, b, c nhập vào từ bàn phím.
namespace CHUONG_I
{
    class Class_10
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("---GIẢI PHƯƠNG TRÌNH BẬC II---");
            Console.WriteLine("Nhập a:");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhập b:");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhập c:");
            float c = float.Parse(Console.ReadLine());
            float delta,x1,x2;
            if (a > 0)
            {
                delta = b*b - 4 * a * c;
                
                if (delta > 0)
                {
                    x1 = (-b + (float)Math.Sqrt(delta)) /(2 * a);
                    x2 = (-b - (float)Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("=> Phương trình có 2 nghiệm phân biệt:");
                    Console.WriteLine($"                                     x1 = {x1}");
                    Console.WriteLine($"                                     x2 = {x2}");
                }
                else if (delta == 0)
                {
                    x1 = -b / 2 * a;
                    Console.WriteLine($"=> Phương trình có nghiệm kép: x = {x1}");
                }
                else
                {
                    Console.WriteLine("=> Phương trình vô nghiệm.");
                }
            }
            else
            {
                Console.WriteLine("=> Phương trình vô nghiệm.");
            }
        }
    }
}
