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
/*Name:Nguyenn_Le_Nhut_Quyen
 *Date:19/11/2021
 */
namespace CHUONG_V
{
    class Bai_01_CHUONG_V
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            //Khai Báo Biến
            int n = 0;
            int A = 0;
            int B = 1;
            int E = 1;
            int D = 1; 
            float C = 0;
            string chon;

            //input
            Console.WriteLine("Nhập vào số nguyên n:");
            n =Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Bạn chọn cái gì(A, B, C, D):");
            chon = Console.ReadLine();
            int kq;
            //tính
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    A += i;
                }
                E *= i;
                D *= (2 * i);
            }
            for (int i = 1; i < n; i++)
            {
                C += 1f / i;
            }
            for (int i = 1; 3*i <= n; i++)
            {
                kq=(n==0)?B=n:B *= i*3;
            }
            switch (chon)
            {
                case "A":
                    Console.WriteLine($"Tổng các số lẻ bé hơn {n} là: {A}");
                    break;
                case "B":
                    Console.WriteLine($"Tích các bội của 3 nhỏ hơn bằng {n} là: {B}");
                    break;
                case "C":
                    Console.WriteLine($" 1 +. . . + 1/{n-1} = {C}");
                    break;
                case "D":
                    Console.WriteLine($"2 * … * {2*n} = {D}");
                    break;
                case "E":
                    Console.WriteLine($"{n}! = {E}");
                    break;
                default:
                    Console.WriteLine($"{chon} không thuộc A, B, C, D. VUI LONG NHẬP LẠI!!!");
                    break;
            }
        }
    }
}
