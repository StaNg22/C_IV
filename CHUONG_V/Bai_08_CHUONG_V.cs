using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//8.	Viết chương trình in ra bảng Cửu chương.
namespace CHUONG_V
{
    class Bai_08_CHUONG_V
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("BẢNG CỬU CHƯƠNG");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 2; j <= 9; j++)
                {
                    Console.Write($"{j}x{i}={i*j}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
