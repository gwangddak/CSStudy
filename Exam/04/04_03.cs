using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._04
{
    class Employee
    {
        public string name { get; set; } = "홍길동";
        public string position { get; set; } = "사원";

        public void Show()
        {
            Console.WriteLine("======================");
            Console.WriteLine("이름 : "+name);
            Console.WriteLine("직급 : "+position);
            Console.WriteLine("======================");
        }
    }
    internal class _04_03
    {

        static void Main3(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Show();

            Employee emp2 = new Employee();
            emp2.name = "김유신";
            emp2.position = "대리";

            emp2.Show();
            Employee emp3 = new Employee() { name = "김춘추", position = "과장" };
            emp3.Show();



        }
    }
}
