using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4.Viết hàm kiểm tra xem một số nguyên có phải là số nguyên tố hay không?
//Hàm trả về 1 nếu là số nguyên tố, ngược lại trả về 0.
//Trong hàm main gọi và thực thi hàm để kiểm tra số do người dùng nhập vào.
//In kết quả ra màn hình “SNT” hoặc “Khong la SNT”.
namespace CHUONG_VI
{
    internal class Bai_03_CHUONG_VI
    {
        static int ktsnt()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0;
            Console.WriteLine("Nhập vào số nguyên n:");
            n = Convert.ToInt32(Console.ReadLine());
            int dem = 0;
            if (n <= 1)
            {
                return 0;
            }
            else
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
                    return 1;
                }
                return 0;
            }
        }
        static void Main()
        {
            
            
                if (ktsnt() == 1)
                {
                    Console.WriteLine($"=> SNT ");
                }
                else
                {
                    Console.WriteLine($"=> Không SNT.");
                }
            
        }
    }
}
