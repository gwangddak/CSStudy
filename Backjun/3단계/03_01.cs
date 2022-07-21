using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Backjun._3단계
{
    internal class _03_01
    {

        static void Main1(string[] args)
        {
            string arg = Console.ReadLine();
            int a = int.Parse(arg);

            for (int i = a; i <= a; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{a} * {j} = {a*j}");
                }
            }

        }


  
    }
}
