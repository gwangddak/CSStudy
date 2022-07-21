using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    internal class SamSungRemoteControl : IRemoteControl
    {
        public void ChDown()
        {
            Console.WriteLine("SamSung Ch Down...");
        }

        public void ChUp()
        {
            Console.WriteLine("SamSung Ch Up...");

        }

        public void PowerOff()
        {
            Console.WriteLine("SamSung Power Off...");

        }

        public void PowerOn()
        {
            Console.WriteLine("SamSung Power On...");

        }

        public void SoundDown()
        {
            Console.WriteLine("SamSung Sound Down...");

        }

        public void SoundUp()
        {
            Console.WriteLine("SamSung Sound Up...");

        }

    }
}
