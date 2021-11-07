using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*      5.	Chương trình cho phép nhập một số nguyên dương n và in bảng nhân của số đó.
        Ví dụ: n=3 thì ta in ra:
            3x1=3
            3x2=6
             …
            3x10=30
 */
namespace CHUONG_I
{
    class Class_5
    {static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Bảng cửu chương {3} là:");
            
                for (int j = 1; j <= 10; j++)
                {
                Console.WriteLine($"3 x {j} = {3 * j}");

                }
            
        }
    }
}
