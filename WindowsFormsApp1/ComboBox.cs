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
    public partial class ComboBox:Form {
        public ComboBox() {
        InitializeComponent();
        }

        private void Label1_Click(object sender,EventArgs e) {

        }
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox_Load(object sender,EventArgs e) {
        comboBox1.Items.Add("计算机网络技术");
        comboBox1.Items.Add("软件工程");
        comboBox1.Items.Add("生物制药");
        comboBox1.Items.Add("会计");
        comboBox1.Items.Add("平面设计");
        }
        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender,EventArgs e) {
        if (textBox1.Text == "") {
        MessageBox.Show("不得为空");
        return;
        }
        if (comboBox1.Items.Contains(textBox1.Text)) {
        MessageBox.Show("当前专业已存在");
        return;
        }
        comboBox1.Items.Add(textBox1.Text);
        textBox1.Text = "";
        }
        /// <summary>
        /// combox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox1_SelectedIndexChanged(object sender,EventArgs e) {
        DialogResult dialogResult = MessageBox.Show("当前所选专业为" + comboBox1.Text + "是否删除?","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        if (dialogResult == DialogResult.Yes) {
        comboBox1.Items.Remove(comboBox1.Text);
        MessageBox.Show("删除完成");
        }
        }
    }
}
