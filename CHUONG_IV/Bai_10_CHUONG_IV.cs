﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//10.Viết chương trình giải phương trình bậc 2: ax2 + bx + c = 0, với a, b, c nhập vào từ bàn phím.
/*Name:Nguyenn_Le_Nhut_Quyen
 *Date:19/11/2021
 */
namespace CHUONG_IV
{
    class Bai_10_CHUONG_IV
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("---GIẢI PHƯƠNG TRÌNH BẬC II---");

            //khaio báo biến
            double a = 0;//giá trị hàm số a
            double b = 0;//giá trị hàm số b
            double c = 0;//giá trị hàm số c
            double delta = 0;// giá trị delta
            double x1 = 0;// nghiệm x1
            double x2 = 0;//nghiệm x1
            string dk;//kết diều kiện phương trình

            //input
            Console.WriteLine("Nhập a:");
            a = float.Parse(Console.ReadLine());//nhập giá trị hàm số a từ bàn phím

            Console.WriteLine("Nhập b:");
            b = float.Parse(Console.ReadLine());//nhập giá trị hàm số b từ bàn phím

            Console.WriteLine("Nhập c:");
            c = float.Parse(Console.ReadLine());//nhập giá trị hàm số c từ bàn phím

            //tính
            if (a > 0 || a < 0)
            {
                delta = b * b - 4 * a * c;
                if (delta > 0)
                {
                    x1 = (-b + (float)Math.Sqrt(delta)) / (2 * a);//tính giá trị x1
                    x2 = (-b - (float)Math.Sqrt(delta)) / (2 * a);//tính giá trị x2

                    Console.WriteLine("=> Phương trình có 2 nghiệm phân biệt:");
                    Console.WriteLine($"                                     x1 = {x1}");
                    Console.WriteLine($"                                     x2 = {x2}");
                }
                else if (delta == 0)
                {
                    x1 = -b / 2 * a;
                    Console.WriteLine($"=> Phương trình có nghiệm kép: x = x1 = x2 = {x1}");
                }
                else
                {
                    Console.WriteLine("=> Phương trình vô nghiệm.");
                }
            }
            else
            {
                if (b == 0)
                {
                    dk = (c == 0) ? "=> Phương trình vô số nghiệm" : "=> Phương trình vô nghiệm";
                    Console.WriteLine(dk);
                }
                else
                {
                    x1 = -c / b;
                    Console.WriteLine($"Phương trình trên có nghiệm là x = {x1}");
                }

            }
        }
    }
}
