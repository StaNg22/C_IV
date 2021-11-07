using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//15.	Viết chương trình nhập vào 2 số nguyên dương a,b tìm và in ra bội chung nhỏ nhất của chúng.

namespace Bai_Tap_80
{
    class so_15
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Nhập vào số nguyên a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào số nguyên b:");
            int b = int.Parse(Console.ReadLine());
            int UCLN,c=a*b;
            Console.Write($"Bội chung nhỏ nhất của {a} và {b} là:");
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            UCLN = a;
            Console.Write(c/UCLN);
            Console.WriteLine();
        }
    }
}
