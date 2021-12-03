using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//10.Viết chương trình đếm các số hoàn hảo nhỏ hơn hoặc bằng N, 
//   với N là số nguyên dương được nhập vào từ bàn phím.
/*Name:Nguyenn_Le_Nhut_Quyen
 *Date:19/11/2021
 */
namespace CHUONG_VI
{
    internal class Bai_10_CHUONG_VI
    {
        static bool dshh(double n)
        {
            int dem = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    dem += i;
                }
            }
            if (dem == n)
            {
                return true;
            }
            return false;
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            double n = 0;
            int dem = 0;
            Console.WriteLine("Nhập vào số nguyên dương n:");
            n = Convert.ToDouble(Console.ReadLine());
            
            if (n <= 0)
            {
                Console.WriteLine($"{n} không thỏa yêu cầu !!!");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (dshh(i) == true)
                    {
                        dem++;
                    }
                }
                Console.WriteLine($"Số số hoàn hảo từ 1 đến {n} là : {dem}");
            }
        }
    }
}
