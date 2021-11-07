using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Hoc_Cua_Quyen
{
    class Bai_10_Bai_Tap_Tong_Hop
    {
        static void choi()
        {
            Random choitrochoi = new Random();
            int x = choitrochoi.Next(501);
            int a, dem =0;
            Console.WriteLine("Đã băt đầu rồi!");
            while (true)
            {
                
                Console.Write($"Nhập số lần {dem+1}: ");
                a = int.Parse(Console.ReadLine());
                if (a == x)
                {
                    Console.WriteLine("Chúc mừng bạn đã chiến thắng.");
                    Console.WriteLine($"Số của máy là: {x}");
                    break;
                }
                if(a>x)
                {
                    Console.WriteLine("Sai rồi! số bạn nhập lớn hơn máy.");
                    dem++;
                }
                if (a < x)
                {
                    Console.WriteLine("Sai rồi! số bạn nhập nhỏ hơn máy.");
                    dem++;
                }
                if(dem==7)
                {
                    Console.WriteLine($"Số của máy là: {x}");
                    break;
                }    

            }
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                choi();
                Console.WriteLine("Bạn có muốn chơi tiếp ?(yes,no)");
                string ll = Console.ReadLine();
                 if (ll=="no")
                {
                    break;
                }
            }
        }
    }
}
