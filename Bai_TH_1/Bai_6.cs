using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Bài 1.6: Hãy nhập 4 số nguyên bất kì sau đó lưu vào 4 biến a, b, c, d. Tìm giá trị lớn 
 *thứ hai trong số chúng, in kết quả ra màn hình. Trường hợp tất cả cùng giá 
 *trị thì không có số lớn thứ hai.
 */

namespace Bai_TH_1
{
    class Bai_6
    {
    static void Main()
        {
            Console.WriteLine("Nhap so nguyen a: ");
            int a = System.Int32.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so nguyen b: ");
            int b = System.Int32.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so nguyen c: ");
            int c = System.Int32.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so nguyen d: ");
            int d = System.Int32.Parse(Console.ReadLine());

            if(a==b&&b==c&&c==d)
            {
                Console.WriteLine("Khong co gia tri lon nhat.");
            }    
            else
            {
                int max = a;
                if (max < b)
                {
                    max = b;
                }
                if(max<c)
                {
                    max = c;
                }
                if (max<d)
                {
                    max = d;
                }
                int min = a;
             if(min>b)
                {
                    min = b;
                }
             if(min>c)
                {
                    min = d;
                }
                int max2 = min;
                if (max2 < a && a != max)
                {
                    max2 = a;
                }
                if (max2 < b && b != max)
                {
                    max2 = b;
                }
                if (max2 < c && c != max)
                {
                    max2 = c;
                }
                if (max2 < d && d != max)
                {
                    max2 = d;
                }

                Console.WriteLine("Gia tri lon nhat: " + max);
                Console.WriteLine("Gia tri lon thu hai: " + max2);
            }   
        }

    }
}
