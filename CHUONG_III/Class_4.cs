using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    4.	Chương trình cho phép nhập vào một số nguyên dương. 
    Kiểm tra và in ra màn hình kết quả “Là số chẵn” hoặc “Là số lẻ”
 */
namespace CHUONG_III
{
    class Class_4
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số nguyên:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("==> ");
            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} là số chẵn");
            }
            else
            {
                Console.WriteLine($"{a} là số lẻ");
            }
        }
    }
}
