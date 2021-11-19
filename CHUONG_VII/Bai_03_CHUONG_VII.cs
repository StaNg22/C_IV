using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
   /*
    3.Chương trình cho phép nhập hai mảng arrA, arrB có N phần tử trên mỗi mảng. 
    Tính arrC là mảng tổng của arrA và arrB. Biết arrC[i] = arrA[i] + arrB[i];
    
    Name: Nguyen_Le_Nhut_Quyen
    Date: 19/11/2021
    */
namespace CHUONG_VII
{
    internal class Bai_03_CHUONG_VII
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0;
            int[] arrA = new int[1000];
            int[] arrB = new int[1000];
            int[] arrC = new int[1000];
            Console.Write("Nhập vào số lượng phần tử: ");
            n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập phần tử của mảng arrA:");
            for (int i = 0; i < n; i++)
            {
                arrA[i]=Convert.ToInt32(Console.ReadLine());    
            }
            Console.WriteLine("Nhập phần tử của mảng arrB:");
            for (int i = 0; i < n; i++)
            {
                arrB[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Phần tử của mảng arrC là:");
            for (int i = 0; i < n; i++)
            {
                arrC[i] = arrA[i] + arrB[i];
                Console.WriteLine($"arrC[{i}] = {arrC[i]}");
            }
        }
    }
}
