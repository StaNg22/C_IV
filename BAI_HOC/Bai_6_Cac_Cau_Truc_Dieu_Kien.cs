using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Dùng toán tử 3 ngôi xuất xếp lại:
 * Gọi x là điểm nhập từ bàn phím 
 * Nếu [8..10]->Giỏi
 *     [6.5..8)->Khá
 *     [5..5,6)->Trung Bình
 *     Còn lại->Yếu
 */     

namespace Bai_Hoc_Cua_Quyen
{
    class Bai_6_Cac_Cau_Truc_Dieu_Kien
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào số điểm của bạn: ");
            float x = float.Parse(Console.ReadLine());
            string kq = x >= 8 ? "Giỏi" : (x >= 6.5 ? "Khá" : (x >= 5 ? "Trung bình" : "Yếu"));
            Console.WriteLine($"Kết Quả Của Em Là: {kq}");
          
            //Bài 1
            
            int a, b;
            Console.WriteLine("Nhập 2 số a và b: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
           char kt;
            Console.WriteLine("Nhập vào ký tự (+-*/): ");
            kt = Console.ReadLine()[0];
            switch (kt)
            {
                case '+':
                    Console.WriteLine($"{a}+{b}={a + b}");
                    break;
                case '-':
                    Console.WriteLine($"{a}-{b}={a - b}");
                    break;
                case '*':
                    Console.WriteLine($"{a}*{b}={a * b}");
                    break;
                case '/':
                    Console.WriteLine($"{a}/{b}={(float)a / b}");
                    break;

                    //Bài 2
            }
              int thang;
              int nam;
              Console.WriteLine("Nhập vào Tháng Của Bạn: ");
              thang = int.Parse(Console.ReadLine());
              if (thang == 2)
              {
                 Console.WriteLine("Vui Lòng Nhập Năm:");
                 nam = int.Parse(Console.ReadLine());
                 if(nam%4==0 && nam%100!=0 || nam % 400 == 0)
                 {
                    Console.WriteLine($"tháng 2 có 29 ngày vì {nam} là năm nhuần.");
                 }
                 else
                 {
                    Console.WriteLine($"Tháng 2 có 28 ngày vì {nam} không phải là năm nhuần.");
                 }
              }
            else if (thang<13)
            {
                switch (thang)
                {
                    case 1:
                        Console.WriteLine("Tháng 1 có 31 ngày");
                        break;
                    case 3:
                        Console.WriteLine("Tháng 3 có 31 ngày");
                        break;
                    case 4:
                        Console.WriteLine("Tháng 4 có 30 ngày");
                        break;
                    case 5:
                        Console.WriteLine("Tháng 5 có 31 ngày");
                        break;
                    case 6:
                        Console.WriteLine("Tháng 6 có 30 ngày");
                        break;
                    case 7:
                        Console.WriteLine("Tháng 7 có 31 ngày");
                        break;
                    case 8:
                        Console.WriteLine("Tháng 8 có 31 ngày");
                        break;
                    case 9:
                        Console.WriteLine("Tháng 1 có 30 ngày");
                        break;
                    case 10:
                        Console.WriteLine("Tháng 10 có 31 ngày");
                        break;
                    case 11:
                        Console.WriteLine("Tháng 11 có 30 ngày");
                        break;
                    case 12:
                        Console.WriteLine("Tháng 12 có 31 ngày");
                        break;
                }
                
            }
            else
            {
                Console.WriteLine("Vui lòng nhập lại tháng.");
            }
        }
    }
}
