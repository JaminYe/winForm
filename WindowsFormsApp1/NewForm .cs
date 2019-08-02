using System.Windows.Forms;
/// <summary>
/// 注册
/// </summary>
namespace WindowsFormsApp1 {
    public partial class NewForm:Form {
        public NewForm() {
            InitializeComponent();
        }



        private void NewFormClick(object sender,MouseEventArgs e) {
            //窗体居中
            this.CenterToScreen();
        }

        private void NewFormDoubleClick(object sender,MouseEventArgs e) {
            //关闭窗体
            this.Close();
        }

        private void NewFormDown(object sender,KeyEventArgs e) {
            DialogResult dr = MessageBox.Show("是否打开新窗口?","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(dr==DialogResult.Yes) {
                NewForm newForm = new NewForm();
                newForm.Show();
            } else {
                this.Close();
            }
        }

        private void Label1_Click(object sender,System.EventArgs e) {

        }

        private void Label2_Click(object sender,System.EventArgs e) {

        }

        private void LinkLabel1_LinkClicked(object sender,LinkLabelLinkClickedEventArgs e) {
            string account = textBox1.Text;
            string password = textBox2.Text;
            if(account.Equals("admin")&&password.Equals("123456")) {
                DialogResult dialogResult = MessageBox.Show("登录成功","登录成功",MessageBoxButtons.OK);
                if(dialogResult==DialogResult.OK) {
                    this.Close();
                }
            } else {
                DialogResult dialogResult = MessageBox.Show("账号或密码有误","账号或密码有误",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                if(dialogResult==DialogResult.Cancel) {
                    this.Close();
                } else {
                    textBox1.Text="";
                    textBox2.Text="";

                }
            }

        }

        private void Label3_Click(object sender,System.EventArgs e) {

        }

        private void TextBox3_TextChanged(object sender,System.EventArgs e) {

        }

        private void TextBox1_TextChanged(object sender,System.EventArgs e) {

        }

        private void Button2_Click(object sender,System.EventArgs e) {
            this.Close();
        }

        private void Button1_Click(object sender,System.EventArgs e) {
            string account = textBox1.Text;
            string password = textBox2.Text;
            string repeatPassword = textBox3.Text;
            if(string.IsNullOrEmpty(account)) {
                MessageBox.Show("账号不得为空");
                return;
            }
            if(string.IsNullOrEmpty(password)) {
                MessageBox.Show("密码不得为空");
                return;
            }
            if(!repeatPassword.Equals(password)) {
                MessageBox.Show("两次密码需一致");
                return;
            }
            MainForm mainForm = new MainForm(account,password);
            mainForm.Show();
            this.Close();



        }

        private void NewForm_Load(object sender,System.EventArgs e) {

        }
    }
}
