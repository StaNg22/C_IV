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
        static int ktsnt(int n)
        {
            int dem = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    dem++;
                }
            }
            if (dem == 2)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int N = 0;
            int dem = 0;
            int j = 2;
            Console.WriteLine("Nhập vào số nguyên dương N:");
            N = Convert.ToInt32(Console.ReadLine());
            if (N <= 0)
            {
                Console.WriteLine("Vui lòng nhập lại!!!");
            }
            else
            {
                Console.WriteLine($"Số nguyên tố từ 2 đến {N} là:");
                for (int i = ; i <= N; i++)
                {
                    if(ktsnt(i)==0)
                    {
                        Console.Write($"{i} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
