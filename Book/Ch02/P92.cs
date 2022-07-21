using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    //문자열과 관련된 복합 대입 연산자
    internal class P92
    {
        static void Main27(string[] args)
        {
            string output = "hello";
            output = output + "world";
            output = output + "!";

            Console.WriteLine(output);
        }
    }
}
