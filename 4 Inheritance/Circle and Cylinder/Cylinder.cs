using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._4_Inheritance.Circle_and_Cylinder
{
    public class Cylinder : Circle
    {
        private double height;

        public Cylinder()
        {
            height = 1.0;
        }

        public Cylinder(double height)
        {
            this.height = height;
        }

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public double getHeight()
        {
            return height;
        }
        public double getVolume()
        {
            return getArea() * height;
        }

        public override string ToString()
        {
            return "Cylinder: subclass of " + base.ToString()  // use Circle's toString()
                         + " height=" + height;  
        }
    }
}
