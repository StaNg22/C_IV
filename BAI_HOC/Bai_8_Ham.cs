using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Hoc_Cua_Quyen
{
    class Bai_8_Ham
    {
      
      static string gptb1(float a, float b)
        {
           if(a==0 && b == 0)
            {
                return "Vô số nghiệm.";
            }
            if (a == 0 && b != 0)
            {
                return "Vô nghiệm.";
            }return "x = " + -b / a;
        }
        static void gptb2(float d,float e,float f)
        {
            
            //xét a,c,b của phương trình.
            if(d==0 && e==0 && f == 0)
            {
                Console.WriteLine("Phương trình có dạng: 0=0 (Luôn đúng)");
                Console.WriteLine("Phương trình có vô số nghiệm.");
            }
            if(d==0 && e == 0)
            {
                Console.WriteLine($"Phương trình có dạng: {f} = 0 (Vô lý)");
                Console.WriteLine("Phương trình vô nghiệm.");
            }
            if (f == 0)
            {
                Console.WriteLine($"Phương trình có dạng: {d}x^2 + {e}x = 0");
                Console.WriteLine("==>");
                Console.WriteLine("   x = 0");
                Console.WriteLine($"  x = {-e/d}");
            }
            else
            {
                float D = e * e - 4 * d * f;
                Console.WriteLine($"Phương trình có dạng: {d}x^2 + {e}x + {f} = 0");
                Console.WriteLine($"D={D}");
                if (D > 0)
                {
                    Console.WriteLine("==>");
                    Console.WriteLine($"  x1 = {(-e + Math.Sqrt(D)) / 2 * d}");
                    Console.WriteLine($"  x2 = {(-e - Math.Sqrt(D)) / 2 * d}");
                }
                if (D == 0)
                {
                    Console.WriteLine("==>");
                    Console.WriteLine($"  x = {-e/2*d}");
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }    
            }
        }
       
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            float a, b,c;
            a = float.Parse(Console.ReadLine());
           b= float.Parse(Console.ReadLine());
            string nghiem = gptb1(a,b);
            Console.WriteLine(nghiem);

            //Bài tập: Giải phương trình bặc 2.
            c = float.Parse(Console.ReadLine());
            gptb2(a, b, c);
            
        }
    }
}
