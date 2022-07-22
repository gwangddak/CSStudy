using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._04
{
    //클래스 상속 문제 
    class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void Hello()
        {
            Console.WriteLine("이름 : "+name);
            Console.WriteLine("나이 : "+age);
        }
    }
    class Student : Person
    {
        private string school;
        private string major;

        public Student(string name, int age ,string school ,string major) :base (name,age) // 부모에 있는것을 BASE로 가져옴 
        {
            this.school = school;
            this.major = major;
        }
        public new void Hello() //부모에있는 Hello의 메서드가 가상화가 안되있는경우 new 사용 // 그냥 부모도 가상화 시켜주는게 좋음
        {
            base.Hello();
            Console.WriteLine("학교 : "+school);
            Console.WriteLine("전공 : "+major);
        }
    }
    class SalaryStudent : Student
    {
        private string company;

        //자식을 또다른 자식클래스를 생성하여 자식에 있는 값을 base로 가져온다.
        public SalaryStudent(string name, int age, string school, string major,string company) : base(name, age,school,major)
        {
            // 자식부모에 있는 base를 참조하였기에 더 필요한 company만 생성해준다.
            this.company = company;
            
        }
        public new void Hello()
        {
            base.Hello();
            Console.WriteLine("회사 : " + company);
         
        }
    }
    internal class _04_09
    {
        static void Main9(string[] args)
        {
            Person kim = new Person("김유신",24);
            Student jang = new Student("장보고", 26, "부경대", "영문학과");
            SalaryStudent lee = new SalaryStudent("이순신", 27, "부산대", "경제학과", "삼성전자");

            kim.Hello();
            Console.WriteLine("============================");
            jang.Hello();
            Console.WriteLine("============================");
            lee.Hello();
            Console.WriteLine("============================");


        }
    }
}
