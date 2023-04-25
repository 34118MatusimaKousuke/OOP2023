using System;
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
        private TennisBall tennisBall;

        private List<Obj> balls = new List<Obj>(); //ボール格納
        private List<PictureBox> pbs = new List<PictureBox>(); //表示用

        private int sum = 0; //サッカーボールの数
        private int sum2 = 0; //テニスボールの数

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

            moveTimer = new Timer();
            moveTimer.Interval = 1; //タイマーのインターバル
           
            moveTimer.Tick += MoveTimer_Tick;　//デリゲード登録
        }
       
        //マウスクリック時のイベントハンドラ
        private void Program_MouseClick(object sender, MouseEventArgs e) {

            
            if (e.Button == MouseButtons.Left)
            {
                //サッカーボールの数をカウント
                this.Text = "BallGame" + "サッカーボール" +(sum + 1) + "回" + "テニスボール" +　 sum2 + "回";
                sum = sum + 1;
                //サッカーボールインスタンス生成
                soccerBall = new SoccerBall(e.X - 25, e.Y - 25);
                pb = new PictureBox(); //画像を表示するコントロール
                pb.Image = soccerBall.Image;
                pb.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY);
                balls.Add(soccerBall);
            }
            else
            {
                this.Text = "BallGame" + "サッカーボール" + sum + "回" + "テニスボール" + (sum2 + 1) + "回";
                sum2 = sum2 + 1;
                tennisBall = new TennisBall(e.X - 25, e.Y - 25);
                pb = new PictureBox(); //画像を表示するコントロール
                pb.Image = tennisBall.Image;
                pb.Location = new Point((int)tennisBall.PosX, (int)tennisBall.PosY);
                balls.Add(tennisBall);
            }
            pb.Size = new Size(50, 50); //画像表示サイズ
            pb.SizeMode = PictureBoxSizeMode.StretchImage; //画像表示モード
            pb.Parent = this;
            pbs.Add(pb);
            moveTimer.Start(); //タイマースタート
        }
        //タイマータイムアウト用のイベントハンドラ
        private void MoveTimer_Tick(object sender, EventArgs e) {
            for (int i = 0; i < balls.Count; i++)
            {
                balls[i].Move();
                pbs[i].Location = new Point((int)balls[i].PosX, (int)balls[i].PosY);
                pbs[i].Location = new Point((int)balls[i].PosX, (int)balls[i].PosY);
                
            }
        }
    }
}
