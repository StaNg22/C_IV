using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Bài 1.2: Nhập vào một số nguyên n, hãy cho biết số đó chẵn hay lẻ, chia hết cho 3 
 *không, in kết quả kiểm tra ra màn hình. Mỗi kết luận trên một dòng.
 */
namespace Hoc_Lap_Trinh_co_ban
{
    class Bai_TH_1
    {
        static void Main()
        {
            Console.WriteLine("Nhap vao so nguyen n: ");
            int n = System.Int16.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine($"{n} la so chan");
            }
            else
            {
                Console.WriteLine($"{n} la so le");
            }
            if (n % 3 == 0)
            {
                Console.WriteLine($"{n} chia het cho 3");
            }
            else
            {
                Console.WriteLine($"{n} khong chia het cho 3");
            }
        }
    }
}
