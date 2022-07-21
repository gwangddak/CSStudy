using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/12
 * 이름 : 조광현
 * 내용 : 변수 실습하기 교재 p79
 * 파일이 hdd로 저장되고 ram에서 할당 처리하고 연산은 cpu에서 처리 처리된 기록은 다시 ram으로
 * 영구 기록시에는 하드디스크에 파일로 다시 저장하면된다.
 * 
 * 변수(Variable)
 *  - 데이터를 처리하기 위한 데이터 그릇
 *  - 변수는 메모리상에 생성되는 공간
 *  
 *  
 * 상수(Constant)
 *  - 데이터를 변경할 수 없는 변수
 *  - 최초 저장 (초기화)된 데이터를 고정
 */
namespace Ch02
{
    internal class _1_변수
    {
        static void Main1(string[] args)
        {
            //변수 

            int num1; // 선언 
            num1 = 1; // 변수에 값 할당

            int num2 = 2; //선언과 초기화

            int num3 = num1 + num2; // 데이터 처리 (연산)

            //결과 확인
            Console.WriteLine("num1 : "+num1);
            Console.WriteLine("num2 : "+num2);
            Console.WriteLine("num3 : "+num3);
            //////////////////////////////////
            ///상수
            ///상수는 값이 변하지 않도록 고정시킨다
            //////////////////////////////////
            const double PI = 3.14;
            const int NUM = 10; // 상수의 변수명은 대문자로 통일한다.
            //NUM = 20 <- 상수는 값변경 X 
            //PI = 5.36 <- 상수는 값변경 X 

            Console.WriteLine("PI : "+PI);
            Console.WriteLine("NUM : "+ NUM);

        }
    }
}
