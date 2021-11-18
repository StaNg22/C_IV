using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//11.Viết chương trình in ra N số chính phương đầu tiên, 
//   với N là số nguyên dương được nhập vào từ bàn phím.
namespace CHUONG_VI
{
    internal class Bai_11_CHUONG_VI
    {
        static void scpdt(double n)
        {
            double dem = 0;
            double so = 1;
            while (dem < n)
            {
                bool scp = false;
                for (int i = 1; i <= so; i++)
                {
                    if (i % so == 0 && i % Math.Sqrt(so) == 0)
                    {
                        scp = true;
                        break;
                    }
                }
                if (scp)
                {
                    Console.Write($"{so}");
                    if (dem < n-1)
                    {
                        Console.Write(",  ");
                    }
                    dem++;
                }
                so++;
            }

        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            double n = 0;
            Console.WriteLine("Nhập vào số N:");
            n = Convert.ToDouble(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Vui lòng nhập lại!!!");
            }
            else
            {
                scpdt(n);
                Console.WriteLine();
            }
        }
    }
}

