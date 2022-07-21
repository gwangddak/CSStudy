using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P100
    {
       //인스턴스 변수는 var 키워드 사용이 불가하다
        static void Main32(string[] args)
        {
            //var 키워드 //var는 자료형을 자동으로 지정한다.
            var number = 100;
            //number = "변경"; // 이런식으로 int 자료형을 string 형식으로 변환하는 것은 불가능 하다.
            var number1 = 10.2;
            //number1 = "변경"; // 역시 float 형식도 string 로는 불가능 하다.

            //var의 지역변수 
            var local = 273;



        }
    }
}
