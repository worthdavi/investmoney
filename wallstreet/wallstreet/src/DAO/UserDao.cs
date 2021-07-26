﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wallstreet.src.DAO
{
    class UserDao
    {


        public int Register(String nome, String email, String password, int tipo, int balance)
        {
            User UserToSave = new User();
            UserToSave.Username = nome;
            UserToSave.Email = email;
            UserToSave.Password = password;
            UserToSave.Type = Convert.ToInt32(tipo);
            UserToSave.Balance = Convert.ToInt32(balance);
            return SQLiteControl.SaveUser(UserToSave);
        }

        public static List<User> GetUserList()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<User>("select * from user", new DynamicParameters());
                return output.ToList();
            }
        }
        public static bool IsEmailRepeated(string email)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "select `id` from `user` where `user`.`email` = '" + email + "'";
                var id = Convert.ToInt32(connection.ExecuteScalar(query));
                if (id != 0)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsUsernameRepeated(string name)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "select `id` from `user` where `user`.`username` = '" + name + "'";
                var id = Convert.ToInt32(connection.ExecuteScalar(query));
                if (id != 0)
                {
                    return true;
                }
            }
            return false;
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}