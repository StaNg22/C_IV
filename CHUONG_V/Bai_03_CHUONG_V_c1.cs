using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3.Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số nguyên tố hay không? 
/*Name:Nguyenn_Le_Nhut_Quyen
 *Date:19/11/2021
 */
namespace CHUONG_V
{
    class Bai_03_CHUONG_V_c1
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool a;
            int n = 0;
            Console.WriteLine("Nhập vào số nguyên:");
            n = int.Parse(Console.ReadLine());

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
