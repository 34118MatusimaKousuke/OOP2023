using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理用データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();
        private int num = 0;

        //設定情報保存用オブジェクト
        Settings settings = Settings.getInstance();

        public Form1() {
            InitializeComponent();
            //dgvCarReports.DataSource = CarReports;
        }

        //ステータスラベルのテキストの表示・非表示
        private void statasLavelDisp(string msg = "") {
            //MessageBox.Show(msg);
            tsInfoText.Text = msg;
        }

        //追加ボタンがクリックされた時のイベントハンドラ
        private void btAddReport_Click(object sender, EventArgs e) {
            statasLavelDisp(); //表示クリア
            if (cbAuthor.Text == "") {
                statasLavelDisp("記録者を入力してください");
                return;
            }
            else if (cbCarName.Text == "") {
                statasLavelDisp("車名を入力してください");
                return;
            }

            DataRow newRow = infosys202314DataSet.CarReportTable.NewRow();
            newRow[1] = dtpDate.Value;
            newRow[2] = cbAuthor.Text;
            newRow[3] = getSalectedMaker();
            newRow[4] = cbCarName.Text;
            newRow[5] = tbReport.Text;
            newRow[6] = ImageToByteArray(pbCarImage.Image);

            infosys202314DataSet.CarReportTable.Rows.Add(newRow);
            this.carReportTableTableAdapter.Update(infosys202314DataSet.CarReportTable);

            /*var CarReport = new CarReport() {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Maker = getSalectedMaker(),
                CarImage = pbCarImage.Image,
            };
            CarReports.Add(CarReport);*/

            setCbAuthor(cbAuthor.Text);
            setCbCarName(cbCarName.Text);
            Clear(); //項目クリア

            enabledFalse(); //マスク処理
            btScaleChange.Enabled = false;
            btImageDelete.Enabled = false;
        }

        private void setCbCarName(string author) {
            if (cbCarName.Items.Contains(author) == false) {
                cbCarName.Items.Add(author);

            }
        }

        private void setCbAuthor(string carname) {
            if (cbAuthor.Items.Contains(carname) == false) {
                cbAuthor.Items.Add(carname);
            }
        }

        private CarReport.MakerGroup getSalectedMaker() {
            foreach (var s in gbMaker.Controls) {
                if (((RadioButton)s).Checked) {
                    return (CarReport.MakerGroup)int.Parse(((RadioButton)s).Tag.ToString());
                }
            }
            return CarReport.MakerGroup.その他;
        }

        private void btImageOpen_Click(object sender, EventArgs e) {
            if (ofdImageFileOpen.ShowDialog() == DialogResult.OK) {
                pbCarImage.Image = Image.FromFile(ofdImageFileOpen.FileName);
                btScaleChange.Enabled = true;
                btImageDelete.Enabled = true;
            }

        }

        private void btDeleteReport_Click(object sender, EventArgs e) {
            dgvCarReports.Rows.RemoveAt(dgvCarReports.CurrentRow.Index);
            this.Validate();
            carReportTableTableAdapter.Update(infosys202314DataSet.CarReportTable);
            Clear();
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReports.Columns[6].Visible = false;
            enabledFalse(); //マスク処理
            btScaleChange.Enabled = false;
            btImageDelete.Enabled = false;
            tsInfoText.Text = "";

            tsTime.Text = DateTime.Now.ToString("F");
            tmTimeUpdate.Start();
            dgvCarReports.RowsDefaultCellStyle.BackColor = Color.Aquamarine;
            //dgvCarReports.AlternatingRowsDefaultCellStyle.BackColor = Color.Black;

            try {
                //設定ファイルを逆シリアル化
                using (var reader = XmlReader.Create("settings.xml")) {
                    var serializer = new XmlSerializer(typeof(Settings));

                    settings = serializer.Deserialize(reader) as Settings;
                    BackColor = Color.FromArgb(settings.MainFormColor);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btModifyReport_Click(object sender, EventArgs e) {
            if (dgvCarReports.RowCount != 0) {
            dgvCarReports.CurrentRow.Cells[1].Value = dtpDate.Value;
            dgvCarReports.CurrentRow.Cells[2].Value = cbAuthor.Text;
            dgvCarReports.CurrentRow.Cells[3].Value = getSalectedMaker();
            dgvCarReports.CurrentRow.Cells[4].Value = cbCarName.Text;
            dgvCarReports.CurrentRow.Cells[5].Value = tbReport.Text;
            dgvCarReports.CurrentRow.Cells[6].Value = pbCarImage.Image;
            dgvCarReports.Refresh(); //一覧更新
            Clear();
            enabledFalse(); //マスク処理
             this.Validate();
             this.carReportTableBindingSource.EndEdit();
             this.tableAdapterManager.UpdateAll(this.infosys202314DataSet);
            }
        }

        private void setSelectedMaker(string makerGroup) {
            switch (makerGroup) {
                case "トヨタ":
                    rbToyota.Checked = true;
                    break;
                case "日産":
                    rbNissan.Checked = true;
                    break;
                case "ホンダ":
                    rbHonda.Checked = true;
                    break;
                case "スバル":
                    rbSubaru.Checked = true;
                    break;
                case "スズキ":
                    rbSuzuki.Checked = true;
                    break;
                case "ダイハツ":
                    rbDaihatu.Checked = true;
                    break;
                case "輸入車":
                    rbImported.Checked = true;
                    break;
                case "その他":
                    rbOther.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void enabledFalse() {
            btDeleteReport.Enabled = false;
            btModifyReport.Enabled = false;
            //btScaleChange.Enabled = false;
            //btImageDelete.Enabled = false;
        }

        private void Clear() {
            cbAuthor.Text = "";
            cbCarName.Text = "";
            tbReport.Text = "";
            pbCarImage.Image = null;
            dgvCarReports.ClearSelection();
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e) {
            var vf = new VersionForm();
            vf.ShowDialog(); //モーダルダイアログ
        }

        private void btImageDelete_Click(object sender, EventArgs e) {
            pbCarImage.Image = null;
            btScaleChange.Enabled = false;
            btImageDelete.Enabled = false;
        }

        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (cdColor.ShowDialog() == DialogResult.OK) {
                this.BackColor = cdColor.Color;
                settings.MainFormColor = cdColor.Color.ToArgb();
            }
        }

        private void btScaleChange_Click(object sender, EventArgs e) {
            num = num < 4 ? ((num == 1) ? 3 : ++num) : 0; //AutoSize(2)を除外

            pbCarImage.SizeMode = (PictureBoxSizeMode)num;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {

            //設定ファイルのシリアル化
            using (var writer = XmlWriter.Create("settings.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer, settings);
            }
        }

        private void tmTimeUpdate_Tick(object sender, EventArgs e) {
            tsTime.Text = DateTime.Now.ToString("F");
        }

        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e) {
            if (sfdCarRepoSave.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(sfdCarRepoSave.FileName, FileMode.Create)) {
                        bf.Serialize(fs, CarReports);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202314DataSet.CarReportTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableTableAdapter.Fill(this.infosys202314DataSet.CarReportTable);

            dgvCarReports.ClearSelection();

            foreach (var s in infosys202314DataSet.CarReportTable) {
                setCbAuthor(s.Author);
                setCbCarName(s.CarName);
            }
        }

        private void dgvCarReports_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvCarReports.RowCount != 0) {
                dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[1].Value;
                cbAuthor.Text = dgvCarReports.CurrentRow.Cells[2].Value.ToString();
                setSelectedMaker(dgvCarReports.CurrentRow.Cells[3].Value.ToString());
                cbCarName.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
                tbReport.Text = dgvCarReports.CurrentRow.Cells[5].Value.ToString();

                pbCarImage.Image = !dgvCarReports.CurrentRow.Cells[6].Value.Equals(DBNull.Value)
                    && ((Byte[])dgvCarReports.CurrentRow.Cells[6].Value).Length != 0 ?
                    ByteArrayToImage((byte[])dgvCarReports.CurrentRow.Cells[6].Value) : null;

                btDeleteReport.Enabled = true;
                btModifyReport.Enabled = true;
                btScaleChange.Enabled = true;
                btImageDelete.Enabled = true;
            }
        }

        private void carReportTableBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202314DataSet);

        }

        private void btConnection_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202314DataSet.CarReportTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableTableAdapter.Fill(this.infosys202314DataSet.CarReportTable);

            dgvCarReports.ClearSelection();

            foreach (var s in infosys202314DataSet.CarReportTable) {
                setCbAuthor(s.Author);
                setCbCarName(s.CarName);
            }
        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }
    }
}
