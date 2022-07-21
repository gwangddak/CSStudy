﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._03
{
    //다형성 연습문제 
    abstract class Shape
    {
        public abstract void Draw();
    }

    class Triangle : Shape // 상속 
    {
        public override void Draw() // abstruct 오버라이드 
        {
            Console.WriteLine("삼각형 그리기...");
        }
    }

    class Circle : Shape
    {
        public override void Draw() // abstruct 오버라이드 
        {
            Console.WriteLine("원 그리기...");
        }
    }

    internal class _03_09
    {
        static void Main9(string[] args)
        {
            _03_09 instance = new _03_09();

            Circle circle = new Circle();
            Triangle triangle = new Triangle();

            instance.Draw(circle);
            instance.Draw(triangle);
        }

        public void Draw(Shape shape)
        {
            shape.Draw();
        }


    }

}
