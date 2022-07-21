using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._03
{

    class king
    {
        private string name;
        private int year;
        public king(int year)
        {
            this.year = year;
        }
        public king(string name, int year)
        {
            this.name = name;
            this.year = year;
        }   
        public king(string name)
        {
            this.name = name;

        }
        public void Show()
        {
            Console.WriteLine("===================");
            Console.WriteLine("name : "+name);
            Console.WriteLine("name : "+year);
            Console.WriteLine("===================");
        }


    }
    internal class _03_02
    {
        static void Main2(string[] args)
        { 


            king k1 = new king("태조", 1392);
            king k2 = new king("세종");
            king k3 = new king(1776);

            k1.Show();
            k2.Show();
            k3.Show();


        }
    }
}
