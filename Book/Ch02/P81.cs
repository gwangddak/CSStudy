﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    //오버플로우
    internal class P81
    {
        static void Main19(string[] args)
        {
            int a = 2147483640;
            int b = 52273;

            Console.WriteLine(a+b);
            //자료형의 범위때문에 오버플로우 즉, -의 값이 나오게 된다.
        }
    }
}
