using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._4_Inheritance.Shape__Circle_Rectangle_and_Square
{
    public class Rectangle : Shape
    {
        protected double width;
        protected double lenght;

        public Rectangle()
        {
            width = 1.0;
            lenght = 1.0;
        }

        public Rectangle(double width, double lenght, string color, Boolean filled) : base(color, filled)
        {
            this.width = width;
            this.lenght = lenght;
        }


        public double getWidth()
        {
            return width;
        }

        public double getLength()
        {
            return lenght;
        }

        public void setWidth(double width)
        {
            this.width=width;
        }

        public void setLength(double length)
        {
            this.lenght=length;
        }

        public double getArea()
        {
            return width*lenght;    
        }

        public double getPerimeter()
        {
            return 2*width + 2 *lenght;
        }

        public override string ToString()
        {
            return String.Format("rectangle[{0}, {1}, {2}]", base.ToString(), width, lenght);
        }


    }
}
