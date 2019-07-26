using System;
using System.IO;
using MySql.Data.MySqlClient;
delegate void ConsoleWrite1();
namespace ConsoleApp1 {


    class Test {
        static void Main() {
            MysqlConnection();
            Console.ReadKey();
        }


        static void MysqlConnection() {
            //配置连接信息
            String connstr = "server=localhost;port=3306;user=root;password=123456;database=ztree";
            MySqlConnection mySqlConnection = new MySqlConnection(connstr);
            //打开连接
            mySqlConnection.Open();
            //sql语句
            string sql = "select * from city";
            MySqlCommand mySqlCommand = new MySqlCommand(sql,mySqlConnection);
            //执行sql语句
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            while(mySqlDataReader.Read()) {
                if(mySqlDataReader.HasRows) {
                    Console.WriteLine("id:{0};name:{1};pid:{2}",mySqlDataReader.GetString(0),mySqlDataReader.GetString(1),mySqlDataReader.GetString(2));
                }
            }
            mySqlConnection.Close();
        }



        static void Ref(ref int a) {
            a+=500;
        }

        static void Params(params int[] array) {
            int max = array[0];
            for(int i = 0;i<array.Length;i++) {
                if(array[i]>max) {
                    max=array[i];
                }
            }
            Console.WriteLine("最大值为{0}",max);
            Console.ReadLine();
        }

        public static int Test7(out string a) {
            a="asddddddddddd";
            return 1;
        }





        static void input() {
            Console.WriteLine("请输入你的姓名:");
            string s = Console.ReadLine();
            Console.WriteLine("你的姓名是"+s);
            Console.ReadKey();
        }




        static unsafe void array() {
            int[] list = { 10,100,200 };
            fixed (int* ptr = list)
                /* 显示指针中数组地址 */
                for(int i = 0;i<3;i++) {
                    Console.WriteLine("Address of list[{0}]={1}",i,(int)(ptr+i));
                    Console.WriteLine("Value of list[{0}]={1}",i,*(ptr+i));
                }
            Console.ReadKey();

        }




        static unsafe void Swap(int* a,int* b) {
            int temp = *a;
            *a=*b;
            *b=temp;
        }


















        static unsafe void Test12() {
            int i = 0;
            int* p = &i;
            Console.WriteLine("i的值为{0},内存地址为{1},toString后为{2}",i,(int)p,p->ToString());
            Console.WriteLine();
        }






    }












    class Program {

        static FileStream fs;
        static StreamWriter sw;
        // 委托声明
        public delegate void printString(string s);

