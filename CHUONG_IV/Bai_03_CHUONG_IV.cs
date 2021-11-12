using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  3.Viết chương trình giải phương trình bậc nhất: ax+b=0, với a, b nhập vào từ bàn phím.
namespace CHUONG_I
{
    class Bai_03_CHUONG_IV
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //khai báo biến 
            double a = 0;//giá trị hàm số a 
            double b = 0;//giá trị hàm số b
            double x = 0;//nghiệm của phương trình
            string kq;//kết qảu phương trình vô nghiệm hay vô số nghiệm

            //input
            Console.WriteLine("GIẢI PHƯƠNG TRÌNH BẬC NHẤT");
            Console.WriteLine("Có dạng ax + b = 0");

            Console.WriteLine("Mời nhập a:");
            a = double.Parse(Console.ReadLine());//nhập giá trị hàm số a từ bàn phím

            Console.WriteLine("Mời nhập b:");
            b = double.Parse(Console.ReadLine());//nhập giá trị hàm số b từ bàn phím

           //tính
            if (a == 0)//nếu a=0
            {
                
                kq = (b == 0) ? "Phương trình vô số nghiệm" : "Phương trình vô nghiệm";//nếu a=0 và b=0 thì phương trình vô số nghiệm ,
                                                                                       //ngược lại a=0 và b khác 0 thì phương trình vô nghiệm
                
                //output
                Console.WriteLine($"=>{kq}");//in ra kết quả của điều kiện trên
            }
            else//ngược lại a>0 hoặc là a<0
            {
                x = -b / a;//tính mghieenj của phương trình 

                //output
                Console.WriteLine($"=>Phương trình có nghiệm là x = {x}");//in ra nghiệm của phương trình 
            }
        }
    }
}
