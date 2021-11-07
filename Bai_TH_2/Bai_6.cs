using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 2.6: Nhập số tự nhiên n, k rồi tính tổng các số tự nhiên không lớn hơn n và 
//chia hết cho k.

namespace Thuc_Hanh_2
{
    class Bai_6
    {
        static void Main()
        {
            Console.WriteLine("Nhap so tu nhien n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap so tu nhien k: ");
            int k = Convert.ToInt32(Console.ReadLine());
            int t = 0;
            
            if (n > 0 && k > 0) 
            {
                for (int i = 1; i <=n; i++)
                {
                    if(i%k==0)
                    {
                        t += i;
                    }     
                }
                Console.WriteLine($"Tong cac so tu nhien be hon {n} va chia het cho {k} la: {t}");
            }   
            else
            {
                Console.WriteLine("Vui long nhap n >0 va k>0");
            }    
        }
    }
}
