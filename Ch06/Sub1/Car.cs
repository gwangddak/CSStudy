using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub1
{
    //추상클래스 : 추상메서드를 갖는 클래스

    internal abstract class Car // public과 동일한 internal // abstract = 추상클래스
    {
        //속성
        protected string name;
        protected string color;
        protected int speed;

        //생성자
        protected Car(string name, string color, int speed)
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
        }

        //기능 // 메서드를 선언만 해준다. // 추상메서드
        public abstract void SpeedUp(int speed); // 스피드에 대한 매개변수 선언
        public abstract void SpeedDown(int speed);


        public virtual void Show()
        {
            Console.WriteLine("==================");
            Console.WriteLine("차량명 : "+name);
            Console.WriteLine("차량색 : "+color);
            Console.WriteLine("속도 : "+speed);

        }


    }
}
