using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._5_Composition_vs_Inheritance.The_Point_and_Line
{
    public class Point
    {
        protected int x;    // x co-ordinate
        protected int y;    // y co-ordinate

        // Constructor
        public Point(int x, int y) { this.x = x;
            this.y = y;
        }

        // Public methods
        public String toString()
        {
            return "Point: (" + x + "," + y + ")";
        }

        public int getX() { return x; }
        public int getY() { return y; }
        public void setX(int x) { this.x = x; }
        public void setY(int y) { this.y = y; }
        public void setXY(int x, int y) { this.x = x; this.y = y; }
    }
}
