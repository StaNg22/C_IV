using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Bài 2.13. Một số được gọi là số thuận nghịch nếu ta đọc từ trái sang phải hay từ
 *phải sang trái số đó ta vẫn nhận được một số giống nhau. Hãy nhập một số và 
 *kiểm tra xem số đó có phải số thuật nghịch hay không (ví dụ số: 558855).
 */
namespace Thuc_Hanh_2
{
    class Bài_so_13cs
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số nguyên n:");
            int n = int.Parse(Console.ReadLine());
            int m = n;
            int dao = 0;
            while (m > 0)
            {
                dao = dao * 10 + m % 10;
                m /= 10;
            }
            if (dao == n)
            {
                Console.WriteLine($"{n} là số thuận nghịch.");
            }
            else
            {
                Console.WriteLine($"{n} không phải là số thuận nghịch.");
            }
        }
    }
}
