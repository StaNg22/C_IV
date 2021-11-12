using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    8.	Chương trình cho phép nhập vào một số nguyên dương num. 
    Nếu là số chẵn thì tăng num lên một đơn vị, nếu là số lẻ thì giảm num một đơn vị. 
    In giá trị mới của num.
 */
namespace CHUONG_III
{
    class Bai_08_CHUONG_III
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //khai báo biến
            int num = 0;//số nguyên num
            int a = 0;//số nguyên num - 1
            int b = 0;//số nguyên num + 1

            //input
            Console.WriteLine("Nhập vào số nguyên num: ");
            num = int.Parse(Console.ReadLine());//nhập số nguyên từ bàn phím

            //tính
            a = num - 1;
            b = num + 1;
            if (num % 2 == 0)//nếu num chia hết cho 2
            { 

                //output
                Console.WriteLine($"{num} là số chãn");//số nguyên num là số chẵn
                Console.WriteLine($"{b}");//num + 1
            }
            else//ngược lại num không chia hết cho 2 
            {

                //output
                Console.WriteLine($"{num} là số lẻ");//số nguyên num là số lẻ
                Console.WriteLine($"{a}");//num - 1
            }
        }
    }
}
