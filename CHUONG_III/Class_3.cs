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
            Console.WriteLine("Nhập vào điểm Toán:");
            float t = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào điểm Lý:");
            float l = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào điểm Hóa:");
            float h = float.Parse(Console.ReadLine());
            Console.WriteLine($"Trung bình cộng của 3 môn là: {Math.Round((t + l + h)/3,2)}");
        }
    }
}
