using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHUONG_III
{
    internal class Nguyen_Le_Nhut_Quyen_C3_BT7
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
            
            //tính
            s = a % 60;//vd a=86399 => s=59 
            p = (a / 60) % 60;//vd a=86399 => p=59
            h = a / 3600;// vd a=86399 => h=23
            Console.WriteLine($"Giờ đổi là: {h:00}:{p:00}:{s:00}");

            //output : vd a=867399 => 23:59:59

        }
    }
}
