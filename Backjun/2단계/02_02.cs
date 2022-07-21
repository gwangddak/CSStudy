using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._2단계
{
    internal class _02_02
    {
        static void Main2(string[] args)
        {
            string number = Console.ReadLine();

            int a = int.Parse(number);   

            if(a <=100 && a >= 90 )
            {
                Console.WriteLine("A");
            }
            else if(a <= 89 && a >= 80)
            {
                Console.WriteLine("B");

            }
            else if(a <= 79 && a >= 70)
            {
                Console.WriteLine("C");
            }
            else if (a <= 69 && a >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }

        }
    }
}
