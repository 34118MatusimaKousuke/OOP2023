﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Program :Form{

        private Timer moveTimer; //タイマー用
        private SoccerBall soccerBall;
        private PictureBox pb;

        static void Main(string[] args) {
            Application.Run(new Program());
           
        }

        public Program() {

            //this.Width = 1200; //幅プロパティ
            //this.Height = 800; // 高さプロパティ
            this.Size = new Size(800 , 600);

            this.BackColor = Color.Green;
 
            this.Text = "BallGame";

            this.MouseClick += Program_MouseClick;

            //ボールインスタンス生成
           
            moveTimer = new Timer();
            moveTimer.Interval = 1; //タイマーのインターバル
           
            moveTimer.Tick += MoveTimer_Tick;　//デリゲード登録

        }
       
        //マウスクリック時のイベントハンドラ
        private void Program_MouseClick(object sender, MouseEventArgs e) {
            soccerBall = new SoccerBall(e.X - 25,e.Y - 25);
            pb = new PictureBox(); //画像を表示するコントロール
            pb.Image = soccerBall.Image;
            pb.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY);
            pb.Size = new Size(51, 51); //画像表示サイズ
            pb.SizeMode = PictureBoxSizeMode.StretchImage; //画像表示モード
            pb.Parent = this;

            moveTimer.Start(); //タイマースタート
        }

        //タイマータイムアウト用のイベントハンドラ
        private void MoveTimer_Tick(object sender, EventArgs e) {
            soccerBall.Move(); //移動
            pb.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY);
        }
    }
}