using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    //문자열 자료형과 연산자 및 변수 생성
    internal class P87
    {
        static void Main24(string[] args)
        {
            char a = 'a';
            char b = 'b';

            Console.WriteLine(a+b);
            Console.WriteLine(a-b);
            Console.WriteLine(a*b);
            Console.WriteLine(a/b);
            Console.WriteLine(a%b);

            string message = "안녕하세요";

            Console.WriteLine(message + "!");
            Console.WriteLine(message[0]);
            Console.WriteLine(message[1]);
            Console.WriteLine(message[2]);
        }
    }
}
