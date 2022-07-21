using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P109
    {
        static void Main36(string[] args)
        {
            //자동 자료형 변환 

            //int 자료형의 숫자를 생성
            int intNumber = 2147483647;
            //int형 숫자를 long 자료형으로 자동 변환
            long intlong = intNumber;
            Console.WriteLine(intlong);

            //int 자료형을 double 자료형으로 자동 변환 
            double intToDouble = intNumber;
            Console.WriteLine(intToDouble);
        }
    }
}
