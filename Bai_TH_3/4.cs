using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Bài 3.4: Nhập số nguyên dương h. Vẽ ra màn hình tam giác vuông góc trái dưới 
    chiều cao h. Ví dụ h = 4:
        *
        * *
        * * *
        * * * *
 */
namespace Bai_TH_3
{
    class _4
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào h:");
            int h = int.Parse(Console.ReadLine());
            int a = 0;
            for (int i = 1; i <= h; i++)
            {
                a++;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
