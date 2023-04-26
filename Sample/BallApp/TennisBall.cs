using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class TennisBall :Obj{

        private static int Tcnt;
        Random rand = new Random();

        public static int Tcnt1 { get => Tcnt; set => Tcnt = value; }

        //コンストラクタ
        public TennisBall(double xp, double yp)
            : base(xp, yp, "pic\\tennis_ball.png") {

            int rndX = rand.Next(-30, 30);
            MoveX = (rndX != 0 ? rndX : 1);

            int rndY = rand.Next(-30, 30);
            MoveY = (rndY != 0 ? rndY : 1);
            Tcnt1++;
        }

       

        //メソッド
        public override void Move(PictureBox pbBar, PictureBox pbBall) {

            Rectangle rBar = new Rectangle(pbBar.Location.X, pbBar.Location.Y, pbBar.Width, pbBar.Height);

            Rectangle rBall = new Rectangle(pbBall.Location.X, pbBall.Location.Y, pbBall.Width, pbBall.Height);

            PosX += MoveX;
            PosY += MoveY;

            if (PosY > 600 || PosY < 0 || rBar.IntersectsWith(rBall))
            {
                MoveY = -MoveY;
            }
            if (PosX > 800 || PosX < 0)
            {
                MoveX = -MoveX;
            }
        }
        public override void Move(Keys direction) {
            ;
        }
    }
}
