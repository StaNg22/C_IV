using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//14.Viết chương trình nhập vào 2 số nguyên dương a,b tìm và in ra màn hình ước chung của chúng.

namespace Bai_Tap_80
{
    class so_14
    {
        static void Main()
        {
           
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số nguyên a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào số nguyên b:");
            int b = int.Parse(Console.ReadLine());
          
            if (a == 0 || b == 0)
            {
                Console.WriteLine($"{a} và {b} không có ước chung.");
            }
            else
            {
                Console.WriteLine($"Ước chung của {a} và {b} là:");
                for (int i = 1; i <= a && i<=b; i++)
                {
                     if (a % i == 0 && b%i==0)
                     {
                        Console.WriteLine(i);
                     }
                }
                
            }
        }
    }
}
