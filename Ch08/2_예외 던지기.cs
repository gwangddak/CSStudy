using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/07/26
 * 이름 : 조광현
 * 내용 : 예외 던지기 실습하기 교재 
 * 
 */
namespace Ch08
{
    class Box
    {
        private int width;
        private int height;

        public Box(int width, int height)
        {
            if (width > 0 && height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else
            {
                //예외 던지기 (예외를 강제 발생 시킴) //음수를 넣었기에 문제점을 지적해야함 // 호출부분에서 던진다.
                throw new Exception("크기는 0보다 작을 수 없습니다."); // Exception 객체

            }

        }


        public void Area()
        {
            Console.WriteLine("박스 넓이 : "+width * height);
        }
    }
    internal class _2_예외_던지기
    {
        static void Main2(string[] args)
        {
            try
            {
                Box box1 = new Box(10, 10);
                box1.Area();

                Box box2 = new Box(-10, -10); // 문제점 파악
                box2.Area(); 
            }
            catch (Exception e)  // 여기서 문제 메세지를 받는다.
            {
                Console.WriteLine(e.Message);
               
            }

        }
    }
}
