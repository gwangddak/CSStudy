using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._1단계
{
    internal class _01_06
    {
        static void Main6(string[] args)
        {
            string[] a = Console.ReadLine().Split();

            int a1 = int.Parse(a[0]);
            int a2 = int.Parse(a[1]);

            Console.WriteLine(a1-a2);
        }
    }
}
