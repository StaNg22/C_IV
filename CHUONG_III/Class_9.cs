using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    9.	Viết chương trình cho phép nhập vào số nguyên dương có ba chữ số.
    In ra số đảo ngược. Ví dụ: Nhập 123, in ra 321.
 */
namespace CHUONG_III
{
    class Class_9
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mời bạn nhập vào số nguyên có 3 chữ số:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Số nghịch đảo của {a} là: {(a%10)*100 + ((a%100)/10)*10 +a/100}");
        }
    }
}
