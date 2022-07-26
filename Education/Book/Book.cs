using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Book
{
    class Book
    {
        private int num;
        private string title;

        public Book(int num, string title)
        {
            this.num = num;
            this.title = title;
        }

        public int Num { get => num; set => num = value; }
        public string Title { get => title; set => title = value; }
    }

}
