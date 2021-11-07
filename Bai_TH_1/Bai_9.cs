using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 1.9: Giải và biện luận phương trình bậc nhất a𝑥 + b = 𝟎

namespace Bai_TH_1
{
    class Bai_9
    {
        static void Main()
        {
            Console.WriteLine("Nhap a: ");
            float a = System.Single.Parse(Console.ReadLine());

            Console.WriteLine("Nhap b: ");
            float b = System.Single.Parse(Console.ReadLine());

            Console.WriteLine($"=> Phuong trinh co dang: {a}x + {b} = 0");
            float x;
            if (a > 0)
            {
                x =(float)( -b / a);
                Console.WriteLine($"x = {x}");
            }
            else if(a==0&&b==0)
            {
                Console.WriteLine("Phuong trinh vo so nghiem.");
            }    
            else if(a==0&&b!=0)
            {
                Console.WriteLine("Phuong trinh vo nghiem.");
            }    

        }
    }
}
