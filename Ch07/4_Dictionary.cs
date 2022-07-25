using Ch07.Sub1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/07/25
 * 이름 : 조광현
 * 내용 : 컬렉션 딕셔너리 실습하기 교재 p211
 *  - 키값(key - value) 쌍으로 이루어진 자료구조
 *  - HashTable을 일반화 시켜 더 나은 성능을 제공 
 *  - list와 더불어 가장 많이 사용하느 자료구조
 * 딕셔너리(Dictionary)
 */
namespace Ch07
{
    internal class _4_Dictionary
    {
        static void Main4(string[] args)
        {
            //둘다 공통적으로 인덱스 값이 없다

            ///////////////////////////
            ///HashTable
            ///////////////////////////
       
            //테이블 생성
            Hashtable table = new Hashtable();


            //데이터 추가
            table['A']="Apple"; // 키지정 밸류값 선언  // 인덱스 형식 
            table.Add('B',"Banana");
            table.Add('c',"Cherry");


            //데이터 삭제 

            table.Remove('c');

            //데이터 출력

            foreach (char k in table.Keys)
            {
                Console.WriteLine("table : "+table[k]);
            }
            Console.WriteLine();


            ///////////////////////////
            ///Dictionary
            ///////////////////////////

            //딕셔너리 생성

            Dictionary<char, string> dic = new Dictionary<char, string>(); // 치환변수 두개 

            dic['A'] = "Apple"; // 키지정 밸류값 선언  // 인덱스 형식 
            dic.Add('B', "Banana");
            dic.Add('c', "Cherry");



            //데이터 삭제 

            dic.Remove('b');

            //데이터 출력

            foreach (string fruit in dic.Values)
            {
                Console.WriteLine("fruit : " +fruit);
            }

            //딕셔너리 연습 

            Dictionary<int, string> people = new Dictionary<int, string>();

            people.Add(101, "김유신");
            people.Add(102, "김춘추");
            people.Add(103, "장보고");
            people.Add(104, "강감찬");
            people.Add(105, "이순신");

            foreach (int k in people.Keys)
            {
                Console.WriteLine($"key : {k},value : {people[k]}");
            }

            //딕셔너리 연습2 

            Dictionary<int,Apple> d1 = new Dictionary<int,Apple>(); // apple 참조 
            Dictionary<int,Apple> d2 = new Dictionary<int,Apple>();
            Dictionary<int,Apple> d3 = new Dictionary<int,Apple>();

            d1.Add(101, new Apple("한국",3000)); // d1 에 정보저장
            d1.Add(102, new Apple("미국",2000));
            d1.Add(103, new Apple("일본",1000));

            d2.Add(201, new Apple("중국", 3000));  // d2 에 정보저장
            d2.Add(202, new Apple("대만", 2000));
            d2.Add(203, new Apple("홍콩", 1000));     
            
            d3.Add(301, new Apple("호주", 3000));  // d3 에 정보저장
            d3.Add(302, new Apple("영국", 2000));
            d3.Add(303, new Apple("인도", 1000));

            List<Dictionary<int, Apple>> Apples = new List<Dictionary<int, Apple>>(); // 딕셔너리화 한 정보들을 또 한묶음으로 묶어주기

            Apples.Add(d1);
            Apples.Add(d2);
            Apples.Add(d3);

            //한국사과 출력

            Dictionary<int,Apple> dicApple = Apples[0];

            Apple apple = dicApple[101];

            apple.Show();

            //미국사과 

            Apples[0][102].Show();

            //대만사과

            Apples[1][202].Show();

            Apples[2][303].Show();

       


    




        }
    }
}
