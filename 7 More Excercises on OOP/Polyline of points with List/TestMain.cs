using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._7_More_Excercises_on_OOP.Polyline_of_points_with_List
{
    public class TestMain
    {
        public static void Main()
        {
            // Test default constructor and toString()
            Polyline l1 = new Polyline();
            Console.WriteLine(l1);  // {}

            // Test appendPoint()
            l1.appendPoint(new Point(1, 2));
            l1.appendPoint(3, 4);
            l1.appendPoint(5, 6);
            Console.WriteLine(l1);  // {(1,2)(3,4)(5,6)}

            // Test constructor 2
            List<Point> points = new List<Point>();
            points.Add(new Point(11, 12));
            points.Add(new Point(13, 14));
            Polyline l2 = new Polyline(points);
            Console.WriteLine(l2);  // {(11,12)(13,14)}
        }

    }
}
