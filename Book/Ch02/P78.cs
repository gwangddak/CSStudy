using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    //불과 논리 연산자
    internal class P78
    {
        static void Main17(string[] args)
        {
            Console.WriteLine(DateTime.Now.Hour < 3 || 8<DateTime.Now.Hour);
            Console.WriteLine(3<DateTime.Now.Hour || DateTime.Now.Hour<8);

        }
    }
}
