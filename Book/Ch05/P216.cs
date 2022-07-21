using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class P216
    {
        static void Main7(string[] args)
        {
            Console.WriteLine(Math.Abs(-52273)); //절대값
            Console.WriteLine(Math.Ceiling(52.273)); // 지정된 숫자보다 크거나 같은 최소 정수를 구한다.
            Console.WriteLine(Math.Floor(52.273)); // 지정된 숫자보다 작거나 같은 최대 정수를 구한다.
            Console.WriteLine(Math.Max(52,273)); // 두개의 매개변수중에 가장 큰값을 구한다.
            Console.WriteLine(Math.Min(52,273)); // 두개의 매개변수중에 가장 작은값을 구한다.
            Console.WriteLine(Math.Round(52.273)); // 반올림을 진행한다.
        }
    }
}
