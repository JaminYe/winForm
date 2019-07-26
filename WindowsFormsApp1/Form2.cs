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
/// 多选
/// </summary>
namespace WindowsFormsApp1 {
    public partial class Form2:Form {
        public Form2() {
        InitializeComponent();
        }

        private void Button1_Click(object sender,EventArgs e) {
        String check = "";
        foreach (Control c in Controls) {
        if (c is CheckBox) {

        if (((CheckBox)c).Checked) {

        check = check + "     " + c.Text;
        }


        }

        }
        MessageBox.Show("所选项为" + check);
        }

        private void Form2_Load(object sender,EventArgs e) {

        }
    }
}
