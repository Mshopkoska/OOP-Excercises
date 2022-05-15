using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._2_Exercises_on_compositon.My_point
{
    public class MyTriangle
    {
        private MyPoint v1;
        private MyPoint v2;
        private MyPoint v3;

        public MyTriangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            this.v1 = new MyPoint(x1, y1);
            this.v2 = new MyPoint(x2, y2);
            this.v3 = new MyPoint(x3, y3);
        }

        public MyTriangle(MyPoint v1, MyPoint v2, MyPoint v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public override string ToString()
        {
            return String.Format("MyTriangle[v1 = ({0},{1}), v2 = ({2},{3}), v3 =({4},{5})]", v1.getX(), v1.getY(), v2.getX(), v2.getY(), v3.getX(), v3.getY());
        }

        public String getType()
        {
            double line1 = Math.Abs(v1.distance(v2));
            double line2 = Math.Abs(v2.distance(v3));
            double line3 = Math.Abs(v3.distance(v1));

            if (line1 == line2 && line2 == line3 && line1 == line3)
            {
                return "equilateral";
            }
            else if (((line1 == line2) && (line1 == line3)) || ((line1 == line2) && (line2 == line3)) || ((line1 == line3) && (line2 == line3)))
            {

                return "isosceles";
            }
            else return "scalene";
        }
    }
}
