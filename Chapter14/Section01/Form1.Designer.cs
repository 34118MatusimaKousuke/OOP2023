
namespace Section01 {
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
            this.btRunNotePad = new System.Windows.Forms.Button();
            this.btRunAddWaitNotePad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btRunNotePad
            // 
            this.btRunNotePad.Location = new System.Drawing.Point(12, 12);
            this.btRunNotePad.Name = "btRunNotePad";
            this.btRunNotePad.Size = new System.Drawing.Size(380, 199);
            this.btRunNotePad.TabIndex = 0;
            this.btRunNotePad.Text = "メモ帳起動";
            this.btRunNotePad.UseVisualStyleBackColor = true;
            this.btRunNotePad.Click += new System.EventHandler(this.btRunNotePad_Click);
            // 
            // btRunAddWaitNotePad
            // 
            this.btRunAddWaitNotePad.Location = new System.Drawing.Point(416, 12);
            this.btRunAddWaitNotePad.Name = "btRunAddWaitNotePad";
            this.btRunAddWaitNotePad.Size = new System.Drawing.Size(380, 199);
            this.btRunAddWaitNotePad.TabIndex = 1;
            this.btRunAddWaitNotePad.Text = "RunAndWaitNotepad";
            this.btRunAddWaitNotePad.UseVisualStyleBackColor = true;
            this.btRunAddWaitNotePad.Click += new System.EventHandler(this.btRunAddWaitNotePad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 598);
            this.Controls.Add(this.btRunAddWaitNotePad);
            this.Controls.Add(this.btRunNotePad);
            this.Name = "Form1";
            this.Text = "14章1節";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRunNotePad;
        private System.Windows.Forms.Button btRunAddWaitNotePad;
    }
}

