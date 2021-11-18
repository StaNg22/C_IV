using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
1.Viết chương trình nhập vào một số nguyên dương n. Viết menu cho phép lựa chọn tính và hiển thị kết quả một trong các biểu thức sau:
A = Tổng các số lẻ nhỏ hơn hay bằng n.
B = Tích các bội số của 3 và nhỏ hơn hoặc bằng n.
C = 1 + 1/2 + 1/3 + . . . + 1/n-1.
D = 2 * 4 * 6 * … 2n.
E = N! = 1 * 2 * . .  * n.
 */
namespace CHUONG_V
{
    class Bai_01_CHUONG_V
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số nguyên n:");
            int n =Convert.ToInt32.Par(Console.ReadLine());
            int A = 0, B = 1, E = 1, D = 1; 
            float C = 0;
            Console.WriteLine("Bạn chọn cái gì(A, B, C, D):");
            string chọn = Console.ReadLine();
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    A += i;
                }
                B *= i * 3;
                C += 1f / i;
                E *= i;
            }
            for (int i = 1; i < 2*n; i++)
            {
                if (i % 2 == 0)
                {
                    D *= i;
                }
            }
            switch (chọn)
            {
                case "A":
                    Console.WriteLine($"Tổng các số lẻ bé hơn {n} là: {A}");
                    break;
                case "B":
                    Console.WriteLine($"Tích các bội của 3 nhỏ hơn {n} là: {B}");
                    break;
                case "C":
                    Console.WriteLine($" 1 + 1/2 + 1/3 + . . . + 1/{n-1} = {C}");
                    break;
                case "D":
                    Console.WriteLine($"2 * 4 * 6 * … {2*n} = {D}");
                    break;
                case "E":
                    Console.WriteLine($"{n}! = {E}");
                    break;
                default:
                    Console.WriteLine($"{chọn} không thuộc A, B, C, D. VUI LONG NHẬP LẠI!!!");
                    break;
            }
        }
    }
}
