using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/07/26
 * 이름 : 조광현
 * 내용 : 대리자 실습하기 교재 p493
 * 
 * 대리자(delegate)
 * - 대리자는 메서드에 대한 참조를 하기 위한 구문으,로 메서드를 대신 호출해주는 역활
 * - 대리자를 익명함수로 많이 사용 (최신 프로그래밍에서는 람다식으로 대체)
 * 
 */
namespace Ch09
{

    //대리자 선언

    public delegate int MyDelegate(int x, int y); // 대리자
    public delegate int SumDelegate(int[] arr);   // Odd Even 호출자

    internal class _1_대리자 // delegate
    {
        static void Main1(string[] args)
        {
            //대리자 초기화 
            MyDelegate my1 = new MyDelegate(Plus);
            MyDelegate my2 = new MyDelegate(Minus);

            int r1 = my1(1, 2);
            int r2 = my2(1, 2);

            Console.WriteLine("delegate1 : "+ r1);
            Console.WriteLine("delegate2 : "+ r2);

            //대리자 활용 : 메서드의 매개변수로 대리자 선언

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int rs1 = Sum(arr,OddSum);
            int rs2 = Sum(arr,EvenSum);

            Console.WriteLine("홀수합 : "+ rs1);
            Console.WriteLine("짝수합 : "+ rs2);

            //대리자 활용 : 익명 메서드로 활용될 수 있음 // 앞으로는 많이 활용될거임

            var function = delegate (int x, int y) // 변수에 담아서 쓰는 함수 // 메서드가 아닌 함수로 기억 // 람다식은 delegate 빠짐 
            {
                return x + y;
            };

            int res1 = function(1, 2);
            int res2 = function(1, 2);

            Console.WriteLine("res1 : "+res1);
            Console.WriteLine("res2 : "+res2);

            //익명함수를 매개변수로 갖는  컬렉션 메서드  // 컬렉션은 전용기능이 있음

            List<int> myList = new List<int>() {1,2,3,4,5,6,7,8,9,10};

            myList.ForEach((int n) => // 람다식 선언법 // 전용 반복문이 존재함
            {
                Console.WriteLine(n+" ");
            });
            Console.WriteLine();

            foreach (int a in myList) // 기존 일반 반복문도 사용가능
            {
                Console.WriteLine(a+" ");
            }
            Console.WriteLine();
        } //main end
        public static int Plus(int x, int y)
        {
            return x + y;   
        }
        public static int Minus(int x, int y)
        {
            return x - y;
        }

        /// <summary>
        /// 홀짝 구하기 
        /// </summary>
        /// <paramname="arr"></param>
        /// <returns></returns>
        public static int OddSum(int[] arr) // 홀수합
        {
            int sum = 0;
            foreach (int n in arr)
            {
                if (n % 2 == 1)
                {
                    sum += n;
                }
            }
            return sum;
        }
        public static int EvenSum(int[] arr) // 짝수합
        {
            int sum = 0;
            foreach (int   n in arr)
            {
                if (n % 2 == 0)
                {
                    sum += n;
                }
            }
            return sum;
        }

        public static int Sum(int[] arr, SumDelegate sd)
        {
            return sd(arr);
        }
    }
}
