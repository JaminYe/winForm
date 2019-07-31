using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
    {
    class App
        {


        [STAThread]
        static void Main()
            {
            /*  //定义application作为程序入口
              Application app = new Application();
              //调用run
              MainWindow mainWindow = new MainWindow();
              app.Run(mainWindow);*/
            /* Application app = new Application();
             MainWindow mainWindow = new MainWindow();
             //指定应用程序的主要MainWindow属性
             app.MainWindow = mainWindow;
             mainWindow.Show();
             //调用无参的run方法
             app.Run();
 */
            Application app = new Application();
            //通过url启动
            app.StartupUri = new Uri("MainWindow.xaml", UriKind.Relative);
            app.Run();
           







            }


        }
    }
