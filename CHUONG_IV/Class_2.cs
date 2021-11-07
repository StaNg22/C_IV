using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*   2.	Viết chương trình cho phép nhập vào điểm trung bình (ĐTB) của sinh viên.
     In ra xếp loại của sinh viên. Biết:
     0<=ĐTB<3: Kém; 3 <=ĐTB<5: Yếu; 5 <=ĐTB<6.5: Trung bình khá; 
     6.5<=ĐTB<8: Khá; 8<=ĐTB< 9: giỏi; 9<=ĐTB<=10: Xuất sắc.
 */

namespace CHUONG_I
{
    class Class_2
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào điểm trung bình của bạn:");
            float TBC = float.Parse(Console.ReadLine());
            Console.WriteLine("Kết quả xét duyệt của em là:");
            if (TBC >= 0 && TBC <= 10)
            {
                if (TBC < 5)
                {
                   string kq = (TBC >= 3) ? "Yếu" : "Kém";
                    Console.WriteLine($"{kq}");
                    Console.WriteLine($"Cần cố gắng hơn!!!");
                }
                else
                {
                    string kq = (TBC >= 8) ? ((TBC >= 9) ? "Xuất sắc" : "Giỏi") : ((TBC >= 6.5) ? "Khá" : "Trung Bình Khá");
                    Console.WriteLine($"{kq}");
                    Console.WriteLine("Chúc Mừng Em.");
                }
            }
            else
            {
                Console.WriteLine($"{TBC}<0,đó không phải là điểm trung bình của bạn");
                Console.WriteLine("Vui lòng nhập lại!");
            }
        }
    }
}
