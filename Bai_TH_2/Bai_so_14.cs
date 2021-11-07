using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Bài 2.14: Nhập số tự nhiên n rồi tính n! theo công thức:
 *       n! = 1 nếu n = 0
 *    n! = n*(n - 1) * (n - 2) * ... * 2 * 1 nếu n > 0
 */
namespace Thuc_Hanh_2
{
    class Bai_so_14
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số tự nhiên n:");
            int n = int.Parse(Console.ReadLine());
            int Ngt=1;
            if (n >= 0)
            {
                if (n == 0)
                {
                    Console.Write("n! = 1");
                    Console.WriteLine();
                }
                else
                {
                    for (int i = n; i >=1; i--)
                    {
                        Ngt *= i;
                    }
                    Console.WriteLine($"{n}! = {Ngt}");
                }
            }
            else
            {
                Console.WriteLine("Vui lòng học lại toán tiểu học!");
            }
        }
    }
}
