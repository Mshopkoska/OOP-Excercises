using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._6_Polymorphism__Abstract_Classes_and_Interfaces.GeometricObject_Interface
{
    public class Circle : GeometricalObject
    {
        double radius;

        public Circle(double radius) { this.radius = radius; }

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
            return string.Format("Circle[radius = {0}]", radius);
        }
    }
}
