using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 1.4: Nhập vào hai số nguyên a, b. So sánh xem số nào lớn hơn, số nào nhỏ hơn 
//hay hai số bằng nhau. In kết quả ra màn hình.
namespace Bai_TH_1
{
    class Bai_4
    {
        static void Main ()
        {
            Console.WriteLine("Nhap so nguyen a: ");
            int a = System.Int32.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so nguyen b: ");
            int b = System.Int32.Parse(Console.ReadLine());
            if(a>b)
            {
                Console.WriteLine($"{a} > {b}");
            }
            else if(a==b)
            {
                Console.WriteLine($"{a} = {b}");
            }    
            else if(a<b)
            {
                Console.WriteLine($"{a} < {b}");
            }    
        }
    }
}
