﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class DBAccess
    {
        private string server = "127.0.0.1";
        private string port = "3306";
        private string username = "root";
        private string password = "1234";
        private string database = "num2db";
        private string table = "user3";

        //싱글톤 
       private static DBAccess instance = new DBAccess();
        public static DBAccess Instance { get { return instance; } }
        private DBAccess() { }

        private MySqlConnection connect() //커넥션 리턴
        {
            string strConn = $"server = {server};port={port};username = {username};password={password};database={database}";
            MySqlConnection conn = new MySqlConnection(strConn);
            return conn;
        }
        public void InsertUser(string uid,string name, string hp , string age)
        {
            MySqlConnection conn = connect();
            try
            {
                //DB 접속
                conn.Open();

                //SQL 실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"INSERT INTO {table} VALUES('{uid}','{name}','{hp}''{age}')";
                cmd.ExecuteNonQuery();
                //결과 처리

            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }
            finally
            {
                //DB 종료 \
                conn.Close();
            }
        }
        public void SelectUser() { }
        public List<User> SelectUsers()
        {    //그리드뷰 데이터 공급을 위한 리스트
            List<User> userList = new List<User>();

            //DB 정보
            MySqlConnection conn = connect();
            try
            {
                //DB 접속
                conn.Open();

                //SQL 실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM {table}";
                MySqlDataReader reader = cmd.ExecuteReader();
                //결과 처리
                while (reader.Read())
                {
                    User user = new User();
                    user.Uid = reader[0].ToString();
                    user.Name = reader[1].ToString();
                    user.Hp = reader[2].ToString();
                    user.Age = int.Parse(reader[3].ToString());

                    userList.Add(user);
                }
            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }
            finally
            {
                //DB 종료 \
                conn.Close();
            }
            return userList; 
            //데이터그리드뷰 데이터 공급 
           
        }
        public void UpdateUser(string uid ,string name, string hp, string age)
        {
        

            //DB 정보
            MySqlConnection conn = connect();
            try
            {
                //DB 접속
                conn.Open();

                //SQL 실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"UPDATE {table} SET `name`='{name}', `hp`= '{hp}' , `age`='{age}',WHERE `uid` ='{uid}' ";
                cmd.ExecuteNonQuery();
                //결과 처리
       

            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }
            finally
            {
                //DB 종료 \
                conn.Close();
            }
            //데이터그리드뷰 데이터 공급 
           
     
        }
        public void DeleteUser(string uid) {
            MySqlConnection conn = connect();
            try
            {
                //DB 접속
                conn.Open();

                //SQL 실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"DELETE FROM {table} WHERE `uid` ='{uid}' ";
                cmd.ExecuteNonQuery();
                //결과 처리


            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }
            finally
            {
                //DB 종료 \
                conn.Close();
            }
            //데이터그리드뷰 데이터 공급 


        }



    }
}
