using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class PictureTimerBox:Form {
        bool flag = false;
        public PictureTimerBox() {
        InitializeComponent();
        }

        private void Timer1_Tick(object sender,EventArgs e) {
        if(flag) {
        pictureBox1.Image = Image.FromFile(@"D:\Windows\Pictures\Camera Roll\orion_nebula_4k.jpg");
        flag = false;


        } else {
        pictureBox1.Image = Image.FromFile(@"D:\Windows\Pictures\Camera Roll\aurora_star_trail_4k.jpg");
        flag = true;
        }


        }
        /// <summary>
        /// 初始化加载图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_Load(object sender,EventArgs e) {
        //初始化图片
        pictureBox1.Image = Image.FromFile(@"D:\Windows\Pictures\Camera Roll\orion_nebula_4k.jpg");
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        //设置并启动定时器
        timer1.Interval = 100;
        timer1.Start();
        }
        /// <summary>
        /// 启动定时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender,EventArgs e) {
        timer1.Start();
        }
        /// <summary>
        /// 关闭定时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender,EventArgs e) {
        timer1.Stop();
        }
    }
}
