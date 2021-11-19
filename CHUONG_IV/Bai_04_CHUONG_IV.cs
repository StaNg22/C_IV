using System;
using System.Text;
/*
    4.	Viết chương trình cho phép nhập một số nguyên trong khoảng từ 1 đến 100. 
Nếu nhập sai yêu cầu người dùng nhập lại. 
Nếu đúng kiểm tra xem nếu số nguyên đó là số chẵn và chia hết cho 3 thì in ra “La so chan chia het cho 3”, 
ngược lại in ra màn hình “Khong thoa dieu kien” và thoát khỏi chương trình
 */
/*Name:Nguyenn_Le_Nhut_Quyen
 *Date:19/11/2021
 */
namespace CHUONG_IV
{
    class Bai_04
        
    {
        static void Main()
    {

        Console.OutputEncoding = Encoding.UTF8;

        //khai báo biến
        int a = 0;//số nguyển xét điều kiện

        //input
        Console.WriteLine("KIỂM TRA SỐ CHẴN CHIA HẾT CHO 3 TỪ 1 ĐẾN 100");
        Console.WriteLine("Nhập vào một số nguyên");
        a = int.Parse(Console.ReadLine());//nhập giá trị số nguyen từ bàn phím

        //tính
        if (a > 0 && a <= 100)
        {
            if (a % 2 == 0 && a % 3 == 0)
            {
                Console.WriteLine($"Sô {a} là số chẵn chia hết cho 3.");
            }
            else
            {
                Console.WriteLine($"Số {a} không thoải yêu cầu đề bài.");
            }
        }
        else
        {
            Console.WriteLine("Vui lòng nhập vào số nguyên từ 1 đến 100.");
            Console.WriteLine("Vui lòng nhập lại!!!");
        }
    }
}
}
