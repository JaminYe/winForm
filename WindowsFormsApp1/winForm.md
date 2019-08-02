###### Windows窗体

1. 属性: 
   1. name:对象的名称
   2. windowsState:初始化窗体的大小,Normal,Minimized,Maximized
   3. StartPosition:窗体起始位置,Manual(由Location属性决定),CenterScreen(居中显示),WindowsDefaultLocation(Windows默认位置),WindowsDefaultBounds(Windows默认位置,边界由Windows决定),CenterParent(在父窗口居中)
   4. Text: 窗体的标题,给用户看
   5. MaximizeBox,MinimizeBox: 是否有最大化最小化的按钮
   6. BackColor:背景颜色
   7. BackgroundImage: 背景图片
   8. BackgroundImageLayout: 背景图片的布局, None（居左显示）、Tile（图像重复，默认值）、Stretch（拉伸）、Center（居中）、Zoom（按比例放大到合适大小）
   9. Enabled:窗体是否可用
   10. Font: 设置窗体上字体
   11. ForeColor:设置窗体上文字颜色
   12. Icon:设置窗体图标
   13. FormBorderStyle: 窗体边框
2. 事件
   1. load:窗体加载事件
   2. mouseClick:鼠标单击事件
   3. mouseDoubleClick:鼠标双击事件
   4. mouseMove:鼠标移动事件
   5. keyDown:键盘按下事件
   6. keyUp:键盘释放事件
   7. FormClosing:窗体关闭时事件
   8. FormClosed:窗体关闭后事件
