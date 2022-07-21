using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._2단계
{
    internal class _02_01
    {
        static void Main1(string[] args)
        {
            string[] number = Console.ReadLine().Split();
            
            int a = int.Parse(number[0]);
            int b = int.Parse(number[1]);

            if (a>b)
            {
                Console.WriteLine('>');
            }
            else if (a<b)
            {
                Console.WriteLine('<');
            }
            else
            {
                Console.WriteLine("==");
            }
        }
    }
}
