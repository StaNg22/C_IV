using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
        7.	Viết chương trình nhập vào tháng, kiểm tra điều kiện nếu tháng không hợp lệ thì phải nhập lại. 
            Nếu tháng hợp lệ thì in ra tháng đã nhập thuộc quý nào?
*/
/*Name:Nguyenn_Le_Nhut_Quyen
 *Date:19/11/2021
 */
namespace CHUONG_IV
{
    class Bai_07_CHUONG_IV
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            //Khai Báo Biến
            uint a = 0;//Giá trị tháng

            //input
            Console.WriteLine("Nhập vào tháng:");
            Nhap: a = uint.Parse(Console.ReadLine());

            //tính
            if (a <= 3)
            {
                Console.WriteLine("Quý 1");
            }
            else if (a > 3 && a <= 6)
            {
                Console.WriteLine("Quý 2");
            }
            else if (a > 6 && a <= 9)
            {
                Console.WriteLine("Quý 3");
            }
            else if (a > 10 && a <= 12)
            {
                Console.WriteLine("Quý 4");
            }
            else
            {
                Console.WriteLine("Vui lòng nhập lại.");
                goto Nhap;
            }
        }
    }
}
