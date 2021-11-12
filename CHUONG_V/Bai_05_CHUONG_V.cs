using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5.Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số hoàn hảo hay không? 
namespace CHUONG_V
{
    class Bai_05_CHUONG_V
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số nguyên:");
            int n = Convert.ToInt32(Console.ReadLine());
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
                Console.WriteLine($"{n} là số hoàn hảo.");
            }
            else
            {
                Console.WriteLine($"{n} không là số hoàn hảo.");
            }
        }
    }
}
