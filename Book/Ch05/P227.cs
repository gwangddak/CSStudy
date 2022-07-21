using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Book.Ch05
{
    internal class P227
    {
        //인스턴스 변수를 생성과 동시에 초기화
        class Product
        {
            public string Name;
            public int price;
        }
        static void Main9(string[] args)
        {
            Product productA = new Product()
            {
                Name = "감자",
                price = 2000
            };
            Product productB = new Product()
            {
                Name = "고구마",
                price = 3000
            };

        }

    }
}