        // 该方法打印到控制台
        public static void WriteToScreen(string str) {
            Console.WriteLine("The String is: {0}",str);
        }
        // 该方法打印到文件
        public static void WriteToFile(string s) {
            fs=new FileStream(@"D:\Document\test.txt",
            FileMode.Append,FileAccess.Write);
            sw=new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        // 该方法把委托作为参数，并使用它调用方法
        public static void sendString(printString ps) {
            ps("Hello World");
        }
        static void main(string[] args) {
            printString ps1 = new printString(WriteToScreen);
            printString ps2 = new printString(WriteToFile);
            sendString(ps1);
            sendString(ps2);
            Console.ReadKey();
        }









        static void ConsoleWrite() {
            Console.WriteLine("测试");
        }






        //获得某文件夹下的文件名与大小
        static void GetFile(String path) {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            DirectoryInfo[] directoryInfo1 = directoryInfo.GetDirectories();
            FileInfo[] files = directoryInfo.GetFiles();
            if(directoryInfo1!=null) {
                foreach(DirectoryInfo directoryInfo2 in directoryInfo1) {
                    GetFile(path+@"\"+directoryInfo2.Name);
                }
            }
            if(files!=null) {
                foreach(FileInfo file in files) {
                    Console.WriteLine("文件名:{0},文件大小{1}",file.Name,file.Length);
                }
            }
        }







        //字节流写入文件
        static void Write() {
            StreamWriter streamWriter = null;
            try {
                streamWriter=new StreamWriter(@"D:\Document\test.txt");
                String[] array = new String[] { "aa","bb","cc","dd" };
                foreach(String s in array) {
                    streamWriter.WriteLine(s);


                }
            } catch(Exception e) {
                Console.WriteLine(e.ToString());
                Console.WriteLine("写入出错");
            } finally {
                Console.WriteLine("写入完成");


                streamWriter.Flush();
                streamWriter.Close();


            }
            StreamReader streamReader = null;
            try {
                streamReader=new StreamReader(@"D:\Document\test.txt");
                string line;
                while((line=streamReader.ReadLine())!=null) {
                    Console.WriteLine(line);
                }
            } catch(Exception e) {
                Console.WriteLine(e.Message);

            } finally {
                streamReader.Close();
            }


        }











        //字符流读取文件
        static void Reader() {
            StreamReader streamReader = new StreamReader(@"D:\Document\test.txt");
            string line;
            //读取文件内容
            while((line=streamReader.ReadLine())!=null) {
                //打印出来
                Console.WriteLine(line);
            }
            //关闭流
            streamReader.Close();
            Console.ReadLine();
        }
























        //预处理器指令
        /*       static void Main()
               {
       #if (a)
                   Console.WriteLine("a已被定义");

       #endif
                   Console.ReadLine();

               }*/






        double length;
        double width;

        internal void A() {
            length=1.2;
            width=1.4;
        }

        public double B() {
            return length*width;

        }

        #region 打印
        public void C() {
            Console.WriteLine("长:{0}",length);
            Console.WriteLine("宽:{0}",width);
            Console.WriteLine("结果:{0}",B());
            //size of 判断数据类型所占字节
            Console.WriteLine("size of {0}",sizeof(decimal));
        }
        #endregion

        #region HelloWorld
        static void mian(string[] args) {
            //打印语句
            Console.WriteLine("Hello World");
            //暂停
            Console.ReadKey();


        }
        #endregion



        #region 方法的调用
        class Test {

            static void main(string[] args) {
                Program program = new Program();

                program.A();
                program.C();
                Console.ReadLine();
            }

        }
        #endregion
        #region 数据转换
        class Test3 {

            static void main(String[] args) {
                //显示转换
                int i = 20;
                double d = 20.21312312;
                Console.WriteLine(i.ToString());
                Console.WriteLine((int)d);

                String s = 123.ToString();
                // Convert.ToInt32(s);
                int.Parse(s);
                Console.ReadLine();

            }

        }
        #endregion


        #region 换行打印

        class Test1 {
            static void main(String[] args) {

                Console.WriteLine("dsaghjdfas"+Environment.NewLine+"sadasfgdfas");
                Console.WriteLine("'/b'");
                Console.ReadLine();
            }



        }
        #endregion

        #region switch测试
        static void Switch() {
            char grade = 'A';
            switch(grade) {

                case 'A':
                    Console.WriteLine("优秀");
                    switch(grade) {
                        case 'A':
                            Console.WriteLine("bb");
                            break;

                    }
                    break;
                case 'B':
                    Console.WriteLine("合格");
                    break;

                case 'C':
                    Console.WriteLine("不及格");
                    break;

                default:
                    Console.WriteLine("无效成绩");
                    break;
            }
            Console.ReadLine();
        }


        #endregion

        #region for循环
        public void For() {
            for(int i = 0;i<10;i++) {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        #endregion

        #region forEach循环
        public void ForEach() {
            int[] array = new int[] { 1,2,4,5,6577,123,1234,12,12 };
            foreach(int i in array) {
                Console.WriteLine("总个数{0},每个数{1}",array.Length
                    ,i);
            }
            Console.ReadLine();
        }
        #endregion

        static double DoWhile() {

            DateTime
                date = System.DateTime.Now;
            /*     do
                 {
                     Console.WriteLine("i的值为{0}", i);
                     i++;
                 } while (i > 0); */



            for(int i = 0;i<100000;i++) {
                Console.WriteLine("i的值为{0}",i);
            }

            DateTime
                   dateTime = System.DateTime.Now;
            double s = (dateTime-date).TotalMilliseconds;
            return s;
        }
        //可空类型
        void NullAble() {
            //默认值为0
            int a;
            //默认值为null
            int? b = 123;
            //如果b为null就赋值2否则c=b
            int c = b??2;
            Console.WriteLine("c的值为{0}",c);
            Console.ReadLine();
        }


        //数组
        static void Array() {
            //初始化数组逐个赋值
            int[] arr = new int[10];
            arr[0]=12312;
            //初始化数组并赋值
            int[] arr1 = { 321,312,12312,12312312,12312312 };
            //使用for循环赋值
            for(int i = 0;i<10;i++) {
                arr[i]=i+100;
            }
            //使用forEach取值
            foreach(int i in arr) {
                Console.WriteLine("元素的值为{0}",i);
            }


        }
        #region 结构体
        struct Books {
            public string id;
            public string name;
            public string price;

        }
        static void GetBooks() {
            Books book1;
            book1.id="123";
            book1.name="aaa";
            book1.price="23131";
            Console.WriteLine("书信息:书id{0},书名{1},书价格{2}",book1.id,book1.name,book1.price);
            Console.ReadLine();
        }
        #endregion

        #region 枚举
        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
        static void Enum() {
            int a = (int)Days.Wed;
            Console.WriteLine(a);
            Console.ReadLine();
        }
        #endregion




        static void main() => Enum();




        //运算符号的重载
        /*        class Test2
                {
                    public int length;
                    //运算符重载  
                    public static Test2 operator +(Test2 a, Test2 b)
                    {
                        Test2 test = new Test2 { length = a.length - b.length };
                        return test;
                    }
                    static void Main(string[] args)
                    {
                        Test2 test = new Test2 { length = 12 };
                        Test2 test1 = new Test2 { length = 213 };
                        Test2 t = test + test1;
                        Console.WriteLine("t的值{0}", t.length);
                        Console.ReadLine();
                    }
                }*/
    }



    //析构函数
    /* class Test
     {
         string id;
         public Test()
         {
             Console.WriteLine("构造函数");
         }
         ~Test()
         {
             Console.WriteLine("析构函数");
         }
         static void Main()
         {
             Test test = new Test { id = "123" };
             Console.WriteLine("id为{0}", test.id);
             Console.ReadLine();
         }

     }*/
}