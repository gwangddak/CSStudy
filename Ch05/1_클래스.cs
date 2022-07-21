using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch05.Sub1;
/*
* 날짜 : 2022/07/18
* 이름 : 조광현
* 내용 : 클래스 실습하기 교재 p203
* 
* 클래스(Class)
* - 클래스는 객체를 생성하는 구조체이며 필드(속성)와 메서드(기능)로 구성된다.
* - 객체는 클래스의 실제 인스턴스 new연산을 통해서 생성이 된다.
* 
*/

namespace Ch05
{
    internal class _1_클래스
    {


        static void Main1(string[] args)
        {
            //객체생성 
            Car Sonata = new Car();
            //클래스 참조변수 = 새 클래스 참조();

            //객체 초기화

            Sonata.name = "소나타";
            Sonata.color = "흰색";
            Sonata.speed = 0;

            //객체 기능 활용 

            Sonata.SpeedUp(80);
            Sonata.SpeedDown(20);
            Sonata.Show();

            //객체 생성과 초기화

            Car Benz = new Car();

            Benz.name = "벤츠";
            Benz.color = "블랙";
            Benz.speed = 0;

            
            Benz.SpeedUp(100);
            Benz.SpeedDown(100);
            Benz.Show();

            //Account 객체 생성
            Account Kb = new Account();
            Account Wr = new Account();

            //Account 객체 초기화
            Kb.bank = "국민은행";
            Kb.id = "9393-0200-152803";
            Kb.name = "조광현";
            Kb.balance = 10000;

            Wr.bank = "우리은행";
            Wr.id = "9393-0200-152804";
            Wr.name = "조광현";
            Wr.balance = 30000;

            //Account 객체 활용


            Kb.Deposit(40000);
            Kb.Withdraw(5000);
            Kb.Show();

            Wr.Deposit(70000);
            Wr.Withdraw(50000);
            Wr.Show();




        }
    }
}
