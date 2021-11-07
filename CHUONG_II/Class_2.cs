using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*      2.	Chương trình cho phép người dùng nhập các giá trị sale1, sale2 và commissionRate. 
        	Tính totalSale = sale1 + sale2 và commission=totalSale*commissionRate. 
        	In ra màn hình giá trị commission.
 */
namespace CHUONG_I
{
    class Class_2
    {
       static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào sale1:");
            float sale1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào sale2:");
            float sale2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào commissionRate:");
            float commissionRate = float.Parse(Console.ReadLine());
            float totalSale = sale1 + sale2;
            Console.WriteLine($"commission = {totalSale * commissionRate}");
        }
    }
}
