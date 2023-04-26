using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public override void Move() {
            PosX += MoveX;
            PosY += MoveY;

            if (PosY > 600 || PosY < 0)
            {
                MoveY = -MoveY;
            }
            if (PosX > 800 || PosX < 0)
            {
                MoveX = -MoveX;
            }
        }
    }
}
