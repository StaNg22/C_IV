using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2.Viết chương trình nhập vào một số nguyên dương rồi in ra tất cả các ước số của số đó.
/*Name:Nguyenn_Le_Nhut_Quyen
 *Date:19/11/2021
 */
namespace CHUONG_V
{
    class Bai_02_CHUONG_V
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            uint n = 0;
            Console.WriteLine("Nhập vào một số nguyên:");
            n = uint.Parse(Console.ReadLine());
            Console.Write($"Ước của {n}: ");
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write($"{i}  ");
                }
            }
            Console.WriteLine();
        }
    }
}
