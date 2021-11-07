using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Bài 2.4: Nhập vào một số tự nhiên n rồi tính: 
 *a) Trung bình cộng các số tự nhiên không lớn hơn n.
 *b) Trung bình cộng các số tự nhiên lẻ không lớn hơn n.
 *c) Trung bình cộng các số tự nhiên chẵn không lớn hơn n.
 */ 

namespace Thuc_Hanh_2
{
    class Bai_4
    {
        static void Main()
        {
            Console.WriteLine("Nhap so tu nhien n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int t= 0;
            int tc = 0;
            int tl = 0;
            int nc = 0;
            int nl = 0;

            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    t += i;
                    if(i%2==0)
                    {
                        nc++;
                        tc += i;
                    }    
                    else
                    {
                        nl++;
                        tl += i;
                    }    
                }
                Console.WriteLine($"a/ Trung binh cong cac so nho hon {n} la: {(float)t/n}");

                Console.WriteLine($"b/ Trung binh cong cac so  chan nho hon {n} la: {(float)tc/nc}");

                Console.WriteLine($"c/ Trung binh cong cac so le nho hon {n} la: {(float)tl/nl}");
            }
            else
            {
                Console.WriteLine("Vui log nhap lai n.");
            }    
        }
    }
}
