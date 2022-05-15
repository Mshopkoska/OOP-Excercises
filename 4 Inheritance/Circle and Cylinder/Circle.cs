using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._4_Inheritance.Circle_and_Cylinder
{
    public class Circle
    {
        protected double radius;
        protected string color;

        public Circle()
        {
            radius = 1.0;
            color = "red";
        }

        public Circle(double radius) { this.radius = radius; }

        public Circle(double radius, string color) { this.radius = radius; this.color = color; }

        public double getRadius() { return radius; }
        public string getColor() { return color; }
        public double getArea() { return radius * radius * Math.PI; }

        public override string ToString()
        {
            return string.Format("Circle[radius = {0}, color = {1}]",radius,color);
        }


    }
}
