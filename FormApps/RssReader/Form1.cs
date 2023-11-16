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
        Dictionary<string, string> Favorite = new Dictionary<string, string>();
        class favoriteList {
            public string UrlSet { get; set; }
            public string NameSet { get; set; }

            public favoriteList(string UrlSet, string NameSet) {
                this.UrlSet = UrlSet;
                this.NameSet = NameSet;
            }
            public override string ToString() {
                return NameSet;
            }
        }

        int num = 0;
        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
            if (tbUrl.Text == "") {
                return;
            }
            using (var wc = new WebClient()) {
                lbRssTitle.Items.Clear();

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
            if (num == lbRssTitle.Items.Count) {
                return;
            }
            num += 1;
            lbRssTitle.SelectedIndex += 1;
            wbBrowser.Navigate(ItemDatas[num].Link);
        }

        private void btBack_Click(object sender, EventArgs e) {
            if (num < 1) {
                return;
            }
            num -= 1;
            lbRssTitle.SelectedIndex -= 1;
            wbBrowser.Navigate(ItemDatas[num].Link);
        }

        private void btGoBack_Click(object sender, EventArgs e) {
            wbBrowser.GoBack();
        }

        private void btGoNext_Click(object sender, EventArgs e) {
            wbBrowser.GoForward();
        }

        private void btDelete_Click(object sender, EventArgs e) {
            tbUrl.ResetText();
            lbRssTitle.Items.Clear();
        }

        private void rbIt_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/it.xml";
            using (var wc = new WebClient()) {
                lbRssTitle.Items.Clear();

                var url = wc.OpenRead("https://news.yahoo.co.jp/rss/topics/it.xml");
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

        private void rbSports_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/sports.xml";
            using (var wc = new WebClient()) {
                lbRssTitle.Items.Clear();

                var url = wc.OpenRead("https://news.yahoo.co.jp/rss/topics/sports.xml");
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

        private void rbScience_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/science.xml";
            using (var wc = new WebClient()) {
                lbRssTitle.Items.Clear();

                var url = wc.OpenRead("https://news.yahoo.co.jp/rss/topics/science.xml");
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

        private void rbEconomy_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/business.xml";
            using (var wc = new WebClient()) {
                lbRssTitle.Items.Clear();

                var url = wc.OpenRead("https://news.yahoo.co.jp/rss/topics/business.xml");
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

        private void btFavorite_Click(object sender, EventArgs e) {
            favoriteList favoriteList = new favoriteList(tbUrl.Text, tbFavoriteName.Text);
            if (Favorite.ContainsKey(tbUrl.Text) || Favorite.ContainsValue(tbFavoriteName.Text)) {
                lbDuplication.Text = "重複しています";
            }
            else {
                lbDuplication.Text = " ";
                Favorite.Add(tbUrl.Text, tbFavoriteName.Text);
                cbFavoriteList.Items.Add(favoriteList);
                tbFavoriteName.Clear();
            }
        }

        private void cbFavoriteList_SelectedIndexChanged(object sender, EventArgs e) {
            favoriteList favorite = (favoriteList) cbFavoriteList.SelectedItem;
            tbUrl.Text = favorite.UrlSet.ToString();
            using (var wc = new WebClient()) {
                lbRssTitle.Items.Clear();

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
    }
}
