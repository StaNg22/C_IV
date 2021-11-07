using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHUONG_I
{
    class Class_6
    {
        static  int TGio1(int h, int m, int s1, int s2)
        {
            if (s1 + s2 < 60)
            {

                return (s1 + s2);
            }
            else if(s1 + s2>=60 && s1 + s2<3600)
            {
                return (m + 1);
                return ((s1 + s2) % 60);
            }
        }
    }
}
