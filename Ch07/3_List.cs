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
 * 내용 : 컬렉션 리스트 실습하기 교재 p211
 * 
 * 리스트(list)\
 * 
 * - 배열과 유사한 선형자료구조로 배열과 다르게 동적으로 데이터를 처리
 * - ArrayList보다 더나은 성능을 일반화 시킨 List를 사용
 */

namespace Ch07
{
    internal class _3_List
    {
        static void Main3(string[] args)
        {

            //////////////////////////////////////
            ///arrayList
            ArrayList list1 = new ArrayList();

            //데이터 추가
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);
            
            //데이터 삽입 
            list1.Insert(1, 6); //두번째 칸에 6을 삽입

            //데이터 삭제 
            list1.Remove(6); // 숫자 6을 삭제시킨다.
            list1.RemoveAt(0); //인덱스 0 을 삭제시킨다

            //데이터 출력

            foreach (int n in list1)
            {
                Console.Write(n+" ");
            }
            Console.WriteLine();

            ArrayList arrList2 = new ArrayList();
            arrList2.Add(1);
            arrList2.Add(1.23);
            arrList2.Add(true);
            arrList2.Add("A");
            arrList2.Add("Apple");

            for (int i = 0; i < arrList2.Count; i++)
            {
                Console.WriteLine(arrList2[i]+" ");
            }
      
            //////////////////////////////////////
            ///List
            //////////////////////////////////////
            ///
            List<int> list2 = new List<int>();

            //데이터 추가
            list2.Add(1);
            list2.Add(2);
            list2.Add(3);
            list2.Add(4);
            list2.Add(5);
            list2.Add(6);

            list2.Insert(1, 6); //두번째 칸에 6을 삽입
            list2.Remove(4); // 숫자 6을 삭제 시킨다.
            list2.RemoveAt(0); // 인덱스 0을 삭제시킨다


            foreach (int n in list2)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            List<string> list3 = new List<string>();

            list3.Add("서울");
            list3.Add("대전");
            list3.Add("대구");
            list3.Add("부산");
            list3.Add("울산");
            list3.Add("광주");

            foreach  (string city in list3)
            {
                Console.WriteLine(list3+"");
            }

            //객체 리스트 

            List<Apple> list4 = new List<Apple>(); // 사과객체 불러옴 

            list4.Add(new Apple("한국", 3000));
            list4.Add(new Apple("미국", 2000));
            list4.Add(new Apple("일본", 1000));

            Apple apple = list4[0];

            apple.Show();

            list4[1].Show();
            list4[2].Show();



        }
    }
}
