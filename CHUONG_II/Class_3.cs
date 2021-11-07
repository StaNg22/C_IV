using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
        3.	Chương trình cho phép người dùng nhập vào năm sinh một nam nhân viên. Tính:
        	Tính tuổi hiện tại.
        	Tính năm về hưu (biết tuổi về hưu của nam là 60).
 */
namespace CHUONG_I
{
    class Class_3
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào năm sinh của Bạn:");
            int year1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào năm hiện tại:");
            int year2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tuổi hiện tại của bạn là: {year2 - year1}");
            Console.WriteLine($"Năm mà bạn về hưu là:{year2 + (60 - (year2 - year1))}");
        }
    }
}
