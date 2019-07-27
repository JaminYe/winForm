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
    public partial class DateTime:Form {
        public DateTime() {
        InitializeComponent();
        }
        /// <summary>
        /// 定时器设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateTime_Load(object sender,EventArgs e) {
        dateTimePicker1.Format = DateTimePickerFormat.Time;
        timer1.Interval = 1000;
        timer1.Start();
        }
        /// <summary>
        /// 定时器触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer1_Tick(object sender,EventArgs e) {
        dateTimePicker1.ResetText();
        }

        private void DateTimePicker1_ValueChanged(object sender,EventArgs e) {

        }
    }
}
