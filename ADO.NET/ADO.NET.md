##### ADO.NET
1. 什么是ADO.NET?
	- 一种允许.NET开发人员使用标准的结构化的无缝连接的一种数据交互技术
2. 核心组成部分
	1. Data Provider数据提供程序
		1. Connection
		2. Command用于发送数据库命令
		3. DataReader 从数据源中提供数据流
		4. DataAdapter 提供连接DataSet对象和数据源的桥梁
	2. DataSet
		- 用于连接XML数据
3. ADO.NET拓展
	1. Entity Framework:利用抽象化数据库,将数据库对象转换为应用程序对象数据字段渣u你换为属性,让数据库E/R模型转换为i对象模型
	2. LINQ:允许C#代码查询数据库的方式操作内存数据
##### 了解.NET数据提供程序
1. .NET数据提供程序的概念
	1. System.Data.SqlClient
	2. System.Data.OledDb
	3. System.Data.ODBC
	4. System.Data.OracleClient
	5. System.Data.EntityClient
2. 重要对象
	1. Parameter:定义命令和储存过程的输入、输出和返回值参数
	2. ConnectionStringBuilder:创建和管理连接对象使用的连接字符串内容
	3. CommandBuilder: 自动生成DataAdapter的命令属性或从储存过程中派生参数信息
3. 理解.NET数据提供程序
	1. 用于SQL Server的.NET Framework数据提供程序(SqlClient):使用自己的协议与SQL Server进行通信
	2. 用于OLE DB 的.NET Framework数据提供程序: 通过COM互操作使用 本机OLE DB来启用数据访问
	3. 用于 ODBC 的 .NET Framework 数据提供程序:使用本机 ODBC 驱动程序管理器 (DM) 来启用数据访问
	4. 用于 Oracle 的 .NET Framework 数据提供程序:通过 Oracle 客户端连接软件启用对 Oracle 数据源的数据访问。 用于 Oracle 的 .NET Framework 数据提供程序要求系统上安装有 Oracle 客户端软件（8.1.7 版或更高版本），才能连接到 Oracle 数据源。
###### 连接字符
1. 连接字符串概念
	
	- 连接字符串是一组被格式化的键值对,提供数据源,数据格式,访问信任级别以及其他任何包括连接的相关信息
2. 语法格式
	连接字符串是由一组元素组成,一个元素包含一个键值对,元素之间由";"分开,
3. 连接字符串的案例
	1. 连接Mysql:`Server=myServerAddress;DataBase=myDataBase;Uid=myUsername;Pwd=myPassword`
	2. 连接Oracle:`Data Source=TORCL;User Id=myUsername;Password=myPassword`
4. 构造连接字符串
	1. `string connStr =myServerAddress;DataBase=myDataBase;Uid=myUsername;Pwd=myPassword`
	2. SqlClient.SqlConnectionStringBuilder构造连接字符串
		- ```c#
            SqlConnectionStringBuilder stringBuilder = new qlConnectionStringBuilder();
            stringBuilder.DataSource=@"localhost:3306";
            stringBuilder.InitialCatalog = "test";
            stringBuilder.UserID = "root";
            stringBuilder.Password = "root";
		  ```
		  
##### Connection对象

1. Connection概念
    1. SqlConnection:与SQL Server的连接对象
    2. OleDbConnection:与OleDb数据源的连接对象
    3. OdbcConnection: 表示与ODBC数据源连接对象
    4. OracleConnection:表示与Oracle数据库的连接对象
2. 方法
    1. Open: 使用ConnectionString所指定的设置打开数据库
    2. Dispose: 释放由Component使用的所有资源
    3. Close: 关闭与数据库的连接
3. 属性
	1. DataBase: 打开连接之后获取当前数据库名称,或者连接打开之前获取连接字符串中指定的数据库名
    2. DataSource:获取要连接的数据库服务器的名称
    3. ConnectionTimeOut:获取终止连接和生成错误的时间
    4. ConnectionString:获取或设置用于打开连接的字符串
    5. State:获取描述连接状态的字符串
4. ConnectionState
    1. Closed: 关闭
    2. Open: 打开
    3. Connecting: 正在连接中
    4. Executing: 正在执行命令
    5. Fetching :正在检索数据
    6. Broken: 连接中断
    ```c#
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
	using(MySqlConnection mySqlConnection = new MySqlConnection { ConnectionString = "server=localhost;port=3306;user=root;password=root;database=test" }) {

        mySqlConnection.Open();
        if(mySqlConnection.State == System.Data.ConnectionState.Open) {
        Console.WriteLine("连接成功");
        }
        Console.ReadLine();
        }        
    ```
##### 数据库连接池
1. 什么是连接池
	
	- 创建连接是一件耗时耗力的事情,连接池就是存放了一定数量的与数据库的连接的容器
