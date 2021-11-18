using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4.Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số chính phương hay không?
namespace CHUONG_V
{
    class Bai_04
        
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số nguyên n:");
            int n = Convert.ToInt32(Console.ReadLine());
            bool scp=false;
            for (int i = 1; i <= n; i++)//vd: Số chính phương chia hết cho 2 thì chia hết cho 4(2^2)
            {
                if (i % n == 0 && i % Math.Sqrt(n) == 0)
                {
                    scp = true;
                }

            }
            if (scp)
            {
                Console.WriteLine($"{n} là số chính phương.");
            }
            else
            {
                Console.WriteLine($"{n} không là số chính phương. ");
            }
        }
    }
}
