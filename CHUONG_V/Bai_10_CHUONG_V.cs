using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//10.Viết chương trình vẽ các tam giác đều n dòng bằng các dấu *. Ví dụ n=4:
//      *      
//     * *
//    * * *
//   * * * *
namespace CHUONG_V
{
    internal class Bai_10_CHUONG_V
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0;
            Console.WriteLine("Nhập vào số n:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
