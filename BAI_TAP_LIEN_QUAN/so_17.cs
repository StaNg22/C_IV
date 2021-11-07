using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2.Cho mảng một chiều n phần tử nguyên, nhập và in ra màn hình xem mảng có bao nhiêu phần tử âm và bao nhiêu phần tử dương.
namespace Bai_Tap_80
{
    class so_17
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n, i, dc = 0, dl = 0;
            Console.Write("Nhập số phẩn tử: ");
            n = int.Parse(Console.ReadLine());
            int[] k = new int[1000];
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine($"Mời nhập phần tử thứ {i}:");
                k[i] = int.Parse(Console.ReadLine());
            }
            Console.Write($"Tất cả các phần tử là: ");
            for (i = 1; i <= n; i++)
            {
                Console.Write($"{k[i]} ");
            }
            Console.WriteLine();
            for (i = 1; i <= n; i++)
            {
                if (k[i] > 0)
                {
                    dc++;
                }
            }
            Console.WriteLine($"Có {dc} so lớn hơn 0.");
            for (i = 1; i <= n; i++)
            {
                if (k[i] < 0)
                {
                    dl++;
                }
            }
            Console.WriteLine($"Có {dl} so bé hơn 0.");
        }
    }
}
