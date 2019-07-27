using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// LiistView
/// </summary>
namespace WindowsFormsApp1 {
    public partial class listView:Form {
        public listView() {
        InitializeComponent();
        }
        /// <summary>
        /// 初始化列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListView_Load(object sender,EventArgs e) {
        //标题
        ColumnHeader c1 = new ColumnHeader();
        c1.Width = 100;
        c1.Text = "姓名";
        ColumnHeader c2 = new ColumnHeader();
        c2.Width = 50;
        c2.Text = "年龄";
        ColumnHeader c3 = new ColumnHeader();
        c3.Width = 100;
        c3.Text = "手机号";
        //显示网格线
        listView1.GridLines = true;
        //显示全行
        listView1.FullRowSelect = true;
        //设置只能单选
        listView1.MultiSelect = false;
        //显示详细信息
        listView1.View = View.Details;
        //添加标题
        listView1.Columns.Add(c1);
        listView1.Columns.Add(c2);
        listView1.Columns.Add(c3);
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender,EventArgs e) {
        if(label1.Text.Equals("") && label2.Text.Equals("") && label3.Text.Equals("")) {
        ListViewItem item = new ListViewItem();
        //第一列的数据
        item.Text = textBox1.Text;
        //第二列的数据
        item.SubItems.Add(textBox2.Text);
        //第三列数据
        item.SubItems.Add(textBox3.Text);
        listView1.Items.Add(item);
        MessageBox.Show("添加成功");
        //添加后把文本输入框清空
        foreach(Control c in Controls) {
        if(c is TextBox) {
        c.Text = "";
        }
        }
        } else {
        MessageBox.Show("请填写内容");
        }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender,EventArgs e) {

        List<ListViewItem> list = new List<ListViewItem>();
        for(int i = 0;i < listView1.SelectedItems.Count;i++) {

        list.Add(listView1.SelectedItems[i]);
        }
        foreach(ListViewItem item in list) {

        listView1.Items.Remove(item);
        }
        }
    }
}
