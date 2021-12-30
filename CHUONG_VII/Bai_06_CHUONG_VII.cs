using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    6.Cho mảng số nguyên arrA. Tạo ra 2 mảng nguyên arrB và arrC theo quy tắc: 
      mảng arrB gồm các phần tử dương hoặc bằng 0 của arrA và mảng arrC gồm các phần tử âm của arrA.
    
    Name: Nguyen_Le_Nhut_Quyen
    Date: 19/11/2021
 */
namespace CHUONG_VII
{
    internal class Bai_06_CHUONG_VII
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0;
            int DemDuong = 0;
            int DemAm = 0;
            int[] arrA;
            int[] arrB;
            int[] arrC;
            n = NhapSoLuongPhanTu();
            Console.WriteLine("Nhập vào phần tử mảng arrA:");
            arrA = NhapMang(n);
            XuatMang(arrA);
            Console.WriteLine("Mảng arrB:");
            arrB = NhapMangDuong(arrA);
            XuatMang(arrB);
            Console.WriteLine("Mảng arrC:");
            arrC = NhapMangAm(arrA);
            XuatMang(arrC);
        }
        static int[] NhapMangAm(int[] arr)
        {
            int[] arrC = new int[DemPhanTuAm(arr)];
            int dem = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arrC[dem] = arr[i];
                    dem++;
                }
            }
            return arrC;
        }
        static int[] NhapMangDuong(int[] arr)
        {
            int[] arrB = new int[DemPhanTuDuong(arr)];
            int dem = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    arrB[dem] = arr[i];
                    dem++;
                }
            }return arrB;
        }
        static int DemPhanTuDuong(int[] arr)
        {
            int demduong = 0;
            foreach (int i in arr)
            {
                if (i>=0)
                {
                    demduong++;
                }
            }
            return demduong;
        }
        static int DemPhanTuAm(int[] arr)
        {
            int demam = 0;
            foreach (int i in arr)
            {
                if (i < 0)
                {
                    demam++;
                }
            }
            return demam;
        }
        static void XuatMang(int[] arr)
        {
            Console.WriteLine("Các phần tử của mảng là:");
            foreach (int item in arr)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine();
        }
        static int[] NhapMang(int n)
        {
            int[] arrA=new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"arrA[{i}] = ");
                arrA[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arrA;
        }
        static int NhapSoLuongPhanTu()
        {
            int n = 0;
            do
            {
                Console.WriteLine("Nhập số lượng phần tử:");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);
            return n;
        }
    }
}
