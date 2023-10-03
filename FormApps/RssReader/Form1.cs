using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        List<ItemData> ItemDatas = new List<ItemData>();
        int num = 0;
        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead(tbUrl.Text);
                XDocument xdoc = XDocument.Load(url);

                ItemDatas = xdoc.Root.Descendants("item").Select(s => new ItemData {
                    Title = (string)s.Element("title"),
                    Link = (string)s.Element("link")
                }).ToList();
                foreach (var s in ItemDatas) {
                    lbRssTitle.Items.Add(s.Title);
                }
            }
        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            num = lbRssTitle.SelectedIndex;
            wbBrowser.Navigate(ItemDatas[num].Link);
        }

        private void btNext_Click(object sender, EventArgs e) {
            num += 1;
            wbBrowser.Navigate(ItemDatas[num].Link);
        }

        private void btBack_Click(object sender, EventArgs e) {
            num -= 1;
            wbBrowser.Navigate(ItemDatas[num].Link);
        }

        private void btGoBack_Click(object sender, EventArgs e) {
            wbBrowser.GoBack();
        }

        private void btGoNext_Click(object sender, EventArgs e) {
            wbBrowser.GoForward();
        }
    }
}
