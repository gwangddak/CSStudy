using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    //인터페이스 : 오직 추상메서드만 갖는 구조체
    internal interface IRemoteControl // 인터페이스 활용시 이름은 대문자 I로 시작 // 구조체
    {
        public abstract void PowerOn();
        public abstract void PowerOff();


        //abstruct 생략
        public void ChUp();
        public void ChDown();


        public void SoundUp();
        public void SoundDown();

        //전부 추상 메서드


    }
}
