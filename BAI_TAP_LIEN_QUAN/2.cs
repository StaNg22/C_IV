using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2.Viết chương trình nhập vào một số nguyên n và in ra màn hình các số nguyên chẵn trong khoảng từ 1 tới n.

namespace Bai_Tap_80
{
    class _2
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số nguyên n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Số chẵn là: ");
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
