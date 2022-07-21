using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P114
    {
        static void Main39(string[] args)
        {

            //double의 소수점 제거 
            double number = 52.273103;
            Console.WriteLine(number.ToString("0.0"));
            Console.WriteLine(number.ToString("0.00"));
            Console.WriteLine(number.ToString("0.000"));
            Console.WriteLine(number.ToString("0.0000"));

            //숫자와 문자열 덧셈 //숫자와 문자열을 더하면 연결 연산자로 적용이된다 

            Console.WriteLine(52+273); // 일반 연산자
            Console.WriteLine("52"+273); // 연결연산자
            Console.WriteLine(52+"273"); // 연결연산자
            Console.WriteLine("52"+"273"); // 연결연산자





        }
    }
}
