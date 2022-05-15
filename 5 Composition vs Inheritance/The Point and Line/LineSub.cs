using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._5_Composition_vs_Inheritance.The_Point_and_Line
{
    public class LineSub : Point
    {

        Point end;               // Ending point

        // Constructors
        public LineSub(int beginX, int beginY, int endX, int endY) : base(beginX, beginY)
        {
            // construct the begin Point
            this.end = new Point(endX, endY);  // construct the end Point
        }
        public LineSub(Point begin, Point end) : base(begin.getX(), begin.getY())
        {  // caller to construct the Points
           // need to reconstruct the begin Point
            this.end = end;
        }

        // Public methods
        // Inherits methods getX() and getY() from superclass Point

        public Point getBegin() { return new Point(this.x, this.y); }
        public Point getEnd() { return this.end; }
        public void setBegin(int x, int y) { this.setXY(x, y); }
        public void setEnd(int x, int y) { end.setX(x);
            end.setY(y);
        }

        public int getBeginX() { return this.getX(); }
        public int getBeginY() { return this.getY(); }
        public int getEndX() { return end.getX(); }
        public int getEndY() { return end.getY(); }

        public void setBeginX(int x) { this.setX(x); }
        public void setBeginY(int y) { this.setY(y); }
        public void setBeginXY(int x, int y ) { this.setXY(x, y); }
        public void setEndX(int x) { this.end.setX(x); }
        public void setEndY(int y) { this.end.setY(y); }
        public void setEndXY(int x, int y) { this.end.setXY(x, y); }

        
    }
}
