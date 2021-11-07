using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  3.Viết chương trình giải phương trình bậc nhất: ax+b=0, với a, b nhập vào từ bàn phím.
namespace CHUONG_I
{
    class Class_3
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("GIẢI PHƯƠNG TRÌNH BẬC NHẤT");
            Console.WriteLine("Có dạng ax + b = 0");

            Console.WriteLine("Mời nhập a:");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Mời nhập b:");
            float b = float.Parse(Console.ReadLine());

            Console.Write("Phương trình có dạng: ");
            if (a == 0)
            {
                Console.WriteLine($"{a}x + {b} = 0");
                string kq = (b == 0) ? "Phương trình vô số nghiệm" : "Phương trình vô nghiệm";
                Console.WriteLine($"=>{kq}");
            }
            else
            {
                if (a == 1)
                {
                    Console.WriteLine($"x + {b} = 0");
                }
                else
                {
                    Console.WriteLine($"{a}x + {b} = 0");
                }
                Console.WriteLine($"=>Phương trình có nghiệm là x = {-b/a}");
            }
        }
    }
}
