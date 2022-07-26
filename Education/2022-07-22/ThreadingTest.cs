using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education._2022_07_22
{
    class Test
    {
        public int Num { get; private set; }
        object lockObj = new object();

        public void Increment()
        {
            Monitor.Enter(lockObj);
            try
            {
                //공유자원 사용
                this.Num++;
            }
            finally
            {
                Monitor.Exit(lockObj);
              
            }
        }
    }




}
