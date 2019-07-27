using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1 {
    public partial class progressBar:Form {


        int i = 1;
        public progressBar() {
        InitializeComponent();
        }

  
        
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



        private void 新建窗口ToolStripMenuItem_Click(object sender,EventArgs e) {
     PictureTimerBox p=new PictureTimerBox();
        p.MdiParent = this;
        p.Show();
        }
    }
}
