using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class SoccerBall {

        //フィールド
        private Image image; //画像データ

        private double posX; //x座標
        private double posY; //y座標

        private double moveX = 10; //移動量X
        private double moveY = 10; //移動量Y

        Random rand = new Random();

        //コンストラクタ
        public SoccerBall(double xp, double yp) {
            Image = Image.FromFile("pic\\soccer_ball.png");
            
            PosX = xp;
            PosY = yp;

            int rndX = rand.Next(-30, -30);
            moveX = (rndX != 0 ? rndX : 1);

            int rndY = rand.Next(-30, -30);
            moveX = (rndY != 0 ? rndY : 1);
        }

        //プロパティ
        public double PosX { get => posX; set => posX = value; }
        public double PosY { get => posY; set => posY = value; }
        public Image Image { get => image; set => image = value; }

        //メソッド
        public void Move() {
            posX += moveX;
            posY += moveY;

            if (posY > 600 || posY < 0)
            {
                moveY = -moveY;
            }
            if (posX > 800 || posX < 0)
            {
                moveX = -moveX;
            }
        }
    }
}
