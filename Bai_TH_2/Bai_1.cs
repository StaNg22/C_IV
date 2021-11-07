using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Bài 2.1: Nhập số tự nhiên n sau đó in ra các số chẵn, lẻ <= n.
namespace Thuc_Hanh_2
{
    class Bai_1
    {
        static void Main()
        {
            Console.WriteLine("Nhap so tu nhien n: ");
            uint n = Convert.ToUInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                if(i%2==1)
                {
                    Console.WriteLine($"So le la: {i}");
                }    
            }
        }
    }
}
