using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
13.	Viết chương trình nhập vào tháng và năm, in ra tháng đó có bao nhiêu ngày.
	Hướng dẫn:  Nếu là tháng 1, 3, 5, 7, 8, 10, 12 thì có 31 ngày
	Nếu là tháng 4, 6, 9, 11 thì có 30 ngày
	Nếu là tháng 2 và là năm nhuận thì có 29 ngày ngược lại 28 ngày
	Năm nhuận là năm chia hết cho 4 và không chia hết cho 100; hoặc chia hết cho 400.

 */
namespace CHUONG_I
{
    class Bai_13_CHUONG_IV
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("---THÁNG CÓ BAO NHIÊU NGÀY---");
            Console.WriteLine("Nhập vào tháng:");
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào năm:");
            int n = int.Parse(Console.ReadLine());
            if (t > 12)
            {
                Console.WriteLine($"Vì {t}>=12 nên, Vui lòng nhập lại!!!");
            }
            else
            {
                if (t == 1 || t == 3 || t == 5 || t == 7 || t == 8 || t == 10 || t == 12)
                {
                    Console.WriteLine($"Tháng {t} có 31 ngày.");
                }
                else if (t == 2)
                {
                    if (n % 400 == 0)
                    {
                        Console.WriteLine($"Vì năm {n} là năm nhuận nên tháng {t} có 29 ngày.");
                    }
                    else
                    {
                        Console.WriteLine($"Vì năm {n} không là năm nhuận nên tháng {t} có 28 ngày.");
                    }
                }
                else
                {
                    Console.WriteLine($"Tháng {t} có 30 ngày.");
                }
            }
        }
    }
}
