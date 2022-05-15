using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises.Ball
{
    public class Ball
    {
        private float x;
        private float y;
        private int radius;
        private float xDelta;
        private float yDelta;


        public Ball(float x, float y, int radius, float xDelta, float yDelta)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            this.xDelta = xDelta;
            this.yDelta = yDelta;
        }

        public float getX() { return x; }
        public float getY() { return y; }
        public float getXDelta() { return xDelta; }
        public float getYDelta() { return yDelta; }

        public int getRadius() { return radius; }
        public void setRadius(int radius) { this.radius = radius; }   

        public void setX(float x) { this.x = x; }
        public void setY(float y) { this.y = y; }
        public void setXDelta(float xDelta) { this.xDelta = xDelta; }
        public void setYDelta(float yDelta) { this.yDelta = yDelta; }  


        public void move()
        {
            this.x += this.xDelta;
            this.y += this.yDelta;
        }

        public void reflectHorizontal()
        {
            this.xDelta = -this.xDelta;
        }

        public void reflectVertical()
        {
            this.yDelta=-this.yDelta;
        }


        public override string ToString()
        {
            return String.Format("Ball[({0:0.0},{1:0.0}), speed = ({2:0.0},{3:0.0})]", x, y, xDelta, yDelta);
        }
    }
}
