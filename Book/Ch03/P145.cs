using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class P145
    {
        static void Main9(string[] args)
        {
            //입력 받아 조건 분할
            Console.Write("입력 : ");
            string Line = Console.ReadLine();

            if (Line.Contains("안녕"))
            {
                Console.WriteLine("안녕하세요!");

            }
            else
            {
                Console.WriteLine("^^");
            }

        }
    }
}
