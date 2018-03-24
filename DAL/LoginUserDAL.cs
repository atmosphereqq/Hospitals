using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using Model;
namespace DAL
{
    public class LoginUserDAL
    {
        public Boolean Chcek( LoginUser u)      //用户名时候的sql语句
        {
            string query = "SELECT * FROM `auth_user` WHERE username = @username and password = @password";
            MySqlParameter[] commandParameter = new MySqlParameter[] {
                new MySqlParameter("@username",u.UserName),
                new MySqlParameter("@password",u.PassWord)
            };
            MySqlDataReader searchResult = MysqlHelper.ExecuteDefaultReader(query, commandParameter);
            if (searchResult.HasRows)
            {
                //如果存在结果说明该登录用户存在
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}
