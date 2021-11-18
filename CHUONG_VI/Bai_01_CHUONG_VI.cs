using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.Viết hàm nhập vào một số nguyên dương n. 
//Kiểm tra điều kiện nếu n <= 0 thì nhập lại. Hàm trả về số nguyên vừa nhập.
namespace CHUONG_VI
{
    internal class Bai_01_CHUONG_VI
    {
        
        static void kt()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0;
            n = Convert.ToInt32(Console.ReadLine());
            
            while (n<=0)
            {
                Console.WriteLine("Vui lòng nhập lại!");
                 n = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Số vừa nhập là: {n}");
        }
        static void Main()
        {
            kt();
        }
    }
}
