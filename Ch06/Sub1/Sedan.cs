using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub1
{
    //추상메서드는 자식이 초기화 해야할 의무가 있음
    internal class Sedan : Car
    {

        private int cc;
        //생성자
        public Sedan(string name, string color, int speed,int cc) : base(name, color, speed)
        {
            this.cc = cc;
        }

        //오버라이드
        public override void SpeedUp(int speed)
        {
            base.speed += speed;
            Console.WriteLine("Sedan SpeedUp...");
        }

        public override void SpeedDown(int speed)
        {
            base.speed -= speed;
            Console.WriteLine("Sedan SpeedDown...");

        }
        public override void Show()
        {
            Console.WriteLine("====================");
            Console.WriteLine("차량명 : "+name);
            Console.WriteLine("차색상 : "+color);
            Console.WriteLine("속도 : "+speed);
            Console.WriteLine("배기량 : "+cc);
        }
    }
}
