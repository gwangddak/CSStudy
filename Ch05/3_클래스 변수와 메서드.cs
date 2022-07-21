﻿using Ch05.Sub3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/07/18
 * 이름 : 조광현
 * 내용 : 클래스 변수 , 클래스 매서드 실습하기 교재 p225
 * 
 * 클래스 변수, 클래스 메서드 
 * - 클래스 변수와 클래스 메서드는 static을 선언한 변수와 메서드로 Data 영약 메모리 공간에 하나의 클래스로 관리
 * - 클래스 이름으로 직접 참조하거나 호출한다.
 * 
 * 싱글톤(singleton)
 * 
 * - static을 활용한 가장 대표적인 객체 생성 방법
 * - 싱글톤 패턴이 적용된 객체는 메모리에 하나의 인스턴스만 생성하고 공유한다.
 * - 싱글톤 객체를 활용해서 메모리 절약과 성능 항상을 도모한다.
 */
namespace Ch05
{
    class increment
    {
        public int num1;

        //Data 영역에 따로 관리되는 클래스 변수 // 정적 변수
        public static int num2;


        public increment()
        {
            num1++;
            num2++;

            Console.WriteLine("num1 : {0} , num2 : {1}",num1,num2);

        }
        //Data 영역에 따로 관리되는 클래스 메서드 // 정적 메서드
        // 정적 메서드 안에 non static 변수를 참조할 수 없다. // 중요
        public static void Add()
        {
            //num1++;
            num2++;

            Console.WriteLine(" num2 : {0}", num2);
        }
    }

    internal class _3_클래스_변수와_메서드
    {
        static void Main(string[] args)
        {

            increment inc1 = new increment();
            increment inc2 = new increment();
            increment inc3 = new increment();

            //클래스 변수 참조
            increment.num2 = 10;

            //클래스 메서드 실행\

            increment.Add();

            //클래스 변수를 활용한 객체

            Car car1 = new Car("소나타", "검정", 0);
            car1.Show();
            Car car2 = new Car("아반떼", "검정", 0);
            car2.Show();

            Car car3 = new Car("싼타페", "검정", 0);
            car3.Show();

            //싱글톤 객체
            Calc cal1 = Calc.Instance; //매우중요
            Calc cal2 = Calc.Instance; //매우중요 // cal1과 cal2는 동일하게 참조

            cal1.Plus(1, 2);

            int r1 = cal1.Plus(1, 2);
            int r2 = cal2.Minus(1, 2);
            int r3 = cal1.Multi(1, 2);
            int r4 = cal2.Div(1, 2);

            Console.WriteLine("r1 : "+r1);
            Console.WriteLine("r2 : "+r2);
            Console.WriteLine("r3 : "+r3);
            Console.WriteLine("r4 : "+r4);





        }
    }
}
