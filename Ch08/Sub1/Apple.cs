﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch08.Sub1
{
    internal class Apple
    {
        private string country;
        private int price;

        //생성자 
        public Apple(string country, int price)
        {
            this.country = country;
            this.price = price;
        }

        public void Show()
        {
            Console.WriteLine("사과 원산지 : "+country);
            Console.WriteLine("사과 가격 : "+price );
        }
    }
}
