using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
9.Viết hàm tìm USCLN, BSCNN của a và b theo thuật toán gợi ý sau đây:
	Nếu a >= b thì gán a = a % b , ngược lại gán b = b % a. Lặp cho đến khi a hoặc b bằng 0. USCLN là (a+b).
	BSCNN(a, b) = (a * b) / USCLN(a, b)
Trong hàm main, cho phép nhập vào hai số nguyên a, b, 
gọi và thực thi các hàm trên để in ra USCLN và BSCNN của hai số a và b.
 */

namespace CHUONG_VI
{
    internal class Bai_09_CHUONG_VI
    {
        static void T(int a,int b)
        {
            int UCLN = 0;
            int BCNN = 0;
            int dem = a * b;
            int s1 = a;
            int s2 = b;
            while (a*b!=0)
            {
                if (a >= b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }
            UCLN = a + b;
            BCNN = dem / UCLN;
            Console.WriteLine($"UCLN({s1}, {s2}) = {UCLN}");
            Console.WriteLine($"BCNN({s1}, {s2}) = {BCNN}");
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a = 0;
            int b = 0;
            Console.WriteLine("Nhập vào số nguyên a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập vào số nguyên b:");
            b = Convert.ToInt32(Console.ReadLine());
            T(a, b);
        }
    }
}
