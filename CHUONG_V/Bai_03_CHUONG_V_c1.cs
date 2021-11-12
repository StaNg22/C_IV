using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3.Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số nguyên tố hay không? 
namespace CHUONG_V
{
    class Bai_03_CHUONG_V_c1
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số nguyên:");
            int n = int.Parse(Console.ReadLine());
            bool a;
            if (n <= 1)
            {
                Console.WriteLine($"{n} không là số nguyên tố.");
            }
            else
            {
                a = true;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n%i == 0)
                    {
                        a = false;
                        break;
                    }
                }
                if (a)
                {
                    Console.WriteLine($"{n} là số nguyên tố.");
                }
                else
                {
                    Console.WriteLine($"{n} không là số nguyên tố.");
                }
            }
        }
    }
}
