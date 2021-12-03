using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//6.Viết hàm kiểm tra một số nguyên có phải là số hoàn hảo hay không? Liệt kê các số hoàn hảo trong khoảng từ 1 đến 1000.
/*Name:Nguyenn_Le_Nhut_Quyen
 *Date:19/11/2021
 */
namespace CHUONG_VI
{
    internal class Bai_06_CHUONG_VI
    {
        static bool ktshh(int n)
        {
            int dem = 0;
            for (int i = 1; i < n; i++)
            
                if (n % i == 0)
                {
                    dem += i;
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
            
           
            Console.WriteLine("=> Số hoàn hảo từ 1->1000 là:");
            for (int i = 1; i <= 1000; i++)
            {
                if (ktshh(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
