using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub2
{
    internal class Car
    {
        //속성 (필드)
        //생성자 호출 단축키 ctrl + .
        private string name;
        private string color;
        private int speed;


        //Getter, Setter : C# 에서는 "프로퍼티"라고 칭한다.
        public string Name 
        { 
            get => name; 
            set => name = value; 
        }
        public string Color
        { 
            get => color; 
            set => color = value; 
        }
        public int Speed 
        { 
            get => speed;
            set // 커스텀 가능
            {
                if (value > 0)
                {
                    Console.WriteLine("speed는 0보다 작을 수 없습니다.");
                }
                else
                {
                    speed = value;
                }
            }
        }

        //=================================================================

        public Car()
        {
            //기본생성자

            //오버라이드
        }

        public Car(string name,string color,int speed)
        {
            this.Name = name;
            this.Color = color;
            this.Speed = speed;

        }

        //기능 (메서드)
        public void SpeedUp(int speed) 
        {
            this.Speed += speed;  
        }

        public void SpeedDown(int speed)
        {
            this.Speed -= speed;
        }

        public void Show()
        {
            Console.WriteLine("=====================");
            Console.WriteLine("차량명 :"+Name);
            Console.WriteLine("차량색 :"+Color);
            Console.WriteLine("현재속도 :"+Speed);
            Console.WriteLine("=====================");




        }

    }
}
