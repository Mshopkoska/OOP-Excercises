using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._2_Exercises_on_compositon.My_point
{
    public class MyPoint
    {

        private int x;
        private int y;

        public MyPoint() { }

        public MyPoint(int x, int y) { this.x = x; this.y = y; }

        public int getX() { return x; }
        public int getY() { return y; }
        public void setX(int x) { this.x = x; }
        public void setY(int y) { this.y = y; }

        public int[] getXY()
        {
            return new int[] { x, y };
        }

        public void setXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return String.Format("({0},{1})", x, y);
        }

        public double distance(int x, int y)
        {
            int distX = x - this.x;
            int distY = y - this.y;

            double result = Math.Sqrt(Math.Pow(distX, 2) + Math.Pow(distY, 2));
            return result;
        }

        public double distance(MyPoint another)
        {
            return distance(another.x, another.y);
        }

        public double distance()
        {
            return distance(0, 0);
        }
    }
}
