using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._4_Inheritance.Point_and_Movable_Point
{
    public class Point
    {

        protected float x;
        protected float y;

        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public Point()
        {
            x = 0.0f;
            y = 0.0f;
        }

        public float getX() { return x; }
        public float getY() { return y; }
        public void setX(float x) { this.x = x; }
        public void setY(float y) { this.y = y; }

        public float[] getXY()
        {
            return new float[] { x, y };
        }

        public void setXY(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return String.Format("({0},{1})", x, y);
        }
    }
}
