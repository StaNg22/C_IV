using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    5.Viết chương trình nhập vào số phần tử của mảng N. 
    Phát sinh tự động các giá trị chAo N phần tử của mảng trong khoảng 0 đến 1000. 
    Viết và gọi thực thi các hàm sau: 
   
    a.  Xuất mảng vừa tạo.
    b.	Tìm giá trị lớn nhất trong mảng.
    c.	Sắp xếp mảng theo thứ tự giảm dần.
    d.	Kiểm tra xem trong mảng có giá trị nào trùng nhau không?

    Name: Nguyen_Le_Nhut_QuyeAn
    Date: 19/11/2021
 */
namespace CHUONG_VII
{
    internal class Bai_05_CHUONG_VII
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random soNgauNhien = new Random();
            int n = 0;
            int pTuTrungGian = 0;
            int[] A = new int[1001];
            int Max = A[0];
            int dem = 0;
            Console.Write("Nhập số lượng phần tử: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                A[i]=soNgauNhien.Next(1001);
            }

            //A
            Console.WriteLine("\na. Các phần tử trong mảng A là:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"   A[{i}] = {A[i]}");
            }

            //B
            Console.Write("\nb. Giá trị lớn nhất trong mảng A là: ");
            for (int i = 1; i < n; i++)
            {
                if (Max < A[i])
                {
                    Max = A[i];
                }
            }
            Console.WriteLine(Max);

            //C
            Console.WriteLine("\nc. Các phần tử trong mảng A được sắp xếp theo thứ tự tăng dần là:");
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (A[i] > A[j])
                    {
                        pTuTrungGian = A[i];
                        A[i] = A[j];
                        A[j] = pTuTrungGian;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"   {A[i]}");
            }

            //D
            Console.WriteLine("\n\nd. Kiểm tra xem trong mảng có giá trị nào trùng nhau không?");
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (A[i] == A[j])
                    {
                        Console.WriteLine($"   A[{i}] = {A[i]} và A[{j}] = {A[j]}");
                        dem++;
                    }
                }
            }
            if (dem == 0)
            {
                Console.WriteLine("   Mảng A không có phần tử trùng nhau.");
            }
            Console.WriteLine("\n");
        }
    }
}
