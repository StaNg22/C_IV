using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 2.15: Hãy viết chương trình tính tổng các chữ số của một số nguyên bất kỳ.
//Ví dụ: số 8545604 có tổng các chữ số là: 8 + 5 + 4 + 5 + 6 + 0 + 4 = 32
namespace Thuc_Hanh_2
{
    class Bai_so_15
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số n:");
            int n = int.Parse(Console.ReadLine());
            int m = n;
            if (n < 0)
            {
                n *= -1;
            }
            int tong = 0;
            while (n > 0)
            {
                tong += n % 10;
                n /= 10;
            }
            Console.WriteLine($"Tổng các chữ số của {m} là: {tong}");
        }
    }
}
