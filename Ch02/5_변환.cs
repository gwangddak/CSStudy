using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/13 
 * 이름 : 조광현
 * 내용 : 테이터 형식 변환 실습하기 교재 P106
 */
namespace Ch02
{
    internal class _5_변환
    {
        static void Main5(string[] args)
        {
            //작은변수에서 큰 변수 

            byte num1 = 255; // 1바이트
            short num2 = num1; // 2바이트 
            int num3 = num2; // 4바이트 

            Console.WriteLine("num1 : {0}", num1);
            Console.WriteLine("num2 : {0}", num2);
            Console.WriteLine("num3 : {0}", num3);


            int var1 = 256;
            short var2 = (short)var1;  // casting 
            byte var3 = (byte)var2;  // casting // 하지만 바이트의 최대크기를 넘어가서 0으로 초기화됨

            Console.WriteLine("var1 : {0}",var1);
            Console.WriteLine("var2 : {0}",var2);
            Console.WriteLine("var3 : {0}",var3);

            //정수에서 실수 
            int a = 1;
            int b = 2;  
            int c = 3;

            double d1 = a;
            double d2 = b;
            double d3 = c;

            Console.WriteLine("d1 : {0}" ,d1);
            Console.WriteLine("d2 : {0}" ,d2);
            Console.WriteLine("d3 : {0}" ,d3);

            //실수에서 정수 // 실수에서 정수로 강제 캐스팅시 실수의 끝자리는 탈락한다.

            double n1 = 1.2;
            double n2 = 2.14;
            double n3 = 12.123;

            int r1 = (int)n1;
            int r2 = (int)n2;
            int r3 = (int)n3;

            Console.WriteLine("r1 : {0}", r1);
            Console.WriteLine("r2 : {0}", r2);
            Console.WriteLine("r3 : {0}", r3);


        }
    }
}
