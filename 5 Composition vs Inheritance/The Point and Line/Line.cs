using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._5_Composition_vs_Inheritance.The_Point_and_Line
{
    public class Line
    {
        // A line composes of two points (as instance variables)
        private Point begin;    // beginning point
        private Point end;      // ending point

        // Constructors
        public Line(Point begin, Point end)
        {  // caller to construct the Points
            this.begin = begin;
            this.end = end;
        }
        public Line(int beginX, int beginY, int endX, int endY)
        {
            this.begin = new Point(beginX, beginY);   // construct the Points here
            this.end = new Point(endX, endY);
        }

        // Public methods
        public String toString() { return String.Format("Line[begin = {0}, end = {1}]", begin.ToString(), end.ToString()); }

        public Point getBegin() { return begin; }
        public Point getEnd() { return end; }
        public void setBegin(Point begin) { this.begin = begin; }
        public void setEnd(Point end) { this.end = end; }

        public int getBeginX() { return begin.getX(); }
        public int getBeginY() { return begin.getY(); }
        public int getEndX() { return end.getX(); }
        public int getEndY() { return end.getY(); }

        public void setBeginX(int x) { begin.setX(x); }
        public void setBeginY(int y) { begin.setY(y); }
        public void setBeginXY(int x, int y) { begin.setX(x); begin.setY(y); }
        public void setEndX(int x) { end.setX(x); }
        public void setEndY(int y) { end.setY(y); }
        public void setEndXY(int x, int y) { end.setX(x); end.setY(y); }

        public int getLength()
        {  // Length of the line
           // Math.sqrt(xDiff*xDiff + yDiff*yDiff)

            int xDiff = end.getX() - begin.getX();
            int yDiff = end.getY() - begin.getY();

            return (int)Math.Sqrt(xDiff * xDiff + yDiff * yDiff);
        }

        public double getGradient() {
            // Gradient in radians
            // Math.atan2(yDiff, xDiff)
            int xDiff = end.getX() - begin.getX();
            int yDiff = end.getY() - begin.getY();
            return Math.Atan2(yDiff, xDiff);
        } 
    }
}
