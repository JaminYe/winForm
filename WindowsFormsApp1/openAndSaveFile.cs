using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1 {
    public partial class openAndSaveFile:Form {
        public openAndSaveFile() {
        InitializeComponent();
        }
        /// <summary>
        /// 打开文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender,EventArgs e) {
        DialogResult dr = openFileDialog1.ShowDialog();
        string name = openFileDialog1.FileName;
        if(dr == DialogResult.OK && name != null) {
        richTextBox1.LoadFile(name,RichTextBoxStreamType.PlainText);
        }

        }
        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender,EventArgs e) {
        DialogResult dr = saveFileDialog1.ShowDialog();
        string name = saveFileDialog1.FileName;
        if(dr == DialogResult.OK && name != null) {
        richTextBox1.SaveFile(name,RichTextBoxStreamType.PlainText);
        }
        }
        /// <summary>
        /// 小数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumericUpDown1_ValueChanged(object sender,EventArgs e) {
        if(numericUpDown1.Value > 0) {
        toolTip1.Show("大于0",this.numericUpDown1,3000);
        } else {
        toolTip1.Show("小于0",this.numericUpDown1,3000);

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
        /// <summary>
        /// 设置气泡
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenAndSaveFile_Load(object sender,EventArgs e) {
        toolTip1.ToolTipTitle = "提示";
        toolTip1.ToolTipIcon = ToolTipIcon.Info;
        toolTip1.SetToolTip(this.button1,"打开文件");
        }
    }
}
