using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
11.	Viết chương trình nhập vào chỉ số cũ, chỉ số mới và tính tiền điện trả định mức, tiền trả vượt định mức, tổng tiền phải trả biết:
	Định mức sử dụng điện cho mỗi hộ là: 50 KW với giá 1000đ/KW
	Nếu phần vượt định mức <=50KW thì tính giá 1500đ/KW
	Nếu 50KW < phần vượt định mức <=100KW thì tính giá 1800đ/KW
	Nếu phần vượt định mức > 100KW thì tính giá 2500đ/KW
	Chỉ số mới và cũ được nhập vào từ bàn phím
	Mức điện tiêu thụ = Chỉ số mới – chỉ số cũ (KW)
	Phần vượt định mức = Mức điện tiêu thụ - 50 (KW)
In ra màn hình mức điện tiêu thụ, tiền trả định mức, tiền trả vượt định mức, tổng tiền phải trả.

 */
namespace CHUONG_I
{
    class Bai_11_CHUONG_IV
    {
        static void Main()
        {
            Console.OutputEncoding=Encoding.UTF8;
            Console.WriteLine("---TÍNH MỨC TIÊU THỤ ĐIỆN ---");
            Console.WriteLine("Nhập chỉ số cũ:");
            int dtt,ttdm,ttvdm,dvdm;
            int csc = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập chỉ số mới:");
            int csm = int.Parse(Console.ReadLine());
            if (csm - csc <= 0)
            {
                Console.WriteLine("Bạn đã nhập sai, Vui lòng nhập lại!!!");
            }
            else
            {
                dtt = csm - csc;
                dvdm = dtt - 50;
                Console.WriteLine($"Mức điện tiêu thụ : {dtt}KW");
                
                if (dtt <= 50)
                {
                    ttdm = dtt * 1000;
                    Console.WriteLine($"Tiền trả định mức: {ttdm}đ");
                    Console.WriteLine("Tiền trả vượt đinh mức: 0đ");
                    Console.WriteLine($"Tổng tiền phải trả: {ttdm}đ");
                }
                else
                {
                    
                    Console.WriteLine($"Tiền trả định mức: 50000đ");
                    if (dvdm <= 50)
                    {
                        ttvdm = dvdm * 1500;
                        Console.WriteLine($"Tiền trả vượt định mức: {ttvdm}đ");
                        Console.WriteLine($"Tổng tiền phải trả: {ttvdm + 50000}đ");
                    }
                    else if (dvdm > 50 && dvdm <= 100)
                    {
                        ttvdm = dvdm * 1800;
                        Console.WriteLine($"Tiền trả vượt định mức: {ttvdm}đ");
                        Console.WriteLine($"Tổng tiền phải trả: {ttvdm + 50000}đ");
                    }
                    else
                    {
                        ttvdm = dvdm * 2500;
                        Console.WriteLine($"Tiền trả vượt định mức: {ttvdm}đ");
                        Console.WriteLine($"Tổng tiền phải trả: {ttvdm + 50000}đ");
                    }
                }
            }
            
        }
    } 
}
