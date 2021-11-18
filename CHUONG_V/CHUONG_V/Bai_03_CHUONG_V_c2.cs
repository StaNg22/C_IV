using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3.Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số nguyên tố hay không? 
namespace CHUONG_V
{
    class Bai_03_CHUONG_V_c2
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số nguyên:");
            int n = Convert.ToInt32(Console.ReadLine());
            int dem = 0;
            if (n <= 1)
            {
                Console.WriteLine($"{n} bé hơn 1. Vui lòng nhập lại!!!");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        dem++;
                    }
                }
                if (dem == 2)
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
