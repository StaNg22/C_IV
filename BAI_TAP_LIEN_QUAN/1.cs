using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.viết chương trình nhập vào một số nguyên dương n và in ra màn hình dãy số tự nhiên từ 1 tới n.

namespace Bai_Tap_80
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số nguyên n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
