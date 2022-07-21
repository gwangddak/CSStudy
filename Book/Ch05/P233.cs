using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    class Student1
    {
        public string name;
        public int grade;

    }
    internal class P233
    {
        static void Main12(string[] args)
        {
            List<Student1> list = new List<Student1>();   

            list.Add(new Student1() { name = "윤인성" , grade = 1});
            list.Add(new Student1() { name = "연하진" , grade = 2});
            list.Add(new Student1() { name = "윤아린" , grade = 3});
            list.Add(new Student1() { name = "윤명월" , grade = 4});
            list.Add(new Student1() { name = "구지연" , grade = 1});
            list.Add(new Student1() { name = "김연화", grade = 2 });

            foreach (var item in list)
            {
                Console.WriteLine(item.name + " : "+item.grade);
            }
      
        }

    }
}
