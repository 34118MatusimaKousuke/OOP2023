using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理用データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = CarReports;     
         }

        //追加ボタンがクリックされた時のイベントハンドラ
        private void btAddReport_Click(object sender, EventArgs e) {
            var CarReport = new CarReport() {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Maker = getSalectedMaker(),
            };
                CarReports.Add(CarReport);
        }

        private CarReport.MakerGroup getSalectedMaker() {
            if (rbToyota.Checked == true) {
                return CarReport.MakerGroup.トヨタ;
            }
            if (rbSuzuki.Checked == true) {
                return CarReport.MakerGroup.スズキ;
            }
            if (rbSubaru.Checked == true) {
                return CarReport.MakerGroup.スバル;
            }
            if (rbNissan.Checked == true) {
                return CarReport.MakerGroup.日産;
            }
            if (rbDaihatu.Checked == true) {
                return CarReport.MakerGroup.ダイハツ;
            }
            if (rbHonda.Checked == true) {
                return CarReport.MakerGroup.ホンダ;
            }
            if (rbImported.Checked == true) {
                return CarReport.MakerGroup.輸入車;
            }
            return CarReport.MakerGroup.その他;

        }
    }
}
