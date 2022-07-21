﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._03
{
    class Product
    {
        protected string category;
        protected int price;

        public Product(string category, int price)
        {
            this.category = category;
            this.price = price;
        }
        public virtual void show() { }
    }
    class Television : Product
    {
        public Television(string category,int price) : base (category,price)
        {

        }
        public override void show()
        {
            Console.WriteLine("제품분류 : "  + category);
            Console.WriteLine("제품가격 : "  + price);
        }
    }
    class Computer : Product
    {
        public Computer(string category, int price) : base (category,price)
        {

        }
        public override void show()
        {
            Console.WriteLine("제품분류 : "+category);
            Console.WriteLine("제품가격 : "+price);

        }
    }
    internal class _03_08
    {
        static void Main8(string[] args)
        {
            Product p1 = new Television("TV", 100);
            Product p2 = new Computer("컴퓨터", 150);

            p1.show();
            p2.show();

        }
    }
}
