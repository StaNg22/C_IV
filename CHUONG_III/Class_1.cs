using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  
 1.	Viết chương trình đọc vào 2 số nguyên và in ra kết quả của phép (+), phép trừ (-),
       phép nhân (*), phép chia (/).
       Nhận xét kết quả chia 2 số nguyên.
 */
namespace CHUONG_III
{
    class Class_1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số nguyên a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào số nguyên b:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"{a} + {b} = {a+b}");
            Console.WriteLine($"{a} - {b} = {a-b}");
            Console.WriteLine($"{a} x {b} = {a*b}");
            Console.WriteLine($"{a} / {b} = {a/b}");
        }
    }
}
