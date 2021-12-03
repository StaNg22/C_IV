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
    class Bai_03_CHUONG_V_c2
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0;
            int dem = 0;
            Console.WriteLine("Nhập vào số nguyên:");
            n = Convert.ToInt32(Console.ReadLine());
            
            if (n <= 1)
            {
                Console.WriteLine($"{n} bé hơn 1. Vui lòng nhập lại!!!");
            }
            else
            {//n  =6 4U 
                for (int i = 4; i <= n; i=i+1)
                {
                    if (n % i == 0)
                    {
                        dem=dem+1;//dem=3
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
