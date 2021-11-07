using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 2.11. Viết chương trình liệt kê n số nguyên tố đầu tiên.

namespace Thuc_Hanh_2
{
    class Bai_so_11
    {
        static void Main()
        {
            Console.Write("Nhap so nguyen n: ");
            uint n = Convert.ToUInt32(Console.ReadLine());
            uint dem = 0;
            int m = 2;
            while (dem < n)
            {
                bool snt = true;
                for (int i = 2; i<= Math.Sqrt(m); i++)
                {
                    if (m % i == 0)
                    {
                        snt = false;
                        break;
                        
                    }
                }
                    if (snt)
                    {
                        Console.Write(m + ", ");
                        dem++;
                    }
                     m++;
            }
            Console.WriteLine();
        }
    }
}
