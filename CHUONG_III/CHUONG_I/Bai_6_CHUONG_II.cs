using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*      6.Chương trình chuyển đổi tiền tệ từ đô la Mỹ($) sang bảng Anh (£), yên Nhật(¥), Việt Nam đồng(đ) 
          và hiển thị kết quả ra màn hình. 
          Biết tỷ giá 1 đô la Mỹ bằng 0.8144£, 105.407¥, 23160đ.
 */
namespace CHUONG_I
{
    class Bai_6_CHUONG_II
    {
        
        
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Khai Báo Biến
            double m = 0;//tiền đôla
            double a = 0;//tiền bảng Anh
            double n = 0;//tiền Yên Nhật
            double v = 0;//tiền việt Nam 

            //Intput

            Console.WriteLine("Nhập vào số tiền $");
            m = double.Parse(Console.ReadLine());//nhập tiền đola mỹ từ bàn phím

            //Tính
            a = a * 0.8144;
            n = a * 105.407;
            v = a * 23160;

            //Output
            Console.WriteLine($"{a}($) = {a}£");
            Console.WriteLine($"{a}($) = {n}¥");
            Console.WriteLine($"{a}($) = {v}đ");
        }
    }
}
