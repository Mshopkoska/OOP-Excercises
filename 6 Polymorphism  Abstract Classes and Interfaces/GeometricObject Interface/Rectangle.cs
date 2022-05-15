using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._6_Polymorphism__Abstract_Classes_and_Interfaces.GeometricObject_Interface
{
    public class Rectangle : GeometricalObject
    {
        protected double width;
        protected double lenght;

        public Rectangle(double width, double lenght)
        {
            this.width = width;
            this.lenght = lenght;
        }

        public double getArea()
        {
            return width * lenght;
        }

        public double getPerimeter()
        {
            return 2 * width + 2 * lenght;
        }

        public override string ToString()
        {
            return String.Format("rectangle[{0}, {1}]",  width, lenght);
        }


    }
}
