using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._6_Polymorphism__Abstract_Classes_and_Interfaces.Abstract_Superclass_Shape_and_its_Concrete_Subclasses
{
    public class Circle : Shape
    {
        protected double radius;

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
        public override double getArea()
        {
            return radius * radius * Math.PI;
        }

        public override double getPerimeter()
        {
            return radius * 2 * Math.PI;
        }
        public override string ToString()
        {
            return String.Format("Circle[{0}, radius = {1}", base.ToString(), radius);
        }

    }
}
