using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Bài 1.5: Hãy nhập 4 số nguyên a, b, c, d. Tìm giá trị nhỏ nhất trong đó và in ra màn 
 *hình. Trong trường hợp 4 số bằng nhau thì in ra: không có số nhỏ nhất.
 */
//C2

namespace Bai_TH_1
{
    class Bai_5_C2
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

            if (a == b && c == b && c == d)
            {
                Console.WriteLine("Khong co gia tri nho nhat.");
            }
            else
            {
                int min = a;
                if(min>b)
                {
                    min = b;
                } 
                if (min>c)
                {
                    min = c;
                }
                if(min>d)
                {
                    min = d;
                }
                Console.WriteLine($"Gia tri nho nhat là{min}");
            }
        }

    }
}
