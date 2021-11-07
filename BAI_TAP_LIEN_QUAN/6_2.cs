using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap_80
{
    class _7
    {
        static int dm(int a)
        {
            int dem = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    dem++;
                }
            }
            if (dem == 2)
            {
                return 1;
            }
            return 2;
        }
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            for(int i = 1; i <= x; i++)
            {
                if (dm(i) == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
