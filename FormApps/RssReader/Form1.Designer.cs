
namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.btBack = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btGoBack = new System.Windows.Forms.Button();
            this.btGoNext = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.rbIt = new System.Windows.Forms.RadioButton();
            this.rbSports = new System.Windows.Forms.RadioButton();
            this.rbScience = new System.Windows.Forms.RadioButton();
            this.rbEconomy = new System.Windows.Forms.RadioButton();
            this.btFavorite = new System.Windows.Forms.Button();
            this.cbFavoriteList = new System.Windows.Forms.ComboBox();
            this.tbFavoriteName = new System.Windows.Forms.TextBox();
            this.lbDuplication = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUrl.Location = new System.Drawing.Point(135, 13);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(528, 31);
            this.tbUrl.TabIndex = 0;
            // 
            // btGet
            // 
            this.btGet.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btGet.Location = new System.Drawing.Point(687, 12);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(134, 31);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(135, 88);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(528, 124);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.SelectedIndexChanged += new System.EventHandler(this.lbRssTitle_SelectedIndexChanged);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(0, 218);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(1271, 338);
            this.wbBrowser.TabIndex = 3;
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBack.Location = new System.Drawing.Point(833, 128);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(134, 31);
            this.btBack.TabIndex = 5;
            this.btBack.Text = "前の記事";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btNext
            // 
            this.btNext.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btNext.Location = new System.Drawing.Point(833, 91);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(134, 31);
            this.btNext.TabIndex = 6;
            this.btNext.Text = "次の記事";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btGoBack
            // 
            this.btGoBack.Location = new System.Drawing.Point(0, 562);
            this.btGoBack.Name = "btGoBack";
            this.btGoBack.Size = new System.Drawing.Size(134, 31);
            this.btGoBack.TabIndex = 7;
            this.btGoBack.Text = "戻る";
            this.btGoBack.UseVisualStyleBackColor = true;
            this.btGoBack.Click += new System.EventHandler(this.btGoBack_Click);
            // 
            // btGoNext
            // 
            this.btGoNext.Location = new System.Drawing.Point(140, 562);
            this.btGoNext.Name = "btGoNext";
            this.btGoNext.Size = new System.Drawing.Size(134, 31);
            this.btGoNext.TabIndex = 8;
            this.btGoNext.Text = "進む";
            this.btGoNext.UseVisualStyleBackColor = true;
            this.btGoNext.Click += new System.EventHandler(this.btGoNext_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDelete.Location = new System.Drawing.Point(833, 50);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(134, 31);
            this.btDelete.TabIndex = 9;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // rbIt
            // 
            this.rbIt.AutoSize = true;
            this.rbIt.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbIt.Location = new System.Drawing.Point(689, 88);
            this.rbIt.Name = "rbIt";
            this.rbIt.Size = new System.Drawing.Size(48, 28);
            this.rbIt.TabIndex = 10;
            this.rbIt.TabStop = true;
            this.rbIt.Text = "IT";
            this.rbIt.UseVisualStyleBackColor = true;
            this.rbIt.CheckedChanged += new System.EventHandler(this.rbIt_CheckedChanged);
            // 
            // rbSports
            // 
            this.rbSports.AutoSize = true;
            this.rbSports.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbSports.Location = new System.Drawing.Point(687, 115);
            this.rbSports.Name = "rbSports";
            this.rbSports.Size = new System.Drawing.Size(104, 28);
            this.rbSports.TabIndex = 11;
            this.rbSports.TabStop = true;
            this.rbSports.Text = "スポーツ";
            this.rbSports.UseVisualStyleBackColor = true;
            this.rbSports.CheckedChanged += new System.EventHandler(this.rbSports_CheckedChanged);
            // 
            // rbScience
            // 
            this.rbScience.AutoSize = true;
            this.rbScience.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbScience.Location = new System.Drawing.Point(687, 148);
            this.rbScience.Name = "rbScience";
            this.rbScience.Size = new System.Drawing.Size(76, 28);
            this.rbScience.TabIndex = 12;
            this.rbScience.TabStop = true;
            this.rbScience.Text = "科学";
            this.rbScience.UseVisualStyleBackColor = true;
            this.rbScience.CheckedChanged += new System.EventHandler(this.rbScience_CheckedChanged);
            // 
            // rbEconomy
            // 
            this.rbEconomy.AutoSize = true;
            this.rbEconomy.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbEconomy.Location = new System.Drawing.Point(687, 182);
            this.rbEconomy.Name = "rbEconomy";
            this.rbEconomy.Size = new System.Drawing.Size(76, 28);
            this.rbEconomy.TabIndex = 13;
            this.rbEconomy.TabStop = true;
            this.rbEconomy.Text = "経済";
            this.rbEconomy.UseVisualStyleBackColor = true;
            this.rbEconomy.CheckedChanged += new System.EventHandler(this.rbEconomy_CheckedChanged);
            // 
            // btFavorite
            // 
            this.btFavorite.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btFavorite.Location = new System.Drawing.Point(687, 50);
            this.btFavorite.Name = "btFavorite";
            this.btFavorite.Size = new System.Drawing.Size(134, 31);
            this.btFavorite.TabIndex = 14;
            this.btFavorite.Text = "お気に入り登録";
            this.btFavorite.UseVisualStyleBackColor = true;
            this.btFavorite.Click += new System.EventHandler(this.btFavorite_Click);
            // 
            // cbFavoriteList
            // 
            this.cbFavoriteList.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbFavoriteList.FormattingEnabled = true;
            this.cbFavoriteList.Location = new System.Drawing.Point(1116, 12);
            this.cbFavoriteList.Name = "cbFavoriteList";
            this.cbFavoriteList.Size = new System.Drawing.Size(134, 32);
            this.cbFavoriteList.TabIndex = 15;
            this.cbFavoriteList.SelectedIndexChanged += new System.EventHandler(this.cbFavoriteList_SelectedIndexChanged);
            // 
            // tbFavoriteName
            // 
            this.tbFavoriteName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbFavoriteName.Location = new System.Drawing.Point(135, 50);
            this.tbFavoriteName.Multiline = true;
            this.tbFavoriteName.Name = "tbFavoriteName";
            this.tbFavoriteName.Size = new System.Drawing.Size(528, 32);
            this.tbFavoriteName.TabIndex = 16;
            // 
            // lbDuplication
            // 
            this.lbDuplication.AutoSize = true;
            this.lbDuplication.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbDuplication.Location = new System.Drawing.Point(683, 88);
            this.lbDuplication.Name = "lbDuplication";
            this.lbDuplication.Size = new System.Drawing.Size(0, 24);
            this.lbDuplication.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(63, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 27);
            this.label1.TabIndex = 18;
            this.label1.Text = "URl：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(-5, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 27);
            this.label2.TabIndex = 19;
            this.label2.Text = "名前入力：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(-5, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 27);
            this.label3.TabIndex = 20;
            this.label3.Text = "記事一覧：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(916, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 27);
            this.label4.TabIndex = 21;
            this.label4.Text = "お気に入り一覧：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 595);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDuplication);
            this.Controls.Add(this.tbFavoriteName);
            this.Controls.Add(this.cbFavoriteList);
            this.Controls.Add(this.btFavorite);
            this.Controls.Add(this.rbEconomy);
            this.Controls.Add(this.rbScience);
            this.Controls.Add(this.rbSports);
            this.Controls.Add(this.rbIt);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btGoNext);
            this.Controls.Add(this.btGoBack);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.tbUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btGoBack;
        private System.Windows.Forms.Button btGoNext;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.RadioButton rbIt;
        private System.Windows.Forms.RadioButton rbSports;
        private System.Windows.Forms.RadioButton rbScience;
        private System.Windows.Forms.RadioButton rbEconomy;
        private System.Windows.Forms.Button btFavorite;
        private System.Windows.Forms.ComboBox cbFavoriteList;
        private System.Windows.Forms.TextBox tbFavoriteName;
        private System.Windows.Forms.Label lbDuplication;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

