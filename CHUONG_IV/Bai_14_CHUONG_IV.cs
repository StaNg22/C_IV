using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
14.Viết chương trình trò chơi One-Two-Three ra cái gì ra cái này theo điều kiện:
	Búa(B) thắng Kéo, thua Giấy.
	Kéo (K) thắng Giấy, thua Búa.
	Giấy (G) thắng Búa, thua Kéo.
	Hướng dẫn: Dùng lệnh switch lồng nhau.
 */
/*Name:Nguyenn_Le_Nhut_Quyen
 *Date:19/11/2021
 */
namespace CHUONG_I
{
    class Bai_14_CHUONG_IV
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("---One - Two - Three---");

            //khai báo biến
            char a;//người đánh số 1
            int b;//người đánh số 2

            //Input
            Console.Write("Người số 1 đánh: ");
            a = Convert.ToChar(Console.ReadLine());//kí tự a nhập từ bàn phím
            Random choitrochoi = new Random();
            b = choitrochoi.Next(3);
            //tính
            if (a != 'K' || a != 'B' || a != 'G')
            {
                Console.WriteLine("Vui lòng nhập lại!!!");
            }
            else
            {
                switch (b)
                {
                    case 0:
                        switch (a)
                        {
                            case 'K':
                                Console.Write("  Thua ");
                                Console.WriteLine("B");
                                break;
                            case 'B':
                                Console.Write("  Hòa ");
                                Console.WriteLine("B");
                                break;
                            case 'G':
                                Console.Write("  Thắng ");
                                Console.WriteLine("B");
                                break;
                        }
                        break;
                    case 1:
                        switch (a)
                        {
                            case 'K':
                                Console.Write("  Thắng ");
                                Console.WriteLine("G");
                                break;
                            case 'B':
                                Console.Write("  Thua ");
                                Console.WriteLine("G");
                                break;
                            case 'G':
                                Console.Write("  Hòa ");
                                Console.WriteLine("G");
                                break;
                        }
                        break;
                    case 2:
                        switch (a)
                        {
                            case 'K':
                                Console.Write("  Hòa ");
                                Console.WriteLine("K");
                                break;
                            case 'B':
                                Console.Write("  Thắng ");
                                Console.WriteLine("K");
                                break;
                            case 'G':
                                Console.Write("  Thua ");
                                Console.WriteLine("K");
                                break;
                        }
                        break;

                }
            }
        }
    }
}
