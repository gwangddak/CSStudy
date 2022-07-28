using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/07/27
 * 이름 : 조광현
 * 내용 : 데이터 베이스 Insert 프로그래밍 실습 
 */
namespace Ch10
{
    internal class _2_Insert_실습
    {
        static void Main2(string[] args)
        {
            //데이터베이스 접속 정보
            string server = "127.0.0.1";
            string port = "3306";
            string username = "root";
            string password = "1234";
            string database = "userdb";

            //데이터베이스 접속 컬렉션 
            string strConn = $"server = {server}; port = {port}; username = {username}; password = {password}; database = {database}";
            MySqlConnection conn = new MySqlConnection(strConn); // mysql 커넥션 
            //데이터베이스 접속 \
            try
            {
                conn.Open();
                Console.WriteLine("접속 성공...!");

                //sql 실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO `user1` VALUES ('c101', '김유신','010-1234-1001',27)"; // 텍스트 생성
                cmd.ExecuteNonQuery(); // 적은 텍스트 실행 
                Console.WriteLine("SQL 실행완료 ...!");
            }
            catch (Exception e)
            {
                Console.WriteLine("접속 실패 : " + e.Message);
                throw;
            }
            finally
            {
                //접속 종료
                conn.Close();
                Console.WriteLine("접속 성공...!");
            }

        }

    }
}
