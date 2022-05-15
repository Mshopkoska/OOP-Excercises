using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._7_More_Excercises_on_OOP.Polyline_of_points_with_List
{
    public class Polyline
    {
        List<Point> points;

        public Polyline() { points = new List<Point>(); }

        public Polyline(List<Point> points)
        {
            this.points = points;
        }

        public void appendPoint(int x, int y)
        {
            points.Add(new Point(x, y));
        }

        public void appendPoint(Point point)
        {
            points.Add(point);
        }

        public double getLength() { return points.Count(); }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder("{");
            foreach(Point point in points)
            {
                st.Append(point.ToString());
            }
            st.Append("}");

            return st.ToString();
        }
    }
}
