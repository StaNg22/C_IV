using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    2.Viết các hàm tính các biểu thức sau với n là số nguyên dương do người dùng nhập vào từ bàn phím:
    A = Tổng các số lẻ nhỏ hơn hay bằng n
    B = Tích các bội số của 3 và nhỏ hơn hoặc bằng n
    C = 1 + 1/2 + 1/3 + . . . + 1/n-1.
    D = 2 * 4 * 6 * … 2n.
    E = N! = 1 * 2 * . .  * n.
	Trong hàm main viết menu chương trình cho phép lựa chọn, gọi hàm và hiển thị kết quả.
 */
/*Name:Nguyenn_Le_Nhut_Quyen
 *Date:19/11/2021
 */
namespace CHUONG_VI
{
    internal class Bai_02_CHUONG_VI
    {
       static double tl(double n)
        {
            double a = 0;
            
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    a += i;
                }
            }return a;
        }
        static double tnd(double n)
        {
            double c = 0;
            for (int i = 0; i <= n; i++)
            {
                c += 1 / i;
            }
            return c;
        }
        static double tn(double n)
        {
            double d = 0;
            for (int i = 0; i <= n; i++)
            {
                d *= (2 * i);
            }
            return d;
        }
        static double tb(double n)
        {
            double b = 0;

            for (int i = 0; i <= n; i++)
            {
                b *= (i * 2);
            }
            return b;
        }
        static double gt(double n)
        {
            double e = 0;

            for (int i = 0; i <= n; i++)
            {
                e *= i ;
            }
            return e;
        }
        static void Main()
        {
            double n = 0;
            char kt;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số nguyên dương n:");
            n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bạn chọn phép toán nào (A, B, C, D):");
            kt = Convert.ToChar(Console.ReadLine());
            if (n >= 0)
            
            {
                switch (kt)
                {
                    case 'A':
                        Console.WriteLine($"A = {tl(n)}");
                        break;
                    case 'B':
                        Console.WriteLine($"B = {tb(n)}");
                        break;
                    case 'C':
                        Console.WriteLine($"C = {tnd(n)}");
                        break;
                    case 'D':
                        Console.WriteLine($"D = {tn(n)}");
                        break;
                    case 'E':
                        Console.WriteLine($"E = {tn(n)}");
                        break;
                    default:
                        Console.WriteLine("Vui lòng nhập lại!!!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Vui lòng nhập lại!!!");
            }
        }
    }
}
