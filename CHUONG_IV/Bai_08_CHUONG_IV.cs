using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
8.Viết chương trình xác định biến ký tự color rồi in ra thông báo
	RED, nếu color = 'R' hoặc color = 'r'
	GREEN, nếu color = 'G' hoặc color = 'g'
	BLUE, nếu color = 'B' hoặc color = 'b'
	BLACK, nếu color có giá trị khác.
*/
namespace CHUONG_I
{
    class Bai_08
        _CHUONG_IV
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào ký tự");
            string a = Console.ReadLine();
            switch (a)
            {
                case "r":
                    Console.WriteLine($"{a} = RED");
                    break;
                case "R":
                    Console.WriteLine($"{a} = RED");
                    break;
                case "G":
                    Console.WriteLine($"{a} = GREEN");
                    break;
                case "g":
                    Console.WriteLine($"{a} = GREEN");
                    break;
                case "B":
                    Console.WriteLine($"{a} = BLUE");
                    break;
                case "b":
                    Console.WriteLine($"{a} = BLUE");
                    break;
                default:
                    Console.WriteLine("BLACK");
                    break;
            }

        }
    }
}
