using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
        1.	Chương trình nhập vào bán kính hình tròn. Tính, in ra chu vi và diện tích của hình tròn. 
        	Biết PI =3.141; 
        	Chu vi = 2 * bán kính * PI; 
        	Diện tích = PI * bán kính * bán kính.
 */
namespace KTLT1
{
    class Class_1
    {
        static void Main(string[] args)
        {
            //1. Khai Báo Biến
            Console.OutputEncoding = Encoding.UTF8;
            float r = 0;// bán kính
            double cv = 0;// chu vi
            double dt = 0;//Diện tích

            //Input
            Console.Write("Nhập vào bán kính r = ");
            r = float.Parse(Console.ReadLine());//Nhập bán kính từ bàn phím
            //tính chu vi và diện tích
            cv = (float)2 * r * Math.PI;
            dt = (float)Math.Pow(r, 2) * Math.PI;

            //Output
            Console.WriteLine($"Chu vi của đường tròn có bán kính {r} là: {cv}");
            Console.WriteLine($"Diện tích của hình tròn có bán kính {r} là: {dt}");
        }
    }
}

