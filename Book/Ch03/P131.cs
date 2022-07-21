using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{

    internal class P131
    {
        static void Main3(string[] args)
        {
            //홀수짝수 구분하기
            Console.Write("숫자입력 : ");
            int input =int.Parse(Console.ReadLine());
            if (input % 2 ==0)
            {
                Console.WriteLine("짝수입니다.");
            }
            else
            {
                Console.WriteLine("홀수입니다.");
            }

            //오전과 오후 구분하기
            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("오전입니다.");
            }
            else
            {
                Console.WriteLine("오후입니다.");
            }
        }
    }
}
