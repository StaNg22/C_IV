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
    class Bai_2_CHUONG_II
    {
        static void Main()
        {//  Khai báo biến
            double sale1 = 0;
            double sale2 = 0;
            double commissionRate = 0;
            double totalSale = 0;
            double commission;
            //Input
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào sale1:");
            sale1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào sale2:");
            sale2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào commissionRate:");
            commissionRate = double.Parse(Console.ReadLine());

            //Tính
            totalSale = sale1 + sale2;
            commission = totalSale * commissionRate;

            //Output
            Console.WriteLine($"commission = {commission}");
        }
    }
}
