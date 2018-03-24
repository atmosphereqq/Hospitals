using System;
using System.Data;
using System.Collections;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DAL
{
    class MysqlHelper
    {
        //数据库连接字符串
        //public static string connectionString = "Database='hospitals';Data Source='localhost';User Id='root';Password='java@163';charset='utf8';pooling=true";
        //public static string connectionString = "Database='hospitals';Data Source='localhost';User Id='root';Password='java@163';charset='utf8';pooling=true";
        public static string connectionString = "Host=localhost;Database=hospitals;Username=root;Password=java@163";


        private static void PrepareCommand(MySqlCommand cmd, MySqlConnection conn, MySqlTransaction trans, CommandType cmdType, string cmdText, MySqlParameter[] cmdParms)
        {

            //判断数据库连接状态
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            //判断是否需要事物处理
            if (trans != null)
            {
                cmd.Transaction = trans;
            }

            cmd.CommandType = cmdType;
            if (cmdParms != null)
            {
                foreach (MySqlParameter parm in cmdParms)
                    cmd.Parameters.Add(parm);
            }
        }

        /// 增删改语句返回受影响的行数
        public static int ExecuteNonQuery(MySqlConnection connection, CommandType cmdType, string cmdText, params MySqlParameter[] commandParameters)
        {
            MySqlCommand cmd = new MySqlCommand();
            PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
            int val = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            return val;
        }

        public static int ExecuteDefaultNonQuery(string querySql, params MySqlParameter[] commandParameters)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            return ExecuteNonQuery(conn, CommandType.Text, querySql, commandParameters);
        }

        ///使用现有的SQL事务执行一个sql命令（不返回数据集）
        public static int ExecuteNonQuery(MySqlTransaction trans, CommandType cmdType, string cmdText, params MySqlParameter[] commandParameters)
        {
            MySqlCommand cmd = new MySqlCommand();
            PrepareCommand(cmd, trans.Connection, trans, cmdType, cmdText, commandParameters);
            int val = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            return val;
        }


        /// 用执行的数据库连接执行一个返回数据集的sql命令
        public static MySqlDataReader ExecuteReader(string connectionString, CommandType cmdType, string cmdText, params MySqlParameter[] commandParameters)
        {
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                MySqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();
                return reader;
            }
            catch
            {
                //关闭连接，抛出异常
                conn.Close();
                throw;
            }
        }

        public static MySqlDataAdapter ExecuteDefaultAdapter(string querySql, params MySqlParameter[] commandParameters) {
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
               // PrepareCommand(cmd, trans.Connection, trans, cmdType, cmdText, commandParameters);
                DataSet ds = new DataSet();
                string sql = "select * from list_class1_submit";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(ds, "table");
                return da;
                //dataGridView1.DataSource = ds.Tables["table"];
            }
            catch
            {
                //关闭连接，抛出异常
                conn.Close();
                throw;
            }
        }
        
        public static MySqlDataReader ExecuteDefaultReader(string querySql, params MySqlParameter[] commandParameters)
        {
            return ExecuteReader(connectionString, CommandType.Text, querySql, commandParameters);
        }

        
        /// 返回第一行第一列的结果
        public static object ExecuteScalar(string connectionString, CommandType cmdType, string cmdText, params MySqlParameter[] commandParameters)
        {
            MySqlCommand cmd = new MySqlCommand();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
                object val = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                return val;
            }
        }

        public static object ExecuteDefaultScalar(string querySql, params MySqlParameter[] commandParameter)
        {
            return ExecuteScalar(connectionString, CommandType.Text, querySql, commandParameter);
        }

        /// 用指定的数据库连接执行一个命令并返回一个数据集的第一列
        public static object ExecuteScalar(MySqlConnection connection, CommandType cmdType, string cmdText, params MySqlParameter[] commandParameters)
        {

            MySqlCommand cmd = new MySqlCommand();
            PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
            object val = cmd.ExecuteScalar();
            cmd.Parameters.Clear();
            return val;
        }


    }
}
