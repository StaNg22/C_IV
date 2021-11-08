using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
        7.	Viết chương trình nhập vào tháng, kiểm tra điều kiện nếu tháng không hợp lệ thì phải nhập lại. 
            Nếu tháng hợp lệ thì in ra tháng đã nhập thuộc quý nào?
*/
namespace CHUONG_I
{
    class Class_7
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào tháng:");
            uint a = uint.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine($"{a} thuộc quý 1");
                    break;
                case 2:
                    Console.WriteLine($"{a} thuộc quý 1");
                    break;
                case 3:
                    Console.WriteLine($"{a} thuộc quý 1");
                    break;
                case 4:
                    Console.WriteLine($"{a} thuộc quý 2");
                    break;
                case 5:
                    Console.WriteLine($"{a} thuộc quý 2");
                    break;
                case 6:
                    Console.WriteLine($"{a} thuộc quý 2");
                    break;
                case 7:
                    Console.WriteLine($"{a} thuộc quý 3");
                    break;
                case 8:
                    Console.WriteLine($"{a} thuộc quý 3");
                    break;
                case 9:
                    Console.WriteLine($"{a} thuộc quý 3");
                    break;
                case 10:
                    Console.WriteLine($"{a} thuộc quý 4");
                    break;
                case 11:
                    Console.WriteLine($"{a} thuộc quý 4");
                    break;
                case 12:
                    Console.WriteLine($"{a} thuộc quý 4");
                    break;
                default:
                    Console.WriteLine("Vui lòng nhập lại");
                    break;
            }
        }
    }
}
