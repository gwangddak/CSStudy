using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._1단계
{

    internal class _01_08
    {
        static void Main8(string[] args)
        {
            string[] a = Console.ReadLine().Split();

            double a1 = double.Parse(a[0]);
            double a2 = double.Parse(a[1]);

            Console.WriteLine(a1 / a2);
        }
    }

}
