﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class P213
    {
        static void Main5(string[] args)
        {
            List<int> list = new List<int>(); // 리스트 배열 형식 
            list.Add(52);
            list.Add(273);
            list.Add(32);
            list.Add(64);

            foreach(var item in list)
            {
                Console.WriteLine("count : "+list.Count + "\titem: "+item);

            }

        }


        
    }
}
