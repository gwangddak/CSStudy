using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/07/26
 * 이름 : 조광현
 * 내용 : 파일 입출력 실습하기
 * 
 * 파일 입출력 (I/O)
 * - 파일은 컴퓨터 저장매체( HDD)에 저장되는 데이터 묶음 
 * -  프로그램은 데이터 처리(Process)와 더불어 처리 결과를 저장하기 위해 파일 입출력 수행
 */
namespace Ch08
{
    internal class _3_파일_입출력
    {
        static void Main(string[] args)
        {
            ///////////////////////
            ///파일 읽기(Read)
            ///////////////////////
            FileStream fs = null;
            StreamReader sr = null;
            string path1 = "C:\\Users\\502\\Desktop\\Sample1.txt";
            try
            {
                //파일 스트림 생성 // 초기 연결
                fs = new FileStream(path1, FileMode.Open, FileAccess.Read); // 스트림 연결을 진행한것이다.

                //텍스트 파일 전용 보조 스트림 연결 // 버퍼 연결
                sr = new StreamReader(fs);

                //파일 읽기 

                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
            finally
            {
                //스트림 해제 (파일닫기)
                sr.Close();
                fs.Close();
            }






            ///////////////////////
            ///파일 쓰기(Write)
            ///////////////////////

            string path2 = "C:\\Users\\502\\Desktop\\Sample2.txt";
            FileStream fs2 = null;  // 파일 스트림 생성 // 초기  
            StreamWriter sw = null; // 파일 쓰기 전용

            try
            {
                fs2 = new FileStream(path2, FileMode.OpenOrCreate,FileAccess.Write); // 파일을 오픈하거나 만든다 // 파일엑세스를 하여 적는다.
                sw = new StreamWriter(fs2); // 스트림 라이터 fs2 참조

                sw.WriteLine("welcome World!");
                sw.WriteLine("welcome Korea!");
                sw.WriteLine("welcome Busan!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
              
            }
            finally
            {
                sw.Close();
                fs2.Close();

            }



            ///////////////////////
            ///파일 읽기/쓰기(Read Write)
            ///////////////////////

            string file1 = "C:\\Users\\502\\Desktop\\Sample1.txt";
            string file2 = "C:\\Users\\502\\Desktop\\Sample2.txt";



            try
            {
                //엑세스는 //FileStream 안해도됨 // 파일 읽기 쓰기는 자동으로 finally 처리가 된다. 그래서 안적어도 됨
                using StreamReader Reader = new StreamReader(new FileStream(file1, FileMode.Open));
                using StreamWriter Writer = new StreamWriter(new FileStream(file2, FileMode.Open));

                string txt;

                while ((txt = Reader.ReadLine()) !=null)
                {
                    Writer.WriteLine(txt);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
            Console.WriteLine("프로그램 종료 ...");




        }
    }
}
