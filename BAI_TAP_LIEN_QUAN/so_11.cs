using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//11.Viết chương trình nhập vào n và in ra màn hình n!
namespace Bai_Tap_80
{
    class _11
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào số nguyên n:");
            int n = int.Parse(Console.ReadLine());
            int A = 1;
            for (int i = 1; i <= n; i++)
            {
                A *= i;
            }
            Console.WriteLine();
            Console.WriteLine($"=> {n}! = {A}");
        }
    }
}
