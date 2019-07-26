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
    public partial class MeauStrip:Form {
        public MeauStrip() {
        InitializeComponent();
        }

        private void 新建ToolStripMenuItem_Click(object sender,EventArgs e) {

        }

        private void 新建窗体ToolStripMenuItem_Click(object sender,EventArgs e) {
        MeauStrip meauStrip= new MeauStrip();
        meauStrip.Show();
        }

        private void 关闭窗体ToolStripMenuItem_Click(object sender,EventArgs e) {
        this.Close();
        }

        private void 切换背景颜色ToolStripMenuItem_Click(object sender,EventArgs e) {
        DialogResult dr=colorDialog1.ShowDialog();
        if (dr == DialogResult.OK) {
        this.BackColor = colorDialog1.Color;
        }

        }

        private void Button1_Click(object sender,EventArgs e) {
     DialogResult dr=   colorDialog1.ShowDialog();
        if (dr == DialogResult.OK) {
        textBox1.ForeColor = colorDialog1.Color;
        }
        }

        private void Button2_Click(object sender,EventArgs e) {
        DialogResult dr=fontDialog1.ShowDialog();
        if (dr == DialogResult.OK) {
        textBox1.Font = fontDialog1.Font;
        }
        }
    }
}
