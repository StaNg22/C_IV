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
        static void Main()
        {
            int n = 0;
            char kt;
            
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số nguyên dương n:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bạn chọn phép toán nào (A, B, C, D):");
            kt = Convert.ToChar(Console.ReadLine());
            if (n >= 0)

            {
                switch (kt)
                {
                    case 'A':
                        Console.WriteLine($"A Tổng các số lẻ nhỏ hơn hay bằng {n} là {TongLe(n)}");
                        break;
                    case 'B':
                        Console.WriteLine($"B Tích các bội số của 3 và nhỏ hơn hoặc bằng {n} là {TichBoi(n)}");
                        break;
                    case 'C':
                        Console.WriteLine($"C Tổng nghịch đảo các số tự nhiên nhỏ hơn {n} là {TongNghichDao(n)}");
                        break;
                    case 'D':
                        Console.WriteLine($"D Tích nhân đôi các số tự nhiên nhỏ hơn {n} là {TichNhanDoi(n)}");
                        break;
                    case 'E':
                        Console.WriteLine($"E {n}! = {GiaThua(n)}");
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
        static double TongLe(int n)//tổng lẻ
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
        static double TongNghichDao(int n)//tổng nghịch đảo
        {
            double c = 0;
            for (int i = 1; i <= n; i++)
            {
                c += 1 / i;
            }
            return c;
        }
        static double TichNhanDoi(int n)//
        {
            double d=1;
            if (n == 0)
            {
                d = 0;
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    d *= (2 * i);
                }
                
            }
            return d;
        }
        static double TichBoi(int n)
        {
            double b = 1;
            if (n == 0)
            {
                b = 0;
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i * 3 <= n)
                    {
                        b *= i * 3;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return b;
        }
        static double GiaThua(int n)
        {
            double e = 1;
            for (int i = 1;i<=n;i++)
            {
                e *= i;
            }return e;
        }

    }
}
