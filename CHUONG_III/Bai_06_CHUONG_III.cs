using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 6.	Viết chương trình nhập vào số nguyên dương có hai chữ số. In ra số đảo ngược. Ví dụ: Nhập vào 18, in ra 81.
 */
namespace CHUONG_III
{
    class Bai_06_CHUONG_III
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //khai báo biến
            int a = 0;//giá trị có 2 chữ số cần nghịch đảo
            int b = 0;//giá trị được nghịch đảo từ a

            //input
            Console.WriteLine("Nhập vào một số có 2 chữ số: ");
            a = int.Parse(Console.ReadLine());//nhập giá trị nghịch đảo từ bàn phím

            //tính
            b = a % 10 * 10 + a / 10;//tính giá trị nghịch đảo

            //output
            Console.WriteLine($"Số nghịch đảo của {a} là: {b}");
        }
    }
}
