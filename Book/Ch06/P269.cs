using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class P269
    {
        class Test
        {
            public int Sum(int min, int max)
            {
                int output = 0;
                for (int i = min; i <= max; i++)
                {
                    output += i;
                }
                return output;
            }
            public int Money(int min, int max)
            {
                int output = 1;

                for (int i = min; i <= max; i++)
                {
                    output *= i;
                }
                return output;
            }
        }
        class Test2
        {
            public int Sum(int min2, int max2)
            {
                int output2 = 0;
                for (int i = min2; i <= max2; i++)
                {
                    output2 -= 1;

                }
                return output2;


            }

        }
        static void Main(string[] args)
        {
            Test test = new Test();

            Test2 test2 = new Test2();
            Console.WriteLine(test.Sum(1,100));
            Console.WriteLine(test.Money(1,10));
            Console.WriteLine(test2.Sum(100, 5000));

            
        }
    }
}
