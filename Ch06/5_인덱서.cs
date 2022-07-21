﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
*날짜 : 2022 / 07 / 21
* 이름 : 조광현
* 내용 : 인덱서 실습하기 교재 p395
* 
* 인덱서 
* - 객체를 배열처럼 인덱스를 활용해서 객체의 속성을 참조 할 수 있게 해주는 속성
* - 인덱서를 메서드로 대체 가능 
*/
namespace Ch06
{
    class MyArray
    {
        private int[] array; // 배열생성

        public MyArray() // 생성자에서 배열크기 지정
        {
            array = new int[3];
        }
        //인덱서
        public int this[int i]
        {
            get { return array[i]; }
            set 
            {
                if (i < array.Length)
                {
                    array[i] = value;

                }
                else
                {
                    Console.WriteLine("더이상 데이터를 저장할 수 없습니다.");

                }
            }
        }
    }

    internal class _5_인덱서
    {
        static void Main5(string[] args)
        {

            MyArray mArr = new MyArray();
            mArr[0] = 100; //인덱서를 호출하고있다 //세터에 밸류값 넣음
            mArr[1] = 200;
            mArr[2] = 300;
            mArr[3] = 400;

            for (int i = 0; i < 3 ; i++)
            {
                Console.WriteLine(mArr[i]);
            }

        }
    }
}
