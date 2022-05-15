using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._4_Inheritance.Shape__Circle_Rectangle_and_Square
{
    public class Circle : Shape
    {
        double radius;

        public Circle()
        {
            radius = 1.0;
        }

        public Circle(double radius, string color, Boolean filled) : base(color, filled)
        {
            this.radius = radius;
        }

        public double getRadius() { return radius; }

        public void setRadius(double radius) { this.radius = radius; }
        public double getArea()
        {
            return radius * radius * Math.PI;
        }

        public double getPerimeter()
        {
            return radius * 2 * Math.PI;
        }
        public override string ToString()
        {
            return String.Format("Circle[{0}, radius = {1}", base.ToString(), radius);
        }

    }
}
