using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._3_More_excercises_on_classes.Ball_and_Container
{
    public class Ball
    {
        private float x;
        private float y;
        private int radius;
        private float xDelta;
        private float yDelta;

        public Ball(float x, float y, int radius, int speed, int direction)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;

            this.xDelta =  speed * (float)Math.Cos((double)direction);
            this.yDelta = (-1) * speed * (float)Math.Cos((double)direction);
        }

        public float getX() { return x; }
        public float getY() { return y; }
        public int getRadius() { return radius; }
        public void setRadius(int radius) { this.radius = radius; }
        public void setX(float x) { this.x = x; }
        public void setY(float y) { this.y = y; }

        public float getXDelta() { return xDelta; }
        public float getYDelta() { return yDelta; }
        public void setXDelta(float xDelta) { this.xDelta = xDelta; }
        public void setYDelta(float yDelta) { this.yDelta = yDelta; }

        public void move()
        {
            this.x += this.xDelta;
            this.y += this.yDelta;
        }

        public void reflectHorizontal()
        {
            this.xDelta = (-1) * this.xDelta;
        }

        public void reflectVertical()
        {
            this.yDelta = (-1) * this.yDelta;
        }

        public override string ToString()
        {
            return String.Format("Ball[({0}{1}), speed=({2},{3})]");
        }
    }
}
