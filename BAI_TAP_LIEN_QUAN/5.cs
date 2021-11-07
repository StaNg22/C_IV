using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//5.	Viết chương trình nhập vào số nguyên dương n và in ra màn hình tổng các số chẵn khoảng từ 1 tới n.

namespace Bai_Tap_80
{
    class _5
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write(" Nhập vào sô nguyên n: ");
            int n = int.Parse(Console.ReadLine());
            int tc = 0;
            for (int i = 1; i<= n; i++)
            {
                if (i % 2 == 0)
                {
                    tc += i;
                }
            }
            Console.Write($"Tổng các số chẵn từ 1 tới {n} là: {tc}");
            Console.WriteLine();
        }
    }
}
