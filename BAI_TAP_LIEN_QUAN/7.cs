using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//7.Viết chương trình nhập vào 2 số a,b và in ra màn hình các số nguyên tố trong khoảng 
//bị giới hạn bởi a và b (Mọi người lưu ý là a,b nhập ngẫu nhiên nhé!)

namespace Bai_Tap_80
{
    class _Bai_7
    {
        static int Snt(int x)
        {
            int dem = 0;
            for(int i = 1; i <= x; i++)
            {
                if (x % i == 0)
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
            Console.WriteLine("Nhập số nguyên a và b:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a < b)
            {
                Console.WriteLine($"Các số nguyên tố từ {a} đến {b} là:");
                while (b > a)
                {
                    if (Snt(a) == 1)
                    {
                        Console.WriteLine(a);
                    }
                    a++;

                }
            }
            else
            {
                Console.WriteLine($"Các số nguyên tố từ {b} đến {a} là:");
                while (b < a)
                {
                    if (Snt(b) == 1)
                    {
                        Console.WriteLine(b);
                    }
                    b++;

                }
            }

        }
    }
}
