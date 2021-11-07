using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//6.Viết chương trình nhập vào 1 số n và in ra màn hình các số nguyên tố trong khoảng từ 1 tới 2n.

namespace Bai_Tap_80
{
    class _6
    {
        static void Snt(int a)
        {
            bool laSoNT = true;
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                {
                    laSoNT = false;

                }
            }
            if (laSoNT)
            {
                Console.WriteLine(a);
            }
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số nguyên n: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 2; i <= 2*n; i++)
            {
                Snt(i);
            }
        }
    }
}
