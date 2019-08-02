using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace UI {
    public partial class Login:Form {

        BLL.AdminService adminService = new BLL.AdminService();
        public Login() {
            InitializeComponent();
            }



        //下面是可用的常量，根据不同的动画效果声明自己需要的
        private const int AW_HOR_POSITIVE = 0x0001;//自左向右显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志
        private const int AW_HOR_NEGATIVE = 0x0002;//自右向左显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志
        private const int AW_VER_POSITIVE = 0x0004;//自顶向下显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志
        private const int AW_VER_NEGATIVE = 0x0008;//自下向上显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志该标志
        private const int AW_CENTER = 0x0010;//若使用了AW_HIDE标志，则使窗口向内重叠；否则向外扩展
        private const int AW_HIDE = 0x10000;//隐藏窗口
        private const int AW_ACTIVE = 0x20000;//激活窗口，在使用了AW_HIDE标志后不要使用这个标志
        private const int AW_SLIDE = 0x40000;//使用滑动类型动画效果，默认为滚动动画类型，当使用AW_CENTER标志时，这个标志就被忽略
        private const int AW_BLEND = 0x80000;//使用淡入淡出效果


        private void Form1_Load(object sender,EventArgs e) {
            //上边图片
            pictureBox1.Image = Image.FromFile(@"F:/1.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //头像圆形操作
            pictureBox2.Image = Image.FromFile(@"F:/1.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            System.Drawing.Drawing2D.GraphicsPath graphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
            graphicsPath.AddEllipse(this.pictureBox2.ClientRectangle);
            Region region = new Region(graphicsPath);
            this.pictureBox2.Region = region;
            //隐藏取消按钮
            //隐藏账号密码错误页面
            this.panel3.Hide();

            }


        //坐标变量
        Point mouseOff;
        //左键是否按下
        bool leftFlag;
        private void Form_1MouseDown(object sender,MouseEventArgs e) {
            //按下的是否是左键
            if(e.Button == MouseButtons.Left) {
                //赋值鼠标坐标
                mouseOff = new Point(-e.X,-e.Y);
                leftFlag = true;
                }
            }

        private void Form_MouseMove(object sender,MouseEventArgs e) {
            if(leftFlag) {
                Point mouseSet = Control.MousePosition;
                mouseOff.Offset(mouseOff.X,mouseOff.Y);
                Location = mouseSet;
                }
            }

        private void Form_MouseUp(object sender,MouseEventArgs e) {
            if(leftFlag) {
                leftFlag = false;
                }
            }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender,EventArgs e) {
            if(comboBox1.Text.Equals("")) {
                toolTip1.Show("请先输入账号",this.comboBox1,3000);
                }
            else if(textBox1.Text.Equals("")) {
                toolTip1.Show("请先输入密码",this.textBox1,3000);
                }
            else if(comboBox1.Text != null && textBox1.Text != null) {
                //验证成功,登录操作
                string name = comboBox1.Text;
                string password = textBox1.Text;
                this.panel1.Hide();
                //登录动画
                for(int i = 0;i < 30;i++) {
                    Size pictureBox1Size = pictureBox1.Size;
                    pictureBox1Size.Height--;
                    pictureBox1.Size = pictureBox1Size;
                    pictureBox2.Left += 4;
                    System.Threading.Thread.Sleep(1);
                    }
                //登录成功
                if(adminService.Login(name,password)) {
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                    }
                //登录失败
                else {
                    this.panel2.Hide();
                    label1.Text = "你输入的帐户名或密码不正确，你要找回密码吗？";
                    pictureBox3.Image = Image.FromFile(@"F:/3.png");
                    this.panel3.Show();
                    }
                }
            }
        /// <summary>
        /// 找回密码取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button4_Click(object sender,EventArgs e) {
            this.panel3.Hide();
            for(int i = 0;i < 30;i++) {
                Size pictureBox1Size = pictureBox1.Size;
                pictureBox1Size.Height++;
                pictureBox1.Size = pictureBox1Size;
                System.Threading.Thread.Sleep(1);
                }
            pictureBox2.Location = new Point(15,9);
            this.panel1.Show();
            this.panel2.Show();
            }

        private void Button2_Click(object sender,EventArgs e) {

            }
        /// <summary>
        /// 注册账号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkLabel1_LinkClicked(object sender,LinkLabelLinkClickedEventArgs e) {
            /*//第一种使用默认浏览器
            System.Diagnostics.Process.Start(@"F:/1.png");*/
            /*//第二种读取注册表浏览器
            RegistryKey key = Registry.ClassesRoot.OpenSubKey(@"http\shell\open\command");
            string s = key.GetValue("").ToString();
            System.Diagnostics.Process.Start(s.Substring(0,s.Length - 8),"http://www.baidu.com");*/
            }
        }
    }
