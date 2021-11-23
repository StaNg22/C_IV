using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
12.Kiểm tra một ký tự nhập vào thuộc tập hợp nào trong các ký tự sau:
	Các ký tự chữ hoa: ‘A’ – ‘Z’
	Các ký tự chữ thường ‘a’ – ‘z’
	Các ký tự số ‘0’ – ‘9’
	Các ký tự khác
 */
/*Name:Nguyenn_Le_Nhut_Quyen
 *Date:19/11/2021
 */
namespace CHUONG_I
{
    class Bai_12_CHUONG_IV
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            char kt;
            int demkt = 0;
            Console.WriteLine("Nhập vào lý tự:");
            kt = Convert.ToChar(Console.ReadLine());
            demkt = kt;
            if (demkt >= 97 && demkt <= 122)
            {
                Console.WriteLine("{0} là ký tự chữ thường.", kt);
            }
            else if (demkt >= 65 && demkt <= 90)
            {
                Console.WriteLine("{0} là ký tự chữ hoa.", kt);
            }
            else if (demkt >= 48 && demkt <= 57)
            {
                Console.WriteLine("{0} là ký tự chữ số.", kt);
            }
            else
            {
                Console.WriteLine("{0} là ký tự đặt biệt.", kt);
            }
        }
    }
}
