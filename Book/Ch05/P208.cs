using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class P208
    {
        //랜덤클래스를 이용한 임의의 정수 생성
        static void Main2(string[] args)
        {
            Random random = new Random();
            Console.WriteLine(random.Next(10,100));
            Console.WriteLine(random.Next(10,100));
            Console.WriteLine(random.Next(10,100));
            Console.WriteLine(random.Next(10,100));
            Console.WriteLine(random.Next(10,100));
            Console.WriteLine(random.Next(10,100));
            Console.WriteLine(random.Next(10,100));
        }
    }
}
