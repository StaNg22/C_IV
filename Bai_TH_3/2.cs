using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Bài 3.2: Nhập vào hai số nguyên dương m, n. Vẽ hình chữ nhật rỗng bằng các dấu 
    kích thước m x n. Ví dụ với m = 4, n = 5:
     * * * * *
     *       *
     *       *
     * * * * *
 */

namespace Bai_TH_3
{
    class _2
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào m:");
            int m = int.Parse(Console.ReadLine());
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == m || j == n || i==1 || j==1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
