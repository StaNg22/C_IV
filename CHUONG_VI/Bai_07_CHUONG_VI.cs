using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//7.Viết hàm kiểm tra một số nguyên có phải là số đối xứng hay không? 
//Liệt kê và đếm số lượng các số đối xứng trong khoảng từ 1 đến 500.
/*Name:Nguyenn_Le_Nhut_Quyen
*Date:19/11/2021
*/
namespace CHUONG_VI
{
    
    internal class Bai_07_CHUONG_VI
    {
        static bool ktsdx(int n)
        {
            int spd = 0;
            int skt = 0;
            int ss = n;
            while (n > 0)
            {
                spd = n % 10;
                skt = skt * 10 + spd;
                n /= 10;
            }
            if (skt == ss)
            {
                return true;
            }
            return false;
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int dem = 0;
            Console.WriteLine("Số đối xứng từ 1->500 là:");
            for (int i = 1; i <= 500; i++)
            {
                if (ktsdx(i) == true)
                {
                    Console.Write("{0}  ",i);
                    dem++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"=> Số lượng số đối xứng từ 1->500 là: {dem}");
        }
    }
}
