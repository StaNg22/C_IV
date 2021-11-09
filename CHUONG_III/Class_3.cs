using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
        3.	Viết chương trình nhập vào điểm ba môn Toán, Lý, Hóa của một học sinh.
        In ra điểm trung bình của học sinh đó với hai số lẻ thập phân.
 */

namespace CHUONG_III
{
    class Class_3
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //khai báo biến
            double t = 0;//điểm toán
            double l = 0;//điểm lý
            double h = 0;//điểm hóa
            double TBC = 0;//Trung bình cộng của 3 môn toán, lý, hóa

            //input
            Console.WriteLine("Nhập vào điểm Toán:");
            t = float.Parse(Console.ReadLine());//nhập điểm toán từ bàn phím

            Console.WriteLine("Nhập vào điểm Lý:");
            l = float.Parse(Console.ReadLine());//nhập điểm lý từ bàn phím

            Console.WriteLine("Nhập vào điểm Hóa:");
            h = float.Parse(Console.ReadLine());//nhập điểm hóa từ bàn phím

            //tính
            TBC = Math.Round((t + l + h) / 3, 2);//tính trung bình của 3 môn toán, lý, hóa

            //output
            Console.WriteLine($"Trung bình cộng của 3 môn là: {TBC}");
        }
    }
}
