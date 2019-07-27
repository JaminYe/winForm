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
    public partial class panel:Form {
        public panel() {
        InitializeComponent();
        }
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
    }
}
