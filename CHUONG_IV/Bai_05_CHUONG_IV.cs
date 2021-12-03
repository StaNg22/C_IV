using System;
using System.Text;
/*
     5.	Viết chương trình nhập vào giờ phút giây (hh:mm:ss) và số giây thêm vào. 
     Tính và in ra kết quả dưới dạng (hh:mm:ss) mới sau khi cộng số giây thêm vào.
 */
/*Name:Nguyenn_Le_Nhut_Quyen
 *Date:19/11/2021
 */
namespace CHUONG_IV
{
    class Bai_05_CHUONG_IV
    {
        
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("TÍNH THỜI GIAN");

            //Khai báo biến
            int h=0;//giá trị giờ nhập vào
            int m = 0;//giá trị phút nhập vào
            int s1 = 0;//giá trị giây nhập vào
            int s2 = 0;//giá trị số giây công thêm 

            int h1 = 0;//giá trị kết quả của giờ
            int m1 = 0;//giá trị kết quả của phút
            int s3 = 0;//giá trị kết quả của giây
            int st = 0;//tổng tất cả giá trị đổi thành giây

            //input
            Console.WriteLine("Nhập số giờ:");
            h = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào phút:");
            m = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào giây:");
            s1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào số giây cộng vào:");
            s2 = int.Parse(Console.ReadLine());

            
            //tính
                    st = h * 3600 + m * 60 + s1 + s2;
                    s3 = st%60;
                    m1 = (st/60)%60;
                    h1 = st / 3600;

            //output
            Console.Write($"{h:00}:{m:00}:{s1:00}s + {s2:00} = ");
            Console.WriteLine($"{h1:00}:{m1:00}:{s3:00}");
                
            
        }
    }
}