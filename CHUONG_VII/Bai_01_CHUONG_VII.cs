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
namespace CHUONG_VII
{
    internal class Bai_01_CHUONG_VII
    {
        //Hàm A
        static int nPTu(int n)
        {
            for (int i = 0; i < n; i++)
            {
                i = Convert.ToInt32(Console.ReadLine());
                return i;
            }
            return 0;
        }

        //Hàm C
        static void iSoChan(int[] d, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (d[i] % 2 == 0)
                {
                    Console.Write($"{d[i]}  ");
                }
            }
        }

        //Hàm D
        static void iSoNT(int[] d,int n)
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= d[i]; j++)
                {
                    if (d[i] % j == 0)
                    {
                        dem++;
                    }
                }
                if (dem == 2)
                {
                    Console.Write($"{d[i]}  ");
                    dem = 0;
                }
                dem = 0;
            }
        }

        //Hàm E
        static void tTB(int[] e,int n)
        {
            double tBinh = 0;
            double demTB = 0;
            for (int i = 0; i < n; i++)
            {
                demTB += e[i];
            }
            tBinh = demTB / n;
            Console.WriteLine($"{tBinh}");
        }

        //Hàm F
        static void kTraSHoanThien(int[] f, int n)
        {
            int dem = 0,dem1=0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < f[i]; j++)
                {
                    if (f[i] % j == 0)
                    {
                        dem += j;
                    }
                }
                if (dem == f[i])
                {
                    dem1++;
                    dem = 0;
                }
                dem = 0;
            }
            Console.WriteLine($"{dem1}");
        }

        //Hàm H
        static void vTriSNT(int[] h,int n)
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= h[i]; j++)
                {
                    if (h[i] % 2 == 0)
                    {
                        dem++;
                    }
                }
                if (dem == 2)
                {
                    Console.WriteLine($"{i}");
                    break;
                }
                dem = 0;
            }
        }

        //Hàm I
        static void pTuLonNhat(int[] I,int n)
        {
            int Max = I[0];
            for (int i = 1; i < n; i++)
            {
                if (Max < I[i])
                {
                    Max = I[i];
                }
            }
            Console.WriteLine($"{Max}");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0;
            int[] A = new int[101];
            
            Console.Write("Nhập vào số nguyên dương n (1->100): ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n < 1 || n > 100)
            {
                Console.WriteLine(" Vui lòng nhập lại!!!");
            }
            else
            {
                //A
                Console.WriteLine($"a. Nhập vào số phần tử trong mảng A:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"A[{i}] = ");
                    A[i] = nPTu(n);
                }

                //B
                Console.WriteLine("\nb. Tất cả các phần tử trong mảng A là:");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"A[{i}] = {A[i]}");
                }

                //C
                Console.Write("\nc. Các số chẵn trong mảng A là: ");
                iSoChan(A, n);

                //D
                Console.Write("\n\nd. Các số nguyên tố trong mảng A là: ");
                iSoNT(A, n);
                
                //E
                Console.Write("\n\ne. Trung bình cộng các phần tử trong mảng A là: ");
                tTB(A, n);
                //F
                Console.Write("\nf. Số lượng số hoàn thiện trong mảng A là: ");
                kTraSHoanThien(A, n);

                //G
                //H
                Console.Write("h. Vị trí số nguyên tố đầu tiên trong mảng A là: ");
                vTriSNT(A, n);

                //I
                Console.Write("\ni. Phần tử lớn nhất trong mảng A là: ");
                pTuLonNhat(A, n);
            }
        }
    }
}
