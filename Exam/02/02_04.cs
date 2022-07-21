using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._02
{
    internal class _02_04
    {
        static void Main4(string[] args)
        {
            int[] arr = { 4, 2, 1, 5, 3 };

            for (int i = 0; i < 4; i++)
            {
                for (int j = i+1; j < 5; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        //자리교환
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;

                    }
                }


            }
            foreach (var n in arr)
            {
                Console.WriteLine(n + " ");
            }
        }
    }
}
