using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Bài 3.6: Nhập số nguyên dương h. Vẽ ra màn hình tam giác vuông góc phải dưới 
    chiều cao h. Ví dụ h = 4:
                                    *
                                  * *
                                * * *
                              * * * *
 */
namespace Bai_TH_3
{
    class _6
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào h:");
            int h = int.Parse(Console.ReadLine());
            int a = 1;
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= h; j++)
                {
                    if (j <= (h - i))
                    {
                        Console.Write("     ");
                    }
                    else
                    {
                        Console.Write("  *  ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
