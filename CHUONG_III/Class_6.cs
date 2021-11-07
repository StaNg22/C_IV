using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 6.	Viết chương trình nhập vào số nguyên dương có hai chữ số. In ra số đảo ngược. Ví dụ: Nhập vào 18, in ra 81.
 */
namespace CHUONG_III
{
    class Class_6
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào một số có 2 chữ số: ");
            int a = int.Parse(Console.ReadLine());
            int b = a % 10 * 10 + a / 10;
            Console.WriteLine($"Số nghịch đảo của {a} là: {b}");
        }
    }
}
