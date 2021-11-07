using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 1.11: Nhập vào ba số thực a, b, c đều dương. Kiểm tra xem đó có phải là ba cạnh 
//của một tam giác hay không. Nếu có hãy chỉ ra đó là loại tam giác nào?

namespace Bai_TH_1
{
    class Bai_11
    {
        static void Main()
        {
            Console.WriteLine("Nhap a: ");
            float a = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Nhap b: ");
            float b = Convert.ToSingle(Console.ReadLine()); 

            Console.WriteLine("Nhap c: ");
            float c = Convert.ToSingle(Console.ReadLine());
            if(a + b > c && a + c > b && b + c > a)
            {
                if(a==b && b==c)
                {
                    Console.WriteLine("Tam giac ABC là tam giac dieu.");
                } 
                if(a*a==(b*b+c*c) || b*b==(c*c+a*a) || c*c==(b*b+a*a))
                {
                    Console.WriteLine("Tam giac ABC la tam giac vuong.");
                } 
                if(a==b || b==c || c==a)
                {
                    Console.WriteLine("Tam giac ABC la tam giac can.");
                }    
               if(a==b&& c * c == (b * b + a * a) || b == c&& a * a == (b * b + c * c) || c == a&&b*b == (c * c + a * a))
                {
                    Console.WriteLine("Tam giac ABC la tam giac vuong can.");
                } 
            }  
            else
            {
                Console.WriteLine(" a, b, c khong lap thanh tam giac.");

            }    
        }
    }
}
