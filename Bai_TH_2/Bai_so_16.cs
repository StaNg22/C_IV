using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 2.16: Nhập vào 2 số tự nhiên m < n. Hãy liệt kê các số chính phương trong 
//đoạn[m, n].Có bao nhiêu số chính phương trong đoạn đó?
namespace Exercises2
{
    class Bai16
    {
        static void Main()
        {
            Console.WriteLine("Nhap gia tri m >= 0: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap n >= m: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (m >= 0 && n >= m)
            {
                int start = (int)Math.Sqrt(m);
                int end = (int)Math.Sqrt(n);
                for (int i = start; i <= end; i++)
                {
                    if (i * i >= m)
                    {
                        Console.Write(i * i + " ");
                    }
                }
                Console.WriteLine("\nSo luong ket qua thoa man: " + (end - start));
            }
            else
            {
                Console.WriteLine("Nhap m >= 0 va n >= m");
            }
        }
    }
}
