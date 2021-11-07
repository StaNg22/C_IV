using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Hoc_Cua_Quyen
{
    class Bai_4_Cac_Phep_Bien
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int year;
            Console.Write("Xin nhập Vào Năm: ");

            year = Convert.ToInt32(Console.ReadLine());
            //Năm nhuần là năm chia hết cho 4 nhưng không chia hết cho 100
            //hoặc chia hết cho 400.

            if (year % 4 == 0 && year % 100 == 1 || year % 400 == 0)
            {
                Console.WriteLine("là năm nhuần.");
            }
            else
            {
                Console.WriteLine("không là năm nhuần.");
            }
            Console.ReadLine();

            //Nhập vào điểm kiếm tra đậu hay rớt.
            double Diem;
            Console.Write("Nhập vào số điểm: ");
            Diem = double.Parse(Console.ReadLine());
            if (!(Diem > 5))
            {
                Console.WriteLine("Xin chia buồn.");
            }
            else
            {
                Console.WriteLine(" Vô đi.");
            }


        }
    }
}
