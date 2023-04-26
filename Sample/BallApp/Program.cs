using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Program : Form {
        private Timer moveTimer; //タイマー用
        private Obj obj;
        private PictureBox pb;

        Bar bar;
        PictureBox pbBar;

        //Listコレクション
        private List<Obj> balls = new List<Obj>(); //ボール格納
        private List<PictureBox> pbs = new List<PictureBox>(); //表示用

        static void Main(string[] args) {
            Application.Run(new Program());

        }

        public Program() {

            //フォーム
            this.Size = new Size(800, 600);
            this.BackColor = Color.Green;
            this.Text = "BallGame";

            this.MouseClick += Program_MouseClick;
            this.KeyDown += Program_KeyDown;

            //Barインスタンス生成
            bar = new Bar(340 , 500);
            pbBar = new PictureBox();
            pbBar.Image = bar.Image;
            pbBar.Location = new Point((int)bar.PosX,(int)bar.PosY);
            pbBar.Size = new Size(150, 10);
            pbBar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBar.Parent = this;

            moveTimer = new Timer();
            moveTimer.Interval = 1; //タイマーのインターバル

            moveTimer.Tick += MoveTimer_Tick;　//デリゲード登録
        }
        
        //マウスクリック時のイベントハンドラ
        private void Program_MouseClick(object sender, MouseEventArgs e) {
            
            if (e.Button == MouseButtons.Left)
            {
                //サッカーボールインスタンス生成
                obj = new SoccerBall(e.X - 25, e.Y - 25);
                
            }
            else
            {
                //テニスボールインスタンス作成
                obj = new TennisBall(e.X - 25, e.Y - 25);
            }
            //ボールの数をカウント
            this.Text = "BallGame" + "サッカーボール" + SoccerBall.Scnt1 + "個" + " テニスボール" + TennisBall.Tcnt1 + "個";
            pb = new PictureBox(); //画像を表示するコントロール
            pb.Image = obj.Image;
            pb.Location = new Point((int)obj.PosX, (int)obj.PosY);
            pb.Size = new Size(50, 50); //画像表示サイズ
            pb.SizeMode = PictureBoxSizeMode.StretchImage; //画像表示モード
            pb.Parent = this;
            balls.Add(obj);
            pbs.Add(pb);
            moveTimer.Start(); //タイマースタート
        }



        //キーが押された時のイベントハンドラ
        private void Program_KeyDown(object sender, KeyEventArgs e) {
                bar.Move(e.KeyData);
                pbBar.Location = new Point((int)bar.PosX, (int)bar.PosY);
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
