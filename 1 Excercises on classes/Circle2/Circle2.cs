using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises.Circle2
{
    public class Circle2
    {
        private double radius;


        public Circle2()
        { //defaulten
            this.radius = 1.0;
        }

        public Circle2(double radius)
        {
            this.radius = radius;
        }
        public double getRadius() { return this.radius; }

        public void setRadius(double radius) { this.radius = radius; }

        public double getArea()
        {
            return this.radius * this.radius * Math.PI;
        }

        public double getCircumference()
        {
            return 2 * this.radius * Math.PI;
        }

        public override string ToString()
        {
            return "Circle[radius=" + this.radius + "]";

        }
    }
}
