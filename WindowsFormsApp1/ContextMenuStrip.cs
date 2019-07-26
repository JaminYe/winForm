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
    public partial class ContextMenuStrip:Form {
        public ContextMenuStrip() {
        InitializeComponent();
        }

        private void 关闭窗口ToolStripMenuItem_Click(object sender,EventArgs e) {
        this.Close();
        }

        private void 打开窗口ToolStripMenuItem_Click(object sender,EventArgs e) {
        ContextMenuStrip contextMenuStrip= new ContextMenuStrip();
        contextMenuStrip.Show();
        }
    }
}
