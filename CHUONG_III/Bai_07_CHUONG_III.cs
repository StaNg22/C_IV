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
           
            //tính
            s = a % 60;//vd a=3599 => s=3599 chia lấy dư cho 60 =59
            if (a < 60)//TH1: số giây nhỏ hơn 60 
            {
                s = a;//vì a <60 nên b=a
                if (s < 10)//nếu b<10(vd b=6) nên b chỉ có 1 chữ số
                {

                    //output
                    Console.WriteLine($"Giờ được chuyển đổi là: 00:00:0{s}");//in ra màn hình dạng đổi từ a (vd: a=6 => b=6 => 00:00:06)
                }
                else//ngược lại (vd b=11)
                {

                    //output
                    Console.WriteLine($"Giờ được chuyển đổi là: 00:00:{s}");//in ra màn hình dạn đổi từ a (vd: a=11 =>b=11 => 00:00:11)
                }
                
            }
            else if (a >= 60 && a < 3600)//TH2: 60<=a<3600 (vd: a=3599 => 00:59:59)
            {
               
                p = a / 60;//vd a=3599 => p=3599/60(chia lấy phần nguyên) = 59
                
                if (p < 10 && s < 10)//vd p=1 VÀ s=1 => 00:01:01
                {
                    //output
                    Console.WriteLine($"Giờ được chuyển đổi là: 00:0{p}:0{s}");//in tra kết quả 
                }
                else if (p < 10)//vd: p=1 và s=11 => 00:01:11
                {
                    
                    //output
                    Console.WriteLine($"Giờ được chuyển đổi là: 00:0{p}:{s}");//in ra kết quả 
                }
                else if (s < 10)//vd: p=11 và s=2 => 00:11:02
                {

                    Console.WriteLine($"Giờ được chuyển đổi là: 0:{p}:0{s}");
                }
                else//vd:p=11 và s=11 => 00:11:11
                {

                    //output
                    Console.WriteLine($"Giờ được chuyển đổi là: 00:{p}:{s}");
                }
            }
            else//vd: a=3601 => 01:00:01
            {
                s = a % 60;
                p = (a / 60)%60;
                h = a / 3600;
                if (h < 10)
                {
                    Console.Write($"Giờ được chuyển đổi là: 0{h}:");
                }
                else
                {
                    Console.Write($"Giờ được chuyển đổi là: {h}:");
                }
                if (p < 10)
                {
                    Console.Write($"0{p}:");
                }
                else
                {
                    Console.Write($"{p}:");
                }
                if (s < 10)
                {
                    Console.WriteLine($"0{s}");
                }
                else
                {
                    Console.WriteLine($"{s}");
                }
            }
        }
    }
}
