using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
        7.	Viết chương trình nhập vào số giây từ 0 đến 86399, 
            đổi số giây nhập vào thành dạng "gio:phut:giay",
            mỗi thành phần là một số nguyên có 2 chữ số.
 */
namespace CHUONG_III
{
    class Bai_07_CHUONG_III
    {
      static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //khai báo biến
            uint a = 0;//số giây
            uint s = 0;//giá trị giây được chuyển từ a
            uint p = 0;//giá trị phút được chuyển từ a
            uint h = 0;//giá trị giờ được chuyển từ a


            //input
            Console.Write("Nhập vào số giây: ");
            a = uint.Parse(Console.ReadLine());//nhập số giây từ bàn phím
          
                s = a % 60;//vd a=86399 => s=59 
                p = (a / 60)%60;//vd a=86399 => p=59
                h = a / 3600;// vd a=86399 => h=23
                if (h < 10)//nếu h<10
                {
                    Console.Write($"Giờ được chuyển đổi là: 0{h}:");//vd h=1 thì in ra giờ được chuyển đổi là : 01:
                }
                else// ngược lại h>=10
                {
                    Console.Write($"Giờ được chuyển đổi là: {h}:");//vd h=11 thì in ra giờ được chuyển đổi là : 11:
                }
                if (p < 10)// nếu p<10
                {
                    Console.Write($"0{p}:");//in ra vd p=2 => 02:
                }
                else//ngược lại p>=10
                {
                    Console.Write($"{p}:");//in ra vd p=12 => 12:
                }
                if (s < 10)//nếu s<10
                {
                    Console.WriteLine($"0{s}");//in ra vd s=3 => 03
                }
                else//ngược lại s>=10
                {
                    Console.WriteLine($"{s}");//in ra cd s=13 => 13
                }

                //output : vd a=867399 => 23:59:59
           
        }
    }
}
