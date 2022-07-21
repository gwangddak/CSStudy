using Ch05.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/07/18
 * 이름 : 조광현
 * 내용 : 캡슐화 실습하기 교재 p203
 * 
 * 캡슐화 (Encapsulation)
 *  - 캡슐화는 객체의 내용(필드)을 외부에서 참조하지 못하도록 객체의 정보()속성을 은닉 하는 특성
 *  - 접근 제한자 public , private,protected를 사용한다.
 *  -은닉된 정보의 안전한 제공을 위해 Getter, Setter를 사용(프로퍼티)
 */
namespace Ch05
{
    internal class _2_캡슐화
    {
        static void Main2(string[] args)
        {
            Account Kb = new Account("국민은행", "9393-0200-152803", "조광현", 10000);

            //Account 객체 초기화

            //Account 객체 활용


            Kb.Deposit(40000);
            Kb.Withdraw(5000);


            //캡슐화로 취약 코드 예방
            //Kb.balance--; // 캡슐화로 인해 초기화 못함

            Kb.Show();

            Car Sonata = new Car("소나타","흰색",100);

            Sonata.SpeedUp(100);
            Sonata.SpeedDown(20);
            Sonata.Show();

            //getter, setter 활용
            Car bmw = new Car();

            bmw.Name = "뱀떱"; // setter 호출
            bmw.Color = "흰색"; // setter 호출
            bmw.Speed = -10; // setter 호출

            Console.WriteLine("bmw name : " + bmw.Name);
            Console.WriteLine("bmw color : " + bmw.Color);
            Console.WriteLine("bmw speed : " + bmw.Speed);


          

        }

    }
}
