using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace DbUtil {
    //数据库操作工具类
    public class DbUtil {
        static String connectionString = "server=localhost;port=3306;database=test;user=root;password=root";
        /// <summary>
        /// 不带参数的增删改
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>修改条数</returns>
        public static int? ExecuteNonQuery(String sql) {
            using(MySqlConnection mySqlConnection = new MySqlConnection(connectionString)) {
                try {
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand(sql,mySqlConnection);
                    int i = mySqlCommand.ExecuteNonQuery();
                    return i;
                    }
                catch(Exception e) {
                    Console.WriteLine(e.Message);
                    }
                return null;
                }
            }
        /// <summary>
        /// 带参数的增删改
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="strings">参数数组</param>
        /// <returns>修改条数</returns>
        public static int? ExecuteNonQuery(string sql,params MySqlParameter[] strings) {
            using(MySqlConnection mySqlConnection = new MySqlConnection(connectionString)) {
                try {
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand(sql,mySqlConnection);
                    mySqlCommand.Parameters.AddRange(strings);
                    int? i = mySqlCommand.ExecuteNonQuery();
                    return i;
                    }
                catch(Exception e) {
                    Console.WriteLine(e.Message);
                    }
                return null;
                }
            }
        /// <summary>
        /// 查询数据个数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int? ExecuteScalar(string sql) {
            using(MySqlConnection mySqlConnection = new MySqlConnection(connectionString)) {
                try {
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand(sql,mySqlConnection);
                    int i = Convert.ToInt32(mySqlCommand.ExecuteScalar());
                    return i;
                    }
                catch(Exception e) {
                    Console.WriteLine("错误,{0}",e.Message);
                    }
                return null;
                }
            }
        /// <summary>
        /// 带参数查询数据个数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static int? ExecuteScalar(String sql,params MySqlParameter[] parameters) {
            using(MySqlConnection mySqlConnection = new MySqlConnection(connectionString)) {
                try {
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand(sql,mySqlConnection);
                    mySqlCommand.Parameters.AddRange(parameters);
                    return Convert.ToInt32(mySqlCommand.ExecuteScalar());
                    }
                catch(Exception e) {
                    Console.WriteLine(e.Message);
                    }
                return null;
                }
            }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>MysqlDataReader</returns>
        public static MySqlDataReader ExecuteReader(string sql) {
            using(MySqlConnection mySqlConnection = new MySqlConnection(connectionString)) {
                try {
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand(sql);
                    return (mySqlCommand.ExecuteReader());
                    }
                catch(Exception e) {
                    Console.WriteLine(e.Message);
                    }
                }
            return null;
            }
        /// <summary>
        /// 带参数查询
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static MySqlDataReader ExecuteReader(string sql,params MySqlParameter[] parameters) {
            using(MySqlConnection mySqlConnection = new MySqlConnection(connectionString)) {
                try {
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand(sql,mySqlConnection);
                    mySqlCommand.Parameters.AddRange(parameters);
                    return mySqlCommand.ExecuteReader();
                    }
                catch(Exception e) {
                    Console.WriteLine(e.Message);
                    }
                return null;
                }
            }
        /// <summary>
        /// 带参数查询
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>DataSet</returns>
        public static DataTable DataSet(string sql) {
            using(MySqlConnection mySqlConnection = new MySqlConnection(connectionString)) {
                try {
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sql,mySqlConnection);
                    DataSet dataSet = new DataSet();
                    mySqlDataAdapter.Fill(dataSet);
                    if(dataSet.Tables.Count > 0) {
                        return dataSet.Tables[0];
                        }
                    }
                catch(Exception e) {
                    Console.WriteLine(e.Message);
                    }
                }
            return null;
            }
        /// <summary>
        /// 带参数查询
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>DataSet</returns>
        public static DataTable DataSet(string sql,params MySqlParameter[] parameters) {
            using(MySqlConnection mySqlConnection = new MySqlConnection(connectionString)) {
                try {
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sql,mySqlConnection);
                    mySqlDataAdapter.SelectCommand.Parameters.AddRange(parameters);
                    DataSet dataSet = new DataSet();
                    mySqlDataAdapter.Fill(dataSet);
                    if(dataSet.Tables.Count > 0) {
                        return dataSet.Tables[0];
                        }
                    }
                catch(Exception e) {
                    Console.WriteLine(e.Message);
                    }
                }
            return null;
            }
        }
    }
