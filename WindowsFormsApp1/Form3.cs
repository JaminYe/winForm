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
/// 多选列
/// </summary>
namespace WindowsFormsApp1 {
    public partial class Form3:Form {
        public Form3() {
        InitializeComponent();
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender,EventArgs e) {

        }
        
        private void Form3_Load(object sender,EventArgs e) {

        }

        private void Button1_Click(object sender,EventArgs e) {
        string s = "";
        for (int i = 0;i < checkedListBox1.Items.Count;i++) {
        s = s + checkedListBox1.Items[i].ToString();
        }
        MessageBox.Show("选中了" + s);
        }
    }
}
