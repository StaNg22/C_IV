using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//12.Viết chương trình in dãy Fibonacci đã nêu trong bằng phương pháp dùng một hàm Fibonacci F có tính đệ quy. 
//F0 = 1, F1 = 1; Fn = Fn - 1 + Fn - 2
/*Name:Nguyenn_Le_Nhut_Quyen
 *Date:19/11/2021
 */
namespace CHUONG_VI
{
    internal class Bai_12_CHUONG_VI
    {
        static void tinday()
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
            Console.WriteLine();
            if (n <= 2)
            {
                Fn = 1;
                Console.WriteLine($"Số thứ hạng {n} của dãy Fibonaci là F{n - 1} = {Fn}");
            }
            else
            {

                for (int i = 2; i < n; i++)
                {
                    Fn = F0 + F1;
                    F0 = F1;
                    F1 = Fn;
                    Console.Write($"{Fn}  ");
                }

            }
        }
    }
}
