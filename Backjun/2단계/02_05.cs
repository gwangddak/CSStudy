using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._2단계
{
    internal class _02_05
    {

        static void Main5(string[] args)
        {
            Console.Write("상근이의 기상시간 : ");

            string[] a1 = Console.ReadLine().Split();

            int a = int.Parse(a1[0]); 
            int b = int.Parse(a1[1]);

            b -= 45;

            if (b < 0)
            {
                b += 60;
                a -= 1;
                if (a < 0)
                {
                    a = 23;
                }
            }


            Console.WriteLine("기상알람 설정 시간 : {0} {1}",a,b);




            
        }
    }
}
