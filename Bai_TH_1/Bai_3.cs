using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Bài 1.3: Nhập vào hai số nguyên a, b. In ra màn hình kết quả các phép tính +, -, *, /, 
 *%. Lưu ý khi xử lý các phép chia sẽ cần ép kiểu, kiểm tra mẫu khác 0. Xuất kết 
 *quả ra màn hình trên từng dòng.
 */
namespace Hoc_Lap_Trinh_co_ban
{
    class Bai_TH_1
    {
        static void Main()
        {
            Console.WriteLine("Nhap vao so nguyen a: ");
            int a = System.Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao so nguyen b: ");
            int b = System.Int32.Parse(Console.ReadLine());

            int tong = a + b;
            int hieu = a - b;
            int tich = a * b;
            float thuong = (float)a / b;
            float du = a % b;

            Console.WriteLine($"{a} + {b} = {tong}");

            Console.WriteLine($"{a} - {b} = {hieu}");

            Console.WriteLine($"{a} * {b} = {tich}");

            Console.WriteLine($"{a} / {b} = {thuong}");

            Console.WriteLine($"{a} % {b} = {du}");
        }
    }
}