using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 2.2: Nhập số tự nhiên n rồi tính tổng: S = 1 + 2 + ... + n.
namespace Thuc_Hanh_2
{
    class Bai_2
    {
        static void Main()
        {
            Console.WriteLine("Nhap so tu nhien n: ");
            uint n = Convert.ToUInt32(Console.ReadLine());
            int S = 0;
            for (int i = 0; i <= n; i++)
            {
                S+= i;
            }
            Console.WriteLine($"Tong: S = 1 + 2 +...+{n}");
            Console.WriteLine($"S = {S}");
        }
            
    }
}
