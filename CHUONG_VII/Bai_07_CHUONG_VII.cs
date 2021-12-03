using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 7.	Cho mảng arrA có N phần tử. 
 *	Viết hàm xóa các phần tử có giá trị bằng X trong mảng, với X nhập từ bàn phím.
 *	Viết hàm chèn thêm một số nguyên X vào sau số nguyên tố đầu tiên có trong mảng, với X được nhập từ bàn phím.
 *	
 *	Name: Nguyen_Le_Nhut_Quyen
 *	Date: 19/11/2021
 */

namespace CHUONG_VII
{
    internal class Bai_07_CHUONG_VII
    {
        static void xuatMang(int[] b,int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"   arrA[{i}] = {b[i]}");
            }
        }
        static void XoaMangTheoViTri(int[] b,ref int n,int x)
        {
            for (int i = x; i < n-1; i++)
            {
                b[i] = b[i + 1];
            }
            n--;
        }
        
        static void ChenMang(int[] a, ref int n,int vtrichen,int sochen)
        {
            for (int i = n; i >=vtrichen; i--)
            {
                a[i] = a[i - 1];
            }
            a[vtrichen] = sochen;
            n++;
        }
      
        static void XoaMangCacGiaTri(int[] b,ref int n)
        {
            int X = 0;
            Console.Write("Nhập vào giá trị cần xóa trong mảng arrA: ");
            X = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (b[i] == X)
                {
                    XoaMangTheoViTri(b,ref n, i);
                }
            }

        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0;
            int n1 = 0;
            int dem = 0;
            int vitrichen = 0;
            int sochen = 0;

            int[] arrA = new int[1000];
            int[] arrB = new int[1000];
            Console.WriteLine("Nhập số lượng phần tử của mảng arrA:");
            n = Convert.ToInt32(Console.ReadLine());
            n1 = n;
            Console.WriteLine("Nhập vào giá trị của mảng arrA:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"   arrA[{i}] = ");
                arrA[i] = Convert.ToInt32(Console.ReadLine());
                arrB[i] = arrA[i];
            }

            //A
            XoaMangCacGiaTri(arrB,ref n);
            Console.WriteLine("\nA. Mảng arrA sau khi xóa phần tử là:");
            xuatMang(arrB, n);

            //B
            Console.WriteLine("\nb. Mảng arrA chèn thêm một phần tử sau số nguyên tố đầu tiền là:");
            Console.Write("Nhập vào số cần chèn: ");
            sochen = int.Parse(Console.ReadLine());
            Console.WriteLine($"Mảng arrA được chèn thêm phần tử {sochen} là:");
            for (int i = 0; i <n1; i++)
            {
                for (int j = 1; j <= arrB[i]; j++)
                {
                    if (arrB[i] % j == 0)
                    {
                        dem++;
                    }
                }
                if (dem == 2)
                {
                    vitrichen = i+1;
                    break;
                }
                dem = 0;
            }
            ChenMang(arrA, ref n1, vitrichen, sochen);
            xuatMang(arrA, n1);
            Console.WriteLine();
        }
    }
}
