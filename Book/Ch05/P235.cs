using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    class Student2
    {
        public string name = null;
        public int grade;
    }

    internal class P235
    {
       

        static void Main13(string[] args)
        {
            List<Student2> list2 = new List<Student2>();
            list2.Add(new Student2() { name = "윤인성", grade = 1 });
            list2.Add(new Student2() { name = "연하진", grade = 2 });
            list2.Add(new Student2() { name = "윤아린", grade = 3 });
            list2.Add(new Student2() { name = "윤명월", grade = 4 });
            list2.Add(new Student2() { name = "구지연", grade = 1 });
            list2.Add(new Student2() { name = "김연화", grade = 2 });


            //리스트의 요소를 제거 및 수정시에는 역반복문을 사용해야 정상적인 처리가 가능하다 

            for (int i = list2.Count-1; i >= 0; i--)
            {
                if (list2[i].grade > 1)
                {
                    list2.RemoveAt(i);
                }
            }

            //
            //foreach (var item in list2)
            //{
            //    if (item.grade > 1)
            //    {
            //        list2.Remove(item);
            //    }

            //}

            foreach (var item in list2)
            {
                Console.WriteLine(item.name + " : " + item.grade);

            }
        }

    }
}
