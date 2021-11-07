using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1Viết chương trình nhập vào dãy n phần tử và in ra các phần tử theo thứ tự ngược lại quá trình nhập.
//Số nhập đầu tiên sẽ in ra sau cùng.
namespace Bai_Tap_80
{
    class so_16
    {
        static void Main()
        {
            int i, n;
           
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] A = new int[1000];
            for ( i = 1; i < n; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Dãy số đã được đảo ngược là:");
            for ( i = n-1; i >0; i--)
            {
                Console.Write($"{A[i]}, ");
            }
            
        }
    }
}
