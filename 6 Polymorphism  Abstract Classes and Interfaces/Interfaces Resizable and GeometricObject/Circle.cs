using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._6_Polymorphism__Abstract_Classes_and_Interfaces.Interfaces_Resizable_and_GeometricObject
{
    public class Circle : GeometricObject
    {

        protected double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

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
            return String.Format("Circle[radius={0}", radius);
        }
    }
}
