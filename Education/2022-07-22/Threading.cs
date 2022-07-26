using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Education._2022_07_22
{
    internal class Threading
    {
        static void Main(string[] args)
        {
            var thread = new Thread(Func);
            //프로그램 실행 종료에 영향을 주지않는 스레드를 BackGround Thread라고 한다.
            thread.IsBackground = true;
            //스레드 스타트
            thread.Start();
            //스레드 백그라운드 이지만 작업이 종료될때 까지 대기하게 할려면 
            //Join()을 사용한다.
            thread.Join();
        }
        static void Func()
        {
            Thread.Sleep(30000);
        }
    }
}
