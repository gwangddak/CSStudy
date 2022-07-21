using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 날짜 : 2022/07/14
 * 이름 : 조광현
 * 내용 : 메서드 타입 실습하기 교재 p265
 * 리턴값이 없으면 당연히 대입 할 이유가없다
 */
namespace Ch04
{
    internal class _2_메서드_형태
    {
        static void Main2(string[] args)
        {
            double y1 = Type1(0.12); // 인자값 0.12 전달
            double y2 = Type1(1.13);
            Console.WriteLine("y1: "+y1);
            Console.WriteLine("y1: "+y2);

            

            Type2(true);
            Type2(false);

            string rs1 = Type3();
            Console.WriteLine("Type3 result: " + rs1);

            Type4();


        }
        //Type1 : 매개변수o, 리턴값o
        public static double Type1(double x)
        {
            double y = x + Math.PI; // 3.14더함
            return y;
            
        }
        //Type2 : 매개변수o, 리턴값x
        public static void Type2(bool status)
        {
            if (status)
            {
                Console.WriteLine("참 입니다.");
            }
            else
            {
                Console.WriteLine("거짓 입니다.");
            }
        }
        //Type3 : 매개변수x, 리턴값o
        public static string Type3()
        {
            int n1 = 1;
            int n2 = 2;

            if (n1 != n2)
            {
                return "n1은 n2보다 크다";
            }
            else
            {
                return "n1은 n2보다 작다";

            }

        }
        //Type3 : 매개변수x, 리턴값x
        public static void Type4()
        {
            Console.WriteLine("type4 result : "+Type1(1.12));
       
        }

    }
}
