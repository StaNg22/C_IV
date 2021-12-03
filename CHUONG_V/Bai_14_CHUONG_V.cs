using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//14.Nhập một số nguyên dương n bất kỳ. Xuất ra số ngược lại. 
//Ví dụ: Nhập 1706 => Xuất 6071.
/*Name:Nguyenn_Le_Nhut_Quyen
 *Date:19/11/2021
 */
namespace CHUONG_V
{
    internal class Bai_14_CHUONG_V
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0;//giá trị số tự nhiên cần nghịch đảo
            int spd = 0;//giá trị lấy phần dư cộng vào
            int kqnd = 0;//giá trị nghịch đảo
            Console.WriteLine("Nhập và số nguyên dương n:");
            n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Vui lòng nhập lại!!!");
            }
            else
            {
                while (n > 0)
                {
                    spd = n % 10;
                    kqnd = kqnd * 10 + spd;
                    n = n / 10;
                }
                Console.WriteLine(+kqnd);
            }
        }
    }
}
