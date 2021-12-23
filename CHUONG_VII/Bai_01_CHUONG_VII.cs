using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
1.Viết chương trình nhập vào một số nguyên n với 1<= n <= 100, nếu nhập sai yêu cầu nhập lại. 
  Viết các hàm thực hiện:
a.	Nhập mảng số nguyên n phần tử.
b.	Xuất mảng vừa nhâp.
c.	Xuất các số chẵn trong mảng.
d.	Xuất các số là số nguyên tố trong mảng.
e.	Tính trung bình cộng các phần tử trong mảng.
f.	Đếm số lượng số hoàn thiện có trong mảng.
g.	Tìm vị trí cuối cùng của phần tử x trong mảng.
h.	Tìm vị trí số nguyên tố đầu tiên trong mảng nếu có.
i.	Tìm phần tử lớn nhất trong mảng.
j.	Tìm số dương nhỏ nhất trong mảng.
k.	Sắp xếp các phần tử của mảng theo thứ tự tăng dần.
l.	Kiểm tra mảng có thứ tự tăng hay không?
 */
/*Name:Nguyenn_Le_Nhut_Quyen
 *Date:19/11/2021
 */
namespace CHUONG_VII
{
    internal class Bai_01_CHUONG_VII
    {
        
        static void Main(string[] args)
        { 
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0;
            int[] arrA;
            int[] arrB;
            n = NhapSoLuongPhanTu();
            arrA = NhapMang(n);
            Console.WriteLine("- Mảng arrA vừa nhập là:");
            XuatMang(arrA);
            XuatSoChan(arrA);
            XuatSoNguyenTo(arrA);
            Console.Write("- Trung bình mảng là: ");
            Console.WriteLine(TrungBinhCong(arrA));
            DemSoHoanThien(arrA);
            TimVTCuoiCung(arrA);
            ViTriSoNTDauTien(arrA);
            TimPhanLonNhat(arrA);
            TimPhanNhoNhat(arrA);
            arrB = SaoChepMang(arrA, n);
            SapXepMang(arrB);
            Console.WriteLine("- Mảng arrA có được sắp xếp tăng dần hay không?");
            Console.WriteLine(ktrsx(arrA));
        }
        static bool ktrsx(int[] arr)
        {
            bool ktr = true;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    ktr = false;
                }
            }
            return ktr;
        }
        static void SapXepMang(int[] arr)
        {
            Console.WriteLine("- Mảng arrA được sắp xếp lại là:");
            int i;
            int j;
            for (i = 0; i < arr.Length - 1; i++)
            {
                for (j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = tmp;
                    }
                }
            }
            XuatMang(arr);
        } 
    
        static int[] SaoChepMang(int[] arr, int n)
        {
            int[] arrB = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arrB[i] = arr[i];
            }
            return arrB;
        }
        static void TimPhanNhoNhat(int[] arr)
        {
            Console.Write("- Phần tử nhỏ nhất trong mảng là: ");
            int Min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (Min < 0)
                {
                    Min = arr[i];

                }
                if (arr[i] < 0)
                {
                    continue;
                }
                else
                {
                    if (Min > arr[i])
                    {
                        Min = arr[i];
                    }
                }
            }
            Console.WriteLine($"{Min}");
        }
        static void TimPhanLonNhat(int[] arr)
        {
            Console.Write("- Phần tử lớn nhất trong mảng là: ");
            int Max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (Max < arr[i])
                {
                    Max = arr[i];
                }
            }
            Console.WriteLine($"{Max}");
        }
        static void ViTriSoNTDauTien(int[] arr)
        {
            
            Console.Write("- Vị trí số nguyên tố đầu tiên trong mảng là: ");
            for (int i = 0; i < arr.Length; i++)
            {
                bool k = KiemTraSoNguyenTo(i);
                if (k == true)
                {
                    Console.WriteLine($"arrA[{i}]");
                    break;
                }
            }
        }
        static void TimVTCuoiCung(int[] arr)
        {
            int x = 0;
            Console.Write("   Nhập phần tử cần xác định: ");
            x = Convert.ToInt32(Console.ReadLine());
            int dem = 0;
            int vTri = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (x == arr[i])
                {
                    dem++;
                    vTri = i;
                }
            }
            if (dem == 0)
            {
                Console.WriteLine($"- Phần tử {x} không nằm trong mảng A.\n");
            }
            else
            {
                Console.WriteLine($"- Vị trí cuối cùng của phần tử {x} là: A[{vTri}].\n");
            }
        }
        static void DemSoHoanThien(int[] arr)
        {
            int dem = 0;
            foreach (int i in arr)
            {
                bool k = KiemTraSoHoanThien(i);
                if (k == true)
                {
                    dem++;
                }
            }
            Console.WriteLine($"- Số số hoàn thiện trog mảng là: {dem}");
        }
        static bool KiemTraSoHoanThien(int so)
        {
            bool k = false;
            int dem = 0;
            for (int i = 1; i < so; i++)
            {
                if (so % i == 0)
                {
                    dem += i;
                }
            }
            if(dem == so)
            {
                k = true;
            }
            return k;
        }
        static double TrungBinhCong(int[] arrA)
        {
            double TrungBinh = 0;
            int dem = 0;
            foreach (int i in arrA)
            {
                TrungBinh += (double)i;
                dem++;
            }
            return TrungBinh/=(double)dem;
        }
        static void XuatSoNguyenTo(int[] arr)
        {
            Console.WriteLine("- Các số nguyên tố trong mảng là:");
            foreach (int i in arr)
            {
                bool KiemTra = KiemTraSoNguyenTo(i);
                if (KiemTra == true)
                {
                    Console.Write($"{i}  ");
                }
            }
            Console.WriteLine();
        }
        static bool KiemTraSoNguyenTo(int so)
        {
            bool k = true;
            if (so == 1)
            {
                k = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(so); i++)
                {
                    if (so % i == 0)
                    {
                        k = false;
                        break;
                    }

                }
            }
            return k;
        }
        static void XuatSoChan(int[] arrA)
        {
            Console.WriteLine("- Các số chẵn trong mảng là:");
            foreach (int i in arrA)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i}  ");
                }
            }
            Console.WriteLine();
        }
        static void XuatMang(int[] arrA)
        {
            foreach (int i in arrA)
            {
                Console.Write($"{i}  ");
            }
            Console.WriteLine();
        }
        static int[] NhapMang(int n)
        {
            int[] arrA = new int[n];
            Console.WriteLine("- Nhập vào các phần tử của mảng:");
            for (int i = 0; i < arrA.Length; i++)
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
                Console.WriteLine("Nhập vào số lượng phần tử của mảng:");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);
            return n;
        }
    }
}
