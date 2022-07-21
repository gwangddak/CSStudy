using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch06.Sub3;
/*
* 날짜 : 2022/07/21
* 이름 : 조광현
* 내용 : 제네릭 실습하기 교재 p395
* 
* 제네릭(Generic)
* 
* - 클래스 내부의 변수의 타입을 동적으로 일반화 시키는 문법요소 
* - 제네릭 사용으로 클래스를 범용성 있게 사용한다. 
* 
*/
namespace Ch06
{
    class FruitBox<T> //
    {
        private T fruit; // 동적으로 만들어짐

        //생성자
        public FruitBox(T fruit)
        {
            this.fruit = fruit; 
        }

        //캡슐화 // 둘다 같은개념이다 
        public T Fruit { get => fruit;  }

        public T GetFruit()
        {
            return fruit;
        }




    }





    //치환변수 <T> 범용성을 위한 치환수 
    internal class _4_제너릭
    {
        static void Main4(string[] args)
        {
            Apple apple = new Apple("한국",3000);
            Banana banana = new Banana("대만", 2000);

            FruitBox <Apple>Box1 = new FruitBox<Apple>(apple);
            FruitBox <Banana>Box2 = new FruitBox<Banana>(banana);

            Box1.Fruit.Show();
            Box2.GetFruit().Show();
        }
    }
}
