using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class _01_08
    {
        
        static void Main8(string[] args)
        {
            int n = 5;

            for (int i = 0; i < n; i++)
            {
                for(int k = 0; k < n-i; k++)
                {
                    Console.Write(" ");
                }
                for (int b = 0; b < i*2+1;  b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


    }
}
