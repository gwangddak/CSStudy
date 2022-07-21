using Ch06.Sub1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/07/20
 * 이름 : 조광현
 * 내용 : 추상클래스 실습하기 교재 p230
 * 
 * 추상클래스(Abctract Class)
 *  - 공통의 기능은 하나의 메서드를 정의하고 개별적인 기능은 상속 받아 override 메서드로 정의하는 추상 메서드를 갖는 클래스
 *  - 오직 상속을 목적으로 설계되는 클래스 
 * 
 * 
 */
namespace Ch06
{
    internal class _1_추상클래스
    {
        static void Main1(string[] args)
        {
            //추상클래스여서 부모를 불러오는건 안된다 //객체 생성 x
            //Car car = new Car(); // 안됨



            //Car car 
            //다형성을 적용시키는 것이 좋다

            Car sedan = new Sedan("그랜져", "검정", 0, 2000);
            sedan.SpeedUp(100);
            sedan.SpeedDown(20);
            sedan.Show();
            Car truck = new Truck("포터", "파랑", 0, 1);
            truck.SpeedUp(80);
            truck.SpeedDown(20);
            truck.Show();


        }
    }
}
