using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._2단계
{
    internal class _02_06
    {
        static void Main6(string[] args)
        {
            string[] str = Console.ReadLine().Split();

            int a = int.Parse(str[0]);  
            int b = int.Parse(str[1]);
            int c = int.Parse(Console.ReadLine());


            b += c;
            while (b >=60)
            {
                b -=60;
                a ++;
            }
            if (a >= 24)
            {
                a -= 24;
            }

            Console.WriteLine("{0} {1}",a,b);
        }
    }
}
