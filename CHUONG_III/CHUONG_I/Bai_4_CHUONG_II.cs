using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*    4.Chương trình cho phép nhập vào hai giá trị num1, num2.
        Thực hiện hoán vị hai giá trị num1 và num2 cho nhau. 
        In giá trị mới ra màn hình.
 */
namespace CHUONG_I
{
    class Bai_4_CHUONG_II
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Khai Báo Biến
            double num1;//giá trị số 1
            double num2;//giá trị số 2
            double dem = 0;//tổng giá trị số 1 và giá trị số 2 
            double num3 = 0;//giá trị hoán vị của num1
            double num4 = 0;
            //Input
            Console.WriteLine("Nhập num1:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập num2:");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Giá trị hoán vị thành:");

            //Tính
            dem = num1 + num2;
            num3 = dem - num1;
            num4 = dem - num2;

            //Output
            Console.WriteLine($"num1 = {num3}");
            Console.WriteLine($"num2 = {num4}");
        }
    }
}
