using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P106
    {
        static void Main35(string[] args)
        {
            //자료형 변환 

            //long 자료형을 int형으로 변환 

            long longNumber = 2147483647L + 2147483647L;
            int intNumber1 = (int)longNumber; // 가능 //강제 형변환 // 하지만 값이 이상한값이 나옴
            Console.WriteLine("intNumber : "+intNumber1); // 

            //강제 형변환 
            var a = (int)10.0;
            var b = (float)10;
            var c = (double)10;

            //강제 형변환의 데이터 손실이 미발생
            long longNumber2 = 52273; 
            int intNumber3 = (int)longNumber2; // 가능 //강제 형변환 // 하지만 값이 이상한값이 나옴
            Console.WriteLine("intNumber : " + intNumber3); // 

            //강제 형변환의 숫자손상

            long longNumber4 = 2147483647L + 2147483647L;
            int intNumber5 = (int)longNumber4; // 가능 //강제 형변환 // 하지만 숫자의 손상이 일어남 
            Console.WriteLine(intNumber5); 




        }
    }
}
