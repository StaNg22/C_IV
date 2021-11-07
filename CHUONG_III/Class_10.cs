using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  	Viết chương trình nhập vào tọa độ của hai điểm (x1, y1) và (x2, y2). 
    Tính khoảng cách giữa hai điểm theo công thức: 
    Khoảng cách=√(〖(y_2-y_1)〗^2  +〖(x_2-x_1)〗^2 )

 */
namespace CHUONG_III
{
    class Class_10
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào 2 tọa độ:A:(x1; y1) và B:(x2; y2)");
            float x1 = float.Parse(Console.ReadLine());
            float y1 = float.Parse(Console.ReadLine());

            float x2 = float.Parse(Console.ReadLine());
            float y2 = float.Parse(Console.ReadLine());
           

            Console.WriteLine($"Khoảng các AB={Math.Sqrt(Math.Pow((y2 - y1),2) + Math.Pow((x2 - x1),2))}");
        }
    }
}
