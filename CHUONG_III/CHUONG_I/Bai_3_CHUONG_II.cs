using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
        3.	Chương trình cho phép người dùng nhập vào năm sinh một nam nhân viên. Tính:
        	Tính tuổi hiện tại.
        	Tính năm về hưu (biết tuổi về hưu của nam là 60).
 */
namespace CHUONG_I
{
    class Bai_3_CHUONG_II
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Khai Báo Biến
            int ns = 0;//năm sinh
            int nm = 0;//năm hiện taị
            int t = 0;//tuổi 
            int nvh = 0;//năm về hưu

            //Input
            Console.WriteLine("Nhập vào năm sinh của Bạn:");
            ns = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào năm hiện tại:");
            nm = int.Parse(Console.ReadLine());

            //Tính
            t = nm - ns;
            nvh = nm + (60 - (nm - ns));

            //Output
            Console.WriteLine($"Tuổi hiện tại của bạn là: {t}");
            Console.WriteLine($"Năm mà bạn về hưu là:{nvh}");
        }
    }
}
