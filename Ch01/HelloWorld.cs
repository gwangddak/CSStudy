using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 날짜 : 2022년 07월 12일 
// 이름 : 조광현
// 내용 : C# 개발환경 설정, HelloWorld 출력 교재 p44

namespace Ch01
{
    internal class HelloWorld
    {
        static void Main(string[] args) // svm 탭탭
        {
            Console.WriteLine("HelloWorld!");// cw 탭탭
            Console.WriteLine("Hello C#!");

            // 서식 출력
            Console.Write("hello\t"); // 문단 복사 ctrl D // \t tab
            Console.Write("korea\n"); // \n 개행
            //포맷출력
            Console.WriteLine("{1},{0}", "hello","busan"); //순서 정해서 출력
        }
    
    }
}
