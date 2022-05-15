using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._3_More_excercises_on_classes.Ball_and_Player
{
    public class Player
    {
        private int number;
        private float x;
        private float y;
        private float z;

        public Player(int number, float x, float y)
        {
            this.number = number; 
            this.x = x; 
            this.y = y;
            this.z = 0.0f;
        }

        public void move(float xDisp, float yDisp) {
            this.x = xDisp + x;
            this.y = yDisp + y;
        }

        public void jump(float zDisp)
        {
            this.z = this.z + zDisp;
        }

        public Boolean near(Ball ball)
        {
            float distX = ball.getX() - this.x;
            float distY = ball.getY() - this.y;

            double distance = Math.Sqrt(Math.Pow(distX, 2) + Math.Pow(distY, 2));
            if (distance < 8) return true;
            return false;
        }
    }
}
