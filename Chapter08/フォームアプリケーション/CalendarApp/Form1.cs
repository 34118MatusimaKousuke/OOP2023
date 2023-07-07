using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();         
        }

        private void btDayCalc_Click(object sender, EventArgs e) {
            var dateTime = DateTime.Now;
            var dtp = dtpDate.Value;

            var now = dateTime - dtp;

            tbMessage.Text = "入力した日にちから" + now.Days + "日です";
         
        }

        private void btAge_Click(object sender, EventArgs e) {
            var dateTime = DateTime.Now;
            var dtp = dtpDate.Value;

            var days = dateTime.Year - dtp.Year;

            if (dateTime < dtp.AddYears(days)) {
                days--;
            }

            tbMessage.Text = days + "歳";
        }

        private void Form1_Load(object sender, EventArgs e) {
            var dateTime = DateTime.Now;
            tbTimeNow.Text = dateTime.ToString("yyyy年MM月dd日 HH時mm分ss秒");
            tmTimeDisp.Start();
        }

        //タイマーイベントハンドラ
        private void tmTimeDisp_Tick(object sender, EventArgs e) {
            tbTimeNow.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH時mm分ss秒");
        }
    }
}
