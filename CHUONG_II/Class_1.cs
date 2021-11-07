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
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào bán kính r = ");
            float r = float.Parse(Console.ReadLine());
            Console.WriteLine($"Chu vi của đường tròn có bán kính {r} là: {(float)2 * r * Math.PI}");
            Console.WriteLine($"diện tích của hình tròn có bán kính {r} là: {(float)Math.Pow(r, 2) * Math.PI}");
        }
    }
}

