using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class P142
    {
        static void Main8(string[] args)
        {
            //삼향 연산자를 이용한 자연수 판별
            string input = Console.ReadLine();
            int number = int .Parse(input);

            Console.WriteLine(number > 0 ? "자연수입니다." : "자연수가 아닙니다.");

          
        }
    }
}
