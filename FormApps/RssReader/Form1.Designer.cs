
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
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUrl.Location = new System.Drawing.Point(35, 13);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(786, 31);
            this.tbUrl.TabIndex = 0;
            // 
            // btGet
            // 
            this.btGet.Location = new System.Drawing.Point(844, 13);
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
            this.lbRssTitle.Location = new System.Drawing.Point(35, 50);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(786, 160);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.SelectedIndexChanged += new System.EventHandler(this.lbRssTitle_SelectedIndexChanged);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(35, 216);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(786, 358);
            this.wbBrowser.TabIndex = 3;
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(844, 87);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(134, 31);
            this.btBack.TabIndex = 5;
            this.btBack.Text = "前の記事";
            this.btBack.UseVisualStyleBackColor = true;
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(844, 50);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(134, 31);
            this.btNext.TabIndex = 6;
            this.btNext.Text = "次の記事";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btGoBack
            // 
            this.btGoBack.Location = new System.Drawing.Point(844, 216);
            this.btGoBack.Name = "btGoBack";
            this.btGoBack.Size = new System.Drawing.Size(134, 31);
            this.btGoBack.TabIndex = 7;
            this.btGoBack.Text = "戻る";
            this.btGoBack.UseVisualStyleBackColor = true;
            this.btGoBack.Click += new System.EventHandler(this.btGoBack_Click);
            // 
            // btGoNext
            // 
            this.btGoNext.Location = new System.Drawing.Point(844, 253);
            this.btGoNext.Name = "btGoNext";
            this.btGoNext.Size = new System.Drawing.Size(134, 31);
            this.btGoNext.TabIndex = 8;
            this.btGoNext.Text = "進む";
            this.btGoNext.UseVisualStyleBackColor = true;
            this.btGoNext.Click += new System.EventHandler(this.btGoNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 595);
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
    }
}

