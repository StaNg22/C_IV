using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
        2.	Viết chương trình đọc vào độ F, tính và in ra độ C theo công thức như sau:
        C = ((F – 32) * 5) / 9.
 */
namespace CHUONG_III
{
    class Class_2
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vòa độ F");
            float F = float.Parse(Console.ReadLine());
            Console.WriteLine($"{F}F = {((F - 32)*5)/9}C");
        }
    }
}
