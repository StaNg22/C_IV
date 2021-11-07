using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 2.10. Viết chương trình phân tích một số nguyên thành các thừa số nguyên 
//tố.Ví dụ: Số 28 được phân tích thành 2 x 2 x 7.

namespace Thuc_Hanh_2
{
    class Bai_so_10
    {
        static void Main()
        {
            Console.Write("Nhap vao so nguyen n: ");
            uint n = Convert.ToUInt32(Console.ReadLine());
            uint i = 2;
            Console.Write($"<=> {n} = ");
            while (n > 1)
            {
                if (n % i == 0)
                {
                    Console.Write(i);
                    if (n != i)
                    {
                        Console.Write("x");

                    }
                    n /= i;// n=n/i
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine();
        }
    }
}
