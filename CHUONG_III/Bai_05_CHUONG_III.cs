using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
         5.	Viết chương trình cho phép nhập hai số từ bàn phím, 
        tìm và in ra màn hình số lớn nhất. 
 */
namespace CHUONG_III
{
    class Bai_05_CHUONG_III
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //khai báo biến
            double a = 0;//giá trị số 1
            double b = 0;//giá trị số 2

            //input
            Console.WriteLine("Nhập vào số thứ nhất:");
            a = double.Parse(Console.ReadLine());//nhập giá trị số 1 từ bàn phím

            Console.WriteLine("Nhập vào số thứ 2:");
            b = double.Parse(Console.ReadLine());//nhập giá trịn số 2 từ bàn phím

            //tính
            if (a>b)//nếu giá trị số 1 lớn hơn giá trị số 2 thì giá trọ số 1 là số lớn nhất trong 2 số
            {

                //ouptut
                Console.WriteLine($"Trong {a} và {b} thì {a} là số lớn nhất");//a là giá trị lớn nhất
            }
            else//ngược lại, nếu giá trị số 1 bé hơn giá trị số 2 thì giá trọ số 1 là số lớn nhất trong 2 số
            {
               
                //ouput
                Console.WriteLine($"Trong {a} và {b} thì {b} là số lớn nhất");//b là giá trị lớn nhất
            }
        }
    }
}
