using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._4_Inheritance.Point_and_Movable_Point
{
    public class MovablePoint:Point
    {
        float xSpeed;
        float ySpeed;

        MovablePoint()
        {
            xSpeed = 0.0f;
            ySpeed = 0.0f;
        }

        MovablePoint(float xSpeed, float ySpeed)
        {
            this.xSpeed= xSpeed;
            this.ySpeed= ySpeed;
        }
        MovablePoint(float x, float y, float xSpeed, float ySpeed) : base(x,y)
        {
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
        }

        public float getXSpeed() { return xSpeed; }
        public float getYSpeed() { return ySpeed; }
        public void setXSpeed(float xSpeed) { this.xSpeed = xSpeed; }
        public void setYSpeed(float ySpeed) { this.ySpeed = ySpeed; }

        public void setSpeed(float xSpeed, float ySpeed)
        {
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
        }

        public float[] getSpeed()
        {
            return new float[]{xSpeed,ySpeed};
        }

        public override string ToString()
        {
            return String.Format("{0}, speed = ({1},{2})", base.ToString(), xSpeed, ySpeed);
        }

        public MovablePoint move()
        {
            this.x += xSpeed;
            this.y += ySpeed;
            return this;
        }
    }
}
