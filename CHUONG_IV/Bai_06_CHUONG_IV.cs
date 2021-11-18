using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    6.	Viết chương trình nhập vào điểm 3 môn thi: Toán, Lý, Hóa của học sinh. 
    Nếu tổng điểm >= 15 và không có môn nào dưới 4 thì in kết quả đậu. 
    Nếu đậu mà các môn đều lớn hơn 5 thì in ra lời phê "Học đều các môn",
    ngược lại in ra "Học chưa đều các môn", các trường hợp khác là "Thi hỏng".
 */
namespace CHUONG_I
{
    class Bai_06_CHUONG_IV
    {
        static void Main()
        {
            float t = 0;
            float l = 0;
            float h = 0;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập điểm môn Toán:");
            t = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm môn Lý:");
            l = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm môn Hóa:");
            h = float.Parse(Console.ReadLine());
            if (t + l + h >= 15 && t >= 4 && l >= 4 && h >= 4)
            {
                Console.WriteLine("Đậu");
                if (t > 5  && l> 5 && h > 5)
                {
                    Console.WriteLine("=> Học điệu các môn");
                }
                else
                {
                    Console.WriteLine("=> Học chưa đều các môn");
                }
            }
            else
            {
                Console.WriteLine("Thi Hỏng");
            }
        }
    }
}
