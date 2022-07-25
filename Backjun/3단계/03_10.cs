using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._3단계
{
    internal class _03_10
    {
        static void Main5(string[] args)
        {
            string arg = Console.ReadLine();

            int n1 = (int)char.GetNumericValue(arg[0]);
            int n2 = (int)char.GetNumericValue(arg[1]);

            int final = n1 + n2;
            int aa;


            if (n1+n2 == final)
            {
                n2 += final;
                aa = n2;

                Console.WriteLine(aa);
            }







        }
    }
}
