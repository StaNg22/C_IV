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
	BLACK, nếu color có giá trị khác.A
*/
/*Name:Nguyenn_Le_Nhut_Quyen
 *Date:19/11/2021
 */
namespace CHUONG_IV
{
    class Bai_08_CHUONG_IV
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Khao Báo Biến
            string a;//ký tự do người nhập

            //Input
            Console.WriteLine("Nhập vào ký tự");
            a = Console.ReadLine();

            //tính
            switch (a)
            {
                case "r":
                case "R":
                    Console.WriteLine($"{a} = RED");
                    break;
                case "G":
                case "g":
                    Console.WriteLine($"{a} = GREEN");
                    break;
                case "B":
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
