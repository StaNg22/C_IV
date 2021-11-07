using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 1.8: Viết chương trình nhập bán kính của hình tròn và tính chu vi, diện tích hình 
//tròn đó.
namespace Bai_TH_1
{
    class Bai_8
    {
        static void Main()
        {
            Console.WriteLine("Nhap ban kinh r: ");
            float r = System.Single.Parse(Console.ReadLine());
            float cv = (float)(2*( r * Math.PI));
            float dt = (float)(r * r * Math.PI);
            Console.WriteLine($"Chu vu hinh tron la: {cv}");
            Console.WriteLine($"Dien tich hinh tron la: {dt}");
        }
    }
}
