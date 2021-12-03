using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
8.Viết hàm tính số hạng thứ n của dãy Fibonaci.
	Dãy Fibonaci là dãy số gồm các số hạng F(n) với:
F0 = F1 = 1; Fn = Fn - 1 + Fn - 2
	Dãy Fibonaci sẽ là: 1 1 2 3 5 8 13 21 34 55 89 144…
Trong hàm main, nhập vào số nguyên không âm n, in ra số hạng thứ n của dãy Fibo ra màn hình.
 */
/*Name:Nguyenn_Le_Nhut_Quyen
 *Date:19/11/2021
 */
namespace CHUONG_VI
{
    internal class Bai_08_CHUONG_VI
    {
        static void TF(double n)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //khai báo biến
            double F0 = 1;//giá trị thứ hạng F0
            double F1 = 1;//giá trị thứ hạng F1
            double Fn = 0;//giá trị thứ hàng Fn

            //input
            
            if (n < 0)
            {
                Console.WriteLine("Vui lòng nhập lại!!!");
            }
            else
            {
                if (n <= 2)
                {
                    Fn = n;
                    Console.WriteLine($"Giá trị F{n} = {Fn}");
                }
                else
                {
                    for (int i = 2; i <= n; i++)
                    {
                        Fn = F0 + F1;
                        F0 = F1;
                        F1 = Fn;
                    }
                    Console.WriteLine($"Giá trị F{n} = {Fn}");
                }
            }
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            double n = 0;
            Console.WriteLine("Nhập vào số nguyên n(n>0):");
            n = Convert.ToDouble(Console.ReadLine());
            if (n > 0)
            {
                TF(n);
            }
            else
            {
                Console.WriteLine("Vui lòng nhập lại!!!");
            }
        }
    }
}
