using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises.Rectangle
{
    public class Rectangle
    {
        private float length;
        private float width;


        public Rectangle()
        {
            this.length = 1.0f;
            this.width = 1.0f;
        }

        public Rectangle(float length, float width)
        {
            this.length = length;
            this.width = width; 
        }

        public float getLength() { return length; }

        public float getWidth() { return width; }   
        public void setLength(float length) { this.length = length; }   
        public void setWidth(float width) { this.width = width; }


        public double getArea()
        {
            return (double)this.length * this.width;
        }

        public double getPerimeter()
        {
            return (double)this.length * 2 + this.width * 2;
        }

        public override string ToString()
        {
            return String.Format("Rectangle[length = {0:0.00}, width = {1:0.00}", length, width);
        }
    }
}
