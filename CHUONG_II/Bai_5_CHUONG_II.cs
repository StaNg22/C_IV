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

            //Khai báo biến
            int n = 0;//số bảng cửu chương của n
            int kq = 0;//kết quả của bản cửu chương n

            //Input
            Console.WriteLine("Nhập vào n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Bảng cửu chương {3} là:");
            
            //Tính
                for (int j = 1; j <= 10; j++)
                {
                kq = j * n;

                //Output
                Console.WriteLine($"{n} x {j} = {kq}");
                }
            
        }
    }
}
