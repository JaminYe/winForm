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
    public partial class ListBox:Form {
        public ListBox() {
        InitializeComponent();
        }
        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender,EventArgs e) {
        if(textBox1.Text != null && textBox1.Text != "") {
        listBox1.Items.Add(textBox1.Text);
        textBox1.Text = "";
        } else {
        MessageBox.Show("不得为空");
        }

        }
        /// <summary>
        /// 查看选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender,EventArgs e) {
        string s = "";
        for(int i = 0;i < listBox1.SelectedItems.Count;i++) {
        s = s + "   " + listBox1.SelectedItems[i].ToString();
        }
        MessageBox.Show("选中项为" + s);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button3_Click(object sender,EventArgs e) {
        List<string> list = new List<string>();
        for(int i = 0;i < listBox1.SelectedItems.Count;i++) {
        list.Add(listBox1.SelectedItems[i].ToString());
        }
        foreach(string s in list) {
        listBox1.Items.Remove(s);
        }
        }
    }
}

