using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3.Viết hàm tính tổng các ước số, hàm đếm số lượng ước số của một số nguyên dương N. 
//Trong hàm main, cho phép người dùng nhập vào số nguyên dương N, 
//gọi các hàm trên và in kết quả tổng ước số, số lượng ước số ra màn hình.
/*Name:Nguyenn_Le_Nhut_Quyen
 *Date:19/11/2021
 */
namespace CHUONG_VI
{
    internal class Bai_03_CHUONG_VI
    {
        static int TCU(int N)
        {
            int dem = 0;
            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    dem += i;
                }
            }
            return dem;
        }
        static int DU(int N)
        {
            int dem = 0;
            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    dem ++;
                }
            }
            return dem;
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int N = 0;
            Console.WriteLine("Nhập vào số nguyên dương N:");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"=> Tổng các ước của {N} là : {TCU(N)}");
            Console.WriteLine($"=> Số lượng ước của {N} là : {DU(N)}");
        }
    }
}
