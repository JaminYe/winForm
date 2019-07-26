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
/// 两个窗口传值
/// </summary>
namespace WindowsFormsApp1 {
    public partial class MainForm:Form {
        public MainForm(string account,string password) {
            InitializeComponent();
            label2.Text="用户名:"+account;
            label3.Text="密码:"+password;

        }


        private void MainMouseClick(object sender,MouseEventArgs e) {
            NewForm newForm = new NewForm();
            newForm.Show();
        }

        private void MainForm_Load(object sender,EventArgs e) {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
