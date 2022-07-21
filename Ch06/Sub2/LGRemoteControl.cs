using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    internal class LGRemoteControl : IRemoteControl // 상속이 아닌 구현이라 칭한다.
    {
        public void ChDown()
        {
            Console.WriteLine("LG Ch Down...");
        }

        public void ChUp()
        {
            Console.WriteLine("LG Ch Up...");

        }

        public void PowerOff()
        {
            Console.WriteLine("LG Power Off...");

        }

        public void PowerOn()
        {
            Console.WriteLine("LG Power On...");

        }

        public void SoundDown()
        {
            Console.WriteLine("LG Sound Down...");

        }

        public void SoundUp()
        {
            Console.WriteLine("LG Sound Up...");

        }
    }
}
