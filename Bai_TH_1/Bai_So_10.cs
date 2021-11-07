using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 1.10: Giải và biện luận phương trình bậc 2

namespace Bai_TH_1
{
    class Bai_10
    {
        static void Main()
        {
            Console.WriteLine("Nhap a: ");
            float a = System.Single.Parse(Console.ReadLine());

            Console.WriteLine("Nhap b: ");
            float b = System.Single.Parse(Console.ReadLine());

            Console.WriteLine("Nhap c: ");
            float c = System.Single.Parse(Console.ReadLine());
            float D = b * b - 4 * a * c;
            if (a > 0 && D > 0)
            {
                float x1 = (float)(-b + Math.Sqrt(D) / 2 * a);

                float x2 = (float)(-b - Math.Sqrt(D) / 2 * a);

                Console.WriteLine("Phuong trinh co 2 nghiem phan biet:");

                Console.WriteLine($"x = {x1}");
                Console.WriteLine($"x = {x2}");
            }
            else if (D == 0)
            {
                float x = -b / a;
                Console.WriteLine($"Phuong trinh co nghiem la: {x}");
            }
            else if (D < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem.");
            }
            
        }
    }
}
    

