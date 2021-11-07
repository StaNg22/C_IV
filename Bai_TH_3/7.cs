using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
     Bài 3.7: Nhập số nguyên dương h. Vẽ ra màn hình tam giác vuông góc phải trên
    chiều cao h. Ví dụ h = 4:
                              * * * *
                                * * *
                                  * *
                                    *
 */
namespace Bai_TH_3
{
    class _7
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào h:");
            int h = int.Parse(Console.ReadLine());
            for (int i = 1; i <= h; i++)
            {
                for (int j = i; j >=1 ; j--)
                {
                    Console.Write(" v ");
                }
                Console.WriteLine("\t");
            }
        }
    }
}
