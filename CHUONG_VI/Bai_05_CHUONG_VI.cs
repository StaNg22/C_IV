using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5.Viết hàm kiểm tra xem một số nguyên có phải là số chính phương hay không?  
//Nếu là số chính phương thì hàm trả về true, ngược lại trả về false. 
//Trong hàm main gọi và thực thi hàm để kiểm tra số do người dùng nhập vào. 
//In kết quả ra màn hình “SCP” hoặc “Khong la SCP”.
/*Name:Nguyenn_Le_Nhut_Quyen
*Date:19/11/2021
*/
namespace CHUONG_VI
{ 
    internal class Bai_05_CHUONG_VI
    {
        static bool ktscp()
        {
            int n = 0;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số nguyên n:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int  i = 1;  i <= n;  i++)
           
                if (i % n == 0 && i % Math.Sqrt(n) == 0)
                {
                    return true;
                }
            return false;
        } 
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            if (ktscp() == true)
            {
                Console.WriteLine("=> SCP");
            }
            else
            {
                Console.WriteLine("=> Không là SCP");
            }
        }
    }
}
