using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class _01_09
    {
        static void Main9(string[] args)
        {
            int count = 0;

            for (int i = 1; i <= 9; i++)
            {
                if (i<= 5)
                {
                    count++;
                }
                else
                {
                    count--;
                }
                for (int k = 0; k < 5-count ; k++)
                {
                    Console.Write(" ");
                }
                for (int n = 0; n < count*2-1; n++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
