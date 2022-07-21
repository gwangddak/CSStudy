using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._2단계
{
    internal class _02_07
    {
        static void Main7(string[] args)
        {
            string[] number = Console.ReadLine().Split();
            int x = int.Parse(number[0]);
            int y = int.Parse(number[1]);
            int z = int.Parse(number[2]);

            if (x == y && y == z)
            {
                Console.WriteLine(10000 + (x * 1000));
            }
            else if (x == y)
            {
                Console.WriteLine(1000 + x*100);
            }
            else if (x == z)
            {
                Console.WriteLine(1000 + x * 100);
            }
            else if (y == z)
            {
                Console.WriteLine(1000 + y * 100);
            }
            else
            {
                if (x > y && x > z)
                {
                    Console.WriteLine(100 * x);
                }
                else if (y > z)
                {
                    Console.WriteLine(100 * y);
                }
                else
                {
                    Console.WriteLine(100 * z);
                }

            }


        }
    }
}
