using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class P140
    {
        static void Main7(string[] args)
        {
            //break 키워드를 사용하지 않는 switch 조건문 
            Console.WriteLine("이번 달은 몇 월 인가요? : ");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 12:
                case 1:  
                case 2:
                    Console.WriteLine("겨울 입니다.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄 입니다.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름 입니다.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을 입니다.");
                    break;
                default:
                    Console.WriteLine("대체 어떤 행성에서 살고있노?");
                    break;
         

            }
        }
    }
}
