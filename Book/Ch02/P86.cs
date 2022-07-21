using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    //size of 연산자
    internal class P86
    {
        static void Main23(string[] args)
        {
            Console.WriteLine("int : "+sizeof(int));
            Console.WriteLine("long : "+sizeof(long));
            Console.WriteLine("float : "+sizeof(float));
            Console.WriteLine("double : "+sizeof(double));
            Console.WriteLine("char : "+sizeof(char));
            //각각의 자료형이 몇 바이트인지 알수있다.
        }
    }
}
