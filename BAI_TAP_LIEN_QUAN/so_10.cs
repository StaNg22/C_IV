using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//10.	Viết chương trình nhập vào 1 số n (n>=10) và kiểm tra xem n có phải số nguyên tố hay ko? In kết quả kiểm tra lên màn hình.
namespace Bai_Tap_80
{
    class _10
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n,dem = 0;
            Console.WriteLine("Nhập vào số nguyên n:");
            n = int.Parse(Console.ReadLine());
            if (n >= 10)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        dem++;
                    }
                }
                if (dem == 2)
                {
                    Console.WriteLine($"{n} là số nguyên tố.");
                }
                else
                {
                    Console.WriteLine($"{n} không phải là số nguyên tố.");
                }
            }
            else
            {
                Console.WriteLine($"{n} < 10 Vui lòng nhập n lớn hơn 10.");
            }
        }
    }
}
