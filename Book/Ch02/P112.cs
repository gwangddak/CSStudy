using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P112
    {
        static void Main38(string[] args)
        {

            //기본 자료형을 문자열로 변환 
            Console.WriteLine((52).ToString());
            Console.WriteLine((52.273).ToString());
            Console.WriteLine(('a').ToString());
            Console.WriteLine((true).ToString());
            Console.WriteLine((false).ToString());
            //기본 자료형을 문자열로 변환 (string 변환값의 타입 알아내기 )
            Console.WriteLine((52).ToString().GetType());
            Console.WriteLine((52.273).ToString().GetType());
            Console.WriteLine(('a').ToString().GetType());
            Console.WriteLine((true).ToString().GetType());
            Console.WriteLine((false).ToString().GetType());

            //간단한 문자열 변환
            int number = 52273;
            string outputA = number + "";
            Console.WriteLine(outputA);
            //char형은 아쉽게도 문자열로 변환이 불가능하다
        }
    }
}
