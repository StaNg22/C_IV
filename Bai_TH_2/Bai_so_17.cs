using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Bài 2.17: Nhập 2 số tự nhiên m, n rồi kiểm tra xem chúng có nguyên tố cùng 
//nhau không(Hai số nguyên tố cùng nhau là 2 số có USCLN là 1).
namespace Thuc_Hanh_2
{
    class Bai_so_17
    { 
    static void Main()
            {
                Console.WriteLine("Nhap vao gia tri m > 0: ");
                int m = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Nhap vao gia tri n > 0: ");
                int n = Convert.ToInt32(Console.ReadLine());

                if (m > 0 && n > 0)
                {
                    while (m != n)
                    {
                        if (m > n)
                        {
                            m -= n;
                        }
                        else
                        {
                            n -= m;
                        }
                    }
                    if (m == 1)
                    {
                        Console.WriteLine("Hai so m, n la nguyen to cung nhau");
                    }
                    else
                    {
                        Console.WriteLine("Hai so m, n khong nguyen to cung nhau");
                    }
                }
                else
                {
                    Console.WriteLine("Nhap m, b > 0");
                }
            }
        }
    }
}