using Ch08.Sub1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/26
 * 이름 : 조광현
 * 내용 : 예외처리 실습하기 교재 
 * 
 * 예외처리 (Exception)
 * - 프로그램 실행중에 발생하는  모든 오류(Error) 를 예외(Exception) 라고 한다.
 * - 실행중에 발생하는 오류를 대처하고 견고하고 안정적인 프로그램 개발을 위해 예외 처리 수행
 * 
 * 
 * 
 */
namespace Ch08
{
    internal class _1_예외처리
    {

        static void Main1(string[] args)
        {
            /////////////////////////////////
            ///try-catch
            ///////////////////////////////// 


            //예외 발생상황
            //상황 1: 어떤수를 0으로 나눌때 에러가 난다.
            //에러가 발생할것을 대비해야한다.
            int num1 = 1;
            int num2 = 0;

            int r1 = 0;
            int r2 = 0;
            int r3 = 0;
            int r4 = 0;


            try // 코드리펙터링 // 후처리 과정이다 // 가독성은 좀 떨어진다. // try걸때는 좀 러프하게 걸어준다.
            {
                //예외가 발생할 수있는 코드 ㄷ작성
                r1 = num1 + num2;
                r2 = num1 * num2;
                r3 = num1 - num2;
                r4 = num1 / num2;
               
            }
            catch (Exception e)
            {
                //예외가 발생했을때 처리할 코드작성
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("r1 : "+r1);
            Console.WriteLine("r2 : "+r2);
            Console.WriteLine("r3 : "+r3);
            Console.WriteLine("r4 : "+r4);


            //상황 2 : 배열의 인덱스 범위를 벗어났을때

            int[] arr = { 1, 2, 3, 4, 5 };

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(arr[i] + " ");
                }
            }
            catch (Exception e) // e = error
            {
                Console.WriteLine(e.Message);

            }

            //상황 3 : NULL 포인트 에러 

            Apple a1 = new Apple("한국", 3000);
            Apple a2 = null; // 

            try
            {
                a1.Show();
                a2.Show();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

            /////////////////////////////////
            ///try-catch-finally
            /////////////////////////////////

            try
            {
                //예외가 발생할 가능성이 있는 코드작성
                Console.WriteLine("try...?");
            }
            catch (Exception e)
            {
                //예외가 발생했을 때 처리할 코드 작성
                Console.WriteLine("catch...?");

            }
            finally
            {
                //예외 발생 여부와 상관없이 무조건 처리되는 코드, 작성

                Console.WriteLine("finally...?");
            }
            Console.WriteLine("프로그램 종료...");

        }
    }
}
