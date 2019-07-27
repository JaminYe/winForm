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
    public partial class treeView:Form {
        public treeView() {
        InitializeComponent();
        }

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
    }
}
