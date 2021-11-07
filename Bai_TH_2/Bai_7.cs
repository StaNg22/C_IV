using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 2.7: Nhập số tự nhiên n rồi liệt kê các ước số tự nhiên của nó. Số đó bao 
//nhiêu ước?

namespace Thuc_Hanh_2
{
    class Bai_7
    {
        static void Main()
        {
            Console.WriteLine("Nhap so tu nhien n: ");
            uint n = Convert.ToUInt32(Console.ReadLine());
            int dem = 0;
            Console.WriteLine($"Uoc cua {n} la: ");
            for (int i = 1; i <=n; i++)
            {
                if(n%i==0)
                {
                    Console.WriteLine(i);
                    dem++;
                }    
            }
            Console.WriteLine($"=> {n} co {dem} uoc.");

        }
    }
}
