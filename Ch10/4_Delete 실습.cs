using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10
{
    internal class _4_Select_실습
    {
        static void Main4(string[] args)
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
                cmd.CommandText = "DELETE  FROM `user1` WHERE `uid` = 'c101'"; // 텍스트 생성
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
