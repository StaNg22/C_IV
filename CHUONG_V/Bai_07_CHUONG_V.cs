using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
7.Viết chương trình nhập hai số nguyên dương a, b. Tìm USCLN, BSCNN của a và b theo thuật toán gợi ý sau đây:
Nếu a >= b thì gán a = a % b , ngược lại gán b = b % a. Lặp cho đến khi a hoặc b bằng 0. USCLN là (a+b).
BSCNN(a, b) = (a * b) / USCLN(a, b)
 */
/*Name:Nguyenn_Le_Nhut_Quyen
 *Date:19/11/2021
 */
namespace CHUONG_V
{
    class Bai_07_CHUONG_V
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //khai báo biến
            int a = 0;
            int b = 0;
            int UCLN = 0;
            int BCNN = 0;
            int dem = 0;

            //input
            Console.WriteLine("Nhập vào số nguyên a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập vào số nguyên b:");
            b = Convert.ToInt32(Console.ReadLine());

            //tính
            dem = a * b;
            while (a*b!=0)
            {
                if (a > b)
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
            Console.WriteLine($"UCLN = {UCLN}");
            Console.WriteLine($"BCNN = {BCNN}");
        }
    }
}
