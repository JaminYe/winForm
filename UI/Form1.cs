using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI {
    public partial class Form1:Form {
        public Form1() {
            InitializeComponent();
            }

        private void Form1_Load(object sender,EventArgs e) {
            pictureBox1.Image = Image.FromFile(@"F:/1.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile(@"F:/1.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            System.Drawing.Drawing2D.GraphicsPath graphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
            graphicsPath.AddEllipse(this.pictureBox2.ClientRectangle);
            Region region = new Region(graphicsPath);
            this.pictureBox2.Region = region;
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

        }
    }
