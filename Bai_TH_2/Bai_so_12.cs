using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 2.12. Dãy số Fibonacci được định nghĩa như sau: F0 = 0, F1 = 1; Fn = Fn-1 + 
//Fn - 2 với n >= 2. Hãy viết chương trình tìm số Fn.
namespace Thuc_Hanh_2
{
    class Bai_so_12
    {
        static void Main()
        {
            Console.Write("Nhap vao so nguyen n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            long F0 = 0, F1 = 1, fn=0;
            if(n>0)
            {
               if(n<2)
                {
                    fn = n;
                    
                }    
                for (int i = 2; i <= n; i++)
                {
                    fn = F0 + F1;
                    F0 = F1;
                    F1 = fn;

                }
                Console.WriteLine($"fn = {fn}");
            }
            else
            {
                Console.WriteLine("Vui long nhap so n>0.");
            }
        }
    }
}
