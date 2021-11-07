using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 2.9: Viết chương trình nhập số nguyên n và kiểm tra n có phải số nguyên tố
//hay không.

namespace Thuc_Hanh_2
{
    class Bai_9
    {
        static void Main()
        {
          
            Console.WriteLine(" Nhap vao so nguyen n:");//in ra màn hihf nhap vào số nguyên
            int n = Convert.ToInt32(Console.ReadLine());
            int dem = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    dem++;
                }
            }
            if (dem == 2)
            {
                Console.WriteLine($"{n} la so nguyen to.");
            }
            else
            {
                Console.WriteLine($"{n} khong phai la so nguyen to.");
            }
        }
    }
}
