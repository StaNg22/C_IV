using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//      1.	Viết chương trình nhập vào 4 số nguyên.
//      Tìm và in ra số lớn nhất.
namespace CHUONG_IV
{
    class Bai_01_CHUONG_IV
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //khai báo biến
            int a = 0;//giá trị số 1
            int b = 0;//giá trị số 2
            int c = 0;//giá trị số 3
            int d = 0;//giá trị số 4

            //input
            Console.WriteLine("Nhập vào 4 số:");
            a = int.Parse(Console.ReadLine());//nhập vào giá trị số 1 từ bàn phím
            b = int.Parse(Console.ReadLine());//nhập vào giá trị số 2 từ bàn phím
            c = int.Parse(Console.ReadLine());//nhập vào giá trị số 3 từ bàn phím
            d = int.Parse(Console.ReadLine());//nhập vào giá trị số 4 từ bàn phím

            //tính
            if (a > b && a > c && a > c && a > d)//vd:a=5, b=4, c=3, d=2 => a là GTLN
            {

                //Output
                Console.WriteLine($"Trong {a}, {b}, {c}, {d} thì {a} là GTLN");//in ra màn hình
            }
            else if (b > a && b > c && b > d)//vd:b=5, a=4, c=3, d=2 => b là GTLN
            {

                //output
                Console.WriteLine($"Trong {a}, {b}, {c}, {d} thì {b} là GTLN");// in ra màn hình
            }
            else if (c > a && c > b && c > d)//vd:c=5, b=4, a=3, d=2 => c là GTLN
            {

                //output
                Console.WriteLine($"Trong {a}, {b}, {c}, {d} thì {c} là GTLN");//in ra màn hình
            }
            else//vd:d=5, b=4, c=3, a=2 => d là GTLN
            {

                //output
                Console.WriteLine($"Trong {a}, {b}, {c}, {d} thì {d} là GTLN");//in ra màn hình
            }
        }
    }
}
