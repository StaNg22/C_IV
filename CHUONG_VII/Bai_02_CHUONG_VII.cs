using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2.Viết chương trình nhập vào mảng số nguyên lẻ, nếu nhập sai yêu cầu nhập lại, 
//việc nhập chỉ dừng lại khi người dùng nhập -1. 
// In ra mảng vừa nhập.
/*Name:Nguyenn_Le_Nhut_Quyen
 *Date:19/11/2021
 */
namespace CHUONG_VII
{
    internal class Bai_02_CHUONG_VII
    {
        
        static void Main()
        {
            int[] mangA = new int[1000];
            int[] mangB = new int[1000];
            int dem = 0;
            int n = 0;
            Console.OutputEncoding = Encoding.UTF8;
            NhapMang(mangA,out n);
            ChepMang(mangA, n, out dem,mangB);
            XuatMang(mangB, dem/*,out mangB*/);

        }
        static void NhapMang(int[] mangA, out int n )
        {
            n = 0;
            Console.WriteLine("Nhập vào mảng:");
            mangA[0] = Convert.ToInt32(Console.ReadLine());
            if (mangA[0] % 2 == 0)
            {
                int i = 0;
                while (mangA[i] != -1)
                {
                    i++;
                    Console.WriteLine("Vui lòng nhập lại:");
                    mangA[i] = Convert.ToInt32(Console.ReadLine());
                    n++;
                }
            }
        }
        static void ChepMang(int[] mangA,int n,out int dem,int[] mangB)
        {
            dem = 1;int j = 0;
            for (int i = 0; i < n; i++)
            {
                if (mangA[i] % 2 != 0)
                {
                    mangB[j] = mangA[i];
                    j++;
                    dem++;
                }
            }
        }
        static void XuatMang(int[] mangA, int n )
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{mangA[i]}  ");
            }
        }
    }
}
