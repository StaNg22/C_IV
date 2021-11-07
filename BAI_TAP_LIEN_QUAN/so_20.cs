using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5.Cho mảng 1 chiều gồm n phần tử nguyên, sắp xếp lại mảng tăng dần. Rồi in ra màn hình.
namespace Bai_Tap_80
{
    class so_20
    {
        static void Main()
        {
            Console.WriteLine("Nhập vào số phần tử: ");
            int n = int.Parse(Console.ReadLine());
            int[] sx = new int[1000000];
            for (int i = 1; i <= n; i++)
            {
                sx[i] = int.Parse(Console.ReadLine());
            }

        }
    }
}
