using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5.Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số hoàn hảo hay không? 
/*Name:Nguyenn_Le_Nhut_Quyen
 *Date:19/11/2021
 */
namespace CHUONG_V
{
    class Bai_05_CHUONG_V
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //khai báo biến
            int n = 0;
            int dem = 0;

            //input
            Console.WriteLine("Nhập vào số nguyên:");
            n = Convert.ToInt32(Console.ReadLine());
            
            //tính
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
