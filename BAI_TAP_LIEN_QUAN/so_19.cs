using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4.Cho mảng 1 chiều gồm n phần tử nguyên, kiểm tra và in ra màn hình những phần tử là số nguyên tố hoặc là số chính phương.
namespace Bai_Tap_80
{
    class so_19
    {
        static int ktsnt(int a)
        {
            int dem = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    dem++;
                }
            }
            if (dem == 2)
            {
                return 1;
            }
            return 2;
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số phần tử:");
            int n = int.Parse(Console.ReadLine());
            int[] k = new int[1000];
            int i, a = 0;
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine($"Mời nhập phần tử thứ {i}:");
                k[i] = int.Parse(Console.ReadLine());
            }
            Console.Write($"Tất cả các phần tử có trong {n} là: ");
            for (i = 1; i <= n; i++)
            {
                Console.Write($"{k[i]} ");
            }
            Console.WriteLine();
            Console.Write($"Các số nguyên tố trong {n} phần tử trên là: ");
            for (i = 1; i <= n; i++)
            {
                if (ktsnt(k[i]) == 1)
                {
                    Console.Write($"{k[i]} ");
                }
            }
            Console.WriteLine();
            Console.Write("Số chỉnh phương trong các phần tử trên là: ");
            for (i = 1;i*i <=2*n; i++)
            {
                if (k[i * i] == 2*n)
                {
                    a = 1;
                }
                if (a == 0)
                {
                    Console.Write($"{k[i]*k[i]} ");
                }
            }
        }
    }
}
