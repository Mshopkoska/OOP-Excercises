using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._2_Exercises_on_compositon.My_point
{
    public class MyLine
    {
        private MyPoint begin;
        private MyPoint end;

        public MyLine(int x1, int y1, int x2, int y2)
        {
            begin = new MyPoint(x1, y1);
            end = new MyPoint(x2, y2);
        }

        public MyLine(MyPoint begin, MyPoint end)
        {
            this.begin = begin;
            this.end = end;
        }

        public MyPoint getBegin() { return begin; }
        public MyPoint getEnd() { return end; }

        public int getBeginX()
        {
            return begin.getX();
        }
        public void setBeginX(int x)
        {
            begin.setX(x);
        }
        public int getBeginY() { return end.getY(); }

        public void setBeginY(int y)
        {
            begin.setY(y);
        }

        public int getEndX() { return end.getX(); }
        public void setEndX(int x)
        {
            end.setX(x);
        }
        public int getEndY() { return end.getY(); }
        public void setEndY(int y)
        {
            end.setY(y);
        }

        public int[] getBeginXY()
        {
            return new int[] { begin.getX(), begin.getY() };
        }

        public void setBeginXY(int x, int y)
        {
            this.setBeginX(x);
            this.setBeginY(y);
        }

        public int[] getEndXY()
        {
            return new int[] { end.getX(), end.getY() };
        }

        public void setEndXY(int x, int y)
        {
            this.setEndX(x);
            this.setEndY(y);
        }

        public double getLength()
        {
            return begin.distance(end);
        }
        
        public double getGradient()
        {
            int xDiff = end.getX() - begin.getX();
            int yDiff = end.getY() - begin.getY();

            return Math.Atan2(yDiff, xDiff);
        }
    }
}
