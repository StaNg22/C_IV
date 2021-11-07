using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//9.	Viết chương trình tìm ra số lũy thừa 2 đầu tiên lớn hơn 1000.

namespace Bai_Tap_80
{
    class Class1
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int i=0;
            while (i * i < 1000)
            {
                i++;
            }
            Console.WriteLine($"Số lũy thừa 2 đầu tiên lớn hơn 1000 là: {i}");
        }
    }
}
