using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._04
{
    class Apple
    {
        public void Show()
        {
            Console.WriteLine("사과 입니다.");
        }
    }
    class Banana
    {
        public void Show()
        {
            Console.WriteLine("바나나 입니다.");
        }
    }
    class Grape
    {
        public void Show()
        {
            Console.WriteLine("포도 입니다.");
        }
    }
    internal class _04_08
    {
        //객체 형변환 문제
        static void Main(string[] args)
        {
            Apple apple = new Apple();
            Banana banana = new Banana();
            Grape grape = new Grape();

            Show(apple);
            Show(banana);
            Show(grape);
        }
        //매개변수에 object는 참조로 객체캐스팅을 해준다.
        //as와is는 객체 캐스팅 시에 사용되는 연산자이다.\
        //is연산자는 객체에 대한 캐스팅 성공 여부를 판단할 수 있다.
        //as연산자는 객체에 대한 캐스팅에 대한 결과를 리턴시켜준다.
        public static void Show(Object fruit)
        {
            if (fruit is Apple)
            {
                Apple apple = (Apple)fruit;
                apple.Show();
            }
            else if (fruit is Banana)
            {
                Banana banana = fruit as Banana;
                banana.Show();
            }
            else if (fruit is Object)
            {
                Grape grape = (Grape)fruit;
                grape.Show();
            }
        }
    }
}
