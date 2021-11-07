using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//8.Số chính phương là số mà căn bậc hai của nó là 1 số nguyên dương. 
//Viết chương trình nhập vào một số nguyên dương n và cho biết trong khoảng từ 1 tới 2n có bao nhiêu
//số chính phương. Hãy in ra dãy số chính phương đó.

namespace Bai_Tap_80
{
    class _8
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số nuyên dương n:");
            int n = int.Parse(Console.ReadLine());
            int a=0;
            for(int i = 1; i*i <=2*n; i++)
            {
                
                if(i*i==2*n)
                {
                    a= 1; 
                }
                if(a==0)
                {
                    Console.WriteLine(i*i);
                }    
                
            }
        }
    }
}
