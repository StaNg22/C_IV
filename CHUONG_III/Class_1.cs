using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  
 1.	Viết chương trình đọc vào 2 số nguyên và in ra kết quả của phép (+), phép trừ (-),
       phép nhân (*), phép chia (/).
       Nhận xét kết quả chia 2 số nguyên.
 */
namespace CHUONG_III
{
    class Class_1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Khai Báo Biến
            int a = 0;//giá trị số 1
            int b = 0;//giá trị số 2
            int A = 0;//kết quả phép cộng
            int B = 0;//Kết quả phép trừ
            double C = 0;//Kết quả phép nhân
            double D = 0;//Kết quả phép chia

            //Input
            Console.WriteLine("Nhập vào số nguyên a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào số nguyên b:");
            b = int.Parse(Console.ReadLine());

            //Tính
            A = a + b;
            B = a - b;
            C = a * b;
            D = (float)a / b;

            //Output
            Console.WriteLine($"{a} + {b} = {A}");
            Console.WriteLine($"{a} - {b} = {B}");
            Console.WriteLine($"{a} x {b} = {C}");
            Console.WriteLine($"{a} / {b} = {D}");
        }
    }
}