3. 消息框(DialogResult  MessageBox.Show(提示语,窗体名,选择项按钮MessageBoxButtons ,提示语图标MessageBoxIcon)  
   1. 选项按钮:OK,OKCancel,AbortRetryIgnore(中止,重试,忽略),YesNoCancel,YesNo,RetryCancel(重试,取消)
      2.提示语图标:None,(Hand,Stop,Error)红x,Question问号,(Exclamation,Warning)警告,(Asterisk,Information)提示
      3.返回值:None,Ok,Cancel,Abort(中止),Retry(重试),Ignore(忽略),Yes,No
4. Label和LinkLabel：标签控件
   - Name: 标签名,唯一标识
   - Text:内容
   - Font:文字样式
   - FontColor:文本颜色
   - BackColor:背景颜色
   - Image:背景图片
   - AutoSize:是否自动调整标签大小 true,false
   - Size:标签大小
   - Visible:标签是否可见
     5.TextBox：文本框
   - Text: 文本内容
   - MaxLength：文本框最多输入字符个数
   - WordWrap：自动换行
   - PasswordChar：密码字符替换
   - Multiline：多行文本文本框
   - ReadOnly：只读
   - Lines：文本行数
   - ScrollBars：滚动条
5. Button：按钮控件
6. RadioButton：单选按钮
7. CheckBox：多选按钮
8. CheckedListBox：多选集合
9. ListBox：列表
   - MultiColumn：列表是否支持多列
   - Items：列表框的值
   - SelectedItems：选中项的集合
   - SelectedItem：选中项
   - SelectedIndex：选中项的索引
   - SelectionMode：列表选择模式
     - One:只能选择一项
     - MultiSimple :可选择多项
     - None: 不可选择
     - MultiExtended:可选择多项但要按下shift
   - 方法:
     - Add: 添加项
     - Insert: 指定位置添加项
     - Remove: 移除项
10. ComboBox:组合框
    - DropDownStyle:外观 Simple(显示文本框和列表框,文本框可编辑),DropDown(只显示文本框,文本框可通过鼠标展开,可编辑),DropDownList(只显示文本框,文本框可通过鼠标展开,不可编辑)
    - Items: 获取或设置组合中的值
    - Text:获取或设置组合框中的文本
    - MaxDropDownItems: 获取或设置最多显示的项数
    - Stored: 是否排序
11. PictureBox:图片控件
    - Image:获取或设置显示的图片
    
    - ImageLocation: 获取或设置图片路径
    
    - SizeMode: 设置图片显示大小和位置Normal(显示在左上角),Stretchimage(适应控件大小),AutoSize(控件大小适应图片大小),Centerimage(图片在图片控件居中),Zoom(图片自动缩放至符合图片控件的大小)
    
	```c#
	System.Drawing.Drawing2D.GraphicsPath graphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
            graphicsPath.AddEllipse(this.pictureBox2.ClientRectangle);
            Region region = new Region(graphicsPath);
            this.pictureBox2.Region = region;
	```
12. Timer:定时器控件
13. 日期时间控件
	- Short:短日期格式,例如2019/1/1
	- Long:长日期格式,例如2019年1月1日
	- Time:仅显示时间,例如22:00:00
	- Custom:用户自定义显示格式
14. ContextMeanStrip :右击菜单控件
15. MeauStrip: 菜单栏控件
16. StatusStrip:状态栏控件
17. progressBar:进度条控件
```c#
		/// <summary>
        /// 开始跑进度条
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click_1(object sender,EventArgs e) {
        progressBar1.Maximum = 1000;
        progressBar1.Value = i;
        label1.Show();
        while (progressBar1.Value!=progressBar1.Maximum){
        label1.Text = "进度:"+progressBar1.Value*100 / progressBar1.Maximum+"%";
        label1.Refresh();
        i++;
        progressBar1.Value = i;
        Thread.Sleep(100);
        }

        }
```
18. ToolStrip:工具栏控件
19. MDI窗体:设置窗体IsMdiContainer属性为true,设置新窗体的MdiParent为当前窗体
20. OpenFileDialog和SaveFileDialog打开文件与保存文件:通过流输入输出
21. RichTextBox富文本编辑器:loadFile加载文件,saveFile保存文件
22. NumericUpDown数字输入框:DecimalPlaces:保留小数点后位数 Increment 增加减少的数
23. ToolTip:气泡提示控件: 
	```c#
	private void ToolTip1_Popup_1(object sender,PopupEventArgs e) {
        ToolTip toolTip = (ToolTip)sender;
        if (e.AssociatedControl.Name == "textPass") {
        toolTip.ToolTipTitle = "提示信息";
        toolTip.ToolTipIcon = ToolTipIcon.Info;
        } else {
        toolTip.ToolTipTitle = "错误信息";
        toolTip.ToolTipIcon = ToolTipIcon.Warning;
        }
        }
		/// <summary>
        /// 气泡测试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button3_Click(object sender,EventArgs e) {
        toolTip1.Show("显示文本",this.textPass,5000);
        }
	```
24.notifyIcon托盘控件
	```c#
	/// <summary>
        /// 当窗体最小化时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SizeChange(object sender,EventArgs e) {
        if(WindowState == FormWindowState.Minimized) {
        this.Hide();
        notifyIcon1.Visible = true;
        notifyIcon1.ShowBalloonTip(20,"demo","this is a demo",ToolTipIcon.Warning);
        }
        }
        /// <summary>
        /// 双击托盘图标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotifyIcon1_MouseDoubleClick(object sender,MouseEventArgs e) {
        if(WindowState == FormWindowState.Minimized) {
        this.Show();
        this.WindowState = FormWindowState.Normal;
        }
        }

        /// <summary>
        /// 托盘右击打开主界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 打开主页面ToolStripMenuItem_Click(object sender,EventArgs e) {
        this.Show();
        WindowState = FormWindowState.Normal;
        }
        /// <summary>
        /// 托盘右击退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 退出ToolStripMenuItem_Click(object sender,EventArgs e) {
        this.Close();
        }
	```
25. treeView1树控件
```c#
     private void TreeView_Load(object sender,EventArgs e) {
        treeView1.Nodes.Add("全部信息");
        }
        /// <summary>
        /// 添加下级
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender,EventArgs e) {
        if(treeView1.SelectedNode == null) {
        MessageBox.Show("请选择节点!!!!");
        } else if(textBox1.Text != "") {
        TreeNode treeNode = new TreeNode(textBox1.Text);
        treeView1.SelectedNode.Nodes.Add(treeNode);
        } else {
        MessageBox.Show("节点信息不得为空!");
        }
        }
        /// <summary>
        /// 添加同级
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button3_Click(object sender,EventArgs e) {
        if(treeView1.SelectedNode.Parent == null) {
        MessageBox.Show("请添加下级");
        return;
        }
        if(treeView1.SelectedNode == null) {
        MessageBox.Show("请选择节点!!!!");
        } else if(textBox1.Text != "") {
        TreeNode treeNode = new TreeNode(textBox1.Text);
        treeView1.SelectedNode.Parent.Nodes.Add(treeNode);
        treeView1.ExpandAll();
        } else {
        MessageBox.Show("节点信息不得为空!");
        }
        }
        /// <summary>
        /// 删除节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender,EventArgs e) {
        if(treeView1.SelectedNode == null) {
        MessageBox.Show("请选择节点!!!!");
        } else if(treeView1.SelectedNode.Nodes.Count == 0) {
        treeView1.SelectedNode.Remove();
        } else {
        MessageBox.Show("请先删除子节点");
        }
        }
```
26. panel容器
```c#
  /// <summary>
        /// 控制panel容器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender,EventArgs e) {
        //清空容器容器中的控件
        this.panel1.Controls.Clear();
        //new一个进度条控件
        progressBar progress = new progressBar();
        //不设置或出现System.ArgumentException:“无法将顶级控件添加到控件。”
        progress.TopLevel = false;
        //让进度条控件的大小以容器大小为主
        progress.Dock = DockStyle.Fill;
        //去除窗口边界
        progress.FormBorderStyle = FormBorderStyle.None;
        //设置最大化
        progress.WindowState = FormWindowState.Maximized;
        //隐藏工具栏
        progress.Visible = false;
        //容器大小设置为窗口大小
        panel1.Height = Screen.PrimaryScreen.Bounds.Size.Height;
        panel1.Width = Screen.PrimaryScreen.Bounds.Size.Width;
        this.panel1.Controls.Add(progress);
        progress.Show();
        }
```