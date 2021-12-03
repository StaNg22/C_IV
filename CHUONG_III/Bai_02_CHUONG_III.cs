using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
        2.	Viết chương trình đọc vào độ F, tính và in ra độ C theo công thức như sau:
        C = ((F – 32) * 5) / 9.
 */
namespace CHUONG_III
{
    class Bai_02_CHUONG_III
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //khai báo biến
            double F = 0;//giá trị độ F
            double C = 0;//giá trị độ C

            //Input
            Console.WriteLine("Nhập vòa độ F");
            F = double.Parse(Console.ReadLine());//nhập giá trị độ F tư bàn phím

            //tính
            C = ((F - 32) * 5) / 9;//đổi dộ F vừa nhập sang độ C

            //Output
            Console.WriteLine($"{F}F = {C}C");
        }
    }
}
