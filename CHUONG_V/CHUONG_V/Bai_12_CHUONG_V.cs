using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    12.	Viết chương trình in các số nguyên tố từ 2 đến N, với N là số nguyên dương được nhập vào từ bàn phím.
 */
namespace CHUONG_V
{
    class Bai_12_CHUONG_V
    {
        
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int N = 0;
            int dem = 0;
            Console.WriteLine("Nhập vào số nguyên dương N:");
            N = Convert.ToInt32(Console.ReadLine());
            if (N <= 0)
            {
                Console.WriteLine("Vui lòng nhập lại!!!");
            }
            else
            {
                Console.WriteLine($"Số nguyên tố từ 2 đến {N} là:");
                for (int i = 2 ; i <= N; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            dem++;
                        }
                    }
                    if (dem == 2)
                    {
                        Console.Write($"{i}  ");
                        
                        dem = 0;
                    }
                    dem = 0;
                }
                Console.WriteLine();
            }
        }
    }
}
