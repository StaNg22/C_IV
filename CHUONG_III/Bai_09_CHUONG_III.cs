using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    9.	Viết chương trình cho phép nhập vào số nguyên dương có ba chữ số.
    In ra số đảo ngược. Ví dụ: Nhập 123, in ra 321.
 */
namespace CHUONG_III
{
    class Bai_09_CHUONG_III
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //khai bái biến
            int a = 0;//giá trị có 3 chữ số
            int b = 0;//giá trị nghịch đảo từ a

            //input
            Console.WriteLine("Mời bạn nhập vào số nguyên có 3 chữ số:");
            a = int.Parse(Console.ReadLine());//nhập giá trị có 3 chữ số từ bàn phím

            //tính
            b=(a%10)*100 + ((a%100)/10)*10 +a/100;//tính nghịch đảo giá trị a vd:a=123 => b=300 + 20 + 1=321

            //output
            Console.WriteLine($"Số nghịch đảo của {a} là: {b}");
        }
    }
}
