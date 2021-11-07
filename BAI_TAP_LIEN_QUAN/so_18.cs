using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3.Cho mảng 1 chiều n phần tử nguyên, nhập và in ra màn hình kiểm tra xem trong mảng có bao nhiêu phần tử là ước của n.
namespace Bai_Tap_80
{
    class so_18
    {
       static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập vào số phần tử: ");
            int n = int.Parse(Console.ReadLine());

            int[] k = new int[1000];

            int i,dem=0;
            Console.WriteLine("Mời bạn nhập:");
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine($"Nhập phần tử {i}:");
                k[i] = int.Parse(Console.ReadLine());
              
            }
                Console.Write($"Tất cả các phần tử trong {n} là: ");
            for (i = 1; i <= n; i++)
            {
                Console.Write($"{k[i]} ");
            }
            for (i = 1; i <= n; i++)
            {
                if (n % k[i] == 0)
                {
                    dem++;
                }
            }
            Console.WriteLine($"Trong {n} phần tử có {dem} là ước của {n}.");
        }
    }
}
