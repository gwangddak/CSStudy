using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._2단계
{
    internal class _02_03
    {
        static void Main3(string[] args)
        {
            string a = Console.ReadLine();

            int a1 = int.Parse(a);
            int num =0;


            if ((a1%4 ==0 && !((a1%100==0)) || a1%400 ==0))
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
