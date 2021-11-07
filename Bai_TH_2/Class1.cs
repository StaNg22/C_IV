using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuc_Hanh_2
{
    class Class1
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập a");

            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập b");

            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập c");

            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập x");

            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập n");

            int n = int.Parse(Console.ReadLine());
            float tong1 = 0, tong3 = 0, tong2 = 0,dem=1,tong4=0;

            // for (int i = 1; i <= n; i++)
            // {
            //    tong1 = ((a * a * x) +(b*x) +c+i);
            //   tong2 = i;
            //   tong3 += tong1 / tong2;
            // }
            for (int i = 1; i <= n; i++)
            {
                tong1 = (a * a * x) / i;
                tong2 = (b * x) / i;
                tong3 = c / i;
                tong4 = 1;
                dem += tong1 + tong2 + tong3 + tong4;
            }
            Console.WriteLine(dem);
        }
    }
}
