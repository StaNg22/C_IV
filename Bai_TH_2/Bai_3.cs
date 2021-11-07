using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 2.3: Nhập số tự nhiên n rồi tính tổng(lưu ý phép chia các số nguyên): 
//S = 1+ 1/2 + 1/3 + ... + 1/n 
namespace Thuc_Hanh_2
{
    class Bai_3
    {
        static void Main()
        {
            Console.WriteLine("Nhap vao so nguyen n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            float S = 0;
            if (n > 0)
            {
                for (float i = 1; i < n; i++)
                {
                    S += 1f / i;
                }
                Console.WriteLine($"S = {S}");
            }
            else
            {
                Console.WriteLine("Nhap lai n.");
            }    
        }
    }
}