2. 连接池工作原理
	1. 创建连接池
		- 连接池类别区分:同一时刻同一应用由不同的连接池,是由进程、应用程序域、连接字符串、以及windows标识;同一应用程序域一般由连接字符串区分;打开一条连接如果连接的类型签名与连接池类型不匹配则新建连接池
	2. 分配空闲连接
	- 当用户创建连接或者打开连接时,连接池管理器根据连接的类型签名找到与连接池类型匹配的连接池,尽力分配一条连接
		- 有空闲连接: 直接分配
		- 无空闲连接: 创建连接再分配
		- 连接数达到最大: 等待空闲连接
	3. 移除无效连接
		- 如果一条连接长时间空闲或者与服务器断开连接,连接池管理器会将这条连接从池中移除
	4. 回收连接
		- 当我们使用完一条连接后应及时使用连接对象Close或者使用using语句
3. 重要属性
	1. Connection Timeout:超时时间,默认15秒
	2. Max Pool Size:最大连接数 默认为100
	3. Min Pool Size:最小连接数 默认为0
	4. Pooling:是否启用连接池
4. 连接池的异常与处理方法
	
	- 当连接池中的连接数量达到最大且没有空闲,此时创建一个连接会处于等待状态直到超时,超过超时时间抛出异常
5. 高效使用连接池基本原则
	1. 在最晚的时刻申请连接,在最早的时刻释放连接
	2. 关闭连接前先关闭事务
	3. 确保并维持连接池至少有一个打开的连接
	4. 尽力避免碎片的产生,主要包括集成安全性产生的池碎片以及使用许多数据库产生的池碎片
##### Command对象与数据检索
1. 什么是Command对象
	
	- 封装了所有对外部数据源的操作(包括增、删、改、查等),并在执行完成后返回合适的结果OleDbCommand,SqlCommand,OdbcCommand,OracleCommand
2. 属性
	1. CommandText:获取或者设置对数据源执行的文本命令,默认值为空字符串
	2. CommandType:命令类型,指示或指定如何解释CommandText属性.将CommandTyppe设置为StoredProcedure时,应将CommandText属性设置为储存过程
	3. Connection:设置或获取与数据源的连接
	4. Parameters:设置Sql语句或储存过程的参数
	5. Tranction:获取或设置在其中执行.NET Framework数据提供程序的Command对象的事务
3. 方法
	1. ExecuteNoneQuery: 执行不返回数据行的操作,并返回一个int类型的数据(增,删,改)
	2. ExecuteReader: 执行查询,并返回一个DataReader对象
	3. ExecuteScalar: 执行查询,并返回查询结果集中第一行的第一列(object类型).如果找不到这个数据就返回null

4. 实例
	```c#
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
	```
##### Command对象高级应用
1. 异步执行命令:在执行命令时无需等待命令执行完成可以同时执行别的操作
	```c#
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
	```
2. 参数化
	```c#
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
        } catch(Exception e) {
        Console.WriteLine(e.Message);
        }
        }
        }
   ```
##### DataAdapter
ADO.NET两个核心组件:连接数据库的DataProvider与操作本地文件的DataSet
1. DataAdapter
	- 为外部数据源与本地DataSet集合提供桥梁 将从外部数据源检索到的数据合理正确的调配到本地DataSet集合
2. DataAdapter的工作原理
	- DataApapter本质上就欧式一个数据调配器
	- 当我们查询数据时 DataAdapter首先构造一个SelectCommand实例,然后检查是否打开连接,如果没有就打开连接,然后钓鱼DataReader接口检索数据,最后根据维护的映射关系,将检索得到的数据填充到本地的DataSet或者DataTable中.当更新数据时,DataAdapter将本地修改的数据根据映射关系构造InsertCommand,UpdateCommmand,DeleteCommand,DeleteCommmand对象人后执行相应的命令.
	- DataAdapter的三大功能	
		1. 数据检索:用DataReader实例来检索数据
		2. 数据更新:执行增删操作
		3. 表或列名映射:维护本地DataSet表名和列名与数据库的映射关系
3. DataAdapter重要成员
	- DataAdapter与其他数据提供对象的相似特征:基于连接的,继承基类,不同的数据源有对应派生版本
	- SelectCommand属性:获取或设置用于在数据源查询的命令
	- UpdateCommand属性:获取或设置用于在数据源更新的命令
	- DeleteCommand属性:获取或设置用于在数据源删除的命令
	- InsertCommand属性:获取或设置用于在数据源插入数据的命令
	- Fill方法:填充数据集
	- Update:更新数据源
4. 创建DataAdapter对象
	1. 无参构造方法
    2. sqlCommand对象参数
    3. sql语句,连接对象参数
    4. sql语句,连接字符串参数
	```c#
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
	```
