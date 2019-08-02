using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;
namespace DAL {
    public class SqlHelper {
        //public static string connectionString = ConfigurationManager.ConnectionStrings["MYSQL"].ConnectionString;
        public static string connectionString = "server=localhost;port=3306;user=root;password=root;database=test";
        /// <summary>
        /// 增加修改删除
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static int? ExecuteNonQuery(string sql,MySqlParameter[] parameters) {
            using(MySqlConnection mySqlConnection = new MySqlConnection(connectionString)) {
                try {
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand(sql,mySqlConnection);
                    mySqlCommand.Parameters.AddRange(parameters);
                    return mySqlCommand.ExecuteNonQuery();
                    }
                catch(Exception e) {
                    Console.WriteLine("出现错误:{0}",e.Message);
                    }
                return null;
                }
            }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static DataTable DataTable(string sql,params MySqlParameter[] parameters) {
            using(MySqlConnection mySqlConnection = new MySqlConnection(connectionString)) {
                try {
                    mySqlConnection.Open();
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sql,mySqlConnection);
                    mySqlDataAdapter.SelectCommand.Parameters.AddRange(parameters);
                    DataSet dataSet = new DataSet();
                    mySqlDataAdapter.Fill(dataSet);
                    if(dataSet.Tables.Count > 0) {
                        return dataSet.Tables[0];
                        }
                    }
                catch(Exception e) {
                    Console.WriteLine("出现错误:{0}",e.Message);
                    }
                return null;
                }
            }


        /// <summary>
        /// 查询数据条数
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">参数数组</param>
        /// <returns>数据条数</returns>
        public static int? ExecuteScalar(string sql,MySqlParameter[] parameters) {
            using(MySqlConnection mySqlConnection = new MySqlConnection(connectionString)) {
                try {
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand(sql,mySqlConnection);
                    mySqlCommand.Parameters.AddRange(parameters);
                    int? count = Convert.ToInt32(mySqlCommand.ExecuteScalar());
                    return count;
                    }
                catch(Exception e) {
                    Console.WriteLine("出错了:{0}",e.Message);
                    }

                return null;
                }



            }
        }
    }
