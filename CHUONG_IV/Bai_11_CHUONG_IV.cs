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
/*Name:Nguyenn_Le_Nhut_Quyen
 *Date:19/11/2021
 */
namespace CHUONG_I
{
    class Bai_11_CHUONG_IV
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //khai báo biến
            int dTieuThu = 0;
            int tTraDinhMuc = 0;
            int tTraVuotDinhMuc = 0;
            int dVuotDinhMuc = 0;
            int tTienPhaiTra = 0;
            int cSoCu = 0;
            int cSoMoi = 0;

            //input
            Console.WriteLine("---TÍNH MỨC TIÊU THỤ ĐIỆN ---");
            Console.WriteLine("Nhập chỉ số cũ:");
            cSoCu = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập chỉ số mới:");
            Nhap: cSoMoi = int.Parse(Console.ReadLine());

            //tính
            if (cSoMoi - cSoCu <= 0)
            {
                Console.WriteLine("Bạn đã nhập sai, Vui lòng nhập lại!!!");
                goto Nhap;
            }
            else
            {
                dTieuThu = cSoMoi - cSoCu;
                dVuotDinhMuc = dTieuThu - 50;
                Console.WriteLine($"Mức điện tiêu thụ : {dTieuThu}KW");

                if (dTieuThu <= 50)
                {
                    tTraDinhMuc = dTieuThu * 1000;
                    tTienPhaiTra = tTraDinhMuc;
                    Console.WriteLine($"Tiền trả định mức: {tTraDinhMuc}đ");
                    Console.WriteLine("Tiền trả vượt đinh mức: 0đ");
                    Console.WriteLine($"Tổng tiền phải trả: {tTienPhaiTra}đ");
                }
                else
                {

                    tTienPhaiTra = 50000;
                    if (dVuotDinhMuc <= 50)
                    {
                        tTraVuotDinhMuc = dVuotDinhMuc * 1500;
                        tTienPhaiTra += tTraVuotDinhMuc;
                        
                    }
                    else if (dVuotDinhMuc > 50 && dVuotDinhMuc <= 100)
                    {
                        tTraVuotDinhMuc = dVuotDinhMuc * 1800;
                        tTienPhaiTra += tTraVuotDinhMuc;
                     
                    }
                    else
                    {
                        tTraVuotDinhMuc = dVuotDinhMuc * 2500;
                        tTienPhaiTra += tTraVuotDinhMuc; 
                       
                    }
                    Console.WriteLine($"Tiền trả định mức: 50000đ");
                    Console.WriteLine($"Tiền trả vượt định mức: {tTraVuotDinhMuc}đ");
                    Console.WriteLine($"Tổng tiền phải trả: {tTienPhaiTra}đ");
                }
            }

        }
    }
}
