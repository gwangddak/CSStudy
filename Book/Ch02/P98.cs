using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P98
    {
        static void Main31(string[] args)
        {
            //GetType() 매서드 활용 
            int _int = 273;
            long _long = 522731033265;
            float _float = 52.273f;
            double _double = 52.273;
            char _char = '글';
            string _string = "문자열";

            Console.WriteLine(_int.GetType());
            Console.WriteLine(_long.GetType());
            Console.WriteLine(_float.GetType());
            Console.WriteLine(_double.GetType());
            Console.WriteLine(_char.GetType());
            Console.WriteLine(_string.GetType());

            //직접적인 GetType() 매서드 활용 

            Console.WriteLine(273.GetType());
            Console.WriteLine(522731033265.GetType());
            Console.WriteLine(52.273f.GetType());
            Console.WriteLine(52.273.GetType());
            Console.WriteLine(('자').GetType());
            Console.WriteLine(("문자열").GetType());



        }
    }
}
