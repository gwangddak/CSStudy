using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class P214
    {
        static void Main6(string[] args)
        {

            //리스트 요소 제거 
            List<int> list = new List<int>()
            {
                52,273,32,64
            };

            list.Remove(52); // 소멸자 

            foreach(var item in list)
            {
                Console.WriteLine("count : "+list.Count + "\nlist : "+item);

            }
        }
    }
}
