using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
15.Viết chương trình nhập vào một số nguyên dương n bất kỳ, kiểm tra xem số đó có phải là số đối xứng hay không? 
Ví dụ: 121, 2332, 52125 là các số đối xứng.
 */
/*Name:Nguyenn_Le_Nhut_Quyen
 *Date:19/11/2021
 */
namespace CHUONG_V
{
    internal class Bai_15_CHUONG_V
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0;
            int spd = 0;
            int skt = 0;
            int skq = 0;
            Console.WriteLine("Nhập vào số nguyên dương n:");
            n = Convert.ToInt32(Console.ReadLine());
            skq = n;
            if (n <= 0)
            {
                Console.WriteLine("{0} < 0, vui lòng nhập lại!!!", n);
            }

            else
            {
                while (n > 0)
                {
                    spd = n % 10;
                    skt = skt * 10 + spd;
                    n /= 10;
                }
                if (skt == skq)
                {
                    Console.WriteLine($"{skq} là số thuận nghịch.");
                }
                else
                {
                    Console.WriteLine($"{skq} không là số thuận nghịch.");
                }
            }
        }
    }
}
