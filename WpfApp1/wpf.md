# WPF学习
1. wpf项目结构
	1. App.xaml:设置应用程序的起始文件与资源
		1. StartupUri:要启动的WFP应用窗体
		2. <Appllication.Resources>系统资源定义区
	2. App.xmal.cs:继承System.Windows.Application用于处理整个WPF应用程序的相关
	3. MainWindow.xmal:WPF应用程序界面与XMAL设计文件
		` <Button Content="Button" HorizontalAlignment="Left" Margin="235,195,0,0" VerticalAlignment="Top" Width="75" Click="Button_Click"/>`
	4. MainWindow.xmal.cs:MainWindow.xmal文件的后台代码继承自System.Window.Window
2. WPF应用程序的启动
	```c#
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
	```
	