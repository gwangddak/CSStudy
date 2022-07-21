using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub1
{
    internal class Truck : Car
    {
        private int capacity;

        public Truck(string name, string color, int speed, int capacity) : base(name, color, speed)
        {
            this.capacity = capacity;
        }
        //오버라이드
        public override void SpeedUp(int speed)
        {
            base.speed += speed;
            Console.WriteLine("Truck SpeedUp...");
        }

        public override void SpeedDown(int speed)
        {
            base.speed -= speed;
            Console.WriteLine("Truck SpeedDown...");

        }
        public override void Show()
        {
            Console.WriteLine("====================");
            Console.WriteLine("차량명 : " + name);
            Console.WriteLine("차색상 : " + color);
            Console.WriteLine("속도 : " + speed);
            Console.WriteLine("적재용량 : " + capacity);
        }
    }
}
