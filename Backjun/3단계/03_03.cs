using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._3단계
{
    internal class _03_03
    {
        static void Main3(string[] args)
        {
            string arg = Console.ReadLine();
            int a = int.Parse(arg);
            int s = 0;
            for (int i = 0; i <= a; i++)
            {
                s += i;

            }
            Console.WriteLine(s);

        }
    }
}
