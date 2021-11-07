using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 1.7: Viết chương trình nhập vào hai cạnh của hình chữ nhật và tính chu vi và 
//diện tích của hình chữ nhật đó. Hiển thị kết quả lên màn hình.
namespace Bai_TH_1
{
    class Bai_7
    {
        static void Main()
        {
            Console.WriteLine("Nhap vao chieu dai a: ");
            float a = System.Single.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao chieu rong b: ");
            float b = System.Single.Parse(Console.ReadLine());
            float cv = ((a + b) * 2);
            float dt = a * b;
            Console.WriteLine($"Dien tich hinh chu nhut la: {dt}");
            Console.WriteLine($"Chu vi hinh nhat la: {cv} ");

        }
    }
}
