using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    //자료형 변환을 사용한 해결방법 // 자료형의 최대값과 최소값 구하기
    internal class P82
    {
        static void Main20(string[] args)
        {
            int a = 2000000000;
            int b = 1000000000;
            Console.WriteLine(a+b);

            /////////////////////////////////////
            ///값이 나오도록 자로형 변환시키기///
            /////////////////////////////////////
            uint unsignedInt = 4147483647;
            ulong unsignedLong = 11223372036854775808;

            Console.WriteLine(unsignedInt);
            Console.WriteLine(unsignedLong);
            /////////////////////////////////
            ///int 자료형 최대값과 최솟값///
            ////////////////////////////////
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            /////////////////////////////////
            ///long 자료형 최대값과 최솟값///
            ////////////////////////////////
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

        }
    }
}
