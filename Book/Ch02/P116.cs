using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P116
    {
        static void Main40(string[] args)
        {
            //문자열을 불로 변환
            Console.WriteLine(bool.Parse("True"));
            Console.WriteLine(bool.Parse("true"));
            Console.WriteLine(bool.Parse("False"));
            Console.WriteLine(bool.Parse("false"));

            //int 자료형 최솟값의 음수 //자료형 말고 숫자를 적게되면 오류가 발생한다 

            int output = int.MinValue;
            Console.WriteLine(-output);

        }

    }
}
