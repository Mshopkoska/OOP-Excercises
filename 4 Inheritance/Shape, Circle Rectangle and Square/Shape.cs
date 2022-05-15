using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._4_Inheritance.Shape__Circle_Rectangle_and_Square
{
    public class Shape
    {
        protected string color;
        protected Boolean filled;

        public Shape() {
            color = "Red";
            filled = true;
        }

        public Shape(string color, Boolean filled)
        {
            this.color = color;
            this.filled = filled;   
        }

        public string getColor() { return color; }
        public Boolean isFilled() { return filled; }

        public void setFilled(Boolean filled) { this.filled = filled; }
        public void setColor(string color) { this.color = color; }

        public override string ToString()
        {
            return string.Format("Shape[color = {0}, filled = {1}", color, filled);
        }
    }
}
