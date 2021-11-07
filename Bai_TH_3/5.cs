using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Bài 3.5: Nhập số nguyên dương h. Vẽ ra màn hình tam giác vuông góc trái trên chiều 
    cao h. Ví dụ h = 4:
        * * * *
        * * *
        * *
        *
 */
namespace Bai_TH_3
{
    class _5
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số h:");
            int h = int.Parse(Console.ReadLine());
            int a = h;
            for (int i = 1; i <= h; i++)
            {
                for (int j = a; j >= 1; j--)
                {
                    Console.Write("* ");
                }
                a--;
                Console.WriteLine();
            }
        }
    }
}
