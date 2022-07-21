using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
*날짜 : 2022 / 07 / 21
* 이름 : 조광현
* 내용 :자주 사용하는 내장클래스 실습하기
*/
namespace Ch06
{
    internal class _6_내장클래스
    {
        static void Main(string[] args)
        {
            //////////////////////////////////
            ///Math 클래스 
            //////////////////////////////////
            //Math math = new Math():

            Console.WriteLine("PI :  " + Math.PI);
            Console.WriteLine("9 제곱근 :  " + Math.Sqrt(9));
            Console.WriteLine("16제곱근 :  " + Math.Sqrt(16));
            Console.WriteLine("절대값 :  " + Math.Abs(-5));
            Console.WriteLine("올림값  :  " + Math.Ceiling(1.2));
            Console.WriteLine("올림값  :  " + Math.Ceiling(1.8));
            Console.WriteLine("내림값  :  " + Math.Floor(1.2));
            Console.WriteLine("내림값  :  " + Math.Floor(1.8));
            Console.WriteLine("반올림  :  " + Math.Round(1.2));
            Console.WriteLine("반올림  :  " + Math.Round(1.8));


            //////////////////////////////////
            ///Random 클래스 
            //////////////////////////////////
            ///

            Random rand = new Random();
            double num1 = rand.NextDouble();

            Console.WriteLine("num1 : "+num1); //0에서 1사이의 임의의 실수

            double num2 = num1 * 10;
            Console.WriteLine("num2 : " + num2); //0에서 10사이의 임의의 실수


            double num3 = Math.Ceiling(num2);
            Console.WriteLine("num3 : " + num3); //1에서 1사이의 임의의 정수


            int rNum1 = rand.Next();
            Console.WriteLine("rnum1 : " + rNum1); //int형의 최대까지 임의의 실수

            int rNum2 = rand.Next(10);
            Console.WriteLine("rnum2 : " + rNum2); //0에서 9사이의 임의의 정수

            int rNum3 = rand.Next(1,11);
            Console.WriteLine("rnum3 : " + rNum3); //1에서 10사이의 임의의 정수
            Console.WriteLine();
            //////////////////////////////////
            ///DateTime 클래스 
            //////////////////////////////////
            ///


            //싱글톤 객체
            DateTime dt1 = DateTime.Now;
            Console.WriteLine(dt1);
            Console.WriteLine("년 : "+dt1.Year);
            Console.WriteLine("월 : "+dt1.Month);
            Console.WriteLine("일 : "+dt1.Day);
            Console.WriteLine("시 : "+dt1.Hour);
            Console.WriteLine("분 : "+dt1.Minute);
            Console.WriteLine("초 : "+dt1.Second);

            //문자열 포멧을 이용해 날짜 출력

            string result1= dt1.ToString("yyyy-MM-dd");
            Console.WriteLine("result1 :" +result1);

            string result2 = dt1.ToString("yy-MM-dd hh:mm:ss");
            Console.WriteLine("result2 :" + result2);

        }


    }
}
