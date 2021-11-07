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
    class Class_6
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số tiền $");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine($"{a}($) = {a*0.8144}£");
            Console.WriteLine($"{a}($) = {a * 105.407}¥");
            Console.WriteLine($"{a}($) = {a * 23160}đ");
        }
    }
}
