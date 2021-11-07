using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3.	Viết chương trình nhập vào số nguyên dương n và in ra màn hình các ước của n.

namespace Bai_Tap_80
{
    class _3
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số nguyên n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ước của {n} là: ");
            for (int i = 1; i <=n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
