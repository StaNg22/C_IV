using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 2.5: Nhập số nguyên dương n và tính tổng: S = 1 + 1.2 + 1.2.3 + ... + 1.2.3...n.

namespace Thuc_Hanh_2
{
    class Bai_5
    {
        static void Main()
        {
            Console.WriteLine("Nhap so nguyen n");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n>0)
            {
                long giathua = 1;
                long t = 0;
                for (int i = 1; i <=n; i++)
                {
                    giathua *= i;
                    t += giathua;
                }
                Console.WriteLine($"Tong S = 1 + 1.2 + 1.2.3 + ... + 1.2.3...{n}. = {t}");
            } 
            else
            {
                Console.WriteLine("Vui long nhap lai n.");
            }    
            
        }
    }
}
