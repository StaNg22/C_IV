using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Bài 1.5: Hãy nhập 4 số nguyên a, b, c, d. Tìm giá trị nhỏ nhất trong đó và in ra màn 
 *hình. Trong trường hợp 4 số bằng nhau thì in ra: không có số nhỏ nhất.
 */
 //C1

namespace Bai_TH_1
{
    class Bai_5_C1
    {
        static void Main()
        {
            Console.WriteLine("Nhap so nguyen a: ");
            int a = System.Int32.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so nguyen b: ");
            int b = System.Int32.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so nguyen c: ");
            int c = System.Int32.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so nguyen d: ");
            int d = System.Int32.Parse(Console.ReadLine());

            if (a == b && c ==b && c == d)
            {
                Console.WriteLine("Khong co gia tri nho nhat.");
            }
            else
                int min2 = Math.Min
            {
                int min1 = Math.Min(a, b);(c, d);
                int mint = Math.Min(min1, min2);
                Console.WriteLine($"Gia Tri Nho Nha La: {mint}");
            }

        }

    }
}
