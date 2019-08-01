using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml;
using MySql.Data.MySqlClient;
using System.Data;
using DbUtil;
using ADO.NET;
namespace ADO.NET {
    class Program {
        static void Main(string[] args) {
            Test();
            Console.Read();
            }


        #region Command使用
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
                /* String sql = "insert into tb_selcustomer values(1,'张三',0,0,13112345678,'11@qq.com','安徽省xx市xx区',11.124,11234.112,15465,'备注')";
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
                #region  删除
                /*String sql = "delete from tb_selcustomer where id=1";
                Console.WriteLine("Sql语句为{0}:",sql);
                MySqlCommand mySqlCommand = new MySqlCommand(sql,sqlConnection);
                try {
                sqlConnection.Open();
                int i = mySqlCommand.ExecuteNonQuery();
                Console.WriteLine("删除了{0}行",i);
                } catch(Exception e) {
                Console.WriteLine("错误,{0}",e.Message);
                }*/
                #endregion
                #region 修改
                /* string sql = "update tb_selcustomer set name='李四' where id=1";
                 Console.WriteLine("sql语句为{0}",sql);
                 MySqlCommand mySqlCommand = new MySqlCommand(sql,sqlConnection);
                 try {
                 sqlConnection.Open();
                 int i = mySqlCommand.ExecuteNonQuery();
                 Console.WriteLine("共修改了{0}行",i);
                 } catch(Exception e) {
                 Console.WriteLine("出错{0}",e.Message);
                 }
         */
                #endregion
                #region 读取数据
                /*        string sql = "select * from tb_selcustomer where id=1";
                        MySqlCommand mySqlCommand = new MySqlCommand(sql,sqlConnection);
                        try {

                        sqlConnection.Open();
                        MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                        if(mySqlDataReader != null && mySqlDataReader.HasRows) {
                        int rows = 0;
                        Console.WriteLine("开始读取-------");
                        while(mySqlDataReader.Read()) {
                        for(int i = 0;i < mySqlDataReader.FieldCount;i++) {
                        Console.WriteLine("{0}:{1}",mySqlDataReader.GetName(i),mySqlDataReader.GetValue(i));
                        }
                        rows++;
                        }
                        Console.WriteLine("共{0}行数据",rows);
                        }
                        mySqlDataReader.Close();
                        } catch(Exception e) {

                        Console.WriteLine("出错;{0}",e.Message);
                        }*/
                #endregion
                #region 查询总条数
                /* string sql = "select count(*) from tb_selcustomer";
                 MySqlCommand mySqlCommand = new MySqlCommand(sql,sqlConnection);
                 try {
                 sqlConnection.Open();
                 int i = Convert.ToInt32(mySqlCommand.ExecuteScalar());
                 Console.WriteLine("共{0}行数据",i);
                 } catch(Exception e) {
                 Console.WriteLine("错误{0}",e.Message);
                 }*/
                #endregion
                }
            }
        #endregion
        #region  数据库连接
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
        #endregion
        #region 异步执行
        /// <summary>
        /// 异步执行
        /// </summary>
        public static void CommandAsyn() {
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
                //sql语句
                string sql = "update tb_selcustomer set id=2";
                MySqlCommand mySqlCommand = new MySqlCommand(sql,sqlConnection);
                IAsyncResult asyncResult = mySqlCommand.BeginExecuteNonQuery();
                //用于计时的变量
                double time = 0;
                //是否结束
                while(asyncResult.IsCompleted == false) {
                    time++;
                    Console.WriteLine("{0}s",time * 0.001);
                    }
                if(asyncResult.IsCompleted == true) {
                    Console.WriteLine("共用时{0}s",time * 0.001);
                    }
                }
            }
        #endregion
        #region  参数
        /// <summary>
        /// 参数
        /// </summary>
        public static void Parameter() {

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
                //sql语句
                string sql = "update tb_selcustomer set id=@id";
                //Command对象
                MySqlCommand mySqlCommand = new MySqlCommand(sql,sqlConnection);
                //创建参数对象
                MySqlParameter id = new MySqlParameter("@id","3");
                //添加参数
                mySqlCommand.Parameters.Add(id);
                try {
                    sqlConnection.Open();
                    int i = mySqlCommand.ExecuteNonQuery();
                    Console.WriteLine("共改变了{0}行",i);
                    }
                catch(Exception e) {
                    Console.WriteLine(e.Message);
                    }
                }
            }

        #endregion


        /// <summary>
        /// 创建DataAdapter对象
        /// </summary>
        public static void DataAdapter() {
            /* 1. 无参构造方法
             2. sqlCommand对象参数
             3. sql语句,连接对象参数
             4. sql语句,连接字符串参数*/
            MySqlConnectionStringBuilder sqlConnectionStringBuilder = new MySqlConnectionStringBuilder();
            sqlConnectionStringBuilder.Server = "localhost";
            sqlConnectionStringBuilder.Port = 3306;
            sqlConnectionStringBuilder.Database = "test";
            sqlConnectionStringBuilder.UserID = "root";
            sqlConnectionStringBuilder.Password = "root";
            string sql = "select * from tb_selcustomer";
            //创建连接对象
            using(MySqlConnection mySqlConnection = new MySqlConnection(sqlConnectionStringBuilder.ConnectionString)) {
                //创建DataAdapter对象
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sql,mySqlConnection);
                //创建DataSet储存数据
                DataSet ds = new DataSet();
                //数据填充
                mySqlDataAdapter.Fill(ds);
                //如果有数据
                if(ds.Tables.Count > 0) {
                    //行
                    foreach(DataRow dataRow in ds.Tables[0].Rows) {
                        //列
                        for(int i = 0;i < ds.Tables[0].Columns.Count;i++) {
                            //字段名与内容
                            Console.Write("{0}:{1}\t",ds.Tables[0].Columns[i].ColumnName,dataRow[i]);
                            }
                        }
                    }
                }
            }





        public static void Test() {
            string sql = "select count(1) from customer where id=@id";
            MySqlParameter[] parameters = new MySqlParameter[] {
                new MySqlParameter("@id",3 )
            };
            int? i = DbUtil.DbUtil.ExecuteScalar(sql,parameters);
            Console.WriteLine(i);
            }
        }
    }