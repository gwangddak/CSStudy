using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    internal class Tv : Internet, Computer // C#은 다중상속이 안되서 하나는 상속 하나는 인터페이스화
    {
        public void PowerOn()
        {
            Console.WriteLine("TV Power On....");

        }
        public void AccessInternet()
        {
            base.Access();
   
        }

        public void Booting()
        {
            Console.WriteLine("TV Booting....");

        }
    }
}
