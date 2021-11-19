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
/*Name:Nguyenn_Le_Nhut_Quyen
 *Date:19/11/2021
 */
namespace CHUONG_IV
{
    class Bai_02_CHUONG_IV
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //khai báo biến
            float TBC = 0;//giá trị điểm trung bình cộng 
            string kq;//kết quá xếp hạng

            //input
            Console.WriteLine("Nhập vào điểm trung bình của bạn:");//thống báp mời nhập vào điểm tring bình 
            TBC = float.Parse(Console.ReadLine());// nhập điểm trung bìn từ bàn phím
            Console.WriteLine("Kết quả xét duyệt của em là:");

            //tính
            if (TBC >= 0 && TBC <= 10)
            {
                if (TBC < 5)
                {
                    kq = (TBC >= 3) ? "Yếu" : "Kém";
                    Console.WriteLine($"{kq}");
                    Console.WriteLine($"Cần cố gắng hơn!!!");
                }
                else
                {
                    kq = (TBC >= 8) ? ((TBC >= 9) ? "Xuất sắc" : "Giỏi") : ((TBC >= 6.5) ? "Khá" : "Trung Bình Khá");
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
