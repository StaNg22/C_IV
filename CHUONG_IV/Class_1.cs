using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//      1.	Viết chương trình nhập vào 4 số nguyên.
//      Tìm và in ra số lớn nhất.
namespace CHUONG_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào 4 số:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            if (a > b && a > c && a > c && a > d)
            {
                Console.WriteLine($"Trong {a}, {b}, {c}, {d} thì {a} là GTLN");
            }
            else if (b > a && b > c && b > d)
            {
                Console.WriteLine($"Trong {a}, {b}, {c}, {d} thì {b} là GTLN");
            }
            else if (c > a && c > b && c > d)
            {
                Console.WriteLine($"Trong {a}, {b}, {c}, {d} thì {c} là GTLN");
            }
            else
            {
                Console.WriteLine($"Trong {a}, {b}, {c}, {d} thì {d} là GTLN");
            }
        }
    }
}
