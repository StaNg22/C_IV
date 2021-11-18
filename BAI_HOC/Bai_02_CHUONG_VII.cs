using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2.Viết chương trình nhập vào mảng số nguyên lẻ, nếu nhập sai yêu cầu nhập lại, 
//việc nhập chỉ dừng lại khi người dùng nhập -1. 
// In ra mảng vừa nhập.
namespace CHUONG_VII
{
    internal class Bai_02_CHUONG_VII
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0,dem=0;
            Console.WriteLine("Nhập vào n:");
            n = int.Parse(Console.ReadLine());
            int[] A = new int[10000];
            Console.WriteLine("Nhập vào pt mảng:");
            for (int i = 0; i < n; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Tổng cá pt chia hết cho 5:");
            for (int i = 0; i < n; i++)
            {
                if (A[i] % 5 == 0)
                {
                    dem+=A[i];
                }
            }
            Console.WriteLine(dem);
        }
    }
}
