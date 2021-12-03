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
            int b;//máy đánh 

            //Input
            Console.Write("Người số 1 đánh: ");
            a = Convert.ToChar(Console.ReadLine());//kí tự a nhập từ bàn phím
            Random choitrochoi = new Random();
            b = choitrochoi.Next(3);//xuất ngẫu nhiên từ 0 đến 2

            //tính
            if (a != 'K' || a != 'B' || a != 'G')
            {
                Console.WriteLine("Vui lòng nhập lại!!!");
            }
            else
            {
                switch (b)
                {
                    case 0://Búa
                        switch (a)
                        {
                            case 'K':
                                Console.Write("  Bạn Thua ");
                                break;
                            case 'B':
                                Console.Write("  Bạn Hòa ");
                                break;
                            case 'G':
                                Console.Write("  Bạn Thắng ");
                                break;
                        }
                        break;
                    case 1://Giấy
                        switch (a)
                        {
                            case 'K':
                                Console.Write("  Bạn Thắng ");
                                break;
                            case 'B':
                                Console.Write("  Bạn Thua ");
                                break;
                            case 'G':
                                Console.Write("  Bạn Hòa ");
                                break;
                        }
                        break;
                    case 2://Kéo
                        switch (a)
                        {
                            case 'K':
                                Console.Write("  Bạn Hòa ");
                                break;
                            case 'B':
                                Console.Write("  Bạn Thắng ");
                                break;
                            case 'G':
                                Console.Write("  Bạn Thua ");
                                break;
                        }
                        break;

                }
            }
        }
    }
}
