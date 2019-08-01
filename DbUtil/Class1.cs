using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DbUtil {
    //数据库操作工具类
    public class DbUtil {
      static  String connectionString = "server=localhost;port=3306;database=test;user=root;password=root";
        //增删改操作
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



        public static int? ExecuteNonQuery(params string[] strings) {
            using(MySqlConnection mySqlConnection=new MySqlConnection(connectionString)) {



                }




            }

        }
    }
