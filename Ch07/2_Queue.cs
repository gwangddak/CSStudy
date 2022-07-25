using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 날짜 : 2022/07/25
 * 이름 : 조광현
 * 내용 : 컬렉션 큐 실습하기
 * 
 * 큐(Queue)
 * - 가장 기본적인 자료구조
 * - 먼저 입력된 데이터가 먼저 출력되는 선형 (FIFO : 선입선출)
 * - 다양한 알고리즘 및 함수 호출에 사용
 * 
 */
namespace Ch07
{
    internal class _2_Queue
    {
        static void Main2(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("김유신");
            queue.Enqueue("김춘추");
            queue.Enqueue("장보고");
            queue.Enqueue("강감찬");

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }

        }
    }
}
