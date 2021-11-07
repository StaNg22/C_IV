using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    8.	Chương trình cho phép nhập vào một số nguyên dương num. 
    Nếu là số chẵn thì tăng num lên một đơn vị, nếu là số lẻ thì giảm num một đơn vị. 
    In giá trị mới của num.
 */
namespace CHUONG_III
{
    class Class_8
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số nguyên num: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            { 
                Console.WriteLine($"{num} là số chãn");
                Console.WriteLine($"{num +1}");
            }
            else
            {
                Console.WriteLine($"{num} là số lẻ");
                Console.WriteLine($"{num - 1}");
            }
        }
    }
}
