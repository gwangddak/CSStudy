using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._1단계
{
    internal class _01_12
    {
        static void Main12(string[] args)
        {
           

            string[] a1 = Console.ReadLine().Split();

            int a = int.Parse(a1[0]);
            int b = int.Parse(a1[1]);
            int c = int.Parse(a1[2]);

            Console.WriteLine((a+b)%c);
            Console.WriteLine(((a%c)+(b%c))%c);
            Console.WriteLine((a*b)%c);
            Console.WriteLine(((a%c)*(b%c))%c);

        }
    }
}
