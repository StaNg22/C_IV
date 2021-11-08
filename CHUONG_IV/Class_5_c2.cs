using System;
using System.Text;
/*
     5.	Viết chương trình nhập vào giờ phút giây (hh:mm:ss) và số giây thêm vào. 
     Tính và in ra kết quả dưới dạng (hh:mm:ss) mới sau khi cộng số giây thêm vào.
 */
namespace CHUONG_I
{
    class Class_5
    {
        static void a(int h)
        {
            string a = (h < 10) ? $"0{h}:" : $"{h}:";
            Console.Write($"{a}");
        }
        static void ts(int s1)
        {
            string a = (s1 < 10) ? $"0{s1}" : $"{s1}";
            Console.Write($"{a}");
        }
        
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

            int h1, m1, s3;
            if (m >= 60 && s1 >= 60)
            {
                Console.WriteLine("Vui lòng nhập lại ");
            }
            else
            {
                Console.WriteLine("=>");
                a(h);
                a(m);
                ts(s1);
                Console.Write(" + ");
                Console.Write($"{s2}s = ");
                if (s1 + s2 < 60)
                {
                    a(h);
                    a(m);
                    ts(s1 + s2);
                    Console.WriteLine();
                }
                else if (s1 + s2 >= 60)
                {
                    s3 = (s1 + s2);
                    m1 = m + s3 / 60;
                    h1 = h + m1 / 60;
                    a(h1);
                    a(m1 % 60);
                    ts(s3 % 60);
                    Console.WriteLine();
                }
            }
        }
    }
}