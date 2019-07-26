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
/// 单选
/// </summary>
namespace WindowsFormsApp1 {
    public partial class Form1:Form {


        public Form1() {
        InitializeComponent();
        }

        private void MoveClick(object sender,MouseEventArgs e) {
        this.BackColor = Color.Red;
        }

        private void MoveDoubleClick(object sender,MouseEventArgs e) {
        this.BackColor = Color.Black;
        }

        private void Form1_Load(object sender,EventArgs e) {

        }

        private void Button1_Click(object sender,EventArgs e) {
        string check = "";

        if (radioButton1.Checked) {
        check = radioButton1.Text;
        } else if (radioButton2.Checked) {
        check = radioButton2.Text;
        } else if (radioButton3.Checked) {
        check = radioButton3.Text;
        }

        MessageBox.Show("你所选择的是" + check);

        }
    }
}
