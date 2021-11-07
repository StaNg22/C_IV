using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
         5.	Viết chương trình cho phép nhập hai số từ bàn phím, 
        tìm và in ra màn hình số lớn nhất. 
 */
namespace CHUONG_III
{
    class Class_5
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số thứ nhất:");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào số thứ 2:");
            float b = float.Parse(Console.ReadLine());
            if ((float)a >(float)b)
            {
                Console.WriteLine($"Trong {a} và {b} thì {a} là số lớn nhất");
            }
            else
            {
                Console.WriteLine($"Trong {a} và {b} thì {b} là số lớn nhất");
            }
        }
    }
}
