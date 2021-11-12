using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//9.Viết chương trình vẽ các tam giác vuông cân n dòng bằng các dấu *. Ví dụ n=4:
//  *
//  **
//  ***
//  ****

namespace CHUONG_V
{
    class Bai_09_CHUONG_V
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0;
            Console.WriteLine("Nhập vào số lần n:");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
