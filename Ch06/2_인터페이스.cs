using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch06.Sub2;
/*
 * 날짜 : 2022/07/20
 * 이름 : 조광현
 * 내용 : 추상클래스 실습하기 교재 p230
 * 
 * 인터페이스(interface)
 *  - 클래스 설계를 위해 공통의 표준 가이드 역할을 위한 구조체
 *  - 인터페이스를 활용해서 객체간 결합도를 완화
 */
 
namespace Ch06
{
    internal class _2_인터페이스
    {
        static void Main2(string[] args)
        {
            ////////////////////////////////////////////
            ///인터페이스로 공통 클래스 구조설계에 활용
            ////////////////////////////////////////////
            IRemoteControl lg = new LGRemoteControl();
            IRemoteControl samsung = new LGRemoteControl();


            lg.PowerOn();
            lg.ChUp();
            lg.SoundUp();

            samsung.PowerOn();
            samsung.ChDown();
            samsung.SoundDown();

            ////////////////////////////////////////////
            ///인터페이스로 다중 상속에 활용
            ////////////////////////////////////////////
            Tv SmartTV = new Tv();

            SmartTV.PowerOn();
            SmartTV.Booting();
            SmartTV.AccessInternet();

            ////////////////////////////////////////////
            ///인터페이스로 객체간 결합도 완화에 활용
            ////////////////////////////////////////////
            ///
            Bulb bulb = new Bulb();
            Socket socket = new Cable(bulb); //다형성

            socket.SwitchOn();
            socket.SwitchOff();

        }

    }
}
