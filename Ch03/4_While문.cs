using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
 * 날짜 : 2022/07/13
 * 이름 : 조광현     
 * 내용 : 반복문 while 실습하기 교재 p162
 */
namespace Ch03
{
    internal class _4_While문
    {
        static void Main4(string[] args)
        {
            //1부터 10까지 합
            int sum = 0;
            int k = 1;

            while (k <= 10)
            {
                sum += k;
                k++; // k값 증가 
            }
            Console.WriteLine("1부터 10까지의 합 : "+sum);

            //do ~ while 최초 한번 반복을 수행하는 반복문 
            int total = 0;
            int total2 = 0;
            int i = 1;

            do
            {
                if (i % 2 == 0)
                {
                    total += i;
              

                }
                else if(i % 2 == 1)
                {
                    total2 += i;
                }
                i++;

            } while (i <= 10);

            Console.WriteLine("1부터 10까지의 짝수 합 : " + total);
            Console.WriteLine("1부터 10까지의 짝수 합 : " + total2);

            //break

            int num = 1;

            while (true)
            {
                if (num % 5 == 0 && num % 7 == 0)
                {
                    break; // 반복문 탈출 
                }
                num++;

            }

            Console.WriteLine("5와 7의 최소 공배수 : "+num);
            //continue

            int tot = 0;
            int tot2 = 0;
            int n = 0;

            while (n<=10)
            {
                n++;
                if (n % 2 == 1)
                {   
                    //홀수이면 
                    continue; // 반복문의 처음으로 이동 
                }
                //짝수이면
                tot += n;
            }
            Console.WriteLine("1부터 10까지 짝수합 : " +tot);


        }
    }
}
