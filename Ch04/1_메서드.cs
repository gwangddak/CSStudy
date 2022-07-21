using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/07/14
 * 이름 : 조광현
 * 내용 : 메서드 실습하기 교재 p256
 * 
 * 메서드(Method)
 *  - 일련의 코드 로직을 재활용 하기 위해 모듈화된 구조체  
 *  - 메서드는 정의(Define)하고 메인에서 호출(call)
 */
namespace Ch04
{
    internal class _1_메서드
    {
        static void Main1(string[] args)
        {
            int y1 = F(1);
            int y2 = F(2);
            int y3 = F(3);
            int y4 = F(4);

            int t1 = Sum(1, 10);
            int t2 = Sum(1, 100);
            int t3 = Sum(start:1,end: 1000);
            

            Console.WriteLine("y1 : "+y1);
            Console.WriteLine("y2 : "+y2);
            Console.WriteLine("y3 : "+y3);
            Console.WriteLine("y4 : "+y4);
            Console.WriteLine("t1 : "+t1);
            Console.WriteLine("t2 : "+t2);
            Console.WriteLine("t3 : "+t3);
  

        } // and of main

        //메서드 정의

        public static int F(int x)
        {
            int y =2* x+3;
            return y;


        }

        public static int Sum(int start , int end)
        {
            int total = 0;

            for (int k  = start;  k  <= end;  k ++)
            {
                total += k;
                
            }
            return total;
        }

    }
}
