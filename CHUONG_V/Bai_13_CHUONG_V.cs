using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
13.Tam giác Pascal là một bảng số, trong đó hàng thứ 0 bằng 1, 
mỗi một số hạng của hàng thứ n+1 là một tổ hợp chập k của n.
Tam giác Pascal có dạng sau: 

1(hàng 0)
1   1(hàng 1)
1   2   1(hàng 2)
1   3   3   1
1   4   6   4   1
1   5   10  10  5   1
1   6   15  20  15  6   1(hàng 6)

Viết chương trình in lên màn hình tam giác Pascal có n hàng (n là số nguyên dương nhập vào khi chạy chương trình) 
bằng cách tạo hai hàm tính giai thừa và tính tổ hợp.
 */
/*Name:Nguyenn_Le_Nhut_Quyen
 *Date:19/11/2021
 */
namespace CHUONG_V
{
    internal class Bai_13_CHUONG_V
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;


            int n = 0;
            long nGiaThua = 1;
            long kGiaThua = 1;
            long hieuGiaThua = 1;
            long toHop = 0;


            Console.WriteLine("Nhập n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("=>");
            for (int i = 0; i <= n; i++)
            {
                if (i == 0)
                {
                    nGiaThua = 1;
                }
                else
                {
                    nGiaThua *= i;
                }
                for (int k = 0; k < i + 1; k++)
                {
                    if (k == 0)
                    {
                        Console.Write("1\t");
                    }
                    else if (k == i)
                    {
                        Console.Write("1");

                    }
                    else
                    {

                        kGiaThua *= k;
                        for (int dem = 0; dem <= i - k; dem++)
                        {
                            if (dem == 0)
                            {
                                hieuGiaThua = 1;
                            }
                            else
                            {
                                hieuGiaThua *= dem;
                            }
                        }
                        toHop = nGiaThua / (kGiaThua * hieuGiaThua);
                        Console.Write("{0}\t", toHop);
                    }
                }
                kGiaThua = 1;
                hieuGiaThua = 1;
                Console.WriteLine("\n");
            }
        }
    }
}
