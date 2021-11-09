using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    4.	Chương trình cho phép nhập vào một số nguyên dương. 
    Kiểm tra và in ra màn hình kết quả “Là số chẵn” hoặc “Là số lẻ”
 */
namespace CHUONG_III
{
    class Class_4
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //khai báo biến
            double a = 0;//giá trị được kiểm tra chẵn lẻ

            //input
            Console.WriteLine("Nhập vào số nguyên:");
            int a = int.Parse(Console.ReadLine());//nhập vào số để kiếm tra chẵn lẻ
            Console.Write("==> ");

            //tính
            if (a % 2 == 0)//điều kiện a chia hết cho 2 nếu a chia hết cho 2 thì a là số chẵn 
            {
                //output
                Console.WriteLine($"{a} là số chẵn");
            }
            else//ngược lại a không chia hết cho 2 thì a là số lẻ 
            {
                //output
                Console.WriteLine($"{a} là số lẻ");
            }
        }
    }
}
