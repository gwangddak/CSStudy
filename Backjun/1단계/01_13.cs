using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._1단계
{
    internal class _01_13
    {

        static void Main13(string[] args)
        {

            string a1 = Console.ReadLine();
            string a2 = Console.ReadLine();

            Console.WriteLine(int.Parse(a1)*(int)char.GetNumericValue(a2[2])); //겟누메릭벨류로 char형식으로 변환
            Console.WriteLine(int.Parse(a1)*(int)char.GetNumericValue(a2[1]));
            Console.WriteLine(int.Parse(a1)*(int)char.GetNumericValue(a2[0]));
            Console.WriteLine(int.Parse(a1)*int.Parse(a2));
               
          

         
       





        }








    }
}
