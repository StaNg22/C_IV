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
        
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0;
            int[] arr;
            int x = 0;
            n = NhapSoPhanTu();
            arr = new int[n];
            NhapMang(ref arr);
            Console.WriteLine("Các phần tử của mảng là:");
            XuatMang(arr, n);
            Console.WriteLine();
            XoaPhanTuTheoGiaTri(arr,ref n);
            XuatMang(arr, n);
            x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Mảng sau khi chèn thêm {x} sau số nguyên tố là:");
            ChanPTSauSNT(ref arr,ref n, x);

            XuatMang(arr, n);
        }
        static void ChanPTSauSNT(ref int[] arr,ref int n, int x)
        {
            int dem = 1;
            for (int i = 0; i < n; i++)
            {
                bool k = KiemTraSoNT(arr[i]);
                if (k == true)
                {
                    ChenPhanTu(arr, ref n, dem+=i, x);
                    break;
                }
            }
        }
        static void ChenPhanTu(int[] a, ref int n, int vtrichen, int x)
        {

            n++;
            for (int i = n - 1; i > vtrichen; i--)
            {
                a[i] = a[i - 1];
            }
            a[vtrichen] = x;
        }
        static bool KiemTraSoNT(int x)
        {
            bool k = true;
            if (x == 1)
            {
                k = false;

            }
            else
            {

                for (int i = 2; i <= Math.Sqrt(x); i++)
                {
                    if (x % i == 0)
                    {
                        k = false;
                    }
                }
            }
            return k;
        }
        static void XoaPhanTuTheoGiaTri(int[] arr,ref int n)
        {
            int GiaTri = 0;
            Console.WriteLine("Nhập vào giá trị cần xóa:");
            GiaTri = int.Parse(Console.ReadLine());
            Console.WriteLine($"Mảng sau khi xóa phần tử {GiaTri} là:");
            for (int i = 0; i < n; i++)
            {
                if (arr[i]==GiaTri)
                {
                    XoaPhanTuTaiViTri(arr, ref n, i);
                    i--;
                }
            }
        }
        static void XoaPhanTuTaiViTri(int[] arr,ref int n, int x) //x là vị trí cần xóa
        {
            for (int i = x; i < n - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            n--;
        }
        static void XuatMang(int[] arr,int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]}  ");
            }
            Console.WriteLine();
        }
        static void NhapMang(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static int NhapSoPhanTu()
        {
            int n = 0;
            do
            {
                Console.WriteLine("Nhập vào số phần tử của mảng:");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);
            return n;
        }
    }
}
