using System;
using System.Text;
/*
     5.	Viết chương trình nhập vào giờ phút giây (hh:mm:ss) và số giây thêm vào. 
     Tính và in ra kết quả dưới dạng (hh:mm:ss) mới sau khi cộng số giây thêm vào.
 */
namespace CHUONG_IV
{
    class Bai_05_CHUONG_IV
    {
        
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("TÍNH THỜI GIAN");

            Console.WriteLine("Nhập số giờ:");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào phút:");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào giây:");
            int s1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào số giây cộng vào:");
            int s2 = int.Parse(Console.ReadLine());

            int h1 = 0;
            int m1 = 0;
            int s3 = 0;
            int st = 0;

            if (m >= 60 || s1 >= 60)
            {
                Console.WriteLine("Vui lòng nhập lại ");
            }
            else
            {
                Console.WriteLine("=>");
                Console.Write($"{h:00}:{m:00}:{s1:00}");
                Console.Write(" + ");
                Console.Write($"{s2:00}s = ");
                   
                    st = h * 3600 + m * 60 + s1+s2;
                    s3 = st%60;
                    m1 = st%60;
                    h1 = st / 3600;
                    Console.WriteLine($"{h1:00}:{m1:00}:{s3:00}");
                
            }
        }
    }
}