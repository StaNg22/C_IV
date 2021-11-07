using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//12.Viết chương trình nhập vào 3 số a,b,c (1<= c <=3). Nếu c=1 in ra tổng a+b, c=2 
//in ra hiệu a-b, Còn nếu c=3 thì in ra màn hình: " Tớ thích cậu rồi đấy!".

namespace Bai_Tap_80
{
    class so_12
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số a,b,c:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (c >= 1 && c <= 3)
            {
                switch (c)
                {
                    case 1:
                        Console.WriteLine($"{a} + {b} = {a+b}");
                        break;
                    case 2:
                        Console.WriteLine($"{a} - {b} = {a-b}");
                        break;
                    case 3:
                        Console.WriteLine("Tớ thích cậu rồi đấy!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Vui lòng nhập 1<=n<=3.");
            }
        }
    }
}
