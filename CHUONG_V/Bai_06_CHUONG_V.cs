using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
6.Viết chương trình tìm số hạng thứ n của dãy Fibonaci.
	Dãy Fibonaci là dãy số gồm các số hạng F(n) với:
F0 = F1 = 1; Fn = Fn - 1 + Fn - 2
	Dãy Fibonaci sẽ là: 1 1 2 3 5 8 13 21 34 55 89 144…
 */
namespace CHUONG_V
{
    class Bai_06_CHUONG_V
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //khai báo biến
            int n = 0;//giá trị số hạng thứ n
            double F0 = 1;//giá trị thứ hạng F0
            double F1 = 1;//giá trị thứ hạng F1
            double Fn = 0;//giá trị thứ hàng Fn

            //input
            Console.WriteLine("Nhập vào n:");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 2)
                {
                    Fn = 1;
                    Console.WriteLine($"Số thứ hạng {n} của dãy Fibonaci là F{n-1} = {Fn}");
                }
                else
                {
                    for (int i = 2; i < n; i++)
                    {
                        Fn = F0 + F1;
                        F0 = F1;
                        F1 = Fn;
                    }
                     Console.WriteLine($"Số thứ hạng {n} của dãy Fibonaci là F{n-1} = {Fn}");
                }
            }
        }
    }
}
