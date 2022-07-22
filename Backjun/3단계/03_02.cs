using System;
using System.Text;


namespace Backjun._3단계
{
    internal class _03_02
    {
        static void Main2(string[] args)
        {
            int f = int.Parse(Console.ReadLine());

            StringBuilder first = new StringBuilder(); // 문자열 통합관리 // 문자열에 대한 데이터 저장값을 통합으로 진행시킨다

            for (int i = 0; i < f; i++)
            {
                string[] arg = Console.ReadLine().Split();
                first.Append(int.Parse(arg[0]) + int.Parse(arg[1]) + "\n");


            }
            Console.WriteLine(first.ToString());

        }
    }
}
