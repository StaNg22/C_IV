using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//13.Viết chương trình cho nhập 3 số bất kì và kiểm tra xem 3 số đó có thể là 3 cạnh của một tam giác hay không?

namespace Bai_Tap_80
{
    class so_13
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào 3 cạnh của tam giác.");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine($"{a}, {b}, {c} là 3 cạnh của tam giác.");
            }
            else
            {
                Console.WriteLine($"{a}, {b}, {c} không phải là 3 cạnh của tam giác.");
            }

        }
    }
}
