using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4.Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số chính phương hay không?
/*Name:Nguyenn_Le_Nhut_Quyen
 *Date:19/11/2021
 */
namespace CHUONG_V
{
    class Bai_04
        
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //khai báo biến
            int n = 0;
            bool scp = false;//giá tri so sánh số chính phương

            //input
            Console.WriteLine("Nhập vào số nguyên n:");
            n = Convert.ToInt32(Console.ReadLine());

            //tính
            for (int i = 1; i <= n; i++)//vd: Số chính phương chia hết cho 2 thì chia hết cho 4(2^2)
            {
                if (i % Math.Sqrt(n) == 0)
                {
                    scp = true;
                }
                else
                {
                    scp=false;
                }
            }
            if (scp)//dk đúng
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