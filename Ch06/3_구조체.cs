using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/07/20
 * 이름 : 조광현
 * 내용 : 구조체 실습하기 교재 p230
 * 
 * 구조체 (Structurr)
 * - 간단하게 객체를 만들때 사용하는 구조형식
 * - 클래스오 ㅏ동일하지만 상속, 다형성 등 지원안함
 * - struct 즉 구조체는 잘 사용안함
 */
namespace Ch06
{
    struct Point
    {
        public int x;
        public int y;
        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
     
        }
    }
    internal class _3_구조체
    {
        static void Main3(string[] args)
        {
            Point p1; // 스택할당
            p1.x = 1;
            p1.y = 1;

            Console.WriteLine("P1 Add : ");

            Point p2 = new Point(2,2);

            p2.x = 2; p2.y = 3;

            Console.WriteLine("p2.Add : "+ p2);
        }

    }
}
