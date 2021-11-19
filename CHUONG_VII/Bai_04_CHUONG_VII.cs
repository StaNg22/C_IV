using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *   4.	Cho mảng số nguyên arrA có N phần tử. Tạo ra 2 mảng nguyên arrB và arrC theo quy tắc: 
 *      mảng arrB gồm các phần tử chẵn của arrA và mảng arrC gồm các phần tử lẻ của arrA.
 *      
 *      Name: Nguyen_Le_Nhut_Quyen
 *      Date: 19/11/2021
 */
namespace CHUONG_VII
{
    internal class Bai_04_CHUONG_VII
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;  
            int n = 0;
            int[] arrA = new int[1000];
            int[] arrB = new int[1000];
            int[] arrC = new int[1000];
            int demB = 0;
            int demC = 0;

            Console.WriteLine("Nhập vào số phần tử của mảng arrA: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhập vào phần tử của mảng arrA:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"arrA[{i}] = ");
                arrA[i] = Convert.ToInt32(Console.ReadLine());
                if (arrA[i] % 2 == 0)
                {
                    arrB[demB] = arrA[i];
                    demB++;
                }
                else
                {
                    arrC[demC] = arrA[i];
                    demC++;
                }
            }
            Console.WriteLine("\nCác phần tử của mảng arrB là:");
            for (int i = 0; i < demB; i++)
            {
                Console.Write($"arrB[{i}] = ");
                Console.WriteLine(arrB[i]);
            }
            Console.WriteLine("\nCác phần tử của mảng arrC là:");
            for (int i = 0; i < demC; i++)
            {
                Console.Write($"arrC[{i}] = ");
                Console.WriteLine(arrC[i]);
            }
        } 
    }
}
