using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//4. Viết chương trình nhập vào số n và in ra màn hình dãy như sau: 1 3 5......n .... 6 4 2 
//(nghĩa là dãy số có các số nguyên dương lẻ nhỏ hơn n nằm bên tay trái còn các số chẵn sẽ nằm bên tay phải.) 
namespace Bai_Tap_80
{
    class _4
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số n: ");
            int n;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write($"{i} ");
                }

            }
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine("");
        }
    }
}
