using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P110
    {
        static void Main37(string[] args)
        {
            string numberString = "522273";
            //int intNumber = (int)numberString; // 문자열을 int형이나 다른 자료형으로 강제 형변환을 시킬때는 
            int intNumber = int.Parse(numberString); // 이런식으로 변환을 해줘야 한다.

            //문자열을 숫자로 변환 


            Console.WriteLine(int.Parse("52"));
            Console.WriteLine(long.Parse("273"));
            Console.WriteLine(float.Parse("52.273"));
            Console.WriteLine(double.Parse("103.32"));

            //문자열을 숫자로 변환 (자료형타입 알아내기)
            Console.WriteLine(int.Parse("52").GetType());
            Console.WriteLine(long.Parse("273").GetType());
            Console.WriteLine(float.Parse("52.273").GetType());
            Console.WriteLine(double.Parse("103.32").GetType());

            //주의 사항 // parse의 매개변수에는 변환이 가능한 자료형을 넣어주도록 하자



        }
    }
}
