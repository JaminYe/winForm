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
    public partial class MonthCalendar:Form {
        public MonthCalendar() {
        InitializeComponent();
        }

        private void MonthCalendar1_DateChanged(object sender,DateRangeEventArgs e) {
        textBox1.Text = monthCalendar1.SelectionStart.ToShortDateString();
        monthCalendar1.Hide();
        }

        private void MonthCalendar_Load(object sender,EventArgs e) {
        monthCalendar1.Hide();
        }

        private void Button1_Click(object sender,EventArgs e) {
        monthCalendar1.Show();

        }
    }
}
