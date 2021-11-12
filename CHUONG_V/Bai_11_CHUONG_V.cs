using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    11.Viết chương trình tính các tổng sau: 
    a) S = 1 + x + x2 + x3 + ... +xn
    b) S = 1 - x + x2 - x3 + ... (-1)nxn
    Trong đó n là một số nguyên dương và x là một số bất kỳ được nhập từ bàn phím khi chạy chương trình.
 */
namespace CHUONG_V
{
    class Bai_11_CHUONG_V
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int x = 0;
            int n = 0;
            double S = 0;
            double sc = 0;
            double sl = 0;
            Console.WriteLine("Nhập x:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập vào số lần lặp:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                S += Math.Pow(x, i);
            }
            Console.WriteLine($"Câu a S = {S}");
            for (int j = 0; j <= n; j++)
            {
                if (j % 2 != 0)
                {
                    
                    sl += Math.Pow(-x, j);
                }
                sc += Math.Pow(x, j);
                
            }
            Console.WriteLine($"Câu b S= {sc+sl}");
        }
    }
}
