using System;
using System.Text;
/*
     5.	Viết chương trình nhập vào giờ phút giây (hh:mm:ss) và số giây thêm vào. 
     Tính và in ra kết quả dưới dạng (hh:mm:ss) mới sau khi cộng số giây thêm vào.
 */
namespace CHUONG_I
{
    class Class_5
    {
        static void tg(int h)
        {
            if (h < 10)
            {
                Console.Write($"   0{h}:");
            }
            else
            {
                Console.Write($"   {h}:");
            }
        }
        static void tg1(int a, int b)
        {
            if (a + b < 0)
            {
                Console.Write($"0{a + b}:");
            }
            else
            {
                Console.Write($"{a + b}:");
            }
        }
        static void tp(int m)
        {
            if (m < 10)
            {
                Console.Write($"0{m}:");
            }
            else
            {
                Console.Write($"{m}:");
            }
        }
        static void ts(int s1)
        {
            if (s1 < 10)
            {
                Console.WriteLine($"0{s1}");
            }
            else
            {
                Console.WriteLine($"{s1}");
            }
        }
        static void tst(int s1, int s2)
        {
            if (s1 + s2 < 60)
            {
                if (s1 + s2 < 10)
                {
                    Console.WriteLine($"0{s1 + s2}");
                }
                else
                {
                    Console.WriteLine($"{s1 + s2}");
                }
            }
        }
        static void tst1(int s1, int s2)
        {
            if (s1 + s2 > 60)
            {

                if ((s1 + s2) % 60 < 10)
                {
                    Console.WriteLine($"0{(s1 + s2) % 60}");
                }
                else
                {
                    Console.WriteLine($"{(s1 + s2) % 60}");
                }
            }
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("TÍNH THỜI GIAN");

            Console.WriteLine("Nhập số giờ:");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào phút:");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào giây:");
            int s1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào số giây cộng vào:");
            int s2 = int.Parse(Console.ReadLine());

            int h1, m1, s3;
            if (m >= 60 && s1 >= 60)
            {
                Console.WriteLine("Vui lòng nhập lại ");
            }
            else
            {
                Console.WriteLine("=>");
                tg(h);
                tp(m);
                ts(s1);
                Console.WriteLine("  +");
                if (s2 < 10)
                {
                    Console.WriteLine($"   00:00:0{s2}");
                    Console.WriteLine("   --------");
                    if (s1 + s2 < 60)
                    {
                        tg(h);
                        tp(m);
                        tst(s1, s2);
                    }
                    else
                    {
                        if (m == 59)
                        {
                            tg(h + 1);
                            tp(0);
                            tst1(s1, s2);
                        }
                        else
                        {
                            tg(h);
                            tp(m + 1);
                            tst1(s1, s2);
                        }
                    }
                }
                else if (s2 >= 10 && s2 < 60)
                {
                    Console.WriteLine($"   00:00:{s2}");
                    Console.WriteLine("   --------");
                    if (s1 + s2 < 60)
                    {
                        tg(h);
                        tp(m);
                        tst(s1, s2);
                    }
                    else
                    {
                        if (m == 59)
                        {
                            tg(h + 1);
                            tp(0);
                            tst1(s1, s2);
                        }
                        else
                        {
                            tg(h);
                            tp(m + 1);
                            tst1(s1, s2);
                        }
                    }
                }
                else if (s2 >= 60 && s2 < 3600)
                {
                    Console.Write("   00:");
                    m1 = s2 / 60;
                    s3 = s2 % 60;
                    tp(m1);
                    ts(s3);
                    Console.WriteLine("   --------");
                    if ((m + m1) < 60 && (s1 + s3) < 60)
                    {
                        tg(h);
                        tg1(m, m1);
                        tst(s1, s3);
                    }
                    else if (s1 + s3 >= 60 && m + m1 < 60)
                    {
                        if (m + m1 == 59)
                        {
                            tg(h + 1);
                            tp(0);
                            tst1(s1, s3);
                        }
                        else
                        {
                            tg(h);
                            tp(m + m1 + 1);
                            tst1(s1, s3);
                        }
                    }
                    else if (s1 + s3 < 60 && m + m1 >= 60)
                    {
                        tg(h + 1);
                        tp((m + m1) % 60);
                        tst(s1, s3);
                    }
                    else if (s1 + s3 >= 60 && m + m1 >= 60)
                    {
                        tg(h + 1);
                        tp((m + m1 + 1) % 60);
                        tst1(s1, s3);
                    }
                }
                else
                {
                    h1 = s2 / 3600;
                    m1 = (s2 - h1 * 3600) / 60;
                    s3 = s2 - (h1 * 3600 + m1 * 60);
                    tg(h1);
                    tp(m1);
                    ts(s3);
                    Console.WriteLine("   --------");
                    if ((m + m1) < 60 && (s1 + s3) < 60)
                    {
                        tg(h + h1);
                        tg1(m, m1);
                        tst(s1, s3);
                    }
                    else if (s1 + s3 >= 60 && m + m1 < 60)
                    {
                        if (m + m1 == 59)
                        {
                            tg(h + 1 + h1);
                            tp(0);
                            tst1(s1, s3);
                        }
                        else
                        {
                            tg(h + h1);
                            tp(m + m1 + 1);
                            tst1(s1, s3);
                        }
                    }
                    else if (s1 + s3 < 60 && m + m1 >= 60)
                    {
                        tg(h + 1 + h1);
                        tp((m + m1) % 60);
                        tst(s1, s3);
                    }
                    else if (s1 + s3 >= 60 && m + m1 >= 60)
                    {
                        tg(h + 1 + h1);
                        tp((m + m1 + 1) % 60);
                        tst1(s1, s3);
                    }
                }
            }
        }
    }
}