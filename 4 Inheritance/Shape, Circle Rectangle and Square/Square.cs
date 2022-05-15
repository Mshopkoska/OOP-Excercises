using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._4_Inheritance.Shape__Circle_Rectangle_and_Square
{
    public class Square : Rectangle
    {
        public Square() { }

        public Square(double side) { 
            this.width = side;
            this.lenght = side;
        }

        public Square(double side, string color, Boolean filled)
        {
            this.width = side;
            this.lenght = side;
            this.color = color;
            this.filled = filled;
        }

        public double getSide() { return this.width; }

        public void setSide(double side) { this.width = side; this.lenght = side; }

        public void setWidth(double side) { this.width = side; }
        public void setLength(double side) { this.lenght = side; }

        public override string ToString()
        {
            return String.Format("Square[{0}]", base.ToString());
        }
    }
}
