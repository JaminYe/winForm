using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml;
using MySql.Data.MySqlClient;

namespace ADO.NET {
    class Program {
        static void Main(string[] args) {
        Command();
        Console.Read();
        }

        /// <summary>
        /// Command使用
        /// </summary>
        public static void Command() {


        MySqlConnectionStringBuilder mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder();
        //服务器地址
        mySqlConnectionStringBuilder.Server = "localhost";
        //端口号
        mySqlConnectionStringBuilder.Port = 3306;
        //指定数据库
        mySqlConnectionStringBuilder.Database = "test";
        //用户名
        mySqlConnectionStringBuilder.UserID = "root";
        //密码
        mySqlConnectionStringBuilder.Password = "root";
        using(MySqlConnection sqlConnection = new MySqlConnection(mySqlConnectionStringBuilder.ConnectionString)) {
        #region 增加
        /*        //sql语句
                String sql = "insert into tb_selcustomer values(1,'张三',0,0,13112345678,'11@qq.com','安徽省xx市xx区',11.124,11234.112,15465,'备注')";
                Console.WriteLine("SQL语句为{0}:",sql);
                MySqlCommand mySqlCommand = new MySqlCommand(sql,sqlConnection);
                try {
                sqlConnection.Open();
                int i = mySqlCommand.ExecuteNonQuery();
                Console.WriteLine("共影响{0}行",i);
                } catch(Exception e) {

                Console.WriteLine("出错了,{0}",e.Message);
                }*/
        #endregion
        String sql ="delete from "
        }

        }




        /// <summary>
        /// 数据库连接
        /// </summary>
        public static void Conection() {
        /*//新建连接并赋值连接字符串
        MySqlConnection mySqlConnection = new MySqlConnection {
            ConnectionString = "server=localhost;port=3306;user=root;password=root;database=test"
        };
        //打开连接
        mySqlConnection.Open();
        //判断连接状态码
        if(mySqlConnection.State == System.Data.ConnectionState.Open) {
        Console.WriteLine("连接");
        //从连接对象获取连接信息与连接数据库
        Console.WriteLine("连接名:{0},数据库:{1}",mySqlConnection.DataSource,mySqlConnection.Database);
        }
        mySqlConnection.Close();
        mySqlConnection.Dispose();
        if(mySqlConnection.State == System.Data.ConnectionState.Closed) {
        Console.WriteLine("释放资源");
        }
        Console.ReadLine();
        */
        //第二种使用
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        //服务器地址
        builder.Server = "localhost";
        //端口号
        builder.Port = 3306;
        //指定数据库
        builder.Database = "test";
        //用户名
        builder.UserID = "root";
        //密码
        builder.Password = "root";
        //开启连接池
        builder.Pooling = true;
        //最小连接数
        builder.MaximumPoolSize = 20;
        //最大连接数
        builder.MinimumPoolSize = 10;
        //超时时间
        builder.ConnectionTimeout = 10;
        using(MySqlConnection mySqlConnection = new MySqlConnection(builder.ConnectionString)) {
        mySqlConnection.Open();
        if(mySqlConnection.State == System.Data.ConnectionState.Open) {
        Console.WriteLine("连接成功");
        }
        Console.ReadLine();
        }




        }
    }
}
