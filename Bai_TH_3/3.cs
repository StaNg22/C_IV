using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_TH_3
{
    class _3
    {
        static void Main()
        {
            int j;
            for (int i = 1; i <= 10; i++)
            {
                for ( j = 1; j < 10; j++)
                {
                    Console.Write($"{j} x {i} = {i * j}\t");
                   
                }
                Console.WriteLine();
            }
        }
    }
}
