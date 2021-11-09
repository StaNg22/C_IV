using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//7.Viết chương trình nhập vào một ký tự. In ra mã Ascii của ký tự đó và in ra ký tự kế tiếp của nó. 
namespace CHUONG_I
{
    class Class_7
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Khai báo biến
            char kt;//ký tự nhập vào
            int a = 0;//

            //Input
            Console.WriteLine("Nhập vào ký  tự:");
            kt = Convert.ToChar(Console.ReadLine());
            Console.Write($"'{kt}' đổi thành mã ASCII là:");
            //tính
            a = kt;
            //input
            Console.WriteLine($" {a}");
        }
    }
}
