﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class P210
    {
        //원하는 범위의 실수 난수 생성
        static void Main3(string[] args)
        {
            Random random = new Random();
            Console.WriteLine(random.NextDouble()*10);
            Console.WriteLine(random.NextDouble()*10);
            Console.WriteLine(random.NextDouble()*10);
            Console.WriteLine(random.NextDouble()*10);
            Console.WriteLine(random.NextDouble()*10);
        }
    }
}
