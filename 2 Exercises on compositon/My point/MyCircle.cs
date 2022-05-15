using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._2_Exercises_on_compositon.My_point
{
    public class MyCircle
    {
        private MyPoint center;
        private int radius;

        public MyCircle()
        {
            center = new MyPoint(0,0);
            radius = 1;
        }

        public MyCircle(int x, int y, int radius)
        {
            center = new MyPoint(x, y);
            this.radius = radius;

            this.center = center;
        }

        public MyCircle(MyPoint center, int radius)
        {
            this.center = center;
            this.radius = radius;
        }

        public int getRadius() { return radius; }
        public void setRadius(int radius) { this.radius = radius; }
        public MyPoint getCenter() { return center; }
        public void setCenter(MyPoint center) { this.center = center; }

        public int getCenterX() { return center.getX(); }
        public int getCenterY() { return center.getY(); }
        public void setCenterX(int x) { center.setX(x); }
        public void setCenterY(int y) { center.setY(y); }


        public int[] getCenterXY()
        {
            return new int[2] { center.getX(), center.getY() };
        }

        public void setCenterXY(int x, int y) { center.setX(x); center.setY(y); }

        public override string ToString()
        {
            return String.Format("MyCircle[radius = {0}, center = ({1},{2})]", radius, center.ToString());
        }

        public double getArea()
        {
            return radius * radius * Math.PI;
        }

        public double getCircumference()
        {
            return radius * 2 * Math.PI;
        }

        public double distance(MyCircle another)
        {
            return center.distance(another.center);
        }

    }
}
