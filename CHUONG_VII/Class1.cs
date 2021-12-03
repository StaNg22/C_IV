using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  16.Tìm và in lên màn hình tất cả các số nguyên trong phạm vi từ 10 đến 99 
//  sao cho tích của 2 chữ số bằng 2 lần tổng của 2 chữ số đó.
/*Name:Nguyenn_Le_Nhut_Quyen
*Date:19/11/2021
*/
namespace CHUONG_V
{
    internal class Bai_16_CHUONG_V
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int dv = 0;//giá trị đơn vị
            int c = 0;//giá trị chục
            int t = 0;//giá trị tích của 
            int sss = 0;//giá trị so sánh

            for (int i = 10; i <= 99; i++)
            {
                dv = i % 10;
                c = i / 10;
                t = dv * c;
                sss = 2 * (c + dv);
                if (sss == t)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
